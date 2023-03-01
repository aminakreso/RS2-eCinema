using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCinema.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("2228948f-8db9-4fb9-ad09-4ae447cff235"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("8b5e4919-1100-4eb9-8190-578c06d40ece"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("a0a2271b-f838-48eb-90fa-80ba7e2dc498"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("fbade7d8-866c-4a80-b906-21ae4d2af2c9"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("30f50005-8f11-4d00-a55e-f8d2eb3df947"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("4d27e5a8-17ae-40bb-b9e4-ae7c5b16204b"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("b7f1947b-8c15-4568-bcc7-e64497b6f0f4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("05c8d129-9e50-4a01-a967-b7d36d001c21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0065eddb-0626-4781-ad2a-962e7dd96300"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac52f3fd-1840-4f95-8523-04e9d6d8f20d"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("e877931d-85e9-4262-b512-addad097ddec"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b7f1947b-8c15-4568-bcc7-e64497b6f0f4"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("778328b7-7b1c-4698-aa26-3730a6aaa50a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c4f865ea-1a98-41e6-a5c3-3eb6777266a3"));

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1880b6e1-31a3-4f71-9399-41be26560728"), "Hall 2" },
                    { new Guid("23a4000b-554d-4401-b4b3-16d33e46b7d2"), "Hall 4" },
                    { new Guid("dba588e4-b2a1-4e83-aa71-5e92da1a4c11"), "Hall 3" },
                    { new Guid("e9695c6b-61f4-4eae-b580-496c7e58cdf6"), "Hall 1" },
                    { new Guid("fc9c3d5e-f19f-4e74-9902-0fdace6da2a1"), "Hall 5" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Country", "Description", "Director", "Duration", "Genres", "IsActive", "Name", "Picture", "ReleaseYear" },
                values: new object[] { new Guid("1299c09b-5af0-40cb-add2-c0c5ea5ba263"), "Ima", "SAD", "Lol", "Ima", 202, null, true, "Avatar", null, 2010 });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("7b3ac61e-7607-4a7f-989a-48353f2e164b"), "Dnevna projekcija", 6m },
                    { new Guid("9d83b36d-7963-490c-ba08-12bb1929061f"), "Vecernja projekcija", 7m },
                    { new Guid("e543e0af-7c51-4ebc-896e-45e5ba29f901"), "Vikend projekcija", 8m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7ba66fcc-69b4-465e-8ad4-4f7d1a7b1788"), "User" },
                    { new Guid("c7929358-eb84-41fe-99a1-6fb4bcfa05f1"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Projections",
                columns: new[] { "Id", "EndTime", "HallId", "IsActive", "MovieId", "PriceId", "ProjectionType", "StartTime", "StateMachine", "Status" },
                values: new object[] { new Guid("3dd8940d-28bf-4e08-9c2f-c2821e13e3eb"), new DateTime(2023, 3, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), new Guid("e9695c6b-61f4-4eae-b580-496c7e58cdf6"), true, new Guid("1299c09b-5af0-40cb-add2-c0c5ea5ba263"), new Guid("7b3ac61e-7607-4a7f-989a-48353f2e164b"), "Late", new DateTime(2023, 3, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Draft", "Active" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CustomerId", "Email", "FirstName", "IsActive", "LastName", "LozinkaHash", "LozinkaSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[] { new Guid("1a5a5f90-f2ff-4ca6-a59e-a6b223615576"), null, "user@gmail.com", "User", null, "User", "5G6ZjbQa7mUf6K4GGNJ5fNQu4jQ=", "fG4FKgLCM5NwcahfwC8TvQ==", null, new Guid("c7929358-eb84-41fe-99a1-6fb4bcfa05f1"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CustomerId", "Email", "FirstName", "IsActive", "LastName", "LozinkaHash", "LozinkaSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[] { new Guid("46f58fbf-05cb-442d-9068-976e85a9f71c"), null, "admin@gmail.com", "Admin", null, "Admin", "wj2WOMkGZ1GPUfUvCcGMI0tS97g=", "40gdSB57aPiD7SX3Aq66WA==", null, new Guid("c7929358-eb84-41fe-99a1-6fb4bcfa05f1"), "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("1880b6e1-31a3-4f71-9399-41be26560728"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("23a4000b-554d-4401-b4b3-16d33e46b7d2"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("dba588e4-b2a1-4e83-aa71-5e92da1a4c11"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("fc9c3d5e-f19f-4e74-9902-0fdace6da2a1"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("9d83b36d-7963-490c-ba08-12bb1929061f"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("e543e0af-7c51-4ebc-896e-45e5ba29f901"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("3dd8940d-28bf-4e08-9c2f-c2821e13e3eb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7ba66fcc-69b4-465e-8ad4-4f7d1a7b1788"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a5a5f90-f2ff-4ca6-a59e-a6b223615576"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46f58fbf-05cb-442d-9068-976e85a9f71c"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("e9695c6b-61f4-4eae-b580-496c7e58cdf6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1299c09b-5af0-40cb-add2-c0c5ea5ba263"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("7b3ac61e-7607-4a7f-989a-48353f2e164b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c7929358-eb84-41fe-99a1-6fb4bcfa05f1"));

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2228948f-8db9-4fb9-ad09-4ae447cff235"), "Hall 5" },
                    { new Guid("8b5e4919-1100-4eb9-8190-578c06d40ece"), "Hall 4" },
                    { new Guid("a0a2271b-f838-48eb-90fa-80ba7e2dc498"), "Hall 2" },
                    { new Guid("e877931d-85e9-4262-b512-addad097ddec"), "Hall 1" },
                    { new Guid("fbade7d8-866c-4a80-b906-21ae4d2af2c9"), "Hall 3" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Country", "Description", "Director", "Duration", "Genres", "IsActive", "Name", "Picture", "ReleaseYear" },
                values: new object[] { new Guid("b7f1947b-8c15-4568-bcc7-e64497b6f0f4"), "Ima", "SAD", "Lol", "Ima", 202, null, true, "Avatar", null, 2010 });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("30f50005-8f11-4d00-a55e-f8d2eb3df947"), "Vikend projekcija", 8m },
                    { new Guid("4d27e5a8-17ae-40bb-b9e4-ae7c5b16204b"), "Vecernja projekcija", 7m },
                    { new Guid("778328b7-7b1c-4698-aa26-3730a6aaa50a"), "Dnevna projekcija", 6m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("05c8d129-9e50-4a01-a967-b7d36d001c21"), "User" },
                    { new Guid("c4f865ea-1a98-41e6-a5c3-3eb6777266a3"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Projections",
                columns: new[] { "Id", "EndTime", "HallId", "IsActive", "MovieId", "PriceId", "ProjectionType", "StartTime", "StateMachine", "Status" },
                values: new object[] { new Guid("b7f1947b-8c15-4568-bcc7-e64497b6f0f4"), new DateTime(2023, 3, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), new Guid("e877931d-85e9-4262-b512-addad097ddec"), true, new Guid("b7f1947b-8c15-4568-bcc7-e64497b6f0f4"), new Guid("778328b7-7b1c-4698-aa26-3730a6aaa50a"), "Late", new DateTime(2023, 3, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Draft", "Active" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CustomerId", "Email", "FirstName", "IsActive", "LastName", "LozinkaHash", "LozinkaSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[] { new Guid("0065eddb-0626-4781-ad2a-962e7dd96300"), null, "admin@gmail.com", "Admin", null, "Admin", "VBVBdtAdFdepvlEaPoX1sgnlXIU=", "0MFgN+2zYowvUYfnI5zIJg==", null, new Guid("c4f865ea-1a98-41e6-a5c3-3eb6777266a3"), "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CustomerId", "Email", "FirstName", "IsActive", "LastName", "LozinkaHash", "LozinkaSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[] { new Guid("ac52f3fd-1840-4f95-8523-04e9d6d8f20d"), null, "user@gmail.com", "User", null, "User", "yd/PcCvRbx832JBnZAaOjwsXv9U=", "THqek75T5hCXQtBTy7ajEw==", null, new Guid("c4f865ea-1a98-41e6-a5c3-3eb6777266a3"), "user" });
        }
    }
}
