using McTools.Xrm.Connection;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Args;

namespace EntitySettingsUpdater
{
    public partial class EntitySettingsUpdaterControl : PluginControlBase
    {
        private Settings mySettings;
        private List<EntityMetadata> entities;
        private List<string> selectedEntities;
        private List<ListViewItem> selectedSettings;
        public event EventHandler SendMessageToStatusBar;

        public EntitySettingsUpdaterControl()
        {
            InitializeComponent();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }
        
        private void btn_execute_Click(object sender, EventArgs e)
        {
            selectedEntities = new List<string>();
            selectedSettings = new List<ListViewItem>();
            
            foreach (string entity in lst_entities.SelectedItems)
            {
                selectedEntities.Add(entity);
            }
            foreach (ListViewItem setting in lstvw_settings.SelectedItems)
            {
                selectedSettings.Add(setting);
            }
            bool enable = lst_actions.SelectedItem.ToString() == "Enable" ? true : false;

            DisableInputs();
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Updating entity settings...",
                Work = (w, e2) =>
                {
                    // This code is executed in another thread                    
                    UpdateEntitySettings(enable);

                    w.ReportProgress(-1, "Entity settings updated.");
                    e2.Result = 1;
                },
                ProgressChanged = e2 =>
                {
                    SetWorkingMessage(e2.UserState.ToString());
                },
                PostWorkCallBack = e2 =>
                {
                    // This code is executed in the main thread
                    PublishEntities();
                },
                AsyncArgument = null,
                // Progress information panel size
                MessageWidth = 340,
                MessageHeight = 150
            });
        }

        private void btn_loadentities_Click(object sender, EventArgs e)
        {
            ExecuteMethod(LoadEntities);
        }

        private void lst_actions_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void toolStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
                
        

        private void DisableInputs()
        {
            lst_entities.Enabled = false;
            lstvw_settings.Enabled = false;
            lst_actions.Enabled = false;
            btn_loadentities.Enabled = false;
            btn_execute.Enabled = false;
        }

        private void EnableInputs()
        {
            lst_entities.Enabled = true;
            lstvw_settings.Enabled = true;
            lst_actions.Enabled = true;
            btn_loadentities.Enabled = true;
            btn_execute.Enabled = true;
        }

        private void EntitySettingsUpdaterControl_Load(object sender, EventArgs e)
        {
            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void EntitySettingsUpdaterControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        private void LoadEntities()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Retrieving entities...",
                Work = (w, e) =>
                {
                    // This code is executed in another thread
                    entities = GetAllEntityMetadata();

                    w.ReportProgress(-1, "Entities loaded.");
                    e.Result = 1;
                },
                ProgressChanged = e =>
                {
                    SetWorkingMessage(e.UserState.ToString());
                },
                PostWorkCallBack = e =>
                {
                    // This code is executed in the main thread
                    foreach (var entity in entities)
                    {
                        lst_entities.Items.Add(entity.LogicalName);
                    }
                    EnableInputs();
                },
                AsyncArgument = null,
                // Progress information panel size
                MessageWidth = 340,
                MessageHeight = 150
            });
        }

        private List<EntityMetadata> GetAllEntityMetadata()
        {
            var request = new RetrieveAllEntitiesRequest
            {
                EntityFilters = EntityFilters.All
            };

            var response = (RetrieveAllEntitiesResponse)Service.Execute(request);
            return response.EntityMetadata.ToList();
        }

        private void PublishEntities()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Publishing entities...",
                Work = (w, e) =>
                {
                    // This code is executed in another thread
                    // publish selected entities
                    PublishXmlRequest publishEntityRequest = new PublishXmlRequest
                    {
                        ParameterXml = "<importexportxml><entities><entity>" + string.Join("</entity><entity>", selectedEntities.ToArray()) + "</entity></entities></importexportxml>"
                    };

                    Service.Execute(publishEntityRequest);

                    w.ReportProgress(-1, "Publishing complete.");
                    e.Result = 1;
                },
                ProgressChanged = e =>
                {
                    SetWorkingMessage(e.UserState.ToString());
                },
                PostWorkCallBack = e =>
                {
                    // This code is executed in the main thread
                    EnableInputs();
                },
                AsyncArgument = null,
                // Progress information panel size
                MessageWidth = 340,
                MessageHeight = 150
            });

        }

        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void UpdateEntitySettings(bool enable)
        {
            UpdateEntityRequest updatereq;
            UpdateEntityResponse updateresp;
            EntityMetadata retrievedEntity;
            int progressInterval = selectedEntities.Count / 100;

            foreach (var entity in selectedEntities)
            {
                retrievedEntity = entities.Find(x => x.LogicalName == entity.ToString());

                if (retrievedEntity != null)
                {
                    updatereq = new UpdateEntityRequest();

                    foreach (ListViewItem setting in selectedSettings)
                    {
                        switch (setting.Tag.ToString())
                        {
                            case "IsBusinessProcessEnabled": retrievedEntity.IsBusinessProcessEnabled = enable; break;
                            case "HasFeedback": updatereq.HasFeedback = enable; break;
                            case "HasNotes": updatereq.HasNotes = enable; break;
                            case "HasActivities": updatereq.HasActivities = enable; break;
                            case "IsConnectionsEnabled": retrievedEntity.IsConnectionsEnabled = new BooleanManagedProperty(enable); break;
                            case "IsActivityParty": retrievedEntity.IsActivityParty = enable; break;
                            case "IsMailMergeEnabled": retrievedEntity.IsMailMergeEnabled = new BooleanManagedProperty(enable); break;
                            case "IsDocumentManagementEnabled": retrievedEntity.IsDocumentManagementEnabled = enable; break;
                            case "AutoCreateAccessTeams": retrievedEntity.AutoCreateAccessTeams = enable; break;
                            case "IsValidForQueue": retrievedEntity.IsValidForQueue = new BooleanManagedProperty(enable); break;
                            case "AutoRouteToOwnerQueue": retrievedEntity.AutoRouteToOwnerQueue = enable; break;
                            case "IsQuickCreateEnabled": retrievedEntity.IsQuickCreateEnabled = enable; break;
                            case "IsDuplicateDetectionEnabled": retrievedEntity.IsDuplicateDetectionEnabled = new BooleanManagedProperty(enable); break;
                            case "IsAuditEnabled": retrievedEntity.IsAuditEnabled = new BooleanManagedProperty(enable); break;                            
                            case "ChangeTrackingEnabled": retrievedEntity.ChangeTrackingEnabled =enable; break;
                            case "IsRetrieveAuditEnabled": retrievedEntity.IsRetrieveAuditEnabled = enable; break;
                            case "IsRetrieveMultipleAuditEnabled": retrievedEntity.IsRetrieveMultipleAuditEnabled = enable; break;
                            case "IsVisibleInMobile": retrievedEntity.IsVisibleInMobile = new BooleanManagedProperty(enable); break;
                            case "IsVisibleInMobileClient": retrievedEntity.IsVisibleInMobileClient = new BooleanManagedProperty(enable); break;
                            case "IsReadOnlyInMobileClient": retrievedEntity.IsReadOnlyInMobileClient = new BooleanManagedProperty(enable); break;
                            case "IsOfflineInMobileClient": retrievedEntity.IsOfflineInMobileClient = new BooleanManagedProperty(enable); break;
                            case "IsAvailableOffline": retrievedEntity.IsAvailableOffline = enable; break;
                            default: MessageBox.Show($"Setting \"{setting.Tag}\" not found."); break;
                        }
                    }
                    updatereq.Entity = retrievedEntity;                    
                    updateresp = (UpdateEntityResponse)Service.Execute(updatereq);
                }
            }
        }
    }
}