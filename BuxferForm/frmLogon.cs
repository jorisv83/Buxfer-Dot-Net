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
    public partial class frmLogon : Form
    {
        public frmLogon()
        {
            InitializeComponent();
        }
        private void frmLogon_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain mainForm = new frmMain(this);
            mainForm.Show();
        }

        
    }
}
