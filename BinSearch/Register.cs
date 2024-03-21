using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinSearch
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoReg_Click(object sender, EventArgs e)
        {
            DBManager dbManager = new DBManager("C:\\Users\\kek\\source\\repos\\BinSearch\\users.db");

            if (string.IsNullOrWhiteSpace(RegLogin.Text) || string.IsNullOrWhiteSpace(RegPwd.Text) || string.IsNullOrWhiteSpace(RegConfPwd.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            if ((RegLogin.Text).Contains('\'') || (RegLogin.Text).Contains('-') || (RegLogin.Text).Contains('='))
            {
                MessageBox.Show("Логин содержит недопустимые символы!");
                return;
            }
            if ((RegLogin.Text).Contains("DROP") || (RegLogin.Text).Contains("INSERT") || (RegLogin.Text).Contains("TABLE"))
            {
                MessageBox.Show("Ха! Хорошая попытка! Придумай еще лучше!");
                return;
            }

            if (dbManager.AddUser(RegLogin.Text, RegPwd.Text))
            {
                MessageBox.Show("Успешная регистрация!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось зарегистрироваться!");
                this.Close();
            }
        }

        private void RegGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
