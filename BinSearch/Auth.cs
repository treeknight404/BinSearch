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
    public partial class Auth : Form
    {
        private bool _isAuthenticated = false;

        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = AuthLogin.Text;
            if (login.Contains('\'') || login.Contains('-') || login.Contains('='))
            {
                MessageBox.Show("Логин содержит недопустимые символы!");
                return;
            }

            if (login.Contains("DROP") || login.Contains("INSERT") || login.Contains("TABLE"))
            {
                MessageBox.Show("Ха! Хорошая попытка! Придумай еще лучше!");
                return;
            }

            DBManager dbManager = new DBManager("C:\\Users\\kek\\source\\repos\\BinSearch\\users.db");
            if (dbManager.CheckUser(AuthLogin.Text, AuthPwd.Text))
            {
                _isAuthenticated = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MakeReg_Click(object sender, EventArgs e)
        {
            Register reg_form = new Register();
            reg_form.ShowDialog();
        }

        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isAuthenticated == false)
            {
                Application.Exit();
            }
        }
    }
}
