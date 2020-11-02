namespace VRSoftware
{
    partial class IssuedVideoList
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
            this.gridIssuedVideoList = new System.Windows.Forms.DataGridView();
            this.RentalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Video = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LblFooter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtVideo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIssuedVideoList)).BeginInit();
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
            // gridIssuedVideoList
            // 
            this.gridIssuedVideoList.AllowUserToAddRows = false;
            this.gridIssuedVideoList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridIssuedVideoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridIssuedVideoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIssuedVideoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentalId,
            this.FirstName,
            this.LastName,
            this.Video,
            this.Cost,
            this.IssuedDate,
            this.ReturnedDate,
            this.IsReturned,
            this.Return});
            this.gridIssuedVideoList.Location = new System.Drawing.Point(118, 193);
            this.gridIssuedVideoList.Name = "gridIssuedVideoList";
            this.gridIssuedVideoList.RowHeadersWidth = 51;
            this.gridIssuedVideoList.RowTemplate.Height = 24;
            this.gridIssuedVideoList.Size = new System.Drawing.Size(1145, 416);
            this.gridIssuedVideoList.TabIndex = 9;
            this.gridIssuedVideoList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridIssuedVideoList_CellContentClick);
            // 
            // RentalId
            // 
            this.RentalId.DataPropertyName = "RentalId";
            this.RentalId.HeaderText = "RentalId";
            this.RentalId.MinimumWidth = 6;
            this.RentalId.Name = "RentalId";
            this.RentalId.ReadOnly = true;
            this.RentalId.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Video
            // 
            this.Video.DataPropertyName = "Title";
            this.Video.HeaderText = "Video";
            this.Video.MinimumWidth = 6;
            this.Video.Name = "Video";
            this.Video.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // IssuedDate
            // 
            this.IssuedDate.DataPropertyName = "IssuedDate";
            this.IssuedDate.HeaderText = "IssuedDate";
            this.IssuedDate.MinimumWidth = 6;
            this.IssuedDate.Name = "IssuedDate";
            this.IssuedDate.ReadOnly = true;
            // 
            // ReturnedDate
            // 
            this.ReturnedDate.DataPropertyName = "ReturnedDate";
            this.ReturnedDate.HeaderText = "ReturnedDate";
            this.ReturnedDate.MinimumWidth = 6;
            this.ReturnedDate.Name = "ReturnedDate";
            this.ReturnedDate.ReadOnly = true;
            // 
            // IsReturned
            // 
            this.IsReturned.DataPropertyName = "IsReturned";
            this.IsReturned.HeaderText = "IsReturned";
            this.IsReturned.MinimumWidth = 6;
            this.IsReturned.Name = "IsReturned";
            this.IsReturned.ReadOnly = true;
            // 
            // Return
            // 
            this.Return.DataPropertyName = "RentalId";
            this.Return.HeaderText = "Return";
            this.Return.MinimumWidth = 6;
            this.Return.Name = "Return";
            this.Return.ReadOnly = true;
            this.Return.Text = "Return";
            this.Return.UseColumnTextForButtonValue = true;
            // 
            // LblFooter
            // 
            this.LblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFooter.AutoSize = true;
            this.LblFooter.Location = new System.Drawing.Point(598, 638);
            this.LblFooter.Name = "LblFooter";
            this.LblFooter.Size = new System.Drawing.Size(238, 17);
            this.LblFooter.TabIndex = 10;
            this.LblFooter.Text = "Copyright © 2020 All Rights Reserve";
            this.LblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Customer";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(543, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 38);
            this.label6.TabIndex = 42;
            this.label6.Text = "Issued Video List";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomer.Location = new System.Drawing.Point(234, 136);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(280, 22);
            this.txtCustomer.TabIndex = 43;
            // 
            // txtVideo
            // 
            this.txtVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVideo.Location = new System.Drawing.Point(662, 139);
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.Size = new System.Drawing.Size(280, 22);
            this.txtVideo.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(572, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Video";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(1026, 131);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 32);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(1152, 131);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 32);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // IssuedVideoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 664);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtVideo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblFooter);
            this.Controls.Add(this.gridIssuedVideoList);
            this.Controls.Add(this.menuStrip1);
            this.Name = "IssuedVideoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issued Video List";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIssuedVideoList)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem issuedVideoListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popularVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popularCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridIssuedVideoList;
        private System.Windows.Forms.Label LblFooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Video;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsReturned;
        private System.Windows.Forms.DataGridViewButtonColumn Return;
        private System.Windows.Forms.Button btnClear;
    }
}