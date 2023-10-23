﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantReservation.Db;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    [DbContext(typeof(RestaurantReservationDbContext))]
    [Migration("20231022010106_AddedData")]
    partial class AddedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestaurantReservation.Db.Customers", b =>
                {
                    b.Property<int>("CustomersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomersId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomersId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomersId = 1,
                            Email = "asd@gmail.com",
                            FirstName = "mohamad",
                            LastName = "moghrabi",
                            PhoneNumber = "0564235698"
                        },
                        new
                        {
                            CustomersId = 2,
                            Email = "hamza@gmail.com",
                            FirstName = "hamza",
                            LastName = "makhlof",
                            PhoneNumber = "0594235698"
                        },
                        new
                        {
                            CustomersId = 3,
                            Email = "ahmed@gmail.com",
                            FirstName = "ahmed",
                            LastName = "hamdan",
                            PhoneNumber = "0564275698"
                        },
                        new
                        {
                            CustomersId = 4,
                            Email = "ramiz@gmail.com",
                            FirstName = "ramiz",
                            LastName = "saleh",
                            PhoneNumber = "0564235321"
                        },
                        new
                        {
                            CustomersId = 5,
                            Email = "sodki@gmail.com",
                            FirstName = "sodki",
                            LastName = "saleh",
                            PhoneNumber = "0564232198"
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.Employees", b =>
                {
                    b.Property<int>("EmployeesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeesId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantsId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesId");

                    b.HasIndex("RestaurantsId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeesId = 1,
                            FirstName = "mohamad",
                            LastName = "ahmed",
                            Position = "waitres",
                            RestaurantsId = 1
                        },
                        new
                        {
                            EmployeesId = 2,
                            FirstName = "ahmed",
                            LastName = "hamdi",
                            Position = "manager",
                            RestaurantsId = 3
                        },
                        new
                        {
                            EmployeesId = 3,
                            FirstName = "roa",
                            LastName = "rmzi",
                            Position = "waitres",
                            RestaurantsId = 5
                        },
                        new
                        {
                            EmployeesId = 4,
                            FirstName = "sami",
                            LastName = "mohamad",
                            Position = "waitres",
                            RestaurantsId = 2
                        },
                        new
                        {
                            EmployeesId = 5,
                            FirstName = "lara",
                            LastName = "sodki",
                            Position = "waitres",
                            RestaurantsId = 4
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.MenuItem", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("RestaurantsId")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.HasIndex("RestaurantsId");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            Description = "fried potato",
                            Name = "potato",
                            Price = 6f,
                            RestaurantsId = 3
                        },
                        new
                        {
                            ItemId = 2,
                            Description = "tomato soap",
                            Name = "soap",
                            Price = 6f,
                            RestaurantsId = 1
                        },
                        new
                        {
                            ItemId = 3,
                            Description = "fried chicken",
                            Name = "chicken",
                            Price = 6f,
                            RestaurantsId = 2
                        },
                        new
                        {
                            ItemId = 4,
                            Description = "beef steak",
                            Name = "steak",
                            Price = 6f,
                            RestaurantsId = 5
                        },
                        new
                        {
                            ItemId = 5,
                            Description = "falafel",
                            Name = "falafel",
                            Price = 6f,
                            RestaurantsId = 4
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.OrderItems", b =>
                {
                    b.Property<int>("OrderItemsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemsId"));

                    b.Property<int>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrdersId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemsId");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("OrdersId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            OrderItemsId = 1,
                            MenuItemId = 3,
                            OrdersId = 4,
                            Quantity = 3
                        },
                        new
                        {
                            OrderItemsId = 2,
                            MenuItemId = 1,
                            OrdersId = 1,
                            Quantity = 7
                        },
                        new
                        {
                            OrderItemsId = 3,
                            MenuItemId = 2,
                            OrdersId = 2,
                            Quantity = 5
                        },
                        new
                        {
                            OrderItemsId = 4,
                            MenuItemId = 4,
                            OrdersId = 5,
                            Quantity = 2
                        },
                        new
                        {
                            OrderItemsId = 5,
                            MenuItemId = 5,
                            OrdersId = 3,
                            Quantity = 6
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.Orders", b =>
                {
                    b.Property<int>("OrdersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrdersId"));

                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReservationsId")
                        .HasColumnType("int");

                    b.Property<float>("TotalAmount")
                        .HasColumnType("real");

                    b.HasKey("OrdersId");

                    b.HasIndex("EmployeesId");

                    b.HasIndex("ReservationsId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrdersId = 1,
                            EmployeesId = 1,
                            OrderDate = new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4898),
                            ReservationsId = 4,
                            TotalAmount = 30f
                        },
                        new
                        {
                            OrdersId = 2,
                            EmployeesId = 2,
                            OrderDate = new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4901),
                            ReservationsId = 2,
                            TotalAmount = 20f
                        },
                        new
                        {
                            OrdersId = 3,
                            EmployeesId = 5,
                            OrderDate = new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4904),
                            ReservationsId = 5,
                            TotalAmount = 10f
                        },
                        new
                        {
                            OrdersId = 4,
                            EmployeesId = 3,
                            OrderDate = new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4906),
                            ReservationsId = 3,
                            TotalAmount = 15f
                        },
                        new
                        {
                            OrdersId = 5,
                            EmployeesId = 4,
                            OrderDate = new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4908),
                            ReservationsId = 1,
                            TotalAmount = 25f
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.Reservations", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.Property<int>("PartySize")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RestaurantsId")
                        .HasColumnType("int");

                    b.Property<int>("TablesId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("CustomersId");

                    b.HasIndex("RestaurantsId");

                    b.HasIndex("TablesId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            ReservationId = 1,
                            CustomersId = 2,
                            PartySize = 3,
                            ReservationDate = new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4813),
                            RestaurantsId = 5,
                            TablesId = 2
                        },
                        new
                        {
                            ReservationId = 2,
                            CustomersId = 4,
                            PartySize = 6,
                            ReservationDate = new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4868),
                            RestaurantsId = 4,
                            TablesId = 3
                        },
                        new
                        {
                            ReservationId = 3,
                            CustomersId = 5,
                            PartySize = 2,
                            ReservationDate = new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4871),
                            RestaurantsId = 3,
                            TablesId = 1
                        },
                        new
                        {
                            ReservationId = 4,
                            CustomersId = 3,
                            PartySize = 4,
                            ReservationDate = new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4874),
                            RestaurantsId = 2,
                            TablesId = 4
                        },
                        new
                        {
                            ReservationId = 5,
                            CustomersId = 1,
                            PartySize = 5,
                            ReservationDate = new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4877),
                            RestaurantsId = 1,
                            TablesId = 5
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.Restaurants", b =>
                {
                    b.Property<int>("RestaurantsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RestaurantsId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpeningHour")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantsId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RestaurantsId = 1,
                            Address = "sesimi street",
                            Name = "shawrma",
                            OpeningHour = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PhoneNumber = "0590033220"
                        },
                        new
                        {
                            RestaurantsId = 2,
                            Address = "nablus street",
                            Name = "ala kafak",
                            OpeningHour = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PhoneNumber = "0590044220"
                        },
                        new
                        {
                            RestaurantsId = 3,
                            Address = "rafedia street",
                            Name = "malaki",
                            OpeningHour = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PhoneNumber = "0590033670"
                        },
                        new
                        {
                            RestaurantsId = 4,
                            Address = "noway street",
                            Name = "aldeek",
                            OpeningHour = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PhoneNumber = "0590035670"
                        },
                        new
                        {
                            RestaurantsId = 5,
                            Address = "potato street",
                            Name = "potato",
                            OpeningHour = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PhoneNumber = "0590256678"
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.Tables", b =>
                {
                    b.Property<int>("TablesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TablesId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantsID")
                        .HasColumnType("int");

                    b.HasKey("TablesId");

                    b.HasIndex("RestaurantsID");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            TablesId = 1,
                            Capacity = 4,
                            RestaurantsID = 4
                        },
                        new
                        {
                            TablesId = 2,
                            Capacity = 3,
                            RestaurantsID = 5
                        },
                        new
                        {
                            TablesId = 3,
                            Capacity = 2,
                            RestaurantsID = 2
                        },
                        new
                        {
                            TablesId = 4,
                            Capacity = 5,
                            RestaurantsID = 1
                        },
                        new
                        {
                            TablesId = 5,
                            Capacity = 4,
                            RestaurantsID = 3
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.Employees", b =>
                {
                    b.HasOne("RestaurantReservation.Db.Restaurants", null)
                        .WithMany("Employees")
                        .HasForeignKey("RestaurantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantReservation.Db.MenuItem", b =>
                {
                    b.HasOne("RestaurantReservation.Db.Restaurants", null)
                        .WithMany("menuItems")
                        .HasForeignKey("RestaurantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantReservation.Db.OrderItems", b =>
                {
                    b.HasOne("RestaurantReservation.Db.MenuItem", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantReservation.Db.Orders", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantReservation.Db.Orders", b =>
                {
                    b.HasOne("RestaurantReservation.Db.Employees", null)
                        .WithMany("Orders")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantReservation.Db.Reservations", null)
                        .WithMany("Orders")
                        .HasForeignKey("ReservationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantReservation.Db.Reservations", b =>
                {
                    b.HasOne("RestaurantReservation.Db.Customers", null)
                        .WithMany("Reservations")
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantReservation.Db.Restaurants", null)
                        .WithMany("Reservations")
                        .HasForeignKey("RestaurantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantReservation.Db.Tables", null)
                        .WithMany("Reservations")
                        .HasForeignKey("TablesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantReservation.Db.Tables", b =>
                {
                    b.HasOne("RestaurantReservation.Db.Restaurants", null)
                        .WithMany("Tables")
                        .HasForeignKey("RestaurantsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantReservation.Db.Customers", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Employees", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RestaurantReservation.Db.MenuItem", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Orders", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Reservations", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Restaurants", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Reservations");

                    b.Navigation("Tables");

                    b.Navigation("menuItems");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Tables", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
