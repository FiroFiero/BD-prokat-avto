namespace Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }
    }

    public class User : Entity
    {
        public User(int id, string? surname, string? name, string? patronymic, string? address, string? phone)
        {
            Id = id;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Address = address;
            Phone = phone;
        }

        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }

        public string FullName => $"{Surname} {Name} {Patronymic}";

        public override string ToString()
        {
            return FullName;
        }
    }

    public class Order : Entity
    {
        public Order(int id, int? cost, int? fine, int? discount, DateTime? dateOfIssue, DateTime? dateOfReturn, DateTime? dateOfActualReturn, User? user, Status? status, Car? car)
        {
            Id = id;
            Cost = cost;
            Fine = fine;
            Discount = discount;
            DateOfIssue = dateOfIssue;
            DateOfReturn = dateOfReturn;
            DateOfActualReturn = dateOfActualReturn;
            User = user;
            Status = status;
            Car = car;
        }

        public int? Cost { get; set; }
        public int? Fine { get; set; }
        public int? Discount { get; set; }
        public DateTime? DateOfIssue { get; set; }
        public DateTime? DateOfReturn{ get; set; }
        public DateTime? DateOfActualReturn { get; set; }
        public User? User { get; set; }
        public Status? Status { get; set; }
        public Car? Car { get; set; }
    }

    public class Status : Entity 
    {
        public Status(int id, string? name)
        {
            Id = id;
            Name = name;
        }

        public string? Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Car : Entity
    {
        public Car(int id, string? name, int? year, int? costHour, Brand? brand, CarType? carType)
        {
            Id = id;
            Name = name;
            Year = year;
            CostHour = costHour;
            Brand = brand;
            CarType = carType;
        }

        public string? Name { get; set; }
        public int? Year { get; set; }
        public int? CostHour { get; set; }
        public Brand? Brand { get; set; }
        public CarType? CarType { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Brand : Entity
    {
        public Brand(int id, string? name)
        {
            Id = id;
            Name = name;
        }

        public string? Name { get; set; }
    }

    public class CarType : Entity
    {
        public CarType(int id, string? name)
        {
            Id = id;
            Name = name;
        }

        public string? Name { get; set; }
    }
}