using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRSoftware.Model;
using VRSoftware.DBLayer;

namespace VRSoftware
{
    public partial class IssuedVideoList : Form
    {
        VRSData _VRSData = new VRSData();
        public IssuedVideoList()
        {
            InitializeComponent();
            BindGrid();
        }

        #region Menu Code
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            if (this.Text != dashboard.Text)
            {
                this.Hide();
                dashboard.Show();
            }
        }
        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            if (this.Text != addCustomer.Text)
            {
                this.Hide();
                addCustomer.Show();
            }
        }
        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerList customerList = new CustomerList();
            if (this.Text != customerList.Text)
            {
                this.Hide();
                customerList.Show();
            }
        }
        private void videoListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoList videoList = new VideoList();
            if (this.Text != videoList.Text)
            {
                this.Hide();
                videoList.Show();
            }
        }
        private void addVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVideo addVideo = new AddVideo();
            if (this.Text != addVideo.Text)
            {
                this.Hide();
                addVideo.Show();
            }
        }
        private void issueVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueVideo issueVideo = new IssueVideo();
            if (this.Text != issueVideo.Text)
            {
                this.Hide();
                issueVideo.Show();
            }
        }
        private void issuedVideoListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssuedVideoList issueVideoList = new IssuedVideoList();
            if (this.Text != issueVideoList.Text)
            {
                this.Hide();
                issueVideoList.Show();
            }
        }
        private void popularVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopularVideo popularVideo = new PopularVideo();
            if (this.Text != popularVideo.Text)
            {
                this.Hide();
                popularVideo.Show();
            }
        }
        private void popularCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopularCustomer popularCustomer = new PopularCustomer();
            if (this.Text != popularCustomer.Text)
            {
                this.Hide();
                popularCustomer.Show();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        public void BindGrid()
        {
            string CustomerName = txtCustomer.Text;
            string Title = txtVideo.Text;

            var Data = _VRSData.GetAllRentalRecordList(CustomerName, Title);
            gridIssuedVideoList.AutoGenerateColumns = false;
            gridIssuedVideoList.DataSource = Data;
        }

        private void gridIssuedVideoList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridIssuedVideoList.Columns[e.ColumnIndex].Name == "Return")
            {
                bool IsReturned = Convert.ToBoolean(gridIssuedVideoList.Rows[e.RowIndex].Cells[7].Value);
                if (IsReturned)
                {
                    MessageBox.Show("Video already returned!");
                }
                else
                {
                    int ReturnId = Convert.ToInt32(gridIssuedVideoList.Rows[e.RowIndex].Cells[0].Value);
                    if (ReturnId > 0)
                    {
                        IssueVideo issueVideo = new IssueVideo(ReturnId);
                        this.Close();
                        issueVideo.Show();
                    }
                }
                
              
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindGrid();            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomer.Text = "";
            txtVideo.Text = "";
            BindGrid();
        }
    }
}
