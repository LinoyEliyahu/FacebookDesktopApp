using System;

namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.listBoxPostsComments = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.linkLabelPosts = new System.Windows.Forms.LinkLabel();
            this.linkLabelEvents = new System.Windows.Forms.LinkLabel();
            this.linkLabelFetchGroups = new System.Windows.Forms.LinkLabel();
            this.listBoxLikePages = new System.Windows.Forms.ListBox();
            this.linkLabelLikePages = new System.Windows.Forms.LinkLabel();
            this.linkLabelFetchAlbums = new System.Windows.Forms.LinkLabel();
            this.pictureBoxlikedPage = new System.Windows.Forms.PictureBox();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.feature2Label = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dateTimePickerUpTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panelPhotos = new System.Windows.Forms.Panel();
            this.comboBoxLikedPagesStrategies = new System.Windows.Forms.ComboBox();
            this.panelGroups = new System.Windows.Forms.Panel();
            this.panelEvents = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlikedPage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(16, 15);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(239, 28);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(16, 50);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(239, 28);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(644, 57);
            this.textBoxPostStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(489, 22);
            this.textBoxPostStatus.TabIndex = 89;
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileName.Location = new System.Drawing.Point(1203, 18);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(131, 33);
            this.labelProfileName.TabIndex = 97;
            this.labelProfileName.Text = "ProfileName";
            // 
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.Enabled = false;
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(1203, 57);
            this.pictureBoxUserProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(131, 114);
            this.pictureBoxUserProfile.TabIndex = 96;
            this.pictureBoxUserProfile.TabStop = false;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostStatus.Location = new System.Drawing.Point(1059, 84);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(75, 36);
            this.buttonPostStatus.TabIndex = 101;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // listBoxPostsComments
            // 
            this.listBoxPostsComments.BackColor = System.Drawing.Color.OldLace;
            this.listBoxPostsComments.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPostsComments.FormattingEnabled = true;
            this.listBoxPostsComments.ItemHeight = 26;
            this.listBoxPostsComments.Location = new System.Drawing.Point(16, 414);
            this.listBoxPostsComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPostsComments.Name = "listBoxPostsComments";
            this.listBoxPostsComments.Size = new System.Drawing.Size(453, 82);
            this.listBoxPostsComments.TabIndex = 100;
            this.listBoxPostsComments.SelectedIndexChanged += new System.EventHandler(this.listBoxPostsComments_SelectedIndexChanged);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 26;
            this.listBoxPosts.Location = new System.Drawing.Point(16, 223);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(453, 108);
            this.listBoxPosts.TabIndex = 99;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // linkLabelPosts
            // 
            this.linkLabelPosts.AutoSize = true;
            this.linkLabelPosts.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelPosts.LinkArea = new System.Windows.Forms.LinkArea(0, 11);
            this.linkLabelPosts.Location = new System.Drawing.Point(16, 162);
            this.linkLabelPosts.Name = "linkLabelPosts";
            this.linkLabelPosts.Size = new System.Drawing.Size(324, 58);
            this.linkLabelPosts.TabIndex = 98;
            this.linkLabelPosts.TabStop = true;
            this.linkLabelPosts.Text = "Fetch Posts\r\n(Click on a post to view the comments)\r\n";
            this.linkLabelPosts.UseCompatibleTextRendering = true;
            this.linkLabelPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPosts_LinkClicked);
            // 
            // linkLabelEvents
            // 
            this.linkLabelEvents.AutoSize = true;
            this.linkLabelEvents.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelEvents.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkLabelEvents.Location = new System.Drawing.Point(481, 524);
            this.linkLabelEvents.Name = "linkLabelEvents";
            this.linkLabelEvents.Size = new System.Drawing.Size(305, 58);
            this.linkLabelEvents.TabIndex = 107;
            this.linkLabelEvents.TabStop = true;
            this.linkLabelEvents.Text = "Fetch Events \r\n(Click on an event to view it\'s picture)";
            this.linkLabelEvents.UseCompatibleTextRendering = true;
            this.linkLabelEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEvents_LinkClicked);
            // 
            // linkLabelFetchGroups
            // 
            this.linkLabelFetchGroups.AutoSize = true;
            this.linkLabelFetchGroups.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFetchGroups.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkLabelFetchGroups.Location = new System.Drawing.Point(899, 162);
            this.linkLabelFetchGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelFetchGroups.Name = "linkLabelFetchGroups";
            this.linkLabelFetchGroups.Size = new System.Drawing.Size(119, 32);
            this.linkLabelFetchGroups.TabIndex = 105;
            this.linkLabelFetchGroups.TabStop = true;
            this.linkLabelFetchGroups.Text = "Fetch Groups\r\n";
            this.linkLabelFetchGroups.UseCompatibleTextRendering = true;
            this.linkLabelFetchGroups.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchGroups_LinkClicked);
            // 
            // listBoxLikePages
            // 
            this.listBoxLikePages.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLikePages.FormattingEnabled = true;
            this.listBoxLikePages.ItemHeight = 26;
            this.listBoxLikePages.Location = new System.Drawing.Point(899, 544);
            this.listBoxLikePages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLikePages.Name = "listBoxLikePages";
            this.listBoxLikePages.Size = new System.Drawing.Size(231, 82);
            this.listBoxLikePages.TabIndex = 111;
            this.listBoxLikePages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikePages_SelectedIndexChanged);
            // 
            // linkLabelLikePages
            // 
            this.linkLabelLikePages.AutoSize = true;
            this.linkLabelLikePages.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLikePages.LinkArea = new System.Windows.Forms.LinkArea(0, 16);
            this.linkLabelLikePages.Location = new System.Drawing.Point(899, 486);
            this.linkLabelLikePages.Name = "linkLabelLikePages";
            this.linkLabelLikePages.Size = new System.Drawing.Size(289, 58);
            this.linkLabelLikePages.TabIndex = 110;
            this.linkLabelLikePages.TabStop = true;
            this.linkLabelLikePages.Text = "Fetch Like Pages \r\n(Click on a page to view it\'s picture)";
            this.linkLabelLikePages.UseCompatibleTextRendering = true;
            this.linkLabelLikePages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLikePages_LinkClicked);
            // 
            // linkLabelFetchAlbums
            // 
            this.linkLabelFetchAlbums.AutoSize = true;
            this.linkLabelFetchAlbums.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFetchAlbums.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkLabelFetchAlbums.Location = new System.Drawing.Point(481, 162);
            this.linkLabelFetchAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelFetchAlbums.Name = "linkLabelFetchAlbums";
            this.linkLabelFetchAlbums.Size = new System.Drawing.Size(127, 32);
            this.linkLabelFetchAlbums.TabIndex = 109;
            this.linkLabelFetchAlbums.TabStop = true;
            this.linkLabelFetchAlbums.Text = "Fetch Albums \r\n";
            this.linkLabelFetchAlbums.UseCompatibleTextRendering = true;
            this.linkLabelFetchAlbums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchAlbums_LinkClicked);
            // 
            // pictureBoxlikedPage
            // 
            this.pictureBoxlikedPage.Location = new System.Drawing.Point(1160, 538);
            this.pictureBoxlikedPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxlikedPage.Name = "pictureBoxlikedPage";
            this.pictureBoxlikedPage.Size = new System.Drawing.Size(165, 134);
            this.pictureBoxlikedPage.TabIndex = 113;
            this.pictureBoxlikedPage.TabStop = false;
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.checkBoxRememberUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(16, 86);
            this.checkBoxRememberUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(150, 30);
            this.checkBoxRememberUser.TabIndex = 117;
            this.checkBoxRememberUser.Text = "Remember me!";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            // 
            // feature2Label
            // 
            this.feature2Label.AutoSize = true;
            this.feature2Label.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Underline);
            this.feature2Label.LinkArea = new System.Windows.Forms.LinkArea(0, 30);
            this.feature2Label.LinkColor = System.Drawing.Color.Blue;
            this.feature2Label.Location = new System.Drawing.Point(962, 674);
            this.feature2Label.Name = "feature2Label";
            this.feature2Label.Size = new System.Drawing.Size(264, 26);
            this.feature2Label.TabIndex = 119;
            this.feature2Label.TabStop = true;
            this.feature2Label.Text = "Feature 2: Show Top 10 Taggers";
            this.feature2Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.feature2LabelLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 633);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 128;
            this.label2.Text = "to date : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 599);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 127;
            this.label1.Text = "from date :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.linkLabel1.Location = new System.Drawing.Point(3, 666);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(400, 26);
            this.linkLabel1.TabIndex = 126;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "click to show all photos between the selected dates!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dateTimePickerUpTo
            // 
            this.dateTimePickerUpTo.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dateTimePickerUpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerUpTo.Location = new System.Drawing.Point(120, 634);
            this.dateTimePickerUpTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerUpTo.MaxDate = new System.DateTime(2110, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerUpTo.Name = "dateTimePickerUpTo";
            this.dateTimePickerUpTo.Size = new System.Drawing.Size(199, 27);
            this.dateTimePickerUpTo.TabIndex = 125;
            this.dateTimePickerUpTo.Value = new System.DateTime(2023, 1, 9, 0, 0, 0, 0);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(120, 599);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFrom.MaxDate = new System.DateTime(2110, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(199, 27);
            this.dateTimePickerFrom.TabIndex = 124;
            this.dateTimePickerFrom.Value = new System.DateTime(2023, 1, 9, 0, 0, 0, 0);
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.labelAlbumName.Location = new System.Drawing.Point(599, 460);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(115, 26);
            this.labelAlbumName.TabIndex = 130;
            this.labelAlbumName.Text = "Album Name:";
            this.labelAlbumName.Visible = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.textBoxName.Location = new System.Drawing.Point(532, 488);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(257, 34);
            this.textBoxName.TabIndex = 129;
            this.textBoxName.Visible = false;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // panelPhotos
            // 
            this.panelPhotos.AutoScroll = true;
            this.panelPhotos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPhotos.Location = new System.Drawing.Point(484, 196);
            this.panelPhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPhotos.Name = "panelPhotos";
            this.panelPhotos.Size = new System.Drawing.Size(395, 262);
            this.panelPhotos.TabIndex = 131;
            // 
            // comboBoxLikedPagesStrategies
            // 
            this.comboBoxLikedPagesStrategies.FormattingEnabled = true;
            this.comboBoxLikedPagesStrategies.Items.AddRange(new object[] {
            "A to Z",
            "Z to A",
            "Sort By Likes"});
            this.comboBoxLikedPagesStrategies.Location = new System.Drawing.Point(899, 645);
            this.comboBoxLikedPagesStrategies.Name = "comboBoxLikedPagesStrategies";
            this.comboBoxLikedPagesStrategies.Size = new System.Drawing.Size(231, 24);
            this.comboBoxLikedPagesStrategies.TabIndex = 132;
            this.comboBoxLikedPagesStrategies.SelectedIndexChanged += new System.EventHandler(this.comboBoxLikedPagesStrategies_SelectedIndexChanged);
            // 
            // panelGroups
            // 
            this.panelGroups.AutoScroll = true;
            this.panelGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGroups.Location = new System.Drawing.Point(899, 196);
            this.panelGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.Size = new System.Drawing.Size(395, 262);
            this.panelGroups.TabIndex = 133;
            // 
            // panelEvents
            // 
            this.panelEvents.AutoScroll = true;
            this.panelEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEvents.Location = new System.Drawing.Point(481, 576);
            this.panelEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEvents.Name = "panelEvents";
            this.panelEvents.Size = new System.Drawing.Size(395, 243);
            this.panelEvents.TabIndex = 134;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 847);
            this.Controls.Add(this.panelEvents);
            this.Controls.Add(this.panelGroups);
            this.Controls.Add(this.comboBoxLikedPagesStrategies);
            this.Controls.Add(this.panelPhotos);
            this.Controls.Add(this.labelAlbumName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dateTimePickerUpTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.feature2Label);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.pictureBoxlikedPage);
            this.Controls.Add(this.listBoxLikePages);
            this.Controls.Add(this.linkLabelLikePages);
            this.Controls.Add(this.linkLabelFetchAlbums);
            this.Controls.Add(this.linkLabelEvents);
            this.Controls.Add(this.linkLabelFetchGroups);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.listBoxPostsComments);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.linkLabelPosts);
            this.Controls.Add(this.labelProfileName);
            this.Controls.Add(this.pictureBoxUserProfile);
            this.Controls.Add(this.textBoxPostStatus);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlikedPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TextBox textBoxPostStatus;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.PictureBox pictureBoxUserProfile;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.ListBox listBoxPostsComments;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.LinkLabel linkLabelPosts;
        private System.Windows.Forms.LinkLabel linkLabelEvents;
        private System.Windows.Forms.LinkLabel linkLabelFetchGroups;
        private System.Windows.Forms.ListBox listBoxLikePages;
        private System.Windows.Forms.LinkLabel linkLabelLikePages;
        private System.Windows.Forms.LinkLabel linkLabelFetchAlbums;
        private System.Windows.Forms.PictureBox pictureBoxlikedPage;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.LinkLabel feature2Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerUpTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel panelPhotos;
        private System.Windows.Forms.ComboBox comboBoxLikedPagesStrategies;
        private System.Windows.Forms.Panel panelGroups;
        private System.Windows.Forms.Panel panelEvents;
    }
}