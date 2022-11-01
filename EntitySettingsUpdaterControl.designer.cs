namespace EntitySettingsUpdater
{
    partial class EntitySettingsUpdaterControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntitySettingsUpdaterControl));
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("Process", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("Communication & Collaboration", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("Data Services", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("Auditing", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Outlook & Mobile", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem45 = new System.Windows.Forms.ListViewItem("Business process flows †");
            System.Windows.Forms.ListViewItem listViewItem46 = new System.Windows.Forms.ListViewItem("Feedback †");
            System.Windows.Forms.ListViewItem listViewItem47 = new System.Windows.Forms.ListViewItem("Notes (includes attachments) †");
            System.Windows.Forms.ListViewItem listViewItem48 = new System.Windows.Forms.ListViewItem("Activities †");
            System.Windows.Forms.ListViewItem listViewItem49 = new System.Windows.Forms.ListViewItem("Connections †");
            System.Windows.Forms.ListViewItem listViewItem50 = new System.Windows.Forms.ListViewItem("Sending email †");
            System.Windows.Forms.ListViewItem listViewItem51 = new System.Windows.Forms.ListViewItem("Mail merge");
            System.Windows.Forms.ListViewItem listViewItem52 = new System.Windows.Forms.ListViewItem("Document management");
            System.Windows.Forms.ListViewItem listViewItem53 = new System.Windows.Forms.ListViewItem("Access Teams");
            System.Windows.Forms.ListViewItem listViewItem54 = new System.Windows.Forms.ListViewItem("Queues †");
            System.Windows.Forms.ListViewItem listViewItem55 = new System.Windows.Forms.ListViewItem("Auto-fill queue");
            System.Windows.Forms.ListViewItem listViewItem56 = new System.Windows.Forms.ListViewItem("Allow quick create");
            System.Windows.Forms.ListViewItem listViewItem57 = new System.Windows.Forms.ListViewItem("Duplicate detection");
            System.Windows.Forms.ListViewItem listViewItem58 = new System.Windows.Forms.ListViewItem("Auditing");
            System.Windows.Forms.ListViewItem listViewItem59 = new System.Windows.Forms.ListViewItem("Change Tracking †");
            System.Windows.Forms.ListViewItem listViewItem60 = new System.Windows.Forms.ListViewItem("Single record auditing");
            System.Windows.Forms.ListViewItem listViewItem61 = new System.Windows.Forms.ListViewItem("Multiple record auditing");
            System.Windows.Forms.ListViewItem listViewItem62 = new System.Windows.Forms.ListViewItem("Enable for phone express");
            System.Windows.Forms.ListViewItem listViewItem63 = new System.Windows.Forms.ListViewItem("Enable for Unified Client");
            System.Windows.Forms.ListViewItem listViewItem64 = new System.Windows.Forms.ListViewItem("Read-only in Unified Client");
            System.Windows.Forms.ListViewItem listViewItem65 = new System.Windows.Forms.ListViewItem("Enable for Mobile offline");
            System.Windows.Forms.ListViewItem listViewItem66 = new System.Windows.Forms.ListViewItem("Offline capability for Dynamics 365 for Outlook");
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_loadentities = new System.Windows.Forms.ToolStripButton();
            this.lst_actions = new System.Windows.Forms.ListBox();
            this.btn_execute = new System.Windows.Forms.Button();
            this.lst_entities = new System.Windows.Forms.ListBox();
            this.lbl_entities = new System.Windows.Forms.Label();
            this.lbl_action = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstvw_settings = new System.Windows.Forms.ListView();
            this.lbl_settings = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.btn_loadentities});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(713, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            this.toolStripMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenu_ItemClicked);
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(40, 22);
            this.tsbClose.Text = "Close";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_loadentities
            // 
            this.btn_loadentities.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_loadentities.Image = ((System.Drawing.Image)(resources.GetObject("btn_loadentities.Image")));
            this.btn_loadentities.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_loadentities.Name = "btn_loadentities";
            this.btn_loadentities.Size = new System.Drawing.Size(78, 22);
            this.btn_loadentities.Text = "Load Entities";
            this.btn_loadentities.Click += new System.EventHandler(this.btn_loadentities_Click);
            // 
            // lst_actions
            // 
            this.lst_actions.BackColor = System.Drawing.SystemColors.Window;
            this.lst_actions.Enabled = false;
            this.lst_actions.FormattingEnabled = true;
            this.lst_actions.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.lst_actions.Location = new System.Drawing.Point(580, 44);
            this.lst_actions.Name = "lst_actions";
            this.lst_actions.Size = new System.Drawing.Size(117, 30);
            this.lst_actions.TabIndex = 15;
            this.lst_actions.SelectedIndexChanged += new System.EventHandler(this.lst_actions_SelectedIndexChanged);
            // 
            // btn_execute
            // 
            this.btn_execute.BackColor = System.Drawing.Color.Transparent;
            this.btn_execute.Enabled = false;
            this.btn_execute.Location = new System.Drawing.Point(580, 80);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(117, 23);
            this.btn_execute.TabIndex = 16;
            this.btn_execute.Text = "Execute";
            this.btn_execute.UseVisualStyleBackColor = false;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // lst_entities
            // 
            this.lst_entities.Enabled = false;
            this.lst_entities.FormattingEnabled = true;
            this.lst_entities.Location = new System.Drawing.Point(4, 44);
            this.lst_entities.Name = "lst_entities";
            this.lst_entities.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_entities.Size = new System.Drawing.Size(200, 485);
            this.lst_entities.TabIndex = 20;
            // 
            // lbl_entities
            // 
            this.lbl_entities.AutoSize = true;
            this.lbl_entities.Location = new System.Drawing.Point(1, 28);
            this.lbl_entities.Name = "lbl_entities";
            this.lbl_entities.Size = new System.Drawing.Size(41, 13);
            this.lbl_entities.TabIndex = 23;
            this.lbl_entities.Text = "Entities";
            // 
            // lbl_action
            // 
            this.lbl_action.AutoSize = true;
            this.lbl_action.Location = new System.Drawing.Point(577, 28);
            this.lbl_action.Name = "lbl_action";
            this.lbl_action.Size = new System.Drawing.Size(37, 13);
            this.lbl_action.TabIndex = 26;
            this.lbl_action.Text = "Action";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EntitySettingsUpdater.Properties.Resources.sagemodeicon8080;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(580, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 80);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // lstvw_settings
            // 
            this.lstvw_settings.Cursor = System.Windows.Forms.Cursors.Default;
            listViewGroup11.Header = "Process";
            listViewGroup11.Name = "Process";
            listViewGroup12.Header = "Communication & Collaboration";
            listViewGroup12.Name = "CommunicationAndCollaboration";
            listViewGroup13.Header = "Data Services";
            listViewGroup13.Name = "DataServices";
            listViewGroup14.Header = "Auditing";
            listViewGroup14.Name = "Auditing";
            listViewGroup15.Header = "Outlook & Mobile";
            listViewGroup15.Name = "OutlookAndMobile";
            this.lstvw_settings.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup11,
            listViewGroup12,
            listViewGroup13,
            listViewGroup14,
            listViewGroup15});
            this.lstvw_settings.HideSelection = false;
            listViewItem45.Group = listViewGroup11;
            listViewItem45.Tag = "IsBusinessProcessEnabled";
            listViewItem45.ToolTipText = "Fields will be created.";
            listViewItem46.Group = listViewGroup12;
            listViewItem46.Tag = "HasFeedback";
            listViewItem47.Group = listViewGroup12;
            listViewItem47.Tag = "HasNotes";
            listViewItem48.Group = listViewGroup12;
            listViewItem48.Tag = "HasActivities";
            listViewItem49.Group = listViewGroup12;
            listViewItem49.Tag = "IsConnectionsEnabled";
            listViewItem50.Group = listViewGroup12;
            listViewItem50.Tag = "IsActivityParty";
            listViewItem50.ToolTipText = "If an email field does not exist, one will be created.";
            listViewItem51.Group = listViewGroup12;
            listViewItem51.Tag = "IsMailMergeEnabled";
            listViewItem52.Group = listViewGroup12;
            listViewItem52.Tag = "IsDocumentManagementEnabled";
            listViewItem53.Group = listViewGroup12;
            listViewItem53.Tag = "AutoCreateAccessTeams";
            listViewItem54.Group = listViewGroup12;
            listViewItem54.Tag = "IsValidForQueue";
            listViewItem55.Group = listViewGroup12;
            listViewItem55.Tag = "AutoRouteToOwnerQueue";
            listViewItem55.ToolTipText = "Automatically move records to the owner\'s default queue when a record is created " +
    "or assigned.";
            listViewItem56.Group = listViewGroup13;
            listViewItem56.Tag = "IsQuickCreateEnabled";
            listViewItem57.Group = listViewGroup13;
            listViewItem57.Tag = "IsDuplicateDetectionEnabled";
            listViewItem58.Group = listViewGroup13;
            listViewItem58.Tag = "IsAuditEnabled";
            listViewItem59.Group = listViewGroup13;
            listViewItem59.Tag = "ChangeTrackingEnabled";
            listViewItem60.Group = listViewGroup14;
            listViewItem60.Tag = "IsRetrieveAuditEnabled";
            listViewItem60.ToolTipText = "Log a record when opened.";
            listViewItem61.Group = listViewGroup14;
            listViewItem61.Tag = "IsRetrieveMultipleAuditEnabled";
            listViewItem61.ToolTipText = "Log all records displayed on an opened page.";
            listViewItem62.Group = listViewGroup15;
            listViewItem62.Tag = "IsVisibleInMobile";
            listViewItem63.Group = listViewGroup15;
            listViewItem63.Tag = "IsVisibleInMobileClient";
            listViewItem64.Group = listViewGroup15;
            listViewItem64.Tag = "IsReadOnlyInMobileClient";
            listViewItem65.Group = listViewGroup15;
            listViewItem65.Tag = "IsOfflineInMobileClient";
            listViewItem66.Group = listViewGroup15;
            listViewItem66.Tag = "IsAvailableOffline";
            this.lstvw_settings.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem45,
            listViewItem46,
            listViewItem47,
            listViewItem48,
            listViewItem49,
            listViewItem50,
            listViewItem51,
            listViewItem52,
            listViewItem53,
            listViewItem54,
            listViewItem55,
            listViewItem56,
            listViewItem57,
            listViewItem58,
            listViewItem59,
            listViewItem60,
            listViewItem61,
            listViewItem62,
            listViewItem63,
            listViewItem64,
            listViewItem65,
            listViewItem66});
            this.lstvw_settings.Location = new System.Drawing.Point(210, 44);
            this.lstvw_settings.Name = "lstvw_settings";
            this.lstvw_settings.ShowItemToolTips = true;
            this.lstvw_settings.Size = new System.Drawing.Size(364, 485);
            this.lstvw_settings.TabIndex = 29;
            this.lstvw_settings.UseCompatibleStateImageBehavior = false;
            this.lstvw_settings.View = System.Windows.Forms.View.Tile;
            // 
            // lbl_settings
            // 
            this.lbl_settings.AutoSize = true;
            this.lbl_settings.Location = new System.Drawing.Point(207, 28);
            this.lbl_settings.Name = "lbl_settings";
            this.lbl_settings.Size = new System.Drawing.Size(45, 13);
            this.lbl_settings.TabIndex = 25;
            this.lbl_settings.Text = "Settings";
            // 
            // EntitySettingsUpdaterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstvw_settings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_action);
            this.Controls.Add(this.lbl_settings);
            this.Controls.Add(this.lbl_entities);
            this.Controls.Add(this.lst_entities);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.lst_actions);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "EntitySettingsUpdaterControl";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(713, 538);
            this.TabIcon = ((System.Drawing.Image)(resources.GetObject("$this.TabIcon")));
            this.Load += new System.EventHandler(this.EntitySettingsUpdaterControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.ToolStripButton btn_loadentities;
        private System.Windows.Forms.ListBox lst_actions;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.ListBox lst_entities;
        private System.Windows.Forms.Label lbl_entities;
        private System.Windows.Forms.Label lbl_action;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lstvw_settings;
        private System.Windows.Forms.Label lbl_settings;
    }
}
