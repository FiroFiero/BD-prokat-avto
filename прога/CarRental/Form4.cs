using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Form4 : Form
    {
        private readonly string _connectionString = "Server=localhost;Port=5432;Database=car_rental;Username=postgres;Password=123";
        private Form3 _form3;

        public Form4(Form3 form3)
        {
            InitializeComponent();
            _form3 = form3;
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            string surname = surnameTextBox.Text;
            string name = nameTextBox.Text;
            string patronymic = patronymicTextBox.Text;
            string address = addressTextBox.Text;
            string phone = phoneTextBox.Text;

            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = connection.CreateCommand()) 
                { 
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO users (user_id, u_surname, u_name, u_patronymic, u_adres, u_phone) VALUES (default, @Surname, @Name, @Patronymic, @Address, @Phone)";
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Patronymic", patronymic);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Phone", phone);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            this.Close();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form3.Form3_Load(sender, e);
        }
    }
}
