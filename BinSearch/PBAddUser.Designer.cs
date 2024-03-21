namespace BinSearch
{
    partial class PBAddUser
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
            PBAddUser_FirstNameTB = new TextBox();
            PBAddUser_LastNameTB = new TextBox();
            PBAddUser_PhoneNumberTB = new TextBox();
            PBAddUser_AddBtn = new Button();
            PBAddUser_BackBtn = new Button();
            PBAddUserLabel = new Label();
            PBAddUser_FirstName = new Label();
            PBAddUser_LastName = new Label();
            PBAddUser_PhoneNumber = new Label();
            SuspendLayout();
            // 
            // PBAddUser_FirstNameTB
            // 
            PBAddUser_FirstNameTB.Location = new Point(225, 74);
            PBAddUser_FirstNameTB.Name = "PBAddUser_FirstNameTB";
            PBAddUser_FirstNameTB.Size = new Size(175, 23);
            PBAddUser_FirstNameTB.TabIndex = 0;
            // 
            // PBAddUser_LastNameTB
            // 
            PBAddUser_LastNameTB.Location = new Point(225, 118);
            PBAddUser_LastNameTB.Name = "PBAddUser_LastNameTB";
            PBAddUser_LastNameTB.Size = new Size(175, 23);
            PBAddUser_LastNameTB.TabIndex = 1;
            // 
            // PBAddUser_PhoneNumberTB
            // 
            PBAddUser_PhoneNumberTB.Location = new Point(225, 162);
            PBAddUser_PhoneNumberTB.Name = "PBAddUser_PhoneNumberTB";
            PBAddUser_PhoneNumberTB.Size = new Size(175, 23);
            PBAddUser_PhoneNumberTB.TabIndex = 2;
            // 
            // PBAddUser_AddBtn
            // 
            PBAddUser_AddBtn.Location = new Point(254, 202);
            PBAddUser_AddBtn.Name = "PBAddUser_AddBtn";
            PBAddUser_AddBtn.Size = new Size(122, 23);
            PBAddUser_AddBtn.TabIndex = 3;
            PBAddUser_AddBtn.Text = "Добавить!";
            PBAddUser_AddBtn.UseVisualStyleBackColor = true;
            PBAddUser_AddBtn.Click += PBAddUser_AddBtn_Click;
            // 
            // PBAddUser_BackBtn
            // 
            PBAddUser_BackBtn.Location = new Point(27, 250);
            PBAddUser_BackBtn.Name = "PBAddUser_BackBtn";
            PBAddUser_BackBtn.Size = new Size(75, 23);
            PBAddUser_BackBtn.TabIndex = 4;
            PBAddUser_BackBtn.Text = "Назад";
            PBAddUser_BackBtn.UseVisualStyleBackColor = true;
            PBAddUser_BackBtn.Click += PBAddUser_BackBtn_Click;
            // 
            // PBAddUserLabel
            // 
            PBAddUserLabel.AutoSize = true;
            PBAddUserLabel.Location = new Point(242, 19);
            PBAddUserLabel.Name = "PBAddUserLabel";
            PBAddUserLabel.Size = new Size(134, 15);
            PBAddUserLabel.TabIndex = 5;
            PBAddUserLabel.Text = "Добавление контакта...";
            PBAddUserLabel.Click += label1_Click;
            // 
            // PBAddUser_FirstName
            // 
            PBAddUser_FirstName.AutoSize = true;
            PBAddUser_FirstName.Location = new Point(297, 56);
            PBAddUser_FirstName.Name = "PBAddUser_FirstName";
            PBAddUser_FirstName.Size = new Size(31, 15);
            PBAddUser_FirstName.TabIndex = 6;
            PBAddUser_FirstName.Text = "Имя";
            // 
            // PBAddUser_LastName
            // 
            PBAddUser_LastName.AutoSize = true;
            PBAddUser_LastName.Location = new Point(284, 100);
            PBAddUser_LastName.Name = "PBAddUser_LastName";
            PBAddUser_LastName.Size = new Size(58, 15);
            PBAddUser_LastName.TabIndex = 7;
            PBAddUser_LastName.Text = "Фамилия";
            // 
            // PBAddUser_PhoneNumber
            // 
            PBAddUser_PhoneNumber.AutoSize = true;
            PBAddUser_PhoneNumber.Location = new Point(264, 144);
            PBAddUser_PhoneNumber.Name = "PBAddUser_PhoneNumber";
            PBAddUser_PhoneNumber.Size = new Size(101, 15);
            PBAddUser_PhoneNumber.TabIndex = 8;
            PBAddUser_PhoneNumber.Text = "Номер телефона";
            // 
            // PBAddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 294);
            Controls.Add(PBAddUser_PhoneNumber);
            Controls.Add(PBAddUser_LastName);
            Controls.Add(PBAddUser_FirstName);
            Controls.Add(PBAddUserLabel);
            Controls.Add(PBAddUser_BackBtn);
            Controls.Add(PBAddUser_AddBtn);
            Controls.Add(PBAddUser_PhoneNumberTB);
            Controls.Add(PBAddUser_LastNameTB);
            Controls.Add(PBAddUser_FirstNameTB);
            Name = "PBAddUser";
            Text = "Добавление контакта";
            Load += PBAddUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PBAddUser_FirstNameTB;
        private TextBox PBAddUser_LastNameTB;
        private TextBox PBAddUser_PhoneNumberTB;
        private Button PBAddUser_AddBtn;
        private Button PBAddUser_BackBtn;
        private Label PBAddUserLabel;
        private Label PBAddUser_FirstName;
        private Label PBAddUser_LastName;
        private Label PBAddUser_PhoneNumber;
    }
}