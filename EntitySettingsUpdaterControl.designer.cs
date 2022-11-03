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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Process", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Communication & Collaboration", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Data Services", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Auditing", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Outlook & Mobile", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Business process flows †");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Feedback †");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Notes (includes attachments) †");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Activities †");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Connections †");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Sending email †");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Mail merge");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Document management");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Access Teams");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Queues †");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Auto-fill queue");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Allow quick create");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Duplicate detection");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Auditing");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Change Tracking †");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Single record auditing");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Multiple record auditing");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Enable for phone express");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("Enable for Unified Client");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("Read-only in Unified Client");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("Enable for Mobile offline");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("Offline capability for Dynamics 365 for Outlook");
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.lstvw_settings.Enabled = false;
            listViewGroup1.Header = "Process";
            listViewGroup1.Name = "Process";
            listViewGroup2.Header = "Communication & Collaboration";
            listViewGroup2.Name = "CommunicationAndCollaboration";
            listViewGroup3.Header = "Data Services";
            listViewGroup3.Name = "DataServices";
            listViewGroup4.Header = "Auditing";
            listViewGroup4.Name = "Auditing";
            listViewGroup5.Header = "Outlook & Mobile";
            listViewGroup5.Name = "OutlookAndMobile";
            this.lstvw_settings.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.lstvw_settings.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem1.Tag = "IsBusinessProcessEnabled";
            listViewItem1.ToolTipText = "Fields will be created.";
            listViewItem2.Group = listViewGroup2;
            listViewItem2.Tag = "HasFeedback";
            listViewItem3.Group = listViewGroup2;
            listViewItem3.Tag = "HasNotes";
            listViewItem4.Group = listViewGroup2;
            listViewItem4.Tag = "HasActivities";
            listViewItem5.Group = listViewGroup2;
            listViewItem5.Tag = "IsConnectionsEnabled";
            listViewItem6.Group = listViewGroup2;
            listViewItem6.Tag = "IsActivityParty";
            listViewItem6.ToolTipText = "If an email field does not exist, one will be created.";
            listViewItem7.Group = listViewGroup2;
            listViewItem7.Tag = "IsMailMergeEnabled";
            listViewItem8.Group = listViewGroup2;
            listViewItem8.Tag = "IsDocumentManagementEnabled";
            listViewItem9.Group = listViewGroup2;
            listViewItem9.Tag = "AutoCreateAccessTeams";
            listViewItem10.Group = listViewGroup2;
            listViewItem10.Tag = "IsValidForQueue";
            listViewItem11.Group = listViewGroup2;
            listViewItem11.Tag = "AutoRouteToOwnerQueue";
            listViewItem11.ToolTipText = "Automatically move records to the owner\'s default queue when a record is created " +
    "or assigned.";
            listViewItem12.Group = listViewGroup3;
            listViewItem12.Tag = "IsQuickCreateEnabled";
            listViewItem13.Group = listViewGroup3;
            listViewItem13.Tag = "IsDuplicateDetectionEnabled";
            listViewItem14.Group = listViewGroup3;
            listViewItem14.Tag = "IsAuditEnabled";
            listViewItem15.Group = listViewGroup3;
            listViewItem15.Tag = "ChangeTrackingEnabled";
            listViewItem16.Group = listViewGroup4;
            listViewItem16.Tag = "IsRetrieveAuditEnabled";
            listViewItem16.ToolTipText = "Log a record when opened.";
            listViewItem17.Group = listViewGroup4;
            listViewItem17.Tag = "IsRetrieveMultipleAuditEnabled";
            listViewItem17.ToolTipText = "Log all records displayed on an opened page.";
            listViewItem18.Group = listViewGroup5;
            listViewItem18.Tag = "IsVisibleInMobile";
            listViewItem19.Group = listViewGroup5;
            listViewItem19.Tag = "IsVisibleInMobileClient";
            listViewItem20.Group = listViewGroup5;
            listViewItem20.Tag = "IsReadOnlyInMobileClient";
            listViewItem21.Group = listViewGroup5;
            listViewItem21.Tag = "IsOfflineInMobileClient";
            listViewItem22.Group = listViewGroup5;
            listViewItem22.Tag = "IsAvailableOffline";
            this.lstvw_settings.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22});
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "† - After you enable this option it cannot be disabled.";
            // 
            // EntitySettingsUpdaterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
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
            this.Size = new System.Drawing.Size(713, 625);
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
        private System.Windows.Forms.Label label1;
    }
}
