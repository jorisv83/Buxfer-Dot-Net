using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuxferLib;

namespace BuxferForm
{
    public partial class frmLogon : Form
    {
        private Buxfer buxfer;

        public frmLogon()
        {
            InitializeComponent();
        }

        private void frmLogon_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username != string.Empty)
            {
                this.txtUsername.Text = Properties.Settings.Default.username;
                this.txtPassword.Text = Properties.Settings.Default.password;
                this.cbRememberMe.Checked = true;
            }
        }

        private void btnLogOn_Click(object sender, EventArgs e)
        {
            if (!cbRememberMe.Checked)
            {
                Properties.Settings.Default.username = string.Empty;
                Properties.Settings.Default.password = string.Empty;
                Properties.Settings.Default.Save();
            }

            if (!string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtUsername.Text))
            {
                this.buxfer = new Buxfer(this.txtUsername.Text, this.txtPassword.Text);

                if (this.buxfer.LogonOk)
                {
                    if (cbRememberMe.Checked)
                    {
                        Properties.Settings.Default.username = this.txtUsername.Text;
                        Properties.Settings.Default.password = this.txtPassword.Text;
                        Properties.Settings.Default.Save();
                    }

                    this.Hide();
                    frmMain mainForm = new frmMain(this, buxfer);
                    mainForm.Show();
                }
                else
                {
                    string message = "Logon failed";
                    if (this.buxfer.Messages.Count > 0)
                    {
                        message += Environment.NewLine;
                        message += this.buxfer.Messages[this.buxfer.Messages.Count - 1].Text;
                    }
                    MessageBox.Show(message, "Logon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string message = "Logon failed";

                message += Environment.NewLine;
                message += "Please provide a username and password";

                MessageBox.Show(message, "Logon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cbRememberMe.Checked)
            {
                Properties.Settings.Default.username = string.Empty;
                Properties.Settings.Default.password = string.Empty;
                Properties.Settings.Default.Save();
            }
        }


    }
}
