﻿namespace VRSoftware
{
    partial class PopularVideo
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
            this.issuedVideoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popularVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popularCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblFooter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridPopular = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuedCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPopular)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1395, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerListToolStripMenuItem,
            this.addCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
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
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.videoToolStripMenuItem.Text = "Video";
            // 
            // videoListToolStripMenuItem
            // 
            this.videoListToolStripMenuItem.Name = "videoListToolStripMenuItem";
            this.videoListToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.videoListToolStripMenuItem.Text = "Video List";
            this.videoListToolStripMenuItem.Click += new System.EventHandler(this.videoListToolStripMenuItem_Click);
            // 
            // addVideoToolStripMenuItem
            // 
            this.addVideoToolStripMenuItem.Name = "addVideoToolStripMenuItem";
            this.addVideoToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.addVideoToolStripMenuItem.Text = "Add Video";
            this.addVideoToolStripMenuItem.Click += new System.EventHandler(this.addVideoToolStripMenuItem_Click);
            // 
            // issueVideoToolStripMenuItem
            // 
            this.issueVideoToolStripMenuItem.Name = "issueVideoToolStripMenuItem";
            this.issueVideoToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.issueVideoToolStripMenuItem.Text = "Issue Video";
            this.issueVideoToolStripMenuItem.Click += new System.EventHandler(this.issueVideoToolStripMenuItem_Click);
            // 
            // issuedVideoListToolStripMenuItem
            // 
            this.issuedVideoListToolStripMenuItem.Name = "issuedVideoListToolStripMenuItem";
            this.issuedVideoListToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.issuedVideoListToolStripMenuItem.Text = "Issued Video List";
            this.issuedVideoListToolStripMenuItem.Click += new System.EventHandler(this.issuedVideoListToolStripMenuItem_Click);
            // 
            // popularVideoToolStripMenuItem
            // 
            this.popularVideoToolStripMenuItem.Name = "popularVideoToolStripMenuItem";
            this.popularVideoToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.popularVideoToolStripMenuItem.Text = "Popular Video";
            this.popularVideoToolStripMenuItem.Click += new System.EventHandler(this.popularVideoToolStripMenuItem_Click);
            // 
            // popularCustomerToolStripMenuItem
            // 
            this.popularCustomerToolStripMenuItem.Name = "popularCustomerToolStripMenuItem";
            this.popularCustomerToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.popularCustomerToolStripMenuItem.Text = "Popular Customer";
            this.popularCustomerToolStripMenuItem.Click += new System.EventHandler(this.popularCustomerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // LblFooter
            // 
            this.LblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFooter.AutoSize = true;
            this.LblFooter.Location = new System.Drawing.Point(584, 638);
            this.LblFooter.Name = "LblFooter";
            this.LblFooter.Size = new System.Drawing.Size(238, 17);
            this.LblFooter.TabIndex = 10;
            this.LblFooter.Text = "Copyright © 2020 All Rights Reserve";
            this.LblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Most Issued Video";
            // 
            // gridPopular
            // 
            this.gridPopular.AllowUserToAddRows = false;
            this.gridPopular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPopular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPopular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPopular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Description,
            this.Genre,
            this.IssuedCount});
            this.gridPopular.Location = new System.Drawing.Point(125, 130);
            this.gridPopular.Name = "gridPopular";
            this.gridPopular.RowHeadersWidth = 51;
            this.gridPopular.RowTemplate.Height = 24;
            this.gridPopular.Size = new System.Drawing.Size(1162, 484);
            this.gridPopular.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // IssuedCount
            // 
            this.IssuedCount.DataPropertyName = "IssuedCount";
            this.IssuedCount.HeaderText = "IssuedCount";
            this.IssuedCount.MinimumWidth = 6;
            this.IssuedCount.Name = "IssuedCount";
            this.IssuedCount.ReadOnly = true;
            // 
            // PopularVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 664);
            this.Controls.Add(this.gridPopular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblFooter);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PopularVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popular Video";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPopular)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem popularVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popularCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label LblFooter;
        private System.Windows.Forms.ToolStripMenuItem issueVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuedVideoListToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridPopular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuedCount;
    }
}