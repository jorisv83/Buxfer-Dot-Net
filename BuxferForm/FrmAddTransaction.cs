//-----------------------------------------------------------------------
// <copyright file="FrmAddTransaction.cs" company="Jorisv83">
//     Copyright (c) Jorisv83. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BuxferForm
{
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

    public partial class FrmAddTransaction : Form
    {
        private Buxfer buxfer;
        private Account account;

        public FrmAddTransaction(Buxfer buxfer, Account account)
        {
            InitializeComponent();
            this.buxfer = buxfer;
            this.account = account;
        } 
        
        private void FrmAddTransaction_Load(object sender, EventArgs e)
        {
            this.lblAccount.Text = string.Concat(this.account.Name, " (", this.account.Id, ")");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.AccountId = this.account.Name;
            transaction.Amount = double.Parse(this.nudAmmount.Value.ToString(Tools.RetrieveCultureInfoFrench()));
            transaction.Date = this.dtpDateOfTransaction.Value.ToString("MM/dd/yyyy");
            transaction.Description = this.txtDescription.Text;
            transaction.Tags = this.txtTags.Text;

            this.buxfer.AddTransaction(transaction);
        }

       
    }
}
