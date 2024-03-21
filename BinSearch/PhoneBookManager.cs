using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinSearch
{
    public class PhoneBookManager
    {
        private SQLiteConnection conn;

        public PhoneBookManager(string path)
        {
            conn = new SQLiteConnection("Data Source=" + path);
            conn.Open();
        }

        ~PhoneBookManager()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Dispose();
            }
        }

        public bool AddUser(string firstName, string lastName, string phoneNumber)
        {
            try
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO phonebook (FirstName, LastName, PhoneNumber) VALUES (@FirstName, @LastName, @PhoneNumber)";
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return false;
            }
        }


        public bool DeleteUser(int id)
        {
            try
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM phonebook WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return false;
            }
        }

        public List<Contact> GetAllUsers()
        {
            List<Contact> contacts = new List<Contact>();

            try
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM phonebook";
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Contact contact = new Contact
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString()
                    };
                    contacts.Add(contact);
                }

                reader.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            return contacts;
        }

        public List<Contact> BinarySearch(string firstName, string lastName)
        {
            List<Contact> contacts = GetAllUsers();
            contacts.Sort((x, y) => string.Compare(x.LastName + x.FirstName, y.LastName + y.FirstName));

            List<Contact> searchResults = new List<Contact>();

            int left = 0;
            int right = contacts.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if ((string.IsNullOrEmpty(lastName) || contacts[mid].LastName.Equals(lastName)) &&
                    (string.IsNullOrEmpty(firstName) || contacts[mid].FirstName.Equals(firstName)))
                {
                    int index = mid;
                    while (index >= 0 && (string.IsNullOrEmpty(lastName) || contacts[index].LastName.Equals(lastName)) &&
                           (string.IsNullOrEmpty(firstName) || contacts[index].FirstName.Equals(firstName)))
                    {
                        searchResults.Add(contacts[index]);
                        index--;
                    }

                    index = mid + 1;
                    while (index < contacts.Count && (string.IsNullOrEmpty(lastName) || contacts[index].LastName.Equals(lastName)) &&
                           (string.IsNullOrEmpty(firstName) || contacts[index].FirstName.Equals(firstName)))
                    {
                        searchResults.Add(contacts[index]);
                        index++;
                    }

                    return searchResults;
                }
                else if (string.Compare(contacts[mid].LastName + contacts[mid].FirstName, lastName + firstName) < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return searchResults;
        }

    }
}
