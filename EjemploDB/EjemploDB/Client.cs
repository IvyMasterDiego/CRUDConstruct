using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            GetClient();
        }

        private void GetClient()
        {
            var client = (from a in db.ClientTypes
                          select new
                          {
                              a.Id,
                              FullName = a.Name,
                              a.Enabled,
                              a.CreatedDate,
                              a.Description
                          }).ToList();
            dataGridView1.DataSource = client;
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            btnadd.Enabled = true;
            btnsave.Enabled = false;
            btnsave.ForeColor = Color.Green;
            btncancel.Enabled = true;
        }

        private void SaveForm()
        {
            var cliente = new Person();
            cliente.ClientType.Id = Convert.ToInt32(Guid.NewGuid().ToString());
            cliente.ClientType.Name = txtname.Text;
            cliente.ClientType.Description = txtdesc.Text;
            cliente.ClientType.CreatedDate = Convert.ToDateTime(txtdate.Text);

            db.ClientTypes.Add(cliente.ClientType);
            var clientsaved = db.SaveChanges() > 0;

            if (clientsaved)
            {
                var user = new User();
                user.Id = Guid.NewGuid().ToString();
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.LicenseTypeId = Convert.ToInt32(cbLicenseType.SelectedValue);
                // user.cl = cliente.Id;
                user.CreatedDate = DateTime.Now;

                db.Users.Add(user);
                var userSaved = db.SaveChanges() > 0;

                if (userSaved)
                {
                    MessageBox.Show("The Client has been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetClient();
                    DefaultControls();

                    btnadd.Enabled = true;
                    btnsave.Enabled = false;
                    btnsave.ForeColor = Color.Black;
                    btncancel.Enabled = false;
                }
            }
        }

        private void DefaultControls()
        {
            txtdate.Text = string.Empty;
            txtdesc.Text = string.Empty;
            txtname.Text = string.Empty;
        }

        private bool ValidateForm()
        {
            msg = new List<string>();
            lblPassword.Visible = false;
            lblUsername.Visible = false;
            lblname.Visible = false;
            lbldesc.Visible = false;
            lbldate.Visible = false;

            bool result = true;
            if (string.IsNullOrEmpty(txtname.Text))
            {
                msg.Add("The field (Name) is required");
                lblname.Visible = true;
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
                MessageBox.Show(errors, "Errors", MessageBoxButtons.OK);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            GetClient();
            DefaultControls();
            btnadd.Enabled = false;
            btnsave.Enabled = false;
            btnsave.ForeColor = Color.Black;
            btncancel.Enabled = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            ClientId = String.Empty;
            var test = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();

            if (!string.IsNullOrEmpty(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()))
            {
                ClientId = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
                btnupdate.Visible = true;
                btndelete.Visible = true;
            }
            else
            {
                btndelete.Visible = false;
                btnupdate.Visible = false;
            }
        }

        private void GetClientById(string clientId)
        {
            DefaultControls();

            var client = db.ClientTypes.FirstOrDefault(x => x.Id == Convert.ToInt32(clientId));

            if (client != null)
            {
                txtname.Text = client.Name;
                txtdesc.Text = client.Description;
                txtdate.Text = client.CreatedDate.ToString();

                var user = db.Users.FirstOrDefault(x => x.PeopleId == clientId);
                if (user != null)
                {
                    txtUsername.Text = user.Username;
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            GetClientById(ClientId);
            btnadd.Enabled = false;
            btnsave.Enabled = true;
            btncancel.Enabled = true;
            btnupdate.Visible = false;
            btndelete.Visible = false;
        }
    }
}
