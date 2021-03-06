﻿//-----------------------------------------------------------------------
// <copyright file="FrmMain.cs" company="Jorisv83">
//     Copyright (c) Jorisv83. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BuxferForm
{
    using System;
    using System.Collections.ObjectModel;
    using System.Windows.Forms;
    using BuxferLib;

    /// <summary>
    /// The main form for this application
    /// </summary>
    public partial class FrmMain : Form
    {
        /// <summary>
        /// The instance of the logon form, used only to close after we close the main form
        /// </summary>
        private FrmLogOn logOnForm;

        /// <summary>
        /// Private variable to store our main Buxfer instance
        /// </summary>
        private Buxfer buxfer;

        /// <summary>
        /// Private variable that holds the current selected account
        /// </summary>
        private Account currentAccount;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmMain" /> class
        /// </summary>
        /// <param name="logOnForm">The logon form</param>
        /// <param name="buxfer">The Buxfer instance</param>
        public FrmMain(FrmLogOn logOnForm, Buxfer buxfer)
        {
            this.InitializeComponent();
            this.logOnForm = logOnForm;
            this.buxfer = buxfer;
        }

        /// <summary>
        /// Form is loaded
        /// </summary>
        /// <param name="sender">The object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.RefreshAll();
        }

        /// <summary>
        /// Closing event of the main form
        /// </summary>
        /// <param name="sender">The object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.logOnForm.Close();
        }

        /// <summary>
        /// Refresh the form, including accounts
        /// </summary>
        private void RefreshAll()
        {
            Collection<Account> accounts = this.buxfer.RetrieveAllAccounts();
            this.cbAccounts.DataSource = accounts;
            this.cbAccounts.DisplayMember = "Name";
            this.cbAccounts.ValueMember = "Id";

            if (accounts.Count > 0)
            {
                this.RefreshGrid(accounts[0].Id);
            }
        }

        /// <summary>
        /// Refresh only the grid, for a specific account
        /// </summary>
        /// <param name="accountId">The account to look up the transactions for</param>
        private void RefreshGrid(string accountId)
        {
            Collection<Transaction> transactions = this.buxfer.RetrieveAllTransactionsFromAccount(accountId);
            this.dgvTransactions.DataSource = transactions;
        }

        /// <summary>
        /// Event when an new account is selected from the drop down list
        /// </summary>
        /// <param name="sender">The object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void CbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccounts.SelectedValue is Account)
            {
                this.currentAccount = cbAccounts.SelectedValue as Account;
                this.RefreshGrid((cbAccounts.SelectedValue as Account).Id);
            }
            else if (cbAccounts.SelectedValue is string)
            {
                this.currentAccount = this.buxfer.RetrieveAccount(cbAccounts.SelectedValue.ToString());
                this.RefreshGrid(cbAccounts.SelectedValue.ToString());
            }
        }

        /// <summary>
        /// Open a new add transaction form
        /// </summary>
        /// <param name="sender">The object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void BtnAddTransaction_Click(object sender, EventArgs e)
        {
            FrmAddTransaction frmAddTransaction = new FrmAddTransaction(this.buxfer, this.currentAccount);
            frmAddTransaction.ShowDialog();
        }
    }
}
