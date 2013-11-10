//-----------------------------------------------------------------------
// <copyright file="FrmLogon.cs" company="Jorisv83">
//     Copyright (c) Jorisv83. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BuxferForm
{
    using System;
    using System.Windows.Forms;
    using BuxferLib;

    /// <summary>
    /// Windows form to allow the user to logon to Buxfer
    /// </summary>
    public partial class FrmLogon : Form
    {
        /// <summary>
        /// Private variable to store our main Buxfer instance
        /// </summary>
        private Buxfer buxfer;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmLogon" /> class
        /// </summary>
        public FrmLogon()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Form is loaded
        /// </summary>
        /// <param name="sender">THe object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void FrmLogon_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username != string.Empty)
            {
                this.txtUsername.Text = Properties.Settings.Default.username;
                this.txtPassword.Text = Properties.Settings.Default.password;
                this.chkRememberMe.Checked = true;
            }
        }

        /// <summary>
        /// Button logon is clicked
        /// </summary>
        /// <param name="sender">THe object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void BtnLogOn_Click(object sender, EventArgs e)
        {
            if (!chkRememberMe.Checked)
            {
                Properties.Settings.Default.username = string.Empty;
                Properties.Settings.Default.password = string.Empty;
                Properties.Settings.Default.Save();
            }

            if (!string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtUsername.Text))
            {
                this.buxfer = new Buxfer(this.txtUsername.Text, this.txtPassword.Text);

                if (this.buxfer.LogOnOk)
                {
                    if (chkRememberMe.Checked)
                    {
                        Properties.Settings.Default.username = this.txtUsername.Text;
                        Properties.Settings.Default.password = this.txtPassword.Text;
                        Properties.Settings.Default.Save();
                    }

                    this.Hide();
                    FrmMain mainForm = new FrmMain(this, this.buxfer);
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

        /// <summary>
        /// Form logon is closing
        /// </summary>
        /// <param name="sender">THe object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void FrmLogon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!chkRememberMe.Checked)
            {
                Properties.Settings.Default.username = string.Empty;
                Properties.Settings.Default.password = string.Empty;
                Properties.Settings.Default.Save();
            }
        }
    }
}
