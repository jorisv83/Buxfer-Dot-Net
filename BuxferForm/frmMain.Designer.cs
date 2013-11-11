namespace BuxferForm
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAccounts = new System.Windows.Forms.ComboBox();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactions.Location = new System.Drawing.Point(3, 16);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.Size = new System.Drawing.Size(845, 425);
            this.dgvTransactions.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvTransactions);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 444);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transactions";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAddTransaction);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbAccounts);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 54);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Accounts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select an account";
            // 
            // cbAccounts
            // 
            this.cbAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccounts.FormattingEnabled = true;
            this.cbAccounts.Location = new System.Drawing.Point(107, 23);
            this.cbAccounts.Name = "cbAccounts";
            this.cbAccounts.Size = new System.Drawing.Size(288, 21);
            this.cbAccounts.TabIndex = 0;
            this.cbAccounts.SelectedIndexChanged += new System.EventHandler(this.CbAccounts_SelectedIndexChanged);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(426, 21);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(139, 23);
            this.btnAddTransaction.TabIndex = 2;
            this.btnAddTransaction.Text = "Add new transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.BtnAddTransaction_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buxfer main screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAccounts;
        private System.Windows.Forms.Button btnAddTransaction;
    }
}