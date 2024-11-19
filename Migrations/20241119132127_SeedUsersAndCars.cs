using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersAndCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Cars_CarId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.RenameTable(
                name: "Reservations",
                newName: "Reservation");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_UserId",
                table: "Reservation",
                newName: "IX_Reservation_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_CarId",
                table: "Reservation",
                newName: "IX_Reservation_CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                column: "ReservationId");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "Description", "IsAvailable", "Make", "Model", "PricePerDay", "Year" },
                values: new object[,]
                {
                    { 1, "A reliable and fuel-efficient sedan.", true, "Toyota", "Camry", 50.00m, 2020 },
                    { 2, "A compact car with great performance.", true, "Honda", "Civic", 55.00m, 2021 },
                    { 3, "A sporty and modern car with advanced features.", false, "Ford", "Focus", 60.00m, 2022 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AddressLine1", "AddressLine2", "City", "ConfirmPassword", "CountryId", "DateOfBirth", "DriversLicenseNumber", "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "123 Main St", "Apt 4B", "New York", "password123", 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "D1234567890", "johndoe@example.com", "John", "Doe", "password123", "1234567890" },
                    { 2, "456 Elm St", "", "Toronto", "password456", 2, new DateTime(1992, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "D9876543210", "janesmith@example.com", "Jane", "Smith", "password456", "0987654321" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Cars_CarId",
                table: "Reservation",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Users_UserId",
                table: "Reservation",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Cars_CarId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Users_UserId",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "Reservations");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_UserId",
                table: "Reservations",
                newName: "IX_Reservations_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_CarId",
                table: "Reservations",
                newName: "IX_Reservations_CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Cars_CarId",
                table: "Reservations",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
