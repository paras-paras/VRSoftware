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
    public partial class AddVideo : Form
    {
        VRSData _VRSData = new VRSData();
       
        public AddVideo()
        {
            InitializeComponent();           
            Update.Enabled = false;
            Save.Enabled = true;
            txtCost.Text = "5";
        }
        public AddVideo(int VideoId)
        {
            InitializeComponent();           
            BindVideo(VideoId);
            Update.Enabled = true;
            Save.Enabled = false;            
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

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Title is required");
                txtTitle.Focus();
            }
            else if (string.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("Description is required");
                txtDesc.Focus();
            }
            else if (string.IsNullOrEmpty(txtGenre.Text))
            {
                MessageBox.Show("Genre is required");
                txtGenre.Focus();
            }
            else
            {
                VideoModel videoModel = new VideoModel();
                videoModel.Title = txtTitle.Text;
                videoModel.Description = txtDesc.Text;
                videoModel.Date = DateTime.Now;
                videoModel.Cost = Convert.ToDecimal(txtCost.Text);
                videoModel.Genre = txtGenre.Text;
                videoModel.ReleaseDate = dateTimePicker1.Value;
                _VRSData.AddVideo(videoModel);
                ClearTexbox();
                MessageBox.Show("Video is saved successfully!");

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            double year = (DateTime.Now - dateTimePicker1.Value).Days / 365;
            if (year>=5)
            {
                txtCost.Text = "2";
            }
            else
            {
                txtCost.Text = "5";
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ClearTexbox();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Title is required");
                txtTitle.Focus();
            }
            else if (string.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("Description is required");
                txtDesc.Focus();
            }
            else if (string.IsNullOrEmpty(txtGenre.Text))
            {
                MessageBox.Show("Genre is required");
                txtGenre.Focus();
            }
            else if (!string.IsNullOrEmpty(LblId.Text) && Convert.ToInt32(LblId.Text) > 0)
            {
                VideoModel videoModel = new VideoModel();
                videoModel.Title = txtTitle.Text;
                videoModel.Description = txtDesc.Text;
                videoModel.Date = DateTime.Now;
                videoModel.Cost = Convert.ToDecimal(txtCost.Text);
                videoModel.Genre = txtGenre.Text.Trim(); ;               
                videoModel.Id = Convert.ToInt32(LblId.Text);
                videoModel.ReleaseDate = dateTimePicker1.Value;
                _VRSData.UpdateVideo(videoModel);
                ClearTexbox();
                Update.Enabled = false;
                Save.Enabled = true;
                MessageBox.Show("Video is updated successfully!");

            }
        }

        public void ClearTexbox()
        {
            txtTitle.Text = "";
            txtDesc.Text = "";
            txtCost.Text = "";            
            txtGenre.Text = "";            
            dateTimePicker1.Value = DateTime.Now;
            LblId.Text = "";
            Update.Enabled = false;
            Save.Enabled = true;
            lblHeading.Text = "Add Video";
        }
                     
        public void BindVideo(int VideoId)
        {
            DataTable dt = _VRSData.GetVideoById(VideoId);
            if (dt != null && dt.Rows.Count > 0)
            {
                LblId.Text = dt.Rows[0]["Id"].ToString();
                txtTitle.Text = dt.Rows[0]["Title"].ToString();
                txtDesc.Text = dt.Rows[0]["Description"].ToString();
                txtCost.Text = dt.Rows[0]["Cost"].ToString();
                string genre = dt.Rows[0]["Genre"].ToString();
                txtGenre.Text = genre;
                dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["ReleaseDate"]);
                Update.Enabled = true;
                Save.Enabled = false;
                lblHeading.Text = "Update Video";
            }
        }

      
    }
}
