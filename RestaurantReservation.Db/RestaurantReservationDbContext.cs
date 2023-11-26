using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Models;
using System.Reflection.Metadata;

namespace RestaurantReservation.Db
{
    public class RestaurantReservationDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-P1OAHG7\\MSSQLSERVER06;Database=RestaurantReservationCore;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(c => c.CustomerId);
            modelBuilder.Entity<Employee>().HasKey(c => c.EmployeeId);
            modelBuilder.Entity<MenuItem>().HasKey(c => c.ItemId);
            modelBuilder.Entity<OrderItem>().HasKey(c => c.OrderItemId);
            modelBuilder.Entity<Order>().HasKey(c => c.OrderId);
            modelBuilder.Entity<Reservation>().HasKey(c => c.ReservationId);
            modelBuilder.Entity<Restaurant>().HasKey(c => c.RestaurantId);
            modelBuilder.Entity<Table>().HasKey(c => c.TableId);

            modelBuilder.Entity<Order>()
            .HasMany(e => e.OrderItems)
            .WithOne(e => e.Order)
            .HasForeignKey(e => e.OrderId)
            .HasPrincipalKey(e => e.OrderId);

            modelBuilder.Entity<MenuItem>()
            .HasMany(e => e.OrderItems)
            .WithOne(e => e.MenuItem)
            .HasForeignKey(e => e.OrderItemId)
            .HasPrincipalKey(e => e.ItemId);

            modelBuilder.Entity<Employee>()
            .HasMany(e => e.Orders)
            .WithOne(e => e.Employee)
            .HasForeignKey(e => e.OrderId)
            .HasPrincipalKey(e => e.EmployeeId);

            modelBuilder.Entity<Reservation>()
            .HasMany(e => e.Orders)
            .WithOne(e => e.Reservation)
            .HasForeignKey(e => e.OrderId)
            .HasPrincipalKey(e => e.ReservationId);

            modelBuilder.Entity<Restaurant>()
            .HasMany(e => e.Employees)
            .WithOne(e => e.Restaurant)
            .HasForeignKey(e => e.EmployeeId)
            .HasPrincipalKey(e => e.RestaurantId);

            modelBuilder.Entity<Customer>()
            .HasMany(e => e.Reservations)
            .WithOne(e => e.Customer)
            .HasForeignKey(e => e.ReservationId)
            .HasPrincipalKey(e => e.CustomerId);

            modelBuilder.Entity<Restaurant>()
            .HasMany(e => e.Reservations)
            .WithOne(e => e.Restaurant)
            .HasForeignKey(e => e.ReservationId)
            .HasPrincipalKey(e => e.RestaurantId);

            modelBuilder.Entity<Table>()
            .HasMany(e => e.Reservations)
            .WithOne(e => e.Table)
            .HasForeignKey(e => e.ReservationId)
            .HasPrincipalKey(e => e.TableId);

            modelBuilder.Entity<Restaurant>()
            .HasMany(e => e.Tables)
            .WithOne(e => e.Restaurant)
            .HasForeignKey(e => e.TableId)
            .HasPrincipalKey(e => e.RestaurantId);

            modelBuilder.Entity<Restaurant>()
            .HasMany(e => e.MenuItems)
            .WithOne(e => e.Restaurant)
            .HasForeignKey(e => e.ItemId)
            .HasPrincipalKey(e => e.RestaurantId);

            var restaurants = new Restaurant[]
            {
                new Restaurant{RestaurantId = 1, Name = "shawrma", Address = "sesimi street" , PhoneNumber = "0590033220" },
                new Restaurant{RestaurantId = 2, Name = "ala kafak", Address = "nablus street" , PhoneNumber = "0590044220" },
                new Restaurant{RestaurantId = 3, Name = "malaki", Address = "rafedia street" , PhoneNumber = "0590033670" },
                new Restaurant{RestaurantId = 4, Name = "aldeek", Address = "noway street" , PhoneNumber = "0590035670" },
                new Restaurant{RestaurantId = 5, Name = "potato", Address = "potato street" , PhoneNumber = "0590256678" }
            };

            modelBuilder.Entity<Restaurant>().HasData(restaurants);

