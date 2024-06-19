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
    public partial class Form3 : Form
    {
        private readonly string _connectionString = "Server=localhost;Port=5432;Database=car_rental;Username=postgres;Password=123";
        private Form1 _form1;

        public Form3(Form1 form1)
        {
            InitializeComponent();

            _form1 = form1;
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            List<User> users = GetUsers();
            List<Car> cars = GetCars();
            List<Status> statuses = GetStatuses();

            searchClientComboBox.DataSource = users;
            searchCarComboBox.DataSource = cars;
            searchStatusComboBox.DataSource = statuses;

            searchClientComboBox.DisplayMember = "FullName";
            searchClientComboBox.ValueMember = "Id";

            searchCarComboBox.DisplayMember = "Name";
            searchCarComboBox.ValueMember = "Id";

            searchStatusComboBox.DisplayMember = "Name";
            searchStatusComboBox.ValueMember = "Id";
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

        private List<Status> GetStatuses()
        {
            List<Status> statuses = new List<Status>();

            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM status", connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);

                            Status status = new Status(id, name);
                            statuses.Add(status);
                        }
                    }
                }

                connection.Close();
            }

            return statuses;
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

        private void addNewOrderButton_Click(object sender, EventArgs e)
        {
            int clientId = (int)searchClientComboBox.SelectedValue!;
            int carId = (int)searchCarComboBox.SelectedValue!;
            int statusId = (int)searchStatusComboBox.SelectedValue!;
            DateTime dateOfIssue = dateOfIssueDateTimePicker.Value;
            DateTime dateOfReturn = dateOfReturnDateTimePicker.Value;
            DateTime dateOfActualReturn = dateOfActualReturnDateTimePicker.Value;
            int cost = (int)costNumericUpDown.Value;
            int fine = (int)fineNumericUpDown.Value;
            int discount = (int)discountNumericUpDown.Value;

            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO orders (order_id, o_date_of_issue, o_date_return, o_cost, o_date_of_actual_return, o_fine, o_discount, orders_o_user_id_fk, orders_o_status_id_fk, orders_o_car_id_fk) VALUES (default, @DateOfIssue, @DateOfReturn, @Cost, @DateOfActualReturn, @Fine, @Discount, @ClientId, @StatusId, @CarId)";
                    command.Parameters.AddWithValue("@DateOfIssue", dateOfIssue);
                    command.Parameters.AddWithValue("@DateOfReturn", dateOfReturn);
                    command.Parameters.AddWithValue("@Cost", cost);
                    command.Parameters.AddWithValue("@DateOfActualReturn", dateOfActualReturn);
                    command.Parameters.AddWithValue("@Fine", fine);
                    command.Parameters.AddWithValue("@Discount", discount);
                    command.Parameters.AddWithValue("@ClientId", clientId);
                    command.Parameters.AddWithValue("@StatusId", statusId);
                    command.Parameters.AddWithValue("@CarId", carId);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            _form1.LoadOrders(_form1.LoadOrdersFromDatabase());
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(this);
            form.ShowDialog();
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(this);
            form.ShowDialog();
        }
    }
}
