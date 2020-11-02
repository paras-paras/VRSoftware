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
    public partial class AddCustomer : Form
    {
        VRSData _VRSData = new VRSData();
        public AddCustomer()
        {
            InitializeComponent();
            Update.Enabled = false;
            Save.Enabled = true;
            lblHeading.Text = "Add Customer";
        }
        public AddCustomer(int CustomerId)
        {
            InitializeComponent();
            BindCustomer(CustomerId);
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

        public void BindCustomer(int CustomerId)
        {
            DataTable dt = _VRSData.GetCustomerById(CustomerId);
            if (dt != null && dt.Rows.Count > 0)
            {
                LblId.Text = dt.Rows[0]["Id"].ToString();
                txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();
                txtLastName.Text = dt.Rows[0]["LastName"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                Update.Enabled = true;
                Save.Enabled = false;
                lblHeading.Text = "Update Customer";
            }
        }
        public void ClearTexbox()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            LblId.Text = "";
            lblHeading.Text = "Add Customer";
            Update.Enabled = false;
            Save.Enabled = true;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("FirstName is required");
                txtFirstName.Focus();                
            }
            else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("LastName is required");
                txtLastName.Focus();
            }
           else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address is required");
                txtAddress.Focus();
            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone is required");
                txtPhone.Focus();
            }
            else
            {
                CustomerModel customerModel = new CustomerModel();
                customerModel.FirstName = txtFirstName.Text;
                customerModel.LastName = txtLastName.Text;
                customerModel.Address = txtAddress.Text;
                customerModel.Phone = txtPhone.Text;
                customerModel.Date = DateTime.Now;
                _VRSData.AddCustomer(customerModel);
                ClearTexbox();
                MessageBox.Show("Customer is saved successfully!");
               
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("FirstName is required");
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("LastName is required");
                txtLastName.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address is required");
                txtAddress.Focus();
            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone is required");
                txtPhone.Focus();
            }
            else if (!string.IsNullOrEmpty(LblId.Text) && Convert.ToInt32(LblId.Text) > 0)
            {
                CustomerModel customerModel = new CustomerModel();
                customerModel.FirstName = txtFirstName.Text;
                customerModel.LastName = txtLastName.Text;
                customerModel.Address = txtAddress.Text;
                customerModel.Phone = txtPhone.Text;                
                customerModel.Date = DateTime.Now;                
                customerModel.Id = Convert.ToInt32(LblId.Text);                
                _VRSData.UpdateCustomer(customerModel);
                ClearTexbox();
                Update.Enabled = false;
                Save.Enabled = true;
                MessageBox.Show("Customer is updated successfully!");

            }            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ClearTexbox();
        }

        
    }
}
