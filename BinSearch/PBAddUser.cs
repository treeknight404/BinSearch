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
    public partial class PBAddUser : Form
    {

        private PhoneBookManager phoneBookManager;

        public PBAddUser(PhoneBookManager manager)
        {
            InitializeComponent();
            phoneBookManager = manager;
        }

        private void PBAddUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PBAddUser_AddBtn_Click(object sender, EventArgs e)
        {
            string firstName = PBAddUser_FirstNameTB.Text;
            string lastName = PBAddUser_LastNameTB.Text;
            string phoneNumber = PBAddUser_PhoneNumberTB.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            if (firstName.Contains("DROP") || firstName.Contains("INSERT") || firstName.Contains("TABLE"))
            {
                MessageBox.Show("Ха! Хорошая попытка! Придумай еще лучше!");
                return;
            }

            if (lastName.Contains("DROP") || lastName.Contains("INSERT") || lastName.Contains("TABLE"))
            {
                MessageBox.Show("Ха! Хорошая попытка! Придумай еще лучше!");
                return;
            }

            if (phoneNumber.Contains("DROP") || phoneNumber.Contains("INSERT") || phoneNumber.Contains("TABLE"))
            {
                MessageBox.Show("Ха! Хорошая попытка! Придумай еще лучше!");
                return;
            }

            if (firstName.Contains('\'') || firstName.Contains('-') || firstName.Contains('='))
            {
                MessageBox.Show("Имя содержит недопустимые символы!");
                return;
            }

            if (lastName.Contains('\'') || lastName.Contains('-') || lastName.Contains('='))
            {
                MessageBox.Show("Фамилия содержит недопустимые символы!");
                return;
            }

            if (phoneNumber.Contains('\'') || phoneNumber.Contains('='))
            {
                MessageBox.Show("Номер телефона содержит недопустимые символы!");
                return;
            }

            if (phoneBookManager.AddUser(firstName, lastName, phoneNumber))
            {
                MessageBox.Show("Пользователь успешно добавлен!");
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении пользователя!");
            }

            this.Close();
        }

        private void PBAddUser_BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
