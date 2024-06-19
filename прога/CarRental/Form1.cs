using Entities;
using Npgsql;

namespace CarRental
{
    public partial class Form1 : Form
    {
        private readonly string _connectionString = "Server=localhost;Port=5432;Database=car_rental;Username=postgres;Password=123";
        private BindingSource _ordersBindingSource;

        public Form1()
        {
            InitializeComponent();
        }

        public void LoadOrders(List<Order> dataSource)
        {
            ordersDataGridView.Rows.Clear();

            _ordersBindingSource = new BindingSource();
            _ordersBindingSource.DataSource = dataSource;

            ordersDataGridView.Columns["IdColumn"].DataPropertyName = "Id";
            ordersDataGridView.Columns["CostColumn"].DataPropertyName = "Cost";
            ordersDataGridView.Columns["DiscountColumn"].DataPropertyName = "Discount";
            ordersDataGridView.Columns["FineColumn"].DataPropertyName = "Fine";
            ordersDataGridView.Columns["DateOfIssueColumn"].DataPropertyName = "DateOfIssue";
            ordersDataGridView.Columns["DateOfReturnColumn"].DataPropertyName = "DateOfReturn";
            ordersDataGridView.Columns["DateOfActualReturnColumn"].DataPropertyName = "DateOfActualReturn";
            ordersDataGridView.Columns["ClientColumn"].DataPropertyName = "User";
            ordersDataGridView.Columns["StatusColumn"].DataPropertyName = "Status";
            ordersDataGridView.Columns["CarColumn"].DataPropertyName = "Car";

            ordersDataGridView.DataSource = _ordersBindingSource;
        }

        public List<Order> LoadOrdersSearchedResults(int clientId, int carId, DateTime startDate, DateTime endDate)
        {
            List<Order> orders = new List<Order>();

            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM orders WHERE (orders_o_user_id_fk = @clientId) AND (orders_o_car_id_fk = @carId) AND (DATE(o_date_of_issue) BETWEEN @startDate AND @endDate)", connection))
                {
                    command.Parameters.AddWithValue("@clientId", clientId);
                    command.Parameters.AddWithValue("@carId", carId);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int orderId = reader.GetInt32(0);
                            int? cost = reader.IsDBNull(3) ? null : (int?)reader.GetInt32(3);
                            int? fine = reader.IsDBNull(5) ? null : (int?)reader.GetInt32(5);
                            int? discount = reader.IsDBNull(6) ? null : (int?)reader.GetInt32(6);
                            DateTime? dateOfIssue = reader.IsDBNull(1) ? null : (DateTime?)reader.GetDateTime(1);
                            DateTime? dateOfReturn = reader.IsDBNull(2) ? null : (DateTime?)reader.GetDateTime(2);
                            DateTime? dateOfActualReturn = reader.IsDBNull(4) ? null : (DateTime?)reader.GetDateTime(4);
                            int userId = reader.GetInt32(7);
                            int statusId = reader.GetInt32(8);
                            int autoId = reader.GetInt32(9);

                            User user = GetUserById(userId);
                            Status status = GetStatusById(statusId);
                            Car car = GetCarById(carId);

                            Order order = new Order(orderId, cost, fine, discount, dateOfIssue, dateOfReturn, dateOfActualReturn, user, status, car);
                            orders.Add(order);
                        }
                    }
                }

                connection.Close();
            }

            return orders;
        }

        public List<Order> LoadOrdersFromDatabase()
        {
            List<Order> orders = new List<Order>();

            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM orders", connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int orderId = reader.GetInt32(0);
                            int? cost = reader.IsDBNull(3) ? null : (int?)reader.GetInt32(3);
                            int? fine = reader.IsDBNull(5) ? null : (int?)reader.GetInt32(5);
                            int? discount = reader.IsDBNull(6) ? null : (int?)reader.GetInt32(6);
                            DateTime? dateOfIssue = reader.IsDBNull(1) ? null : (DateTime?)reader.GetDateTime(1);
                            DateTime? dateOfReturn = reader.IsDBNull(2) ? null : (DateTime?)reader.GetDateTime(2);
                            DateTime? dateOfActualReturn = reader.IsDBNull(4) ? null : (DateTime?)reader.GetDateTime(4);
                            int userId = reader.GetInt32(7);
                            int statusId = reader.GetInt32(8);
                            int carId = reader.GetInt32(9);

                            User user = GetUserById(userId);
                            Status status = GetStatusById(statusId);
                            Car car = GetCarById(carId);

                            Order order = new Order(orderId, cost, fine, discount, dateOfIssue, dateOfReturn, dateOfActualReturn, user, status, car);
                            orders.Add(order);
                        }
                    }
                }

                connection.Close();
            }

            return orders;
        }

        private User GetUserById(int userId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users WHERE user_id = @userId", connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string surname = reader.GetString(1);
                            string name = reader.GetString(2);
                            string patronymic = reader.GetString(3);
                            string address = reader.GetString(4);
                            string phone = reader.GetString(5);

                            return new User(userId, surname, name, patronymic, address, phone);
                        }
                    }
                }

                connection.Close();
            }

            return null;
        }

        private Status GetStatusById(int statusId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM status WHERE status_id = @statusId", connection))
                {
                    command.Parameters.AddWithValue("@statusId", statusId);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader.GetString(1);
                            return new Status(statusId, name);
                        }
                    }
                }

                connection.Close();
            }

            return null;
        }

        private Car GetCarById(int carId)
        {
            using(NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM auto WHERE auto_id = @carId", connection))
                {
                    command.Parameters.AddWithValue("@carId", carId);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader.GetString(1);
                            int year = reader.GetInt32(2);
                            int costHour = reader.GetInt32(3);
                            int brandId = reader.GetInt32(4);
                            int carTypeId = reader.GetInt32(5);

                            Brand brand = GetBrandById(brandId);
                            CarType carType = GetCarTypeById(carTypeId);

                            return new Car(carId, name, year, costHour, brand, carType);
                        }
                    }
                }

                connection.Close();
            }

            return null;
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
            using(NpgsqlConnection connection=new NpgsqlConnection(_connectionString))
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

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            LoadOrders(LoadOrdersFromDatabase());
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void addNewItemButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.ShowDialog();
        }
    }
}