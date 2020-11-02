namespace VRSoftware
{
    partial class IssueVideo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popularVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popularCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblFooter = new System.Windows.Forms.Label();
            this.LblHeading = new System.Windows.Forms.Label();
            this.IssuedateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboVideo = new System.Windows.Forms.ComboBox();
            this.LblId = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.LblIssueDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.LblIssuehid = new System.Windows.Forms.Label();
            this.issuedVideoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.videoToolStripMenuItem,
            this.popularVideoToolStripMenuItem,
            this.popularCustomerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1395, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerListToolStripMenuItem,
            this.addCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // customerListToolStripMenuItem
            // 
            this.customerListToolStripMenuItem.Name = "customerListToolStripMenuItem";
            this.customerListToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.customerListToolStripMenuItem.Text = "Customer List";
            this.customerListToolStripMenuItem.Click += new System.EventHandler(this.customerListToolStripMenuItem_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoListToolStripMenuItem,
            this.addVideoToolStripMenuItem,
            this.issueVideoToolStripMenuItem,
            this.issuedVideoListToolStripMenuItem});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.videoToolStripMenuItem.Text = "Video";
            // 
            // videoListToolStripMenuItem
            // 
            this.videoListToolStripMenuItem.Name = "videoListToolStripMenuItem";
            this.videoListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.videoListToolStripMenuItem.Text = "Video List";
            this.videoListToolStripMenuItem.Click += new System.EventHandler(this.videoListToolStripMenuItem_Click);
            // 
            // addVideoToolStripMenuItem
            // 
            this.addVideoToolStripMenuItem.Name = "addVideoToolStripMenuItem";
            this.addVideoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addVideoToolStripMenuItem.Text = "Add Video";
            this.addVideoToolStripMenuItem.Click += new System.EventHandler(this.addVideoToolStripMenuItem_Click);
            // 
            // issueVideoToolStripMenuItem
            // 
            this.issueVideoToolStripMenuItem.Name = "issueVideoToolStripMenuItem";
            this.issueVideoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.issueVideoToolStripMenuItem.Text = "Issue Video";
            this.issueVideoToolStripMenuItem.Click += new System.EventHandler(this.issueVideoToolStripMenuItem_Click);
            // 
            // popularVideoToolStripMenuItem
            // 
            this.popularVideoToolStripMenuItem.Name = "popularVideoToolStripMenuItem";
            this.popularVideoToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.popularVideoToolStripMenuItem.Text = "Popular Video";
            this.popularVideoToolStripMenuItem.Click += new System.EventHandler(this.popularVideoToolStripMenuItem_Click);
            // 
            // popularCustomerToolStripMenuItem
            // 
            this.popularCustomerToolStripMenuItem.Name = "popularCustomerToolStripMenuItem";
            this.popularCustomerToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.popularCustomerToolStripMenuItem.Text = "Popular Customer";
            this.popularCustomerToolStripMenuItem.Click += new System.EventHandler(this.popularCustomerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // LblFooter
            // 
            this.LblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFooter.AutoSize = true;
            this.LblFooter.Location = new System.Drawing.Point(593, 638);
            this.LblFooter.Name = "LblFooter";
            this.LblFooter.Size = new System.Drawing.Size(238, 17);
            this.LblFooter.TabIndex = 10;
            this.LblFooter.Text = "Copyright © 2020 All Rights Reserve";
            this.LblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHeading
            // 
            this.LblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHeading.AutoSize = true;
            this.LblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeading.Location = new System.Drawing.Point(584, 80);
            this.LblHeading.Name = "LblHeading";
            this.LblHeading.Size = new System.Drawing.Size(187, 38);
            this.LblHeading.TabIndex = 56;
            this.LblHeading.Text = "Issue Video";
            // 
            // IssuedateTimePicker1
            // 
            this.IssuedateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IssuedateTimePicker1.Location = new System.Drawing.Point(505, 297);
            this.IssuedateTimePicker1.Name = "IssuedateTimePicker1";
            this.IssuedateTimePicker1.Size = new System.Drawing.Size(462, 22);
            this.IssuedateTimePicker1.TabIndex = 55;
            // 
            // comboVideo
            // 
            this.comboVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVideo.FormattingEnabled = true;
            this.comboVideo.Location = new System.Drawing.Point(505, 229);
            this.comboVideo.Name = "comboVideo";
            this.comboVideo.Size = new System.Drawing.Size(459, 24);
            this.comboVideo.TabIndex = 54;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(505, 360);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(0, 17);
            this.LblId.TabIndex = 51;
            this.LblId.Visible = false;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.AutoSize = true;
            this.Cancel.Location = new System.Drawing.Point(856, 404);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(108, 43);
            this.Cancel.TabIndex = 50;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Update
            // 
            this.Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Update.AutoSize = true;
            this.Update.Location = new System.Drawing.Point(681, 404);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(108, 43);
            this.Update.TabIndex = 49;
            this.Update.Text = "Return Video";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.AutoSize = true;
            this.Save.Location = new System.Drawing.Point(505, 404);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(108, 43);
            this.Save.TabIndex = 48;
            this.Save.Text = "Issue Video";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // LblIssueDate
            // 
            this.LblIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblIssueDate.AutoSize = true;
            this.LblIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIssueDate.Location = new System.Drawing.Point(282, 295);
            this.LblIssueDate.Name = "LblIssueDate";
            this.LblIssueDate.Size = new System.Drawing.Size(105, 25);
            this.LblIssueDate.TabIndex = 45;
            this.LblIssueDate.Text = "Issue Date";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Video";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Customer";
            // 
            // comboCustomer
            // 
            this.comboCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Location = new System.Drawing.Point(505, 161);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(459, 24);
            this.comboCustomer.TabIndex = 57;
            // 
            // LblIssuehid
            // 
            this.LblIssuehid.AutoSize = true;
            this.LblIssuehid.Location = new System.Drawing.Point(575, 359);
            this.LblIssuehid.Name = "LblIssuehid";
            this.LblIssuehid.Size = new System.Drawing.Size(0, 17);
            this.LblIssuehid.TabIndex = 58;
            this.LblIssuehid.Visible = false;
            // 
            // issuedVideoListToolStripMenuItem
            // 
            this.issuedVideoListToolStripMenuItem.Name = "issuedVideoListToolStripMenuItem";
            this.issuedVideoListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.issuedVideoListToolStripMenuItem.Text = "Issued Video List";
            this.issuedVideoListToolStripMenuItem.Click += new System.EventHandler(this.issuedVideoListToolStripMenuItem_Click);
            // 
            // IssueVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 664);
            this.Controls.Add(this.LblIssuehid);
            this.Controls.Add(this.comboCustomer);
            this.Controls.Add(this.LblHeading);
            this.Controls.Add(this.IssuedateTimePicker1);
            this.Controls.Add(this.comboVideo);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.LblIssueDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblFooter);
            this.Controls.Add(this.menuStrip1);
            this.Name = "IssueVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Video";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popularVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popularCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label LblFooter;
        private System.Windows.Forms.Label LblHeading;
        private System.Windows.Forms.DateTimePicker IssuedateTimePicker1;
        private System.Windows.Forms.ComboBox comboVideo;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label LblIssueDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.Label LblIssuehid;
        private System.Windows.Forms.ToolStripMenuItem issuedVideoListToolStripMenuItem;
    }
}