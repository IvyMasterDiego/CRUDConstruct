using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDB
{
    public partial class Client : Form
    {
        INTEC_AGU_OCT22Entities db = new INTEC_AGU_OCT22Entities();
        List<string> msg = new List<string>();
        string ClientId = string.Empty;

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("F");
            GetClientTypes();
            GetContactTypes();
            GetPermissions();
            GetRestrictions();
            GetPeoples();
        }

        private void GetPeoples()
        {
            var client = (from a in db.People
                           select new
                           {
                               a.Id,
                               FullName = a.FirstName + " " + a.LastName,
                               a.PhoneNumber,
                               a.EmailAddress,
                               a.Enabled,
                               a.CreatedDate
                           }).ToList();

            dgvClient.DataSource = client;
            dgvClient.Columns[0].Visible = false;
        }

        private void GetRestrictions()
        {
            var restrictions = db.Restrictions.ToList();
            foreach(var item in restrictions)
            {
                cblRestrictions.Items.Add(item.Name);
            }
        }

        private void GetPermissions()
        {
            var permissions = db.Permissions.ToList();
            foreach (var item in permissions)
            {
                cblPermissions.Items.Add(item.Name);
            }
        }

        private void GetClientTypes()
        {
            var clientTypes = db.ClientTypes.ToList();
            cbClientType.DataSource = clientTypes;
            cbClientType.DisplayMember = "Name";
            cbClientType.ValueMember = "Id";
        }

        private void GetContactTypes()
        {
            var contactTypes = db.ContactTypes.ToList();
            cbContactType.DataSource = contactTypes;
            cbContactType.DisplayMember = "Name";
            cbContactType.ValueMember="Id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlForm.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnSave.ForeColor = Color.Green;
            btnCancel.Enabled = true;
        }

        private void SaveForm()
        {
            var Client = new Person();
            Client.Id = Guid.NewGuid().ToString();
            Client.FirstName = txtFirstName.Text;
            Client.MiddleName = txtMiddleName.Text;
            Client.LastName = txtLastName.Text;
            Client.ClientTypeId = Convert.ToInt32(cbClientType.SelectedValue);

            if (cbContactType.SelectedIndex != 0)
            {
                Client.ContactTypeId = Convert.ToInt32(cbContactType.SelectedValue);
            }

            Client.SupportStaff = chkSupportStaff.Checked;
            Client.PhoneNumber = txtPhoneNumber.Text;
            Client.EmailAddress = txtEmailAddress.Text;
            Client.Enabled = true;
            Client.CreatedDate = DateTime.Now;

            db.People.Add(Client);
            var peopleSaved = db.SaveChanges() > 0;

            if (peopleSaved)
            {
                var user = new User();
                user.Id = Guid.NewGuid().ToString();
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.LicenseTypeId = Convert.ToInt32(cbLicenseType.SelectedValue);
                user.PeopleId = Client.Id;
                user.Enabled = true;
                user.CreatedDate = DateTime.Now;

                db.Users.Add(user);
                var userSaved = db.SaveChanges() > 0;

                if (userSaved)
                {
                    MessageBox.Show("The people has been added.");

                    GetPeoples();
                    DefaultControls();

                    pnlForm.Enabled = false;
                    btnAdd.Enabled = true;
                    btnSave.Enabled = false;
                    btnSave.ForeColor = Color.Black;
                    btnCancel.Enabled = false;
                }
            }
        }

        private void DefaultControls()
        {
            txtFirstName.Text = string.Empty;
            txtMiddleName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            cbClientType.SelectedIndex = 0;
            cbContactType.SelectedIndex = 0;
            chkSupportStaff.Checked = false;
            chkSupportStaff.Text = "NO";
            txtPhoneNumber.Text = string.Empty;
            txtEmailAddress.Text = string.Empty;
            txtCreatedDate.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cbLicenseType.SelectedIndex = 0;
        }

        private bool ValidateForm()
        {
            msg = new List<string>();

            lblFirstName.Visible = false;
            lblLastName.Visible = false;
            lblPhoneNumber.Visible = false;
            lblUsername.Visible = false;
            lblPassword.Visible = false;

            bool result = true;

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                msg.Add("The field (First Name) is required.");
                lblFirstName.Visible = true;
                result = false;
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                msg.Add("The field (Last Name) is required.");
                lblLastName.Visible = true;
                result = false;
            }

            if (cbClientType.SelectedIndex == 0)
            {
                msg.Add("The field (Client Type) is required.");
                result = false;
            }

            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                msg.Add("The field (Phone Number) is required.");
                lblPhoneNumber.Visible = true;
                result = false;
            }

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                msg.Add("The field (User Name) is required.");
                lblUsername.Visible = true;
                result = false;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                msg.Add("The field (Password) is required.");
                lblPassword.Visible = true;
                result = false;
            }

            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveForm();
            }
            else
            {
                string errors = string.Empty;
                int errorIndex = 1;
                foreach (var item in msg)
                {
                    errors += $"{errorIndex}. - {item.ToString()}\n";
                    errorIndex++;
                }

                MessageBox.Show(errors, "ERRORS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GetPeoples();
            DefaultControls();

            pnlForm.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnSave.ForeColor = Color.Black;
            btnCancel.Enabled = false;
        }

        private void dgvClient_Click(object sender, EventArgs e)
        {
            ClientId = String.Empty;

            if (!string.IsNullOrEmpty(dgvClient.SelectedRows[0].Cells["Id"].Value.ToString()))
            {
                ClientId = dgvClient.SelectedRows[0].Cells["Id"].Value.ToString();
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void GetPeopleById(string clientId)
        {
            DefaultControls();

            var people = db.People.FirstOrDefault(x => x.Id == clientId);
            if (people != null)
            {
                txtFirstName.Text = people.FirstName;
                txtMiddleName.Text = people.MiddleName;
                txtLastName.Text = people.LastName;
                chkSupportStaff.Checked = people.SupportStaff;
                chkSupportStaff.Text = people.SupportStaff ? "SI" : "NO";
                txtPhoneNumber.Text = people.PhoneNumber;
                txtEmailAddress.Text = people.EmailAddress;
                txtCreatedDate.Text = people.CreatedDate.ToString("MM/dd/yyyy");

                var user = db.Users.FirstOrDefault(x => x.PeopleId == clientId);
                if (user != null)
                {
                    txtUsername.Text = user.Username;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GetPeopleById(ClientId);

            pnlForm.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }
    }
}
