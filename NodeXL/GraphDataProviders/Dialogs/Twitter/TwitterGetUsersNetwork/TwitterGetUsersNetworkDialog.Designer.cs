﻿

namespace Smrf.NodeXL.GraphDataProviders.Twitter
{
    partial class TwitterGetUsersNetworkDialog
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.usrTwitterRateLimits = new Smrf.NodeXL.GraphDataProviders.Twitter.TwitterRateLimitsControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlUserInputs = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMaximumStatusesPerUser = new System.Windows.Forms.NumericUpDown();
            this.chkExpandStatusUrls = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkLimitToSpecifiedUsers = new System.Windows.Forms.CheckBox();
            this.hllNetworkTypeBasic = new Smrf.AppLib.HelpLinkLabel();
            this.hllNetworkTypeBasicPlusFollows = new Smrf.AppLib.HelpLinkLabel();
            this.picNetworkPreview = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radNetworkTypeBasicPlusFollows = new System.Windows.Forms.RadioButton();
            this.radNetworkTypeBasic = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radUseScreenNames = new System.Windows.Forms.RadioButton();
            this.radUseListName = new System.Windows.Forms.RadioButton();
            this.txbListName = new System.Windows.Forms.TextBox();
            this.txbScreenNames = new System.Windows.Forms.TextBox();
            this.lblScreenNamesHelp = new System.Windows.Forms.Label();
            this.usrTwitterAuthorization = new Smrf.NodeXL.GraphDataProviders.Twitter.TwitterAuthorizationControl();
            this.statusStrip1.SuspendLayout();
            this.pnlUserInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumStatusesPerUser)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNetworkPreview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(522, 555);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(608, 555);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // usrTwitterRateLimits
            // 
            this.usrTwitterRateLimits.Location = new System.Drawing.Point(12, 12);
            this.usrTwitterRateLimits.Name = "usrTwitterRateLimits";
            this.usrTwitterRateLimits.Size = new System.Drawing.Size(352, 14);
            this.usrTwitterRateLimits.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 592);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(702, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slStatusLabel
            // 
            this.slStatusLabel.Name = "slStatusLabel";
            this.slStatusLabel.Size = new System.Drawing.Size(687, 17);
            this.slStatusLabel.Spring = true;
            this.slStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlUserInputs
            // 
            this.pnlUserInputs.Controls.Add(this.label4);
            this.pnlUserInputs.Controls.Add(this.label3);
            this.pnlUserInputs.Controls.Add(this.nudMaximumStatusesPerUser);
            this.pnlUserInputs.Controls.Add(this.chkExpandStatusUrls);
            this.pnlUserInputs.Controls.Add(this.groupBox2);
            this.pnlUserInputs.Controls.Add(this.groupBox1);
            this.pnlUserInputs.Controls.Add(this.usrTwitterAuthorization);
            this.pnlUserInputs.Location = new System.Drawing.Point(10, 41);
            this.pnlUserInputs.Name = "pnlUserInputs";
            this.pnlUserInputs.Size = new System.Drawing.Size(685, 512);
            this.pnlUserInputs.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Li&mit to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "recent tweets per user";
            // 
            // nudMaximumStatusesPerUser
            // 
            this.nudMaximumStatusesPerUser.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaximumStatusesPerUser.Location = new System.Drawing.Point(433, 422);
            this.nudMaximumStatusesPerUser.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudMaximumStatusesPerUser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaximumStatusesPerUser.Name = "nudMaximumStatusesPerUser";
            this.nudMaximumStatusesPerUser.Size = new System.Drawing.Size(60, 20);
            this.nudMaximumStatusesPerUser.TabIndex = 4;
            this.nudMaximumStatusesPerUser.ThousandsSeparator = true;
            this.nudMaximumStatusesPerUser.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // chkExpandStatusUrls
            // 
            this.chkExpandStatusUrls.AutoSize = true;
            this.chkExpandStatusUrls.Location = new System.Drawing.Point(390, 458);
            this.chkExpandStatusUrls.Name = "chkExpandStatusUrls";
            this.chkExpandStatusUrls.Size = new System.Drawing.Size(209, 17);
            this.chkExpandStatusUrls.TabIndex = 6;
            this.chkExpandStatusUrls.Text = "E&xpand URLs in recent tweets (slower)";
            this.chkExpandStatusUrls.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkLimitToSpecifiedUsers);
            this.groupBox2.Controls.Add(this.hllNetworkTypeBasic);
            this.groupBox2.Controls.Add(this.hllNetworkTypeBasicPlusFollows);
            this.groupBox2.Controls.Add(this.picNetworkPreview);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.radNetworkTypeBasicPlusFollows);
            this.groupBox2.Controls.Add(this.radNetworkTypeBasic);
            this.groupBox2.Location = new System.Drawing.Point(0, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "What to import";
            // 
            // chkLimitToSpecifiedUsers
            // 
            this.chkLimitToSpecifiedUsers.AutoSize = true;
            this.chkLimitToSpecifiedUsers.Location = new System.Drawing.Point(15, 172);
            this.chkLimitToSpecifiedUsers.Name = "chkLimitToSpecifiedUsers";
            this.chkLimitToSpecifiedUsers.Size = new System.Drawing.Size(234, 17);
            this.chkLimitToSpecifiedUsers.TabIndex = 6;
            this.chkLimitToSpecifiedUsers.Text = "&Import only the Twitter users I\'m interested in";
            this.chkLimitToSpecifiedUsers.UseVisualStyleBackColor = true;
            this.chkLimitToSpecifiedUsers.CheckedChanged += new System.EventHandler(this.OnEventThatRequiresImageChange);
            // 
            // hllNetworkTypeBasic
            // 
            this.hllNetworkTypeBasic.AutoSize = true;
            this.hllNetworkTypeBasic.Location = new System.Drawing.Point(49, 69);
            this.hllNetworkTypeBasic.Name = "hllNetworkTypeBasic";
            this.hllNetworkTypeBasic.Size = new System.Drawing.Size(112, 13);
            this.hllNetworkTypeBasic.TabIndex = 2;
            this.hllNetworkTypeBasic.TabStop = true;
            this.hllNetworkTypeBasic.Tag = "";
            this.hllNetworkTypeBasic.Text = "More about this option";
            // 
            // hllNetworkTypeBasicPlusFollows
            // 
            this.hllNetworkTypeBasicPlusFollows.AutoSize = true;
            this.hllNetworkTypeBasicPlusFollows.Location = new System.Drawing.Point(49, 138);
            this.hllNetworkTypeBasicPlusFollows.Name = "hllNetworkTypeBasicPlusFollows";
            this.hllNetworkTypeBasicPlusFollows.Size = new System.Drawing.Size(112, 13);
            this.hllNetworkTypeBasicPlusFollows.TabIndex = 5;
            this.hllNetworkTypeBasicPlusFollows.TabStop = true;
            this.hllNetworkTypeBasicPlusFollows.Tag = "";
            this.hllNetworkTypeBasicPlusFollows.Text = "More about this option";
            // 
            // picNetworkPreview
            // 
            this.picNetworkPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNetworkPreview.Location = new System.Drawing.Point(390, 19);
            this.picNetworkPreview.Name = "picNetworkPreview";
            this.picNetworkPreview.Size = new System.Drawing.Size(166, 119);
            this.picNetworkPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picNetworkPreview.TabIndex = 6;
            this.picNetworkPreview.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add some of the users\' friends and followers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show who was mentioned or replied to in the users\' recent tweets";
            // 
            // radNetworkTypeBasicPlusFollows
            // 
            this.radNetworkTypeBasicPlusFollows.AutoSize = true;
            this.radNetworkTypeBasicPlusFollows.Location = new System.Drawing.Point(15, 96);
            this.radNetworkTypeBasicPlusFollows.Name = "radNetworkTypeBasicPlusFollows";
            this.radNetworkTypeBasicPlusFollows.Size = new System.Drawing.Size(269, 17);
            this.radNetworkTypeBasicPlusFollows.TabIndex = 3;
            this.radNetworkTypeBasicPlusFollows.TabStop = true;
            this.radNetworkTypeBasicPlusFollows.Text = "Basic network plus &friends and followers (very slow!)";
            this.radNetworkTypeBasicPlusFollows.UseVisualStyleBackColor = true;
            this.radNetworkTypeBasicPlusFollows.CheckedChanged += new System.EventHandler(this.OnEventThatRequiresImageChange);
            // 
            // radNetworkTypeBasic
            // 
            this.radNetworkTypeBasic.AutoSize = true;
            this.radNetworkTypeBasic.Location = new System.Drawing.Point(15, 27);
            this.radNetworkTypeBasic.Name = "radNetworkTypeBasic";
            this.radNetworkTypeBasic.Size = new System.Drawing.Size(92, 17);
            this.radNetworkTypeBasic.TabIndex = 0;
            this.radNetworkTypeBasic.TabStop = true;
            this.radNetworkTypeBasic.Text = "&Basic network";
            this.radNetworkTypeBasic.UseVisualStyleBackColor = true;
            this.radNetworkTypeBasic.CheckedChanged += new System.EventHandler(this.OnEventThatRequiresImageChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radUseScreenNames);
            this.groupBox1.Controls.Add(this.radUseListName);
            this.groupBox1.Controls.Add(this.txbListName);
            this.groupBox1.Controls.Add(this.txbScreenNames);
            this.groupBox1.Controls.Add(this.lblScreenNamesHelp);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Twitter users I\'m interested in";
            // 
            // radUseScreenNames
            // 
            this.radUseScreenNames.AutoSize = true;
            this.radUseScreenNames.Location = new System.Drawing.Point(15, 18);
            this.radUseScreenNames.Name = "radUseScreenNames";
            this.radUseScreenNames.Size = new System.Drawing.Size(215, 17);
            this.radUseScreenNames.TabIndex = 0;
            this.radUseScreenNames.Text = "The &Twitter users with these usernames:";
            this.radUseScreenNames.UseVisualStyleBackColor = true;
            this.radUseScreenNames.CheckedChanged += new System.EventHandler(this.OnEventThatRequiresControlEnabling);
            // 
            // radUseListName
            // 
            this.radUseListName.AutoSize = true;
            this.radUseListName.Location = new System.Drawing.Point(15, 108);
            this.radUseListName.Name = "radUseListName";
            this.radUseListName.Size = new System.Drawing.Size(194, 17);
            this.radUseListName.TabIndex = 3;
            this.radUseListName.Text = "The Twitter &users in this Twitter List:";
            this.radUseListName.UseVisualStyleBackColor = true;
            this.radUseListName.CheckedChanged += new System.EventHandler(this.OnEventThatRequiresControlEnabling);
            // 
            // txbListName
            // 
            this.txbListName.Location = new System.Drawing.Point(34, 131);
            this.txbListName.MaxLength = 41;
            this.txbListName.Name = "txbListName";
            this.txbListName.Size = new System.Drawing.Size(222, 20);
            this.txbListName.TabIndex = 4;
            // 
            // txbScreenNames
            // 
            this.txbScreenNames.AcceptsReturn = true;
            this.txbScreenNames.Enabled = false;
            this.txbScreenNames.Location = new System.Drawing.Point(34, 41);
            this.txbScreenNames.Multiline = true;
            this.txbScreenNames.Name = "txbScreenNames";
            this.txbScreenNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbScreenNames.Size = new System.Drawing.Size(541, 38);
            this.txbScreenNames.TabIndex = 1;
            // 
            // lblScreenNamesHelp
            // 
            this.lblScreenNamesHelp.AutoSize = true;
            this.lblScreenNamesHelp.Enabled = false;
            this.lblScreenNamesHelp.Location = new System.Drawing.Point(34, 84);
            this.lblScreenNamesHelp.Name = "lblScreenNamesHelp";
            this.lblScreenNamesHelp.Size = new System.Drawing.Size(207, 13);
            this.lblScreenNamesHelp.TabIndex = 2;
            this.lblScreenNamesHelp.Text = "(Separate with spaces, commas or returns)";
            // 
            // usrTwitterAuthorization
            // 
            this.usrTwitterAuthorization.Location = new System.Drawing.Point(0, 386);
            this.usrTwitterAuthorization.Name = "usrTwitterAuthorization";
            this.usrTwitterAuthorization.Size = new System.Drawing.Size(352, 124);
            this.usrTwitterAuthorization.Status = Smrf.NodeXL.GraphDataProviders.Twitter.TwitterAuthorizationStatus.HasTwitterAccountNotAuthorized;
            this.usrTwitterAuthorization.TabIndex = 2;
            // 
            // TwitterGetUsersNetworkDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(702, 614);
            this.Controls.Add(this.usrTwitterRateLimits);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlUserInputs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TwitterGetUsersNetworkDialog";
            this.Text = "[Gets set in code]";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlUserInputs.ResumeLayout(false);
            this.pnlUserInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumStatusesPerUser)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNetworkPreview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbScreenNames;
        private System.Windows.Forms.Label lblScreenNamesHelp;
        private System.Windows.Forms.Panel pnlUserInputs;
        private TwitterAuthorizationControl usrTwitterAuthorization;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slStatusLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radUseListName;
        private System.Windows.Forms.TextBox txbListName;
        private System.Windows.Forms.RadioButton radUseScreenNames;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkExpandStatusUrls;
        private TwitterRateLimitsControl usrTwitterRateLimits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radNetworkTypeBasicPlusFollows;
        private System.Windows.Forms.RadioButton radNetworkTypeBasic;
        private System.Windows.Forms.PictureBox picNetworkPreview;
        private AppLib.HelpLinkLabel hllNetworkTypeBasicPlusFollows;
        private AppLib.HelpLinkLabel hllNetworkTypeBasic;
        private System.Windows.Forms.CheckBox chkLimitToSpecifiedUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMaximumStatusesPerUser;
    }
}
