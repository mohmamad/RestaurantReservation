using Microsoft.EntityFrameworkCore;

namespace RestaurantReservation.Db
{
    public class RestaurantReservationDbContext:DbContext
    {
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Reservations> Reservations { get; set; }
        public DbSet<Restaurants> Restaurants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-P1OAHG7\\MSSQLSERVER06;Database=RestaurantReservationCore;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>().HasKey(c => c.CustomersId);
            modelBuilder.Entity<Employees>().HasKey(c => c.EmployeesId);
            modelBuilder.Entity<MenuItem>().HasKey(c => c.ItemId);
            modelBuilder.Entity<OrderItems>().HasKey(c => c.OrderItemsId);
            modelBuilder.Entity<Orders>().HasKey(c => c.OrdersId);
            modelBuilder.Entity<Reservations>().HasKey(c => c.ReservationId);
            modelBuilder.Entity<Restaurants>().HasKey(c => c.RestaurantsId);
            modelBuilder.Entity<Tables>().HasKey(c => c.TablesId);
           
            

            
            var restaurants = new Restaurants[]
            {
                new Restaurants{RestaurantsId = 1, Name = "shawrma", Address = "sesimi street" , PhoneNumber = "0590033220" },
                new Restaurants{RestaurantsId = 2, Name = "ala kafak", Address = "nablus street" , PhoneNumber = "0590044220" },
                new Restaurants{RestaurantsId = 3, Name = "malaki", Address = "rafedia street" , PhoneNumber = "0590033670" },
                new Restaurants{RestaurantsId = 4, Name = "aldeek", Address = "noway street" , PhoneNumber = "0590035670" },
                new Restaurants{RestaurantsId = 5, Name = "potato", Address = "potato street" , PhoneNumber = "0590256678" }
            };

            modelBuilder.Entity<Restaurants>().HasData(restaurants);

