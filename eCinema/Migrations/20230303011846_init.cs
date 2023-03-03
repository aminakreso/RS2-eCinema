using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCinema.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    ReleaseYear = table.Column<int>(type: "int", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HallId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seats_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Projections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HallId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PriceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateMachine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projections_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Projections_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Projections_Prices_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Prices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LozinkaHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NotificationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Projections_ProjectionId",
                        column: x => x.ProjectionId,
                        principalTable: "Projections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StripePaymentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeatReservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsTaken = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeatReservations_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeatReservations_Seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2269b63d-3d2b-404a-a322-8a855aa5cd69"), "Hall 1" },
                    { new Guid("61200b16-64a0-452e-827d-4860a8d0c761"), "Hall 4" },
                    { new Guid("6a3437ba-36a6-40af-b8ea-a6682762a959"), "Hall 5" },
                    { new Guid("b5462f22-4f78-46fe-96a0-3dc4629ecbd8"), "Hall 2" },
                    { new Guid("c932e702-ba23-4d05-97f9-166796c02e37"), "Hall 3" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Country", "Description", "Director", "Duration", "Genres", "IsActive", "Name", "Picture", "ReleaseYear" },
                values: new object[] { new Guid("f09d18f8-4f14-4ac4-8f34-1a282847e405"), "Ima", "SAD", "Lol", "Ima", 202, null, true, "Avatar", null, 2010 });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("97724e3b-882e-40aa-b779-544742c9bf85"), "Vecernja projekcija", 7m },
                    { new Guid("f5221040-1881-4276-85e7-64e0f6505f2a"), "Vikend projekcija", 8m },
                    { new Guid("f9de5860-2c1a-489b-b084-c543604f0ee8"), "Dnevna projekcija", 6m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9addaa3c-849d-490b-9884-5c12ce9992c7"), "Admin" },
                    { new Guid("f7805ca2-3cf2-4949-a978-88cd99c0e8e5"), "User" }
                });

            migrationBuilder.InsertData(
                table: "Projections",
                columns: new[] { "Id", "EndTime", "HallId", "IsActive", "MovieId", "PriceId", "ProjectionType", "StartTime", "StateMachine", "Status" },
                values: new object[] { new Guid("9b0a4cfe-d5af-4584-9c0c-78e2dc99aaaf"), new DateTime(2023, 3, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), new Guid("2269b63d-3d2b-404a-a322-8a855aa5cd69"), true, new Guid("f09d18f8-4f14-4ac4-8f34-1a282847e405"), new Guid("f9de5860-2c1a-489b-b084-c543604f0ee8"), "Late", new DateTime(2023, 3, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Draft", "Active" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CustomerId", "Email", "FirstName", "IsActive", "LastName", "LozinkaHash", "LozinkaSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[] { new Guid("17e37dd8-762f-4a3f-bf62-ab7f7bdcce34"), null, "admin@gmail.com", "Admin", null, "Admin", "BKSmCy4KJqiqWsp+Bdg3gnGgmZ8=", "VrmMBT9khwJUY2enGHTFgw==", null, new Guid("9addaa3c-849d-490b-9884-5c12ce9992c7"), "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CustomerId", "Email", "FirstName", "IsActive", "LastName", "LozinkaHash", "LozinkaSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[] { new Guid("d34c38bd-1a61-4287-9bd5-c3a97bbcd28e"), null, "user@gmail.com", "User", null, "User", "DvCd6WPxkYVublhpeX1tWgDuseQ=", "jyxqW/wzSLFp48iJ5AtrsA==", null, new Guid("9addaa3c-849d-490b-9884-5c12ce9992c7"), "user" });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_AuthorId",
                table: "Notifications",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ReservationId",
                table: "Payments",
                column: "ReservationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projections_HallId",
                table: "Projections",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_Projections_MovieId",
                table: "Projections",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Projections_PriceId",
                table: "Projections",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ProjectionId",
                table: "Reservations",
                column: "ProjectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatReservations_ReservationId",
                table: "SeatReservations",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatReservations_SeatId",
                table: "SeatReservations",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_HallId",
                table: "Seats",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "SeatReservations");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Projections");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
