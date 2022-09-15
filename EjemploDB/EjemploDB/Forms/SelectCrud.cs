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
    public partial class SelectCrud : Form
    {
        public SelectCrud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chbPeople.Checked)
            {

                this.Hide();
                var people = new People();
                people.FormClosed += (s, args) => this.Close();
                people.Show();
            }

            if (chbClient.Checked)
            {

                this.Hide();
                var client = new Client();
                client.FormClosed += (s, args) => this.Close();
                client.Show();
            }

            if (chbContact.Checked)
            {

                this.Hide();
                var contact = new Contact();
                contact.FormClosed += (s, args) => this.Close();
                contact.Show();
            }
        }

        private void chbPeople_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPeople.Checked == true)
            {
                chbClient.Enabled = false;
                chbContact.Enabled = false;
            }
            else
            {
                chbClient.Enabled = true;
                chbContact.Enabled = true;
            }
        }

        private void chbClient_CheckedChanged(object sender, EventArgs e)
        {
            if (chbClient.Checked == true)
            {
                chbPeople.Enabled = false;
                chbContact.Enabled = false;
            }
            else
            {
                chbPeople.Enabled = true;
                chbContact.Enabled = true;
            }
        }

        private void chbContact_CheckedChanged(object sender, EventArgs e)
        {
            if (chbContact.Checked == true)
            {
                chbClient.Enabled = false;
                chbPeople.Enabled = false;
            }
            else
            {
                chbClient.Enabled = true;
                chbPeople.Enabled = true;
            }
        }
    }
}
