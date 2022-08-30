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
    public partial class People : Form
    {
        INTEC_AGU_OCT22Entities db = new INTEC_AGU_OCT22Entities();
        List<string> msg = new List<string>();
        string PeopleId = string.Empty;
        public People()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetClientTypes();
            GetContactTypes();
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
            cbContactType.ValueMember = "Id";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            panelFrom.Enabled = true;
            btnadd.Enabled = false;
            btnsave.Enabled = true;
            btnsave.ForeColor = Color.Green;
            btncancel.Enabled = true;
        }

        private void SaveForm()
        {
            var people = new Person();
            people.Id = Guid.NewGuid().ToString();
            people.FirstName = txtFristname.Text;
            people.MiddleName = txtMiddleName.Text;
            people.LastName = txtLastname.Text;
            people.ClientTypeId = Convert.ToInt32(cbClientType.SelectedValue);

            if (cbContactType.SelectedIndex != 0)
            {
                people.ContactTypeId = Convert.ToInt32(cbContactType.SelectedValue);
            }

            people.SupportStaff = chkStaf.Checked;
            people.PhoneNumber = txtphonenumber.Text;
            people.EmailAddress = txtemail.Text;
            people.Enabled = true;
            people.CreatedDate = DateTime.Now;

            db.People.Add(people);
            var peopleSaved = db.SaveChanges() > 0;
            if (peopleSaved)
            {
                var user = new User();
                user.Id = Guid.NewGuid().ToString();
                user.Username = txtusername.Text;
                user.Password = txtpassword.Text;
                user.LicenseTypeId = Convert.ToInt32(cblicense.SelectedValue);
                user.PeopleId = people.Id;
                user.Enabled = true;
                user.CreatedDate = DateTime.Now;

                db.Users.Add(user);
                var userSaved = db.SaveChanges() > 0;

                if (userSaved)
                {
                    MessageBox.Show("The People has been added");

                    GetPeople();
                    DefaultCOntrols();

                    panelFrom.Enabled = false;
                    btnadd.Enabled = true;
                    btnsave.Enabled = false;
                    btnsave.ForeColor = Color.Black;
                    btncancel.Enabled = false;
                }
            }

        }

        private void DefaultCOntrols()
        {
            txtFristname.Text = string.Empty;
            txtMiddleName.Text = string.Empty;
            txtLastname.Text = string.Empty;
            cbClientType.SelectedIndex = 0;
            cbContactType.SelectedIndex = 0;
            chkStaf.Checked = false;
            chkStaf.Text = "NO";
            txtphonenumber.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtCreatedDate.Text = string.Empty;
            txtusername.Text = string.Empty;
            txtpassword.Text = string.Empty;
            cblicense.SelectedIndex = 0;
        }

        private bool ValidateForm()
        {
            msg = new List<string>();
            lblfristname.Visible = false;
            lbllastname.Visible = false;
            lblphonenumer.Visible = false;
            lblusername.Visible = false;
            lblpassword.Visible = false;

            bool result = true;


            if (string.IsNullOrEmpty(txtFristname.Text))
            {
                msg.Add("The field (First Name) is required.");
                lblfristname.Visible = true;
                result = false;
            }

            if (string.IsNullOrEmpty(txtLastname.Text))
            {
                msg.Add("The field (Last Name) is required.");
                lbllastname.Visible = true;
                result = false;
            }

            if (cbClientType.SelectedIndex == 0)
            {
                msg.Add("The field (Client Type) is required.");
                result = false;
            }

            if (string.IsNullOrEmpty(txtphonenumber.Text))
            {
                msg.Add("The field (Phone Number) is required.");
                lblphonenumer.Visible = true;
                result = false;
            }

            if (string.IsNullOrEmpty(txtusername.Text))
            {
                msg.Add("The field (User Name) is required.");
                lblusername.Visible = true;
                result = false;
            }

            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                msg.Add("The field (Password) is required.");
                lblpassword.Visible = true;
                result = false;
            }

            return result;
        }

        private void btnsave_Click(object sender, EventArgs e)
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            GetPeople();
            DefaultCOntrols();
            panelFrom.Enabled = false;
            btnadd.Enabled = true;
            btnsave.Enabled = false;
            btnsave.ForeColor = Color.Black;
            btncancel.Enabled = false;
        }

        private void GetPeople()
        {
            var people = (from a in db.People
                          select new { a.Id, FullName = a.FirstName + " " + a.LastName, a.PhoneNumber, a.EmailAddress, a.Enabled, a.CreatedDate }).ToList();

            dgvPeople.DataSource = people;
            dgvPeople.Columns[0].Visible = false;
        }

        private void dgvPeople_Click(object sender, EventArgs e)
        {
            PeopleId = String.Empty;

            if (!string.IsNullOrEmpty(dgvPeople.SelectedRows[0].Cells["Id"].Value.ToString()))
            {
                PeopleId = dgvPeople.SelectedRows[0].Cells["Id"].Value.ToString();
                btnupdate.Visible = true;
                btndelete.Visible = true;
            }
            else
            {
                btnupdate.Visible = false;
                btndelete.Visible = false;
            }
        }

        private void GetPeopleById(string peopleId)
        {
            DefaultCOntrols();

            var people = db.People.FirstOrDefault(x => x.Id == peopleId);
            if (people != null)
            {
                txtFristname.Text = people.FirstName;
                txtMiddleName.Text = people.MiddleName;
                txtLastname.Text = people.LastName;
                chkStaf.Checked = people.SupportStaff;
                chkStaf.Text = people.SupportStaff ? "SI" : "NO";
                txtphonenumber.Text = people.PhoneNumber;
                txtemail.Text = people.EmailAddress;
                txtCreatedDate.Text = people.CreatedDate.ToString("MM/dd/yyyy");

                var user = db.Users.FirstOrDefault(x => x.PeopleId == peopleId);
                if (user != null)
                {
                    txtusername.Text = user.Username;
                }

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            GetPeopleById(PeopleId);

            panelFrom.Enabled = true;
            btnadd.Enabled = false;
            btnsave.Enabled = true;
            btncancel.Enabled = true;
            btnupdate.Visible = false;
            btndelete.Visible = false;
        }

        private void chkStaf_CheckedChanged(object sender, EventArgs e)
        {
            chkStaf.Text = chkStaf.Checked ? "SI" : "NO";
        }
    }
}