            var customers = new Customer[] 
            {
                new Customer{CustomerId = 1, FirstName = "mohamad" , LastName = "moghrabi" , Email = "asd@gmail.com" , PhoneNumber = "0564235698"}
                , new Customer{CustomerId = 2, FirstName = "hamza" , LastName = "makhlof" , Email = "hamza@gmail.com" , PhoneNumber = "0594235698"}
                , new Customer{CustomerId = 3, FirstName = "ahmed" , LastName = "hamdan" , Email = "ahmed@gmail.com" , PhoneNumber = "0564275698"}
                , new Customer{CustomerId = 4, FirstName = "ramiz" , LastName = "saleh" , Email = "ramiz@gmail.com" , PhoneNumber = "0564235321"}
                , new Customer{CustomerId = 5, FirstName = "sodki" , LastName = "saleh" , Email = "sodki@gmail.com" , PhoneNumber = "0564232198"}
            };
            modelBuilder.Entity<Customer>().HasData(customers);
            var menuItems = new MenuItem[]
            {
                new MenuItem{ItemId = 1 , RestaurantId = 3 , Name = "potato" , Description = "fried potato" , Price = 6}
                ,new MenuItem{ItemId = 2 , RestaurantId = 1 , Name = "soap" , Description = "tomato soap" , Price = 6}
                ,new MenuItem{ItemId = 3 , RestaurantId = 2 , Name = "chicken" , Description = "fried chicken" , Price = 6}
                ,new MenuItem{ItemId = 4 , RestaurantId = 5 , Name = "steak" , Description = "beef steak" , Price = 6}
                ,new MenuItem{ItemId = 5 , RestaurantId = 4 , Name = "falafel" , Description = "falafel" , Price = 6}
            };
            modelBuilder.Entity<MenuItem>().HasData(menuItems);
            var tables = new Table[]
            {
                new Table{TableId = 1 , Capacity = 4 , RestaurantID = 4},
                new Table{TableId = 2 , Capacity = 3 , RestaurantID = 5},
                new Table{TableId = 3 , Capacity = 2 , RestaurantID = 2},
                new Table{TableId = 4 , Capacity = 5 , RestaurantID = 1},
                new Table{TableId = 5 , Capacity = 4 , RestaurantID = 3}
            };
            modelBuilder.Entity<Table>().HasData(tables);
            var employees = new Employee[]
            {
                new Employee{EmployeeId = 1 , RestaurantId = 1 , FirstName = "mohamad" , LastName = "ahmed" , Position = "waitres"},
                new Employee{EmployeeId = 2 , RestaurantId = 3 , FirstName = "ahmed" , LastName = "hamdi" , Position = "manager"},
                new Employee{EmployeeId = 3 , RestaurantId = 5 , FirstName = "roa" , LastName = "rmzi" , Position = "waitres"},
                new Employee{EmployeeId = 4 , RestaurantId = 2 , FirstName = "sami" , LastName = "mohamad" , Position = "waitres"},
                new Employee{EmployeeId = 5 , RestaurantId = 4 , FirstName = "lara" , LastName = "sodki" , Position = "waitres"}
            };
            modelBuilder.Entity<Employee>().HasData(employees);
            var reservations = new Reservation[]
            {
                new Reservation{ReservationId = 1 , CustomerId = 2 , RestaurantId = 5 , TableId = 2 , ReservationDate = DateTime.Now , PartySize = 3},
                new Reservation{ReservationId = 2 , CustomerId = 4 , RestaurantId = 4 , TableId = 3 , ReservationDate = DateTime.Now , PartySize = 6},
                new Reservation{ReservationId = 3 , CustomerId = 5 , RestaurantId = 3 , TableId = 1 , ReservationDate = DateTime.Now , PartySize = 2},
                new Reservation{ReservationId = 4 , CustomerId = 3 , RestaurantId = 2 , TableId = 4 , ReservationDate = DateTime.Now , PartySize = 4},
                new Reservation{ReservationId = 5 , CustomerId = 1 , RestaurantId = 1 , TableId = 5 , ReservationDate = DateTime.Now , PartySize = 5}
            };
            modelBuilder.Entity<Reservation>().HasData(reservations);
            var orders = new Order[]
            {
                new Order{OrderId = 1 , ReservationId = 4 , EmployeeId = 1 , OrderDate = DateTime.Now , TotalAmount = 30},
                new Order{OrderId = 2 , ReservationId = 2 , EmployeeId = 2 , OrderDate = DateTime.Now , TotalAmount = 20},
                new Order{OrderId = 3 , ReservationId = 5 , EmployeeId = 5 , OrderDate = DateTime.Now , TotalAmount = 10},
                new Order{OrderId = 4 , ReservationId = 3 , EmployeeId = 3 , OrderDate = DateTime.Now , TotalAmount = 15},
                new Order{OrderId = 5 , ReservationId = 1 , EmployeeId = 4 , OrderDate = DateTime.Now , TotalAmount = 25}
            };
            modelBuilder.Entity<Order>().HasData(orders);
            var orderItems = new OrderItem[]
            {
                new OrderItem{OrderItemId = 1 , OrderId = 4 , MenuItemId = 3 , Quantity = 3},
                new OrderItem{OrderItemId = 2 , OrderId = 1 , MenuItemId = 1 , Quantity = 7},
                new OrderItem{OrderItemId = 3 , OrderId = 2 , MenuItemId = 2 , Quantity = 5},
                new OrderItem{OrderItemId = 4 , OrderId = 5 , MenuItemId = 4 , Quantity = 2},
                new OrderItem{OrderItemId = 5 , OrderId = 3 , MenuItemId = 5 , Quantity = 6}
            };
            modelBuilder.Entity<OrderItem>().HasData(orderItems);
        }

       
    }
}