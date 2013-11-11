namespace BuxferForm
{
    partial class FrmAddTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddTransaction));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDateOfTransaction = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudAmmount = new System.Windows.Forms.NumericUpDown();
            this.lblAccount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblAccount);
            this.groupBox1.Controls.Add(this.nudAmmount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTags);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpDateOfTransaction);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(324, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(243, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dtpDateOfTransaction
            // 
            this.dtpDateOfTransaction.Location = new System.Drawing.Point(91, 50);
            this.dtpDateOfTransaction.Name = "dtpDateOfTransaction";
            this.dtpDateOfTransaction.Size = new System.Drawing.Size(280, 20);
            this.dtpDateOfTransaction.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(91, 76);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(280, 21);
            this.cbStatus.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tags";
            // 
            // txtTags
            // 
            this.txtTags.Location = new System.Drawing.Point(91, 103);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(280, 20);
            this.txtTags.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(91, 129);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(280, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ammount";
            // 
            // nudAmmount
            // 
            this.nudAmmount.Location = new System.Drawing.Point(91, 155);
            this.nudAmmount.Name = "nudAmmount";
            this.nudAmmount.Size = new System.Drawing.Size(280, 20);
            this.nudAmmount.TabIndex = 9;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(88, 31);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(64, 13);
            this.lblAccount.TabIndex = 10;
            this.lblAccount.Text = "...account...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Account";
            // 
            // FrmAddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 259);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddTransaction";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a transaction to Buxfer";
            this.Load += new System.EventHandler(this.FrmAddTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.NumericUpDown nudAmmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateOfTransaction;
    }
}