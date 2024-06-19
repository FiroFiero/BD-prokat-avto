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
    public partial class Form2 : Form
    {
        private readonly string _connectionString = "Server=localhost;Port=5432;Database=car_rental;Username=postgres;Password=123";

        private Form1 _form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();

            _form1 = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<User> users = GetUsers();
            List<Car> cars = GetCars();

            searchClientComboBox.DataSource = users;
            searchCarComboBox.DataSource = cars;

            searchClientComboBox.DisplayMember = "FullName";
            searchClientComboBox.ValueMember = "Id";

            searchCarComboBox.DisplayMember = "Name";
            searchCarComboBox.ValueMember = "Id";
        }

        private List<User> GetUsers()
        {
            List<User> users = new List<User>();

            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users", connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string surname = reader.GetString(1);
                            string name = reader.GetString(2);
                            string patronymic = reader.GetString(3);
                            string address = reader.GetString(4);
                            string phone = reader.GetString(5);

                            User user = new User(id, surname, name, patronymic, address, phone);
                            users.Add(user);
                        }
                    }
                }

                connection.Close();
            }

            return users;
        }

        private List<Car> GetCars()
        {
            List<Car> cars = new List<Car>();

            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM auto", connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            int year = reader.GetInt32(2);
                            int costHour = reader.GetInt32(3);
                            int brandId = reader.GetInt32(4);
                            int carTypeId = reader.GetInt32(5);

                            Brand brand = GetBrandById(brandId);
                            CarType carType = GetCarTypeById(carTypeId);

                            Car car = new Car(id, name, year, costHour, brand, carType);
                            cars.Add(car);
                        }
                    }
                }

                connection.Close();
            }

            return cars;
        }

        private Brand GetBrandById(int brandId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM brand WHERE brand_id = @brandId", connection))
                {
                    command.Parameters.AddWithValue("@brandId", brandId);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader.GetString(1);
                            return new Brand(brandId, name);
                        }
                    }
                }

                connection.Close();
            }

            return null;
        }

        private CarType GetCarTypeById(int carTypeId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM type_of_car WHERE type_of_car_id = @carTypeId", connection))
                {
                    command.Parameters.AddWithValue("@carTypeId", carTypeId);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader.GetString(1);
                            return new CarType(carTypeId, name);
                        }
                    }
                }

                connection.Close();
            }

            return null;
        }

        private void searchSubmitButton_Click(object sender, EventArgs e)
        {
            int clientId = (int) searchClientComboBox.SelectedValue!;
            int carId = (int) searchCarComboBox.SelectedValue!;
            DateTime startDate = firstDateOfIssueDateTimePicker.Value;
            DateTime endDate = secondDateOfIssueDateTimePicker.Value;

            if (startDate.Date > endDate.Date) { return; }

            List<Order> orders = _form1.LoadOrdersSearchedResults(clientId, carId, startDate, endDate);
            _form1.LoadOrders(orders);
        }
    }
}