            var customers = new Customers[] 
            {
                new Customers{CustomersId = 1, FirstName = "mohamad" , LastName = "moghrabi" , Email = "asd@gmail.com" , PhoneNumber = "0564235698"}
                , new Customers{CustomersId = 2, FirstName = "hamza" , LastName = "makhlof" , Email = "hamza@gmail.com" , PhoneNumber = "0594235698"}
                , new Customers{CustomersId = 3, FirstName = "ahmed" , LastName = "hamdan" , Email = "ahmed@gmail.com" , PhoneNumber = "0564275698"}
                , new Customers{CustomersId = 4, FirstName = "ramiz" , LastName = "saleh" , Email = "ramiz@gmail.com" , PhoneNumber = "0564235321"}
                , new Customers{CustomersId = 5, FirstName = "sodki" , LastName = "saleh" , Email = "sodki@gmail.com" , PhoneNumber = "0564232198"}
            };
            modelBuilder.Entity<Customers>().HasData(customers);
            var menuItems = new MenuItem[]
            {
                new MenuItem{ItemId = 1 , RestaurantsId = 3 , Name = "potato" , Description = "fried potato" , Price = 6}
                ,new MenuItem{ItemId = 2 , RestaurantsId = 1 , Name = "soap" , Description = "tomato soap" , Price = 6}
                ,new MenuItem{ItemId = 3 , RestaurantsId = 2 , Name = "chicken" , Description = "fried chicken" , Price = 6}
                ,new MenuItem{ItemId = 4 , RestaurantsId = 5 , Name = "steak" , Description = "beef steak" , Price = 6}
                ,new MenuItem{ItemId = 5 , RestaurantsId = 4 , Name = "falafel" , Description = "falafel" , Price = 6}
            };
            modelBuilder.Entity<MenuItem>().HasData(menuItems);
            var tables = new Tables[]
            {
                new Tables{TablesId = 1 , Capacity = 4 , RestaurantsID = 4},
                new Tables{TablesId = 2 , Capacity = 3 , RestaurantsID = 5},
                new Tables{TablesId = 3 , Capacity = 2 , RestaurantsID = 2},
                new Tables{TablesId = 4 , Capacity = 5 , RestaurantsID = 1},
                new Tables{TablesId = 5 , Capacity = 4 , RestaurantsID = 3}
            };
            modelBuilder.Entity<Tables>().HasData(tables);
            var employees = new Employees[]
            {
                new Employees{EmployeesId = 1 , RestaurantsId = 1 , FirstName = "mohamad" , LastName = "ahmed" , Position = "waitres"},
                new Employees{EmployeesId = 2 , RestaurantsId = 3 , FirstName = "ahmed" , LastName = "hamdi" , Position = "manager"},
                new Employees{EmployeesId = 3 , RestaurantsId = 5 , FirstName = "roa" , LastName = "rmzi" , Position = "waitres"},
                new Employees{EmployeesId = 4 , RestaurantsId = 2 , FirstName = "sami" , LastName = "mohamad" , Position = "waitres"},
                new Employees{EmployeesId = 5 , RestaurantsId = 4 , FirstName = "lara" , LastName = "sodki" , Position = "waitres"}
            };
            modelBuilder.Entity<Employees>().HasData(employees);
            var reservations = new Reservations[]
            {
                new Reservations{ReservationId = 1 , CustomersId = 2 , RestaurantsId = 5 , TablesId = 2 , ReservationDate = DateTime.Now , PartySize = 3},
                new Reservations{ReservationId = 2 , CustomersId = 4 , RestaurantsId = 4 , TablesId = 3 , ReservationDate = DateTime.Now , PartySize = 6},
                new Reservations{ReservationId = 3 , CustomersId = 5 , RestaurantsId = 3 , TablesId = 1 , ReservationDate = DateTime.Now , PartySize = 2},
                new Reservations{ReservationId = 4 , CustomersId = 3 , RestaurantsId = 2 , TablesId = 4 , ReservationDate = DateTime.Now , PartySize = 4},
                new Reservations{ReservationId = 5 , CustomersId = 1 , RestaurantsId = 1 , TablesId = 5 , ReservationDate = DateTime.Now , PartySize = 5}
            };
            modelBuilder.Entity<Reservations>().HasData(reservations);
            var orders = new Orders[]
            {
                new Orders{OrdersId = 1 , ReservationsId = 4 , EmployeesId = 1 , OrderDate = DateTime.Now , TotalAmount = 30},
                new Orders{OrdersId = 2 , ReservationsId = 2 , EmployeesId = 2 , OrderDate = DateTime.Now , TotalAmount = 20},
                new Orders{OrdersId = 3 , ReservationsId = 5 , EmployeesId = 5 , OrderDate = DateTime.Now , TotalAmount = 10},
                new Orders{OrdersId = 4 , ReservationsId = 3 , EmployeesId = 3 , OrderDate = DateTime.Now , TotalAmount = 15},
                new Orders{OrdersId = 5 , ReservationsId = 1 , EmployeesId = 4 , OrderDate = DateTime.Now , TotalAmount = 25}
            };
            modelBuilder.Entity<Orders>().HasData(orders);
            var orderItems = new OrderItems[]
            {
                new OrderItems{OrderItemsId = 1 , OrdersId = 4 , MenuItemId = 3 , Quantity = 3},
                new OrderItems{OrderItemsId = 2 , OrdersId = 1 , MenuItemId = 1 , Quantity = 7},
                new OrderItems{OrderItemsId = 3 , OrdersId = 2 , MenuItemId = 2 , Quantity = 5},
                new OrderItems{OrderItemsId = 4 , OrdersId = 5 , MenuItemId = 4 , Quantity = 2},
                new OrderItems{OrderItemsId = 5 , OrdersId = 3 , MenuItemId = 5 , Quantity = 6}
            };
            modelBuilder.Entity<OrderItems>().HasData(orderItems);
        }

       
    }
}