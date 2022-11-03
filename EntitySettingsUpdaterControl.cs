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

namespace EntitySettingsUpdater
{
    public partial class EntitySettingsUpdaterControl : PluginControlBase
    {
        private Settings mySettings;
        private List<EntityMetadata> entities;
        private List<string> selectedEntities;
        private List<ListViewItem> selectedSettings;

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
            UpdateEntityRequest updateRequest;
            RetrieveEntityRequest retrieveRequest;
            RetrieveEntityResponse retrieveResponse;
            EntityMetadata entity;
            bool settingUpdateSuccessful = true;

            foreach (var selectedEntity in selectedEntities)
            {
                entity = entities.Find(x => x.LogicalName == selectedEntity.ToString());

                if (entity != null)
                {
                    updateRequest = new UpdateEntityRequest();

                    foreach (ListViewItem setting in selectedSettings)
                    {
                        switch (setting.Tag.ToString())
                        {
                            case "IsBusinessProcessEnabled": entity.IsBusinessProcessEnabled = enable; break;
                            case "HasFeedback": updateRequest.HasFeedback = enable; break;
                            case "HasNotes": updateRequest.HasNotes = enable; break;
                            case "HasActivities": updateRequest.HasActivities = enable; break;
                            case "IsConnectionsEnabled": entity.IsConnectionsEnabled = new BooleanManagedProperty(enable); break;
                            case "IsActivityParty": entity.IsActivityParty = enable; break;
                            case "IsMailMergeEnabled": entity.IsMailMergeEnabled = new BooleanManagedProperty(enable); break;
                            case "IsDocumentManagementEnabled": entity.IsDocumentManagementEnabled = enable; break;
                            case "AutoCreateAccessTeams": entity.AutoCreateAccessTeams = enable; break;
                            case "IsValidForQueue": entity.IsValidForQueue = new BooleanManagedProperty(enable); break;
                            case "AutoRouteToOwnerQueue": entity.AutoRouteToOwnerQueue = enable; break;
                            case "IsQuickCreateEnabled": entity.IsQuickCreateEnabled = enable; break;
                            case "IsDuplicateDetectionEnabled": entity.IsDuplicateDetectionEnabled = new BooleanManagedProperty(enable); break;
                            case "IsAuditEnabled": entity.IsAuditEnabled = new BooleanManagedProperty(enable); break;                            
                            case "ChangeTrackingEnabled": entity.ChangeTrackingEnabled = enable; break;
                            case "IsRetrieveAuditEnabled": entity.IsRetrieveAuditEnabled = enable; break;
                            case "IsRetrieveMultipleAuditEnabled": entity.IsRetrieveMultipleAuditEnabled = enable; break;
                            case "IsVisibleInMobile": entity.IsVisibleInMobile = new BooleanManagedProperty(enable); break;
                            case "IsVisibleInMobileClient": entity.IsVisibleInMobileClient = new BooleanManagedProperty(enable); break;
                            case "IsReadOnlyInMobileClient": entity.IsReadOnlyInMobileClient = new BooleanManagedProperty(enable); break;
                            case "IsOfflineInMobileClient": entity.IsOfflineInMobileClient = new BooleanManagedProperty(enable); break;
                            case "IsAvailableOffline": entity.IsAvailableOffline = enable; break;
                            default: MessageBox.Show($"Setting \"{setting.Tag}\" not found."); break;
                        }
                    }
                    updateRequest.Entity = entity;

                    try
                    {
                        Service.Execute(updateRequest);

                        // Retrieve the entity to verify settings
                        retrieveRequest = new RetrieveEntityRequest
                        {
                            EntityFilters = EntityFilters.All,
                            LogicalName = selectedEntity,
                            RetrieveAsIfPublished = true
                        };

                        retrieveResponse = (RetrieveEntityResponse)Service.Execute(retrieveRequest);

                        foreach (ListViewItem setting in selectedSettings)
                        {
                            switch (setting.Tag.ToString())
                            {
                                case "IsBusinessProcessEnabled": settingUpdateSuccessful = retrieveResponse.EntityMetadata.IsBusinessProcessEnabled.Value == enable ? true : false; break;
                                case "HasFeedback": settingUpdateSuccessful = retrieveResponse.EntityMetadata.HasFeedback.Value == enable ? true : false; break;
                                case "HasNotes": settingUpdateSuccessful = retrieveResponse.EntityMetadata.HasNotes.Value == enable ? true : false; break;
                                case "HasActivities": settingUpdateSuccessful = retrieveResponse.EntityMetadata.HasActivities.Value == enable ? true : false; break;
                                case "IsConnectionsEnabled": settingUpdateSuccessful = retrieveResponse.EntityMetadata.IsConnectionsEnabled.Value = enable; break;
                                case "IsActivityParty": settingUpdateSuccessful = retrieveResponse.EntityMetadata.IsActivityParty.Value == enable ? true : false; break;
                                case "IsMailMergeEnabled": settingUpdateSuccessful = retrieveResponse.EntityMetadata.IsMailMergeEnabled.Value == enable ? true : false; break;
                                case "IsDocumentManagementEnabled": settingUpdateSuccessful = retrieveResponse.EntityMetadata.IsDocumentManagementEnabled.Value == enable ? true : false; break;
                                case "AutoCreateAccessTeams": settingUpdateSuccessful = retrieveResponse.EntityMetadata.AutoCreateAccessTeams.Value == enable ? true : false; break;
                                case "IsValidForQueue": settingUpdateSuccessful = retrieveResponse.EntityMetadata.IsValidForQueue.Value == enable ? true : false; break;
                                case "AutoRouteToOwnerQueue": settingUpdateSuccessful = retrieveResponse.EntityMetadata.AutoRouteToOwnerQueue.Value == enable ? true : false; break;
                                case "IsQuickCreateEnabled": settingUpdateSuccessful = retrieveResponse.EntityMetadata.IsQuickCreateEnabled.Value == enable ? true : false; break;
                                case "IsDuplicateDetectionEnabled": settingUpdateSuccessful = retrieveResponse.EntityMetadata.IsDuplicateDetectionEnabled.Value == enable ? true : false; break;
                                case "IsAuditEnabled": settingUpdateSuccessful = retrieveResponse.EntityMetadata.IsAuditEnabled.Value == enable ? true : false; break;
                                case "ChangeTrackingEnabled": settingUpdateSuccessful = retrieveResponse.EntityMetadata.ChangeTrackingEnabled.Value == enable ? true : false; break;
                                case "IsRetrieveAuditEnabled": settingUpdateSuccessful = retrieveResponse.EntityMetadata.IsRetrieveAuditEnabled.Value == enable ? true : false; break;
                                case "IsRetrieveMultipleAuditEnabled": settingUpdateSuccessful = retrieveResponse.EntityMetadata.IsRetrieveMultipleAuditEnabled.Value == enable ? true : false; break;
                                case "IsVisibleInMobile": settingUpdateSuccessful = retrieveResponse.EntityMetadata.IsVisibleInMobile.Value == enable ? true : false; break;
                                case "IsVisibleInMobileClient": settingUpdateSuccessful = retrieveResponse.EntityMetadata.IsVisibleInMobileClient.Value == enable ? true : false; break;
                                case "IsReadOnlyInMobileClient": settingUpdateSuccessful = retrieveResponse.EntityMetadata.IsReadOnlyInMobileClient.Value == enable ? true : false; break;
                                case "IsOfflineInMobileClient": settingUpdateSuccessful = retrieveResponse.EntityMetadata.IsOfflineInMobileClient.Value == enable ? true : false; break;
                                case "IsAvailableOffline": settingUpdateSuccessful = retrieveResponse.EntityMetadata.IsAvailableOffline.Value == enable ? true : false; break;
                                default: break;
                            }

                            if (settingUpdateSuccessful == false)
                            {
                                if (setting.Text.Contains("†") && enable == false)
                                {
                                    MessageBox.Show($"{setting.Text} setting update for {selectedEntity} failed. Settings with † cannot be disabled.");
                                }
                                else
                                {
                                    MessageBox.Show($"{setting.Text} setting update for {selectedEntity} failed. Please double check which settings are allowed to be enabled/disabled for this entity.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Settings update for {selectedEntity} failed for the following reason: {ex.Message}.");
                    }
                }
            }
        }
    }
}