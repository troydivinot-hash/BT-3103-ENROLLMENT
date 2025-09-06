namespace EventDriven.Project.UI
{
    partial class FormClient
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            grpClient = new GroupBox();
            lblBDate = new Label();
            dtpBirthdate = new DateTimePicker();
            txtGender = new ComboBox();
            label1 = new Label();
            lblPhone = new Label();
            txtMobileNumber = new MaskedTextBox();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtLastname = new TextBox();
            lblLname = new Label();
            txtFirstname = new TextBox();
            lblFname = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDel = new Button();
            btnRefresh = new Button();
            dgridView = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            btnPrint = new Button();
            grpAccount = new GroupBox();
            lblModified = new Label();
            label2 = new Label();
            txtBalance = new TextBox();
            lblAccountId = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            grpClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridView).BeginInit();
            grpAccount.SuspendLayout();
            SuspendLayout();
            // 
            // grpClient
            // 
            grpClient.Controls.Add(lblBDate);
            grpClient.Controls.Add(dtpBirthdate);
            grpClient.Controls.Add(txtGender);
            grpClient.Controls.Add(label1);
            grpClient.Controls.Add(lblPhone);
            grpClient.Controls.Add(txtMobileNumber);
            grpClient.Controls.Add(txtAddress);
            grpClient.Controls.Add(lblAddress);
            grpClient.Controls.Add(txtLastname);
            grpClient.Controls.Add(lblLname);
            grpClient.Controls.Add(txtFirstname);
            grpClient.Controls.Add(lblFname);
            grpClient.FlatStyle = FlatStyle.Flat;
            grpClient.Font = new Font("Segoe UI", 24F);
            grpClient.Location = new Point(12, 12);
            grpClient.Name = "grpClient";
            grpClient.Size = new Size(1001, 423);
            grpClient.TabIndex = 0;
            grpClient.TabStop = false;
            grpClient.Text = "Client Information";
            // 
            // lblBDate
            // 
            lblBDate.AutoSize = true;
            lblBDate.Font = new Font("Segoe UI", 24F);
            lblBDate.Location = new Point(482, 316);
            lblBDate.Name = "lblBDate";
            lblBDate.Size = new Size(152, 45);
            lblBDate.TabIndex = 11;
            lblBDate.Text = "BirthDate";
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Font = new Font("Segoe UI", 24F);
            dtpBirthdate.Location = new Point(482, 365);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(491, 50);
            dtpBirthdate.TabIndex = 10;
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Segoe UI", 24F);
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            txtGender.Location = new Point(296, 364);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(150, 53);
            txtGender.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(293, 316);
            label1.Name = "label1";
            label1.Size = new Size(124, 45);
            label1.TabIndex = 8;
            label1.Text = "Gender";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 24F);
            lblPhone.Location = new Point(0, 319);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(246, 45);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Mobile Number";
            // 
            // txtMobileNumber
            // 
            txtMobileNumber.Font = new Font("Segoe UI", 24F);
            txtMobileNumber.Location = new Point(6, 367);
            txtMobileNumber.Mask = "(999) 000-0000";
            txtMobileNumber.Name = "txtMobileNumber";
            txtMobileNumber.Size = new Size(256, 50);
            txtMobileNumber.TabIndex = 6;
            txtMobileNumber.KeyPress += txtMobileNumber_KeyPress;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 24F);
            txtAddress.Location = new Point(15, 208);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(958, 96);
            txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 24F);
            lblAddress.Location = new Point(15, 160);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(135, 45);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Segoe UI", 24F);
            txtLastname.Location = new Point(530, 96);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(443, 50);
            txtLastname.TabIndex = 3;
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Font = new Font("Segoe UI", 24F);
            lblLname.Location = new Point(530, 46);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(155, 45);
            lblLname.TabIndex = 2;
            lblLname.Text = "Lastname";
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Segoe UI", 24F);
            txtFirstname.Location = new Point(15, 96);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(471, 50);
            txtFirstname.TabIndex = 1;
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Font = new Font("Segoe UI", 24F);
            lblFname.Location = new Point(15, 46);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(159, 45);
            lblFname.TabIndex = 0;
            lblFname.Text = "Firstname";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 24F);
            btnAdd.Location = new Point(14, 457);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(219, 66);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 24F);
            btnUpdate.Location = new Point(239, 457);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(219, 66);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Segoe UI", 24F);
            btnDel.Location = new Point(938, 457);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(219, 66);
            btnDel.TabIndex = 3;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 24F);
            btnRefresh.Location = new Point(1163, 457);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(219, 66);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgridView
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridView.Location = new Point(12, 529);
            dgridView.Name = "dgridView";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridView.Size = new Size(1660, 230);
            dgridView.TabIndex = 5;
            dgridView.CellClick += dgridView_CellClick;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI", 24F);
            btnPrint.Location = new Point(1388, 457);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(219, 66);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "P&rint";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // grpAccount
            // 
            grpAccount.Controls.Add(lblModified);
            grpAccount.Controls.Add(label2);
            grpAccount.Controls.Add(txtBalance);
            grpAccount.Controls.Add(lblAccountId);
            grpAccount.FlatStyle = FlatStyle.Flat;
            grpAccount.Font = new Font("Segoe UI", 24F);
            grpAccount.Location = new Point(1029, 12);
            grpAccount.Name = "grpAccount";
            grpAccount.Size = new Size(840, 423);
            grpAccount.TabIndex = 12;
            grpAccount.TabStop = false;
            grpAccount.Text = "Account Information";
            // 
            // lblModified
            // 
            lblModified.AutoSize = true;
            lblModified.Font = new Font("Segoe UI", 24F);
            lblModified.Location = new Point(24, 306);
            lblModified.Name = "lblModified";
            lblModified.Size = new Size(0, 45);
            lblModified.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(24, 178);
            label2.Name = "label2";
            label2.Size = new Size(128, 45);
            label2.TabIndex = 4;
            label2.Text = "Balance";
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 24F);
            txtBalance.Location = new Point(24, 238);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(443, 50);
            txtBalance.TabIndex = 3;
            txtBalance.KeyPress += txtBalance_KeyPress;
            // 
            // lblAccountId
            // 
            lblAccountId.AutoSize = true;
            lblAccountId.Font = new Font("Segoe UI", 24F);
            lblAccountId.Location = new Point(15, 46);
            lblAccountId.Name = "lblAccountId";
            lblAccountId.Size = new Size(174, 45);
            lblAccountId.TabIndex = 0;
            lblAccountId.Text = "Account Id";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 24F);
            btnSave.Location = new Point(464, 457);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(219, 66);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 24F);
            btnCancel.Location = new Point(689, 457);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(219, 66);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 771);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grpAccount);
            Controls.Add(btnPrint);
            Controls.Add(dgridView);
            Controls.Add(btnRefresh);
            Controls.Add(btnDel);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(grpClient);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormClient";
            Text = "FormClient";
            Load += FormClient_Load;
            grpClient.ResumeLayout(false);
            grpClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgridView).EndInit();
            grpAccount.ResumeLayout(false);
            grpAccount.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpClient;
        private MaskedTextBox txtMobileNumber;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtLastname;
        private Label lblLname;
        private TextBox txtFirstname;
        private Label lblFname;
        private Label lblBDate;
        private DateTimePicker dtpBirthdate;
        private ComboBox txtGender;
        private Label label1;
        private Label lblPhone;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDel;
        private Button btnRefresh;
        private DataGridView dgridView;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private Button btnPrint;
        private GroupBox grpAccount;
        private Label label2;
        private Label lblAccountId;
        private TextBox txtBalance;
        private Label lblModified;
        private Button btnSave;
        private Button btnCancel;
    }
}