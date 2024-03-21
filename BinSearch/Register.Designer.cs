namespace BinSearch
{
    partial class Register
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
            RegPwd = new TextBox();
            RegLogin = new TextBox();
            DoReg = new Button();
            RegGoBack = new Button();
            RegConfPwd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // RegPwd
            // 
            RegPwd.Location = new Point(242, 130);
            RegPwd.Name = "RegPwd";
            RegPwd.PasswordChar = '*';
            RegPwd.Size = new Size(248, 23);
            RegPwd.TabIndex = 0;
            // 
            // RegLogin
            // 
            RegLogin.Location = new Point(242, 67);
            RegLogin.Name = "RegLogin";
            RegLogin.Size = new Size(248, 23);
            RegLogin.TabIndex = 1;
            // 
            // DoReg
            // 
            DoReg.Location = new Point(291, 230);
            DoReg.Name = "DoReg";
            DoReg.Size = new Size(159, 23);
            DoReg.TabIndex = 2;
            DoReg.Text = "Зарегистрироваться";
            DoReg.UseVisualStyleBackColor = true;
            DoReg.Click += DoReg_Click;
            // 
            // RegGoBack
            // 
            RegGoBack.Location = new Point(33, 267);
            RegGoBack.Name = "RegGoBack";
            RegGoBack.Size = new Size(75, 23);
            RegGoBack.TabIndex = 3;
            RegGoBack.Text = "Назад";
            RegGoBack.UseVisualStyleBackColor = true;
            RegGoBack.Click += RegGoBack_Click;
            // 
            // RegConfPwd
            // 
            RegConfPwd.Location = new Point(242, 188);
            RegConfPwd.Name = "RegConfPwd";
            RegConfPwd.PasswordChar = '*';
            RegConfPwd.Size = new Size(248, 23);
            RegConfPwd.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 40);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 5;
            label1.Text = "Придумайте логин";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 103);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 6;
            label2.Text = "Придумайте пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 170);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 7;
            label3.Text = "Подтвердите пароль";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 317);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RegConfPwd);
            Controls.Add(RegGoBack);
            Controls.Add(DoReg);
            Controls.Add(RegLogin);
            Controls.Add(RegPwd);
            Name = "Register";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RegPwd;
        private TextBox RegLogin;
        private Button DoReg;
        private Button RegGoBack;
        private TextBox RegConfPwd;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}