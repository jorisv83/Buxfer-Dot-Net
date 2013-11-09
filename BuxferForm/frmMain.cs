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
    public partial class frmMain : Form
    {
        private frmLogon logonForm;
        private Buxfer buxfer;

        public frmMain(frmLogon logonForm, Buxfer buxfer)
        {
            InitializeComponent();
            this.logonForm = logonForm;
            this.buxfer = buxfer;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.logonForm.Close();
        }
    }
}
