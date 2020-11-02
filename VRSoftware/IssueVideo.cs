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
    public partial class IssueVideo : Form
    {
        VRSData _VRSData = new VRSData();
        public IssueVideo()
        {
            InitializeComponent();
            Update.Enabled = false;
            Save.Enabled = true;
            LblHeading.Text = "Issue Video";
            BindCombobox();
        }
        public IssueVideo(int RentalId)
        {
            InitializeComponent();
            Update.Enabled = true;
            Save.Enabled = false;
            LblHeading.Text = "Return Video";
            BindCombobox();
            BindIssuedVideo(RentalId);
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

        public void BindCombobox()
        {
            DataTable dt = _VRSData.GetAllCustomerList();

            DataRow row = dt.NewRow();
            row[0] = 0;
            row[6] = "Select Customer";
            dt.Rows.InsertAt(row, 0);

            comboCustomer.DataSource = dt;
            comboCustomer.ValueMember = "Id";
            comboCustomer.DisplayMember = "FullName";


            DataTable dtVideo = _VRSData.GetAllVideoList();
            DataRow rowVideo = dtVideo.NewRow();
            rowVideo[0] = 0;
            rowVideo[1] = "Select Video";
            dtVideo.Rows.InsertAt(rowVideo, 0);

            comboVideo.DataSource = dtVideo;
            comboVideo.ValueMember = "Id";
            comboVideo.DisplayMember = "Title";
        }

        public void BindIssuedVideo(int RentalId)
        {
            DataTable dt = _VRSData.GetRentalById(RentalId);
            if (dt!=null && dt.Rows.Count>0)
            {
                comboCustomer.SelectedValue = Convert.ToInt32(dt.Rows[0]["CustomerId"]);
                comboVideo.SelectedValue = Convert.ToInt32(dt.Rows[0]["VideoId"]);
                LblId.Text = Convert.ToString(dt.Rows[0]["Id"]);
                LblIssuehid.Text = Convert.ToString(dt.Rows[0]["IssuedDate"]);
                LblIssueDate.Text = "Returned Date";
            }
            
        }

        public void ClearTexbox()
        {
            comboCustomer.SelectedIndex = 0;
            comboVideo.SelectedIndex = 0;
            LblId.Text = "";
            LblIssuehid.Text = "";
            Update.Enabled = false;
            Save.Enabled = true;
            LblHeading.Text = "Issue Video";
            LblIssueDate.Text = "Issue Date";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (comboCustomer.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select customer");
                comboCustomer.Focus();
            }
            else if (comboVideo.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select video");
                comboVideo.Focus();
            }
            else
            {
                RentalModel rentalModel = new RentalModel();
                rentalModel.CustomerId = Convert.ToInt32(comboCustomer.SelectedValue);
                rentalModel.VideoId = Convert.ToInt32(comboVideo.SelectedValue);
                rentalModel.IsReturned = false;
                rentalModel.IssuedDate = IssuedateTimePicker1.Value;
                rentalModel.Date = DateTime.Now;
                rentalModel.Id = 0;
                rentalModel.ReturnedDate = null;
                _VRSData.AddRental(rentalModel);

                ClearTexbox();
                MessageBox.Show("Video is rented successfully!");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ClearTexbox();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (comboCustomer.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select customer");
                comboCustomer.Focus();
            }
            else if (comboVideo.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select video");
                comboVideo.Focus();
            }
            else if (!string.IsNullOrEmpty(LblId.Text) && Convert.ToInt32(LblId.Text) > 0)
            {
                RentalModel rentalModel = new RentalModel();
                rentalModel.CustomerId = Convert.ToInt32(comboCustomer.SelectedValue);
                rentalModel.VideoId = Convert.ToInt32(comboVideo.SelectedValue);
                rentalModel.IsReturned = true;
                rentalModel.IssuedDate =Convert.ToDateTime(LblIssuehid.Text) ;
                rentalModel.Date = DateTime.Now;
                rentalModel.Id = Convert.ToInt32(LblId.Text);
                rentalModel.ReturnedDate = IssuedateTimePicker1.Value;
                if (rentalModel.IssuedDate> rentalModel.ReturnedDate.Value)
                {
                    MessageBox.Show("Retrun date can't be before issued date");
                }
                else
                {
                    _VRSData.UpdateRental(rentalModel);
                    ClearTexbox();
                    DataTable dt = _VRSData.GetVideoById(rentalModel.VideoId);
                    string Message = "Video is rented successfully!";
                    if (dt!=null)
                    {
                        decimal Videocost = Convert.ToDecimal(dt.Rows[0]["Cost"]);
                        int TotalDay = (rentalModel.ReturnedDate.Value - rentalModel.IssuedDate).Days;
                        decimal TotalAmount = Videocost;
                        if (TotalDay > 1)
                        { TotalAmount = Videocost * TotalDay; }


                        Message += "\nTotal Amount: " + TotalAmount;
                    }
                    MessageBox.Show(Message);
                }
                
            }
        }

        
    }
}
