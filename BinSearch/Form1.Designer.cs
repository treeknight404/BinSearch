namespace BinSearch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PBAddUser_btn = new Button();
            PBDeleteUser_btn = new Button();
            PB_Label = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactBindingSource = new BindingSource(components);
            UserSearchBtn = new Button();
            Search_LastNameTB = new TextBox();
            Search_label = new Label();
            Search_FirstNameTB = new TextBox();
            Label_FirstName = new Label();
            Label_LastName = new Label();
            Sort_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PBAddUser_btn
            // 
            PBAddUser_btn.Location = new Point(516, 50);
            PBAddUser_btn.Name = "PBAddUser_btn";
            PBAddUser_btn.Size = new Size(147, 36);
            PBAddUser_btn.TabIndex = 1;
            PBAddUser_btn.Text = "Добавить...";
            PBAddUser_btn.UseVisualStyleBackColor = true;
            PBAddUser_btn.Click += button1_Click_1;
            // 
            // PBDeleteUser_btn
            // 
            PBDeleteUser_btn.Location = new Point(516, 92);
            PBDeleteUser_btn.Name = "PBDeleteUser_btn";
            PBDeleteUser_btn.Size = new Size(147, 36);
            PBDeleteUser_btn.TabIndex = 3;
            PBDeleteUser_btn.Text = "Удалить...";
            PBDeleteUser_btn.UseVisualStyleBackColor = true;
            PBDeleteUser_btn.Click += button1_Click_3;
            // 
            // PB_Label
            // 
            PB_Label.AutoSize = true;
            PB_Label.Location = new Point(272, 23);
            PB_Label.Name = "PB_Label";
            PB_Label.Size = new Size(147, 15);
            PB_Label.TabIndex = 4;
            PB_Label.Text = "Телефонный справочник";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn });
            dataGridView1.DataSource = contactBindingSource;
            dataGridView1.Location = new Point(32, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(463, 140);
            dataGridView1.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // contactBindingSource
            // 
            contactBindingSource.DataSource = typeof(Contact);
            // 
            // UserSearchBtn
            // 
            UserSearchBtn.Location = new Point(516, 216);
            UserSearchBtn.Name = "UserSearchBtn";
            UserSearchBtn.Size = new Size(143, 36);
            UserSearchBtn.TabIndex = 6;
            UserSearchBtn.Text = "Поиск...";
            UserSearchBtn.UseVisualStyleBackColor = true;
            UserSearchBtn.Click += UserSearchBtn_Click;
            // 
            // Search_LastNameTB
            // 
            Search_LastNameTB.Location = new Point(96, 224);
            Search_LastNameTB.Name = "Search_LastNameTB";
            Search_LastNameTB.Size = new Size(385, 23);
            Search_LastNameTB.TabIndex = 7;
            // 
            // Search_label
            // 
            Search_label.AutoSize = true;
            Search_label.Location = new Point(32, 201);
            Search_label.Name = "Search_label";
            Search_label.Size = new Size(203, 15);
            Search_label.TabIndex = 8;
            Search_label.Text = "Поиск по фамилии или по имени...";
            Search_label.Click += label1_Click;
            // 
            // Search_FirstNameTB
            // 
            Search_FirstNameTB.Location = new Point(96, 266);
            Search_FirstNameTB.Name = "Search_FirstNameTB";
            Search_FirstNameTB.Size = new Size(385, 23);
            Search_FirstNameTB.TabIndex = 9;
            // 
            // Label_FirstName
            // 
            Label_FirstName.AutoSize = true;
            Label_FirstName.Location = new Point(59, 269);
            Label_FirstName.Name = "Label_FirstName";
            Label_FirstName.Size = new Size(31, 15);
            Label_FirstName.TabIndex = 10;
            Label_FirstName.Text = "Имя";
            // 
            // Label_LastName
            // 
            Label_LastName.AutoSize = true;
            Label_LastName.Location = new Point(32, 227);
            Label_LastName.Name = "Label_LastName";
            Label_LastName.Size = new Size(58, 15);
            Label_LastName.TabIndex = 11;
            Label_LastName.Text = "Фамилия";
            // 
            // Sort_Btn
            // 
            Sort_Btn.Location = new Point(516, 134);
            Sort_Btn.Name = "Sort_Btn";
            Sort_Btn.Size = new Size(147, 56);
            Sort_Btn.TabIndex = 12;
            Sort_Btn.Text = "Обновить (Отсортировать)";
            Sort_Btn.UseVisualStyleBackColor = true;
            Sort_Btn.Click += Sort_Btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 323);
            Controls.Add(Sort_Btn);
            Controls.Add(Label_LastName);
            Controls.Add(Label_FirstName);
            Controls.Add(Search_FirstNameTB);
            Controls.Add(Search_label);
            Controls.Add(Search_LastNameTB);
            Controls.Add(UserSearchBtn);
            Controls.Add(dataGridView1);
            Controls.Add(PB_Label);
            Controls.Add(PBDeleteUser_btn);
            Controls.Add(PBAddUser_btn);
            Name = "Form1";
            Text = "Телефонный Справочник";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button PBAddUser_btn;
        private Button PBDeleteUser_btn;
        private Label PB_Label;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private BindingSource contactBindingSource;
        private Button UserSearchBtn;
        private TextBox Search_LastNameTB;
        private Label Search_label;
        private TextBox Search_FirstNameTB;
        private Label Label_FirstName;
        private Label Label_LastName;
        private Button Sort_Btn;
    }
}