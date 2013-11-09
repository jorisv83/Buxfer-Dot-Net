using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuxferForm
{
    public partial class frmMain : Form
    {
        private frmLogon logonForm;

        public frmMain(frmLogon logonForm)
        {
            InitializeComponent();
            this.logonForm = logonForm;
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
