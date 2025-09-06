namespace EventDriven.Project.UI
{
    partial class FormLogin
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
            txtUsername = new TextBox();
            lblFname = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnCancel = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 24F);
            txtUsername.Location = new Point(12, 59);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(471, 50);
            txtUsername.TabIndex = 3;
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Font = new Font("Segoe UI", 24F);
            lblFname.Location = new Point(12, 9);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(163, 45);
            lblFname.TabIndex = 2;
            lblFname.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 24F);
            txtPassword.Location = new Point(12, 175);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(471, 50);
            txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 24F);
            lblPassword.Location = new Point(12, 125);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(153, 45);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 24F);
            btnCancel.Location = new Point(264, 269);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(219, 66);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 24F);
            btnLogin.Location = new Point(12, 269);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(219, 66);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 403);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblFname);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Label lblFname;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnCancel;
        private Button btnLogin;
    }
}