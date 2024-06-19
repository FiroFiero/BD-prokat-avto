using Entities;
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
    public partial class Form5 : Form
    {
        private readonly string _connectionString = "Server=localhost;Port=5432;Database=car_rental;Username=postgres;Password=123";
        private Form3 _form3;

        public Form5(Form3 form3)
        {
            InitializeComponent();
            _form3 = form3;
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form3.Form3_Load(sender, e);
        }

        private int addBrand(string name)
        {
            int id;

            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO brand (brand_id, b_name) VALUES (default, @Name) returning brand_id";
                    command.Parameters.AddWithValue("@Name", name);

                    id = (int) command.ExecuteScalar();
                }

                connection.Close();
            }

            return id;
        }

        private int addCarType(string name)
        {
            int id;

            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO type_of_car (type_of_car_id, t_name) VALUES (default, @Name) returning type_of_car_id";
                    command.Parameters.AddWithValue("@Name", name);

                    id = (int) command.ExecuteScalar();
                }

                connection.Close();
            }

            return id;
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int year = (int) yearNumericUpDown.Value;
            int costHour = (int) costHourNumericUpDown.Value;

            int brandId = addBrand(brandTextBox.Text);
            int carTypeId = addCarType(carTypeTextBox.Text);

            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO auto (auto_id, a_name, a_year, a_cost_hour, auto_a_brand_id_fk, auto_a_type_of_car_id_fk) VALUES (default, @Name, @Year, @CostHour, @BrandId, @CarTypeId)";
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@CostHour", costHour);
                    command.Parameters.AddWithValue("@BrandId", brandId);
                    command.Parameters.AddWithValue("@CarTypeId", carTypeId);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            this.Close();
        }
    }
}
