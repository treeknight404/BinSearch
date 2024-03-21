using System.Windows.Forms;

namespace BinSearch
{
    public partial class Form1 : Form
    {
        private List<Contact> searchResults = new List<Contact>();
        private PhoneBookManager phoneBookManager;

        public Form1()
        {
            InitializeComponent();

            Auth auth_form = new Auth();
            auth_form.ShowDialog();

            phoneBookManager = new PhoneBookManager("C:\\Users\\kek\\source\\repos\\BinSearch\\phonebook.db");

            ShowAllContacts();
        }


        private void ShowAllContacts()
        {
            var contacts = phoneBookManager.GetAllUsers();
            contacts.Sort((x, y) => string.Compare(x.LastName, y.LastName));
            dataGridView1.DataSource = contacts;

        }

        private void DoSort_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PBAddUser addUser_form = new PBAddUser(phoneBookManager);
            addUser_form.ShowDialog();

            ShowAllContacts();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int contactId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот контакт?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    if (phoneBookManager.DeleteUser(contactId))
                    {
                        MessageBox.Show("Контакт успешно удален!");

                        ShowAllContacts();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при удалении контакта!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите контакт для удаления!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы уверены, что хотите закрыть программу?", "Внимание!", MessageBoxButtons.YesNo);
            if (answer != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void UserSearchBtn_Click(object sender, EventArgs e)
        {
            string searchFirstName = Search_FirstNameTB.Text.Trim();
            string searchLastName = Search_LastNameTB.Text.Trim();

            if (string.IsNullOrEmpty(searchFirstName) && string.IsNullOrEmpty(searchLastName))
            {
                MessageBox.Show("Введите имя или фамилию для поиска");
                return;
            }

            List<Contact> searchResults;

            if (!string.IsNullOrEmpty(searchFirstName) && !string.IsNullOrEmpty(searchLastName))
            {
                searchResults = phoneBookManager.BinarySearch(searchFirstName, searchLastName);
            }
            else if (!string.IsNullOrEmpty(searchLastName))
            {
                searchResults = phoneBookManager.BinarySearch(searchLastName, "");
            }
            else
            {
                searchResults = phoneBookManager.BinarySearch("", searchFirstName);
            }

            if (searchResults != null && searchResults.Count > 0)
            {
                dataGridView1.DataSource = searchResults;
            }
            else
            {
                MessageBox.Show("Контакт не найден");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sort_Btn_Click(object sender, EventArgs e)
        {
            List<Contact> contacts = phoneBookManager.GetAllUsers();
            contacts.Sort((x, y) =>
            {
                int result = string.Compare(x.LastName, y.LastName);
                if (result == 0)
                {
                    result = string.Compare(x.FirstName, y.FirstName);
                }
                return result;
            });


            contactBindingSource.DataSource = contacts;

            ShowAllContacts();
        }
    }
}