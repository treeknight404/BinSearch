namespace BinSearch
{
    partial class Auth
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
            AuthLogin = new TextBox();
            AuthPwd = new TextBox();
            AuthLoginLabel = new Label();
            AuthPwdLabel = new Label();
            DoAuth = new Button();
            MakeReg = new Button();
            NoAccLabel = new Label();
            SuspendLayout();
            // 
            // AuthLogin
            // 
            AuthLogin.Location = new Point(244, 70);
            AuthLogin.Name = "AuthLogin";
            AuthLogin.Size = new Size(219, 23);
            AuthLogin.TabIndex = 0;
            // 
            // AuthPwd
            // 
            AuthPwd.BackColor = SystemColors.Window;
            AuthPwd.Location = new Point(244, 134);
            AuthPwd.Name = "AuthPwd";
            AuthPwd.PasswordChar = '*';
            AuthPwd.Size = new Size(219, 23);
            AuthPwd.TabIndex = 1;
            // 
            // AuthLoginLabel
            // 
            AuthLoginLabel.AutoSize = true;
            AuthLoginLabel.Location = new Point(335, 52);
            AuthLoginLabel.Name = "AuthLoginLabel";
            AuthLoginLabel.Size = new Size(41, 15);
            AuthLoginLabel.TabIndex = 2;
            AuthLoginLabel.Text = "Логин";
            // 
            // AuthPwdLabel
            // 
            AuthPwdLabel.AutoSize = true;
            AuthPwdLabel.Location = new Point(335, 116);
            AuthPwdLabel.Name = "AuthPwdLabel";
            AuthPwdLabel.Size = new Size(49, 15);
            AuthPwdLabel.TabIndex = 3;
            AuthPwdLabel.Text = "Пароль";
            AuthPwdLabel.Click += label2_Click;
            // 
            // DoAuth
            // 
            DoAuth.AutoSize = true;
            DoAuth.Location = new Point(312, 184);
            DoAuth.Name = "DoAuth";
            DoAuth.Size = new Size(105, 25);
            DoAuth.TabIndex = 4;
            DoAuth.Text = "Авторизоваться";
            DoAuth.UseVisualStyleBackColor = true;
            DoAuth.Click += button1_Click;
            // 
            // MakeReg
            // 
            MakeReg.AutoSize = true;
            MakeReg.BackColor = Color.Transparent;
            MakeReg.ForeColor = SystemColors.Highlight;
            MakeReg.Location = new Point(551, 283);
            MakeReg.Name = "MakeReg";
            MakeReg.Size = new Size(129, 25);
            MakeReg.TabIndex = 5;
            MakeReg.Text = "Зарегистрироваться";
            MakeReg.UseVisualStyleBackColor = false;
            MakeReg.Click += MakeReg_Click;
            // 
            // NoAccLabel
            // 
            NoAccLabel.AutoSize = true;
            NoAccLabel.BackColor = SystemColors.Control;
            NoAccLabel.ForeColor = SystemColors.ControlText;
            NoAccLabel.Location = new Point(462, 287);
            NoAccLabel.Name = "NoAccLabel";
            NoAccLabel.Size = new Size(83, 15);
            NoAccLabel.TabIndex = 6;
            NoAccLabel.Text = "Нет аккаунта?";
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 323);
            Controls.Add(NoAccLabel);
            Controls.Add(MakeReg);
            Controls.Add(DoAuth);
            Controls.Add(AuthPwdLabel);
            Controls.Add(AuthLoginLabel);
            Controls.Add(AuthPwd);
            Controls.Add(AuthLogin);
            Name = "Auth";
            Text = "Авторизация";
            FormClosed += Auth_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AuthLogin;
        private TextBox AuthPwd;
        private Label AuthLoginLabel;
        private Label AuthPwdLabel;
        private Button DoAuth;
        private Button MakeReg;
        private Label NoAccLabel;
    }
}