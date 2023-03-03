using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCinema.Migrations
{
    public partial class renameContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("3248dfa8-fe3d-49f8-897d-e15591b634b1"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("462dd58b-59fb-47cc-8519-54f172976e9a"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("6457b6c7-b1d7-4046-93de-0bffcf095b9d"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("899db9f3-f42f-48a5-b24f-93f1b9b55ca4"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("8eca5d7a-57c5-474d-8b77-192406ffc315"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("d774fa8d-a39e-4379-95c4-6e582d2c197b"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("a0f237ba-125d-4175-96d9-f2852042832b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("483e8b0c-8869-4ca2-aedf-686cb2b49f2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82466f1d-90fe-436d-9f9b-90a348cb47cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f63e71e9-1042-4fc4-8365-546a2a7accbd"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("ce25d69d-9fb6-48ec-94ae-31077ea7bbc2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("75f5422f-fa84-4722-976c-899c1131f43f"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("00b85b2b-19cf-40db-817d-0eb32c185127"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ad0efa21-a57d-4dbe-bc64-3a1e5e2c216c"));

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Notifications",
                newName: "Description");

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("58de40f5-6d1f-4354-b1d8-6bb231f08937"), "Hall 4" },
                    { new Guid("60078146-c136-4659-a5e1-535f29c16c6e"), "Hall 5" },
                    { new Guid("b435902d-ba5c-426e-ad15-6f8b6f223296"), "Hall 1" },
                    { new Guid("d54f78ba-5813-4c13-9a05-6706e2c375b9"), "Hall 3" },
                    { new Guid("eab9738b-3885-4213-ac13-16fd146cd0af"), "Hall 2" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Country", "Description", "Director", "Duration", "Genres", "IsActive", "Name", "Picture", "ReleaseYear" },
                values: new object[] { new Guid("364fb6c4-d645-454d-92d8-27565fc9c23b"), "Ima", "SAD", "Lol", "Ima", 202, null, true, "Avatar", null, 2010 });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("4b9508c4-2642-4328-95b5-53b27ea37ee2"), "Vecernja projekcija", 7m },
                    { new Guid("999b4640-52a8-4c97-8a74-fe10e0d5f5a1"), "Vikend projekcija", 8m },
                    { new Guid("c4acf3cc-58f2-410c-8d98-c35f510a8fba"), "Dnevna projekcija", 6m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2eb051c4-eb1a-4231-9dcd-663fdb07cf6d"), "Admin" },
                    { new Guid("8e77c320-7043-4c37-a2e5-863a7863aad2"), "User" }
                });

            migrationBuilder.InsertData(
                table: "Projections",
                columns: new[] { "Id", "EndTime", "HallId", "IsActive", "MovieId", "PriceId", "ProjectionType", "StartTime", "StateMachine", "Status" },
                values: new object[] { new Guid("f0ea32bb-9717-463f-958b-e5c6eb1caaab"), new DateTime(2023, 3, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), new Guid("b435902d-ba5c-426e-ad15-6f8b6f223296"), true, new Guid("364fb6c4-d645-454d-92d8-27565fc9c23b"), new Guid("c4acf3cc-58f2-410c-8d98-c35f510a8fba"), "Late", new DateTime(2023, 3, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Draft", "Active" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CustomerId", "Email", "FirstName", "IsActive", "LastName", "LozinkaHash", "LozinkaSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[] { new Guid("089782f3-710f-4f40-84d1-0b99623e7985"), null, "admin@gmail.com", "Admin", null, "Admin", "J526znSJHRceO6peTbt4Bl8IADc=", "Yr48w5vI11uid1EdDngyNg==", null, new Guid("2eb051c4-eb1a-4231-9dcd-663fdb07cf6d"), "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CustomerId", "Email", "FirstName", "IsActive", "LastName", "LozinkaHash", "LozinkaSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[] { new Guid("d80dacb7-e410-4acc-b923-943e2f3078cf"), null, "user@gmail.com", "User", null, "User", "6glWKRVrKKpVlIiiVY3hiwaoWpQ=", "HUcmPdVRWNqbzW0uHG//1w==", null, new Guid("2eb051c4-eb1a-4231-9dcd-663fdb07cf6d"), "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("58de40f5-6d1f-4354-b1d8-6bb231f08937"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("60078146-c136-4659-a5e1-535f29c16c6e"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("d54f78ba-5813-4c13-9a05-6706e2c375b9"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("eab9738b-3885-4213-ac13-16fd146cd0af"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("4b9508c4-2642-4328-95b5-53b27ea37ee2"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("999b4640-52a8-4c97-8a74-fe10e0d5f5a1"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("f0ea32bb-9717-463f-958b-e5c6eb1caaab"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e77c320-7043-4c37-a2e5-863a7863aad2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("089782f3-710f-4f40-84d1-0b99623e7985"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d80dacb7-e410-4acc-b923-943e2f3078cf"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("b435902d-ba5c-426e-ad15-6f8b6f223296"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("364fb6c4-d645-454d-92d8-27565fc9c23b"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("c4acf3cc-58f2-410c-8d98-c35f510a8fba"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2eb051c4-eb1a-4231-9dcd-663fdb07cf6d"));

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Notifications",
                newName: "Content");

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3248dfa8-fe3d-49f8-897d-e15591b634b1"), "Hall 3" },
                    { new Guid("462dd58b-59fb-47cc-8519-54f172976e9a"), "Hall 5" },
                    { new Guid("6457b6c7-b1d7-4046-93de-0bffcf095b9d"), "Hall 2" },
                    { new Guid("899db9f3-f42f-48a5-b24f-93f1b9b55ca4"), "Hall 4" },
                    { new Guid("ce25d69d-9fb6-48ec-94ae-31077ea7bbc2"), "Hall 1" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Country", "Description", "Director", "Duration", "Genres", "IsActive", "Name", "Picture", "ReleaseYear" },
                values: new object[] { new Guid("75f5422f-fa84-4722-976c-899c1131f43f"), "Ima", "SAD", "Lol", "Ima", 202, null, true, "Avatar", null, 2010 });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("00b85b2b-19cf-40db-817d-0eb32c185127"), "Dnevna projekcija", 6m },
                    { new Guid("8eca5d7a-57c5-474d-8b77-192406ffc315"), "Vecernja projekcija", 7m },
                    { new Guid("d774fa8d-a39e-4379-95c4-6e582d2c197b"), "Vikend projekcija", 8m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("483e8b0c-8869-4ca2-aedf-686cb2b49f2f"), "User" },
                    { new Guid("ad0efa21-a57d-4dbe-bc64-3a1e5e2c216c"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Projections",
                columns: new[] { "Id", "EndTime", "HallId", "IsActive", "MovieId", "PriceId", "ProjectionType", "StartTime", "StateMachine", "Status" },
                values: new object[] { new Guid("a0f237ba-125d-4175-96d9-f2852042832b"), new DateTime(2023, 3, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), new Guid("ce25d69d-9fb6-48ec-94ae-31077ea7bbc2"), true, new Guid("75f5422f-fa84-4722-976c-899c1131f43f"), new Guid("00b85b2b-19cf-40db-817d-0eb32c185127"), "Late", new DateTime(2023, 3, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Draft", "Active" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CustomerId", "Email", "FirstName", "IsActive", "LastName", "LozinkaHash", "LozinkaSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[] { new Guid("82466f1d-90fe-436d-9f9b-90a348cb47cd"), null, "admin@gmail.com", "Admin", null, "Admin", "EmZVx61PusqHliSUpr6bjrwvOQg=", "zT5SasrEKMkOPWMCUmxslg==", null, new Guid("ad0efa21-a57d-4dbe-bc64-3a1e5e2c216c"), "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CustomerId", "Email", "FirstName", "IsActive", "LastName", "LozinkaHash", "LozinkaSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[] { new Guid("f63e71e9-1042-4fc4-8365-546a2a7accbd"), null, "user@gmail.com", "User", null, "User", "yYaGh4FqcKZrr6IzMqzMISLM8o4=", "iI4H54IXJF+JQn7soTYytg==", null, new Guid("ad0efa21-a57d-4dbe-bc64-3a1e5e2c216c"), "user" });
        }
    }
}
