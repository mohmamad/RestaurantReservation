using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "MenuItems",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomersId", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "asd@gmail.com", "mohamad", "moghrabi", "0564235698" },
                    { 2, "hamza@gmail.com", "hamza", "makhlof", "0594235698" },
                    { 3, "ahmed@gmail.com", "ahmed", "hamdan", "0564275698" },
                    { 4, "ramiz@gmail.com", "ramiz", "saleh", "0564235321" },
                    { 5, "sodki@gmail.com", "sodki", "saleh", "0564232198" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantsId", "Address", "Name", "OpeningHour", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "sesimi street", "shawrma", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0590033220" },
                    { 2, "nablus street", "ala kafak", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0590044220" },
                    { 3, "rafedia street", "malaki", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0590033670" },
                    { 4, "noway street", "aldeek", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0590035670" },
                    { 5, "potato street", "potato", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0590256678" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeesId", "FirstName", "LastName", "Position", "RestaurantsId" },
                values: new object[,]
                {
                    { 1, "mohamad", "ahmed", "waitres", 1 },
                    { 2, "ahmed", "hamdi", "manager", 3 },
                    { 3, "roa", "rmzi", "waitres", 5 },
                    { 4, "sami", "mohamad", "waitres", 2 },
                    { 5, "lara", "sodki", "waitres", 4 }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "ItemId", "Description", "Name", "Price", "RestaurantsId" },
                values: new object[,]
                {
                    { 1, "fried potato", "potato", 6f, 3 },
                    { 2, "tomato soap", "soap", 6f, 1 },
                    { 3, "fried chicken", "chicken", 6f, 2 },
                    { 4, "beef steak", "steak", 6f, 5 },
                    { 5, "falafel", "falafel", 6f, 4 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TablesId", "Capacity", "RestaurantsID" },
                values: new object[,]
                {
                    { 1, 4, 4 },
                    { 2, 3, 5 },
                    { 3, 2, 2 },
                    { 4, 5, 1 },
                    { 5, 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "CustomersId", "PartySize", "ReservationDate", "RestaurantsId", "TablesId" },
                values: new object[,]
                {
                    { 1, 2, 3, new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4813), 5, 2 },
                    { 2, 4, 6, new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4868), 4, 3 },
                    { 3, 5, 2, new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4871), 3, 1 },
                    { 4, 3, 4, new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4874), 2, 4 },
                    { 5, 1, 5, new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4877), 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrdersId", "EmployeesId", "OrderDate", "ReservationsId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4898), 4, 30f },
                    { 2, 2, new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4901), 2, 20f },
                    { 3, 5, new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4904), 5, 10f },
                    { 4, 3, new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4906), 3, 15f },
                    { 5, 4, new DateTime(2023, 10, 22, 4, 1, 5, 923, DateTimeKind.Local).AddTicks(4908), 1, 25f }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemsId", "MenuItemId", "OrdersId", "Quantity" },
                values: new object[,]
                {
                    { 1, 3, 4, 3 },
                    { 2, 1, 1, 7 },
                    { 3, 2, 2, 5 },
                    { 4, 4, 5, 2 },
                    { 5, 5, 3, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemsId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "ItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "ItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeesId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeesId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomersId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomersId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomersId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomersId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomersId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TablesId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TablesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TablesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TablesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TablesId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantsId",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "MenuItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
