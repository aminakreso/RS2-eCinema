﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCinema.Migrations
{
    public partial class userRoleMigrationFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("1d6afdd1-aa90-4d75-ac49-a259b80da5a0"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("4e3b258c-85e6-4a9e-b265-c0893671f2e0"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("6eba16cc-94a8-4bcf-a1ae-62686cd2dbf6"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("08b33276-70f8-4359-af5e-1ef5fe93dd1d"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("275165a2-390a-46ac-b2c4-474fb234a959"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("290ea445-5cf1-4238-ab29-741cec47cd57"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("306f1ffd-845d-4d0c-8bb2-1cf8610f1e06"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("37f13a82-949f-44fb-a8fb-7265e626c6a9"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("44812a9b-40ef-48e8-8109-4afb6d7501af"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("5341c14a-f139-4a07-b9af-a67c326dbadb"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("5b32c8b9-c4df-4f8f-aa33-2340d8edda56"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("5f252452-2196-48b1-ad61-5ef263750248"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("70fba6a5-d183-4647-a8fd-10704893433d"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("736ea45b-8f77-41ad-9063-f3bb7d302cd3"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("8b1b16d8-25b1-429f-b825-e55335fd185a"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("9b7fc596-a548-422c-a420-c611341842d7"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("9eff2b34-db53-47fa-8028-e9c1e9d41fa8"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("a4b573b1-092f-4e75-9227-3fc25b3e2c56"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("a61941ff-a85e-4457-866b-06fcd66cfedd"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("b289cdf1-2372-480b-a60f-1ff272ede29b"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("c6597743-9eff-4544-b947-2b69417aea4c"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("cb26ae8b-74c5-44a5-9fe5-6c328e602412"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("e0d85c7d-d384-45cf-9a35-291a3d1ae4ca"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("e9098413-af75-4e55-99f8-8b9be65622a4"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("f1e97317-0be3-470b-8d05-f4703852505c"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("6d9a93b2-89e5-481d-876f-56b3d0a17478"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c4724d5c-38b9-4124-a06d-54eb62607e82"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("0df6fa05-9463-40b5-bc55-9a06804725da"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("13547568-51b6-4254-bde4-404fd4c72900"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("150a78e3-e085-41b9-85f0-068666f89326"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("2c458291-117b-41bd-a9f2-25464ae24547"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("2f4278b8-084c-480d-86b5-c9f1d7fea55e"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("37cef1e0-098f-4788-b708-77e19b09049c"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("4079fb17-3765-4b8b-bff1-bf27d72e3269"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("43afd2b4-cf9e-4c93-9c9c-1266bc656029"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("4cb29952-80d7-498b-bd7e-785d58d56e0f"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("4f3a38eb-9c32-4c27-b7b5-2a7ea2ad0cf9"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("63a22d59-26d3-46a2-91b8-d2d2564941b9"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("6cc23e03-9406-42d8-8417-30d97f988aeb"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("6e1b456f-3403-4c00-a85a-876fbc2d51d8"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("6f25c1bb-6928-4c90-9044-b9f05c276eeb"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("82e07a5a-4a13-4501-bfcb-3f5a57f97e23"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("8865cefa-fbf4-44cc-800e-4fdfc7065711"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("89481f7d-5daf-4f02-adc0-d985f44c6aa8"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("8c015deb-f5a9-476b-acea-78a1c1040341"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("9109e0f8-b930-4def-8eb9-6ce93ca6a44e"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("977b98a8-924e-4a2d-b29c-cd8edcf4aae9"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("9b9e848f-346f-4535-85dc-3b9eb3d3b5be"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("a80ba98c-ddeb-403c-b86f-8b9114d45b81"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("a8827940-45af-4f61-aa1b-c7228c8b1c97"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("a8c19546-60a9-4894-8ed3-f1718d1ddcf0"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("ab0952eb-e818-408c-a623-f36234724d34"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("b3a79afc-70db-4d09-8151-2810a47ea848"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("ccb60dd2-7561-4896-876c-064ee88dff95"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("d0e2e822-b733-404a-a7ab-0ba31d70d725"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("d80d911b-2f38-4902-b049-794553201866"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("e1a027a4-c340-4313-98f5-346448246663"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("e2823a91-2b85-4535-8f37-152765330781"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("eaba5668-4ccb-4a0a-8c01-1ef2542455fe"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("eafc027a-4c0e-4087-95ea-ade36f88487b"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("ed69d0db-591b-4dff-9d79-dc1935e117ac"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("ef2fb245-5d21-4c94-9743-ca1f86d382df"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("ef3dc20a-daaa-4a8b-ae33-0ca2d1566611"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("f1356d0d-55e8-41b7-b7eb-2ef14aca15ab"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("f835d54b-6e7f-44dc-89b3-dac935da0237"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("f89a67c5-7aea-4750-bd10-cf9f11ff864e"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("ff91c737-2987-43ec-ade8-47867c38ae1a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1033ffae-94b0-458a-9d72-ea804feda152"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("174c0b85-7f39-49e6-9ab3-82777503ee29"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1b8b72d0-2c2a-4400-8eaa-61e712a76018"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1d58cc10-d97d-49bb-8efd-50dc5c44bc7e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("20a2ac77-8459-46c7-bbaa-4e86f666fc47"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("249756b0-df5c-4ffb-a7b3-32fedf70b84a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("29966b8c-d6ab-4f37-8c24-81f24b54cb8c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("30477a37-d5a2-4fb2-83f3-2d5d18dd99a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("331683b7-de99-447d-bd67-ff3b926d2ce7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("33278bae-dd5d-4a67-99ff-c7519805e75f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("364b6305-1d24-4e61-9dc1-c00b1e8f4710"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3aa1a9b6-de1e-42c2-b8c8-090e32cb7b57"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3aa84e02-1b27-47b4-849a-16c190bb4432"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("403f0100-dfb7-4af8-a399-134ecb66a4c8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4e60fceb-276b-44bb-8e95-3188d71e9cd4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("598d35c7-6e7a-4c42-9da2-aede7c99f267"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5d8a354f-ff59-4968-9167-99d636574f44"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f65b725-175f-4c5f-a1da-0c52dc936318"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("634440dd-888e-44d9-b4bb-d4477982faca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6782d89f-aaaf-4a56-8550-cce52ed7d44b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("67a556ab-82bc-496e-988a-3cd2853f703b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6844dc5d-4e2d-4bcb-813b-29f023b8ef01"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("75a1d3b3-cf70-4c30-9ecb-ab8c74392d9b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7a4fc300-260f-490a-b826-6f678eaecbb7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7aa964f4-1a49-421c-b9e3-cf7ff6968136"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7dd0b9b0-69b1-4c25-834f-a63d7e94c8f0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("83ff7ab9-d126-449e-aade-ed00653b1629"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("845829b6-431b-46b2-8b0c-d97b8383da70"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("86aa1b91-686b-4cfd-b154-524d6b8cd6f0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("87521de9-cd0f-4313-a70a-8413f6e9b0f4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("92dc89cb-7cdb-4359-ac68-b82cc0ea05b3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9e4c98e6-dedf-4a49-a00a-77dfdcd74c60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a19f2e7f-7439-4c98-94f3-d6f2f9b57c84"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a54c5b5a-916e-4068-bfd7-c01d6b1a3d16"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a5ad1211-5b31-469d-b98e-77ff1c241ba2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aaad1a9f-b831-4474-a8a4-b36e3e6a3ae9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ac23c91d-1361-4f60-a7ca-7cce9e9e3c12"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b3050775-329d-4326-8934-b5d3ca91eaa0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b69552f4-30d9-46de-be0f-d3dc493d5016"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b9fabe57-ac7a-44ba-8476-f3b7b23dc1ae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bbf35135-a5ef-4c96-8ae8-dcd108cdca98"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bc880064-28ec-44b3-96a8-2a943ffcfa72"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c0af86f0-f54c-45a9-bcab-de7db5cfb8e7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2ba9d73-df65-48c8-94fe-a4394dee93f1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c52f8ab4-d33a-43c5-b225-8841a02ba4b8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c629ec67-732e-4796-8c57-a43fafec1eca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7e0bbfd-7554-48bb-a240-657338dcf0a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cae51a41-ccb5-42e2-b3fe-4fe0673ab7cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d3467857-1557-44b1-9f22-6af9b762bd95"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da2c86af-8676-433c-93d4-6e65723bf6ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dabc1f88-50f2-4b33-a30a-8e621d770efe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e4ad5923-62c5-4215-8378-b4649cbf01e8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ea225f4b-4a2d-486b-b940-2b178d97a537"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f01d41ec-c612-4d44-9c77-7a5b16e139b8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f0fe48e9-86cd-477d-8398-a4300bf4b470"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f14414c6-a2ad-4ed2-ac40-51ef0ee67c7d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f363cb49-4134-452b-a6d3-06d63d5f8e07"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f5f88765-463e-4897-9815-46a5ee085dbb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fc99de05-2eb7-4f62-bd25-3d86d956889c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ff4d2cee-138b-495d-81cc-cfcbcfd55fab"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("09aeb923-8f2d-44ed-b24d-b48434cce049"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("192d87a6-2421-45a0-8edb-bc049e1bb8a6"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("228f150c-f920-4bd3-9aa3-f10f08c99663"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2b31c844-1506-4ec3-b2f5-b0d9fddd73fc"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("365f2e8d-f7a1-4444-8db8-8c58231c4bb1"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("552d500e-c57d-4513-893f-a3f64205e70a"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("616611a5-21ae-4634-94b4-82912199a9fa"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("6cc6418a-fdce-424b-ae5c-8339b027ee97"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("740ea0e0-41ca-4965-bc35-8a6408f077af"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("766d5915-1e08-49f7-bb43-7cb65b8ab996"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("835e86c4-902c-495d-8986-fe7a3eb068b0"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("8925ba7a-09fb-4a1b-9e3c-6a44a3bdd827"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("959f86ab-ebff-414c-9dc4-8496e69368cc"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("9efe89a0-bb30-4368-b4dd-8ee7de95acc2"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("a29ffaca-4571-4e0b-b651-f905c90515ea"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("a47aafcf-7639-443f-8e84-5e2efae0d27d"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ac9145c7-c368-4d80-a93b-c4f83d09eaeb"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("af868671-4e22-4bad-9b79-f6112418fb07"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("c0a09475-3173-40eb-bc87-51cbb0b639c8"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("c3ba2f42-9e6d-47aa-93f2-2bf5dc838190"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("cbab20aa-edc8-4ffa-86e4-ac5d6a0f0b96"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("f718bf63-8a5a-4253-9bd5-801b256a2949"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("055238a8-4888-4d8e-bce4-ec90be680b8e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0caaff76-7ccc-41bb-9d9b-734fd2ad2827"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d549b84-83f9-4d20-9da9-65370b968dcb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d94fb5c-1f1a-4fa3-b1c4-a1ff71ce95b8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1342d65d-611f-4afd-9a4e-ab8b7db50dec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("14752418-ec08-489e-8656-ef54e6cb2991"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1e16ca1c-7545-4318-aab1-260975280f39"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1ff4c441-6029-4833-b31a-3d82eb5eb71f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b6f1d0a-5c8d-4c1b-904f-ad59e36f018d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b72c3c9-d626-4d95-9ec3-493994e0f47c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2dd168e4-e2ac-4470-bcaf-dc3cc047ac74"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("35b9d43c-c1dd-4da3-af40-584225214c8e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c666582-22fd-4161-9a9d-c2a26697e50f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("41a3408d-c4d3-47c8-b2b5-2a6bd6eb2ed6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5542e314-4504-4943-b67d-83b6582bc02b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5be8cd33-597c-4f02-a6e0-49a147a0a830"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5d8449b7-3610-4eae-96bc-3a1c6f98716a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("612c2066-1ecb-4b33-a723-54dd105b602a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6cf96063-dc29-41f7-8e05-830bba21462c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("787dc146-4128-472b-82b3-9005ab28f2d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8a99e99d-5f05-46b0-8ca3-0f23902a7506"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a6accafd-4d56-4890-a6a6-89af450bc566"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b05a968c-f9b0-42f8-84cc-f7327bba26f8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b0a6407a-6da1-444c-9246-d3beecfaed0e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b0cc744f-7976-499b-a797-3e61547e7d8e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b931ab61-ee95-441d-b3c7-bbbf97e5359a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2754c58-32bd-4594-a469-24900a6340b0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("db421cc6-2d98-41bf-ba89-62910316a3a5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("df2e6131-bb1f-4a1a-bb7a-c3686066c1f6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e990ef43-b4a5-4333-90b0-dd25c0448367"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e9c59ed5-03fa-45a0-86dd-d5e3b826f08c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ec78fd21-22f5-441f-bfe9-02d0c93c3255"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed22f82a-bd2b-4d2e-95b4-8475dc6b94d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed4b6868-e79f-4cd3-a373-e139978ab437"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ee93e6f9-9fc6-45da-b489-76571d9ed11b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f2148edc-3e78-4326-a888-7b61caf7e917"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f7653960-b2fb-46fc-b02f-500ed6245b06"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f9e1a66f-529e-47b5-8078-46481bba4708"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fcbc3ae1-1cac-4e1f-9f5a-89ff8da683c4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ff70d08e-5586-4a0a-9fd0-e40b9b947988"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("04c73069-65bd-4562-b559-49488e2a1cfe"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("0983503e-15e9-4e6f-a091-f1072d335dba"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("0a6a1b7f-2b04-47aa-8559-653ee4ce8618"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("1bf4537b-18a3-4e64-b607-dbf0028e669d"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("204c516f-0744-47ec-98bf-7f4e2f6f9afc"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("20b4d454-630d-4e34-924b-a1759a070ab1"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("2ba0efc4-0616-4cc7-86dd-ab5911a548a7"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("30cab3fa-badc-4c9f-bfe6-d1bdd6a5acfd"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("3996354a-6603-40f0-9df9-42e29c84abe4"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("3a4c09bd-6d76-44a8-8cab-c363798a7e7f"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("4076619e-b114-483e-a7de-a436b82d1b92"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("4cac76b5-dc72-4bff-9c2a-27b04462fcdc"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("560219eb-51c7-4b9c-a253-b17cf4f67fc9"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("65648c6a-ce0f-49e0-b95e-d660c7f37bc6"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("72672abe-3874-4c9c-abda-8c986561d7e8"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("a75b1622-5153-4117-aa2d-2c78166a884f"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("b2f6fd09-fa95-4e8d-a83e-13fac4cb583f"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("c2c0e52a-78a1-4327-a7b9-07aa6d5617ec"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("d497724d-fb94-4567-8ecc-dfe1a7e25c5e"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("d5b3d0e3-d66a-48c1-9508-00e3a0e2fb5e"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("e5fe1952-b3d8-41c6-81ca-736cb17cf41d"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("f3a0b5a0-0fbd-4d92-828d-e722d719a13f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67021f71-3c90-4edd-a1c8-6d3f0a968810"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb5ff9c1-059f-4bf7-8e05-3dec90c862a2"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0f453479-a1e1-4668-b25f-46caf0712d37"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("37f256ba-d472-4dc2-9e18-4f536e50bc59"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3d81dd51-584c-46be-a7d2-2333c2bebb00"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5e24ca83-02d0-46c8-ad0f-be936de3a255"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8f41e10c-85ed-4ef2-9064-dd8394f3b2e2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bb0f3ad3-9f5e-4faa-a989-b4d987b3e150"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bb1759c3-3375-4513-8f31-eb209c65d2a9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d5a6425b-c53f-4a17-8b0b-88c8c4a95f99"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e843cb70-2cf0-47cc-a7f7-c08a139dc98e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ec655172-0c4d-4911-8986-b34fef20c06c"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("88ad3600-f9fa-4b4d-853e-bbf1bfd2773a"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("96a55b26-ffa7-4783-9a87-d875c1cb1f31"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("a2be7227-b866-42a3-be4b-a4ab8da5183d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f952e116-fddc-4a93-b3cb-955c25376720"));

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "Hall 2" },
                    { new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "Hall 4" },
                    { new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "Hall 1" },
                    { new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "Hall 5" },
                    { new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "Hall 3" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Country", "Description", "Director", "Duration", "Genres", "IsActive", "Name", "Picture", "ReleaseYear" },
                values: new object[,]
                {
                    { new Guid("04a7cc9c-491d-4972-a73f-5a4152c3de11"), "Tom Cruise, Miles Teller, Jennifer Connelly, Jon Hamm, Glen Powell", "SAD", " Nakon više od 30 godina služenja u mornarici, kao jedan od najboljih pilota, Pete “Maverick” Mitchell (Tom Cruise) je tamo gdje i treba da bude. Ne preza da probije barijere kao hrabar test pilot i izbjegava da prihvati unapređenje koje bi ga zauvijek spustilo na zemlju. Kada je počeo da podučava vod mladih pilota koji su na obuci za specijalne misije, kakve ni jedan živi pilot nikada još nije vidio, Maverick sreće poručnika Bradleya Bradshawa čiji je nadimak “Rooster”, sina Maverickovog pokojnog prijatelja i oficira za presretanje radara, poručnika Nicka Bradshawa, zvanog “Gus”.", "Joseph Kosinski ", 131, "akcija, avantura", true, "TOP GUN: MAVERICK", "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", 2022 },
                    { new Guid("65b41d0c-0d4e-41ef-8093-45a37a546560"), "Michelle Williams, Gabriel LaBelle, Paul Dano", "SAD", "Višestruko nagrađivani Steven Spielberg, jedan od najznačajnijih reditelja u povijesti kinematografije, nakon ekranizacija svih mogućih priča, od fantastičnih avantura do ozbiljnih ratnih filmova, napokon je snimio film o sebi.U novoj uzbudljivoj filmskoj priči Spielberg donosi intimni pogled u svoje djetinjstvo u polu-autobiografskom filmu koji prati osjetljive godine mladića koji će otkriti potresnu porodičnu tajnu što će ga potaknuti da uroni u svijet filmova koji će mu pomoći da spozna istinu o sebi i drugima.", "Steven Spielberg", 151, "drama", true, "FABELMANOVI", "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", 2022 },
                    { new Guid("6d9c6b8e-d803-435a-9261-e899c33585f6"), "Emma Roberts, Luke Bracey, Richard Gere, Diane Keaton, William H. Macy, Susan Sarandon", "SAD", "Multigeneracijska romantična komedija predvođena Richardom Gereom, oskarovkama Diane Keaton i Susan Sarandon te Williamom H. Macyjem.Michelle i Allen su u svojoj vezi došli do točke kada trebaju poduzeti slijedeći korak prema braku. Misleći da je dobra ideja pozvati roditelje da se konačno upoznaju, priprema se večera i igre počinju.", "Michael Jacobs ", 95, "romantična komedija", true, "UZIMAM, MOŽDA", "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", 2023 },
                    { new Guid("7cc179d8-1753-441c-bcfa-c89bfe41e324"), "Colin Farrell, Brendan Gleeson, Kerry Condon, Barry Keoghan", "Velika Britanija, Irska ", "Crna komedija scenarista i redatelja filma „Tri plakata izvan grada” u kojoj su zvijezde Colin Farrell i Brendan Gleeson, nasmijat će vas, ali i rastužiti do suza.Smješten na udaljenom otoku u blizini zapadne obale Irske, film prati dugogodišnje prijatelje Pádraica (Colin Farrell) i Colma (Brendan Gleeson), koji se nađu u slijepoj ulici kada Colm neočekivano prekine njihovo prijateljstvo.", "Martin McDonagh ", 114, "komedija, drama", true, "DUHOVI OTOKA", "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", 2023 },
                    { new Guid("9a908f71-bf03-4d02-82e7-0e4690a213f5"), "Martin Freeman, Letitia Wright, Angela Bassett, Lupita Nyong’o, Danai Gurira", "SAD", "Pripremite se za povratak u Wakandu! Nastavak filma Black Panther iz 2018. godine koji je oduševio kritičare i publiku diljem svijeta. Uz to, film je osvojio i tri Oscara, za najbolju originalnu glazbu, najbolji dizajn kostima i najbolju scenografiju.Wakanda se mora zaštititi od svjetskih sila koje interveniraju nakon smrti kralja T’Challe. Dok Wakanđani nastoje prihvatiti gubitak voljenog vođe, heroji se moraju udružiti te uz pomoć Nakiae i Everetta Rossa iskovati novi plan za kraljevstvo Wakande.", "Ryan Coogler", 161, "akcija, avantura", true, "BLACK PANTHER: WAKANDA ZAUVIJEK", "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", 2022 },
                    { new Guid("9cc5cec2-38f1-4f49-8acb-d7c6371569dd"), "Brendan Fraser, Sadie Sink, Hong Chau", "SAD", "Priča govori o povučenom učitelju engleskog, ozbiljno pretilom, koji se bori sa zdravstvenim problemima te se pokušava ponovno povezati sa svojom otuđenom sedamnaestogodišnjom kćeri. Nju i njezinu majku ostavio je prije mnogo godina, zbog veze s muškarcem.Na ovogodišnjem Venecijanskom filmskom festivalu film je dobio sve pohvale, kako kritike, tako i publike koja ga je nagradila višeminutnim ovacijama..", "Darren Aronofsky", 117, "drama", true, "KIT", "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", 2022 },
                    { new Guid("b53a3339-6d07-43af-9d1d-fa4c51d647b7"), "Michael B. Jordan, Jonathan Majors, Tessa Thompson", "SAD", "Nakon uspjeha u svijetu boksa, Adonis Creed napreduje i u karijeri i u porodičnom životu. Kada se nakon odslužene zatvorske kazne pojavi njegov prijatelj iz djetinjstva, i nekadašnje boksačko čudo, Damian (Jonathan Majors) će zaželjeti priliku u ringu. Sučeljavanje bivših prijatelja više je od obične tučnjave. Kako bi poravnao račune, Adonis mora staviti svoju budućnost na kocku kako bi se borio protiv Damiana - borca koji nema što izgubiti.", "Michael B. Jordan", 116, "sportska drama", true, "CREED III", "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", 2023 },
                    { new Guid("c4443570-d753-4403-8079-406d19cbb023"), "Keanu Reeves, Donnie Yen, Bill Skarsgard, Laurence Fishburne", "SAD", "U četvrtom nastavku velikog akcijskog spektakla John Wick se suočava sa dosad najsmrtonosnijim protivnicima.John Wick (Keanu Reeves) otkriva put do pobjede nad Visokim stolom. Ali prije nego što uspije zaslužiti slobodu, Wick se mora suočiti s novim neprijateljem i moćnim savezima diljem svijeta, te silama koje stare prijatelje pretvaraju u neprijatelje.Radnja novog filma odvija se diljem svijeta i donosi precizno-koreografiranu akciju posebne vrste. U potrazi za najmoćnijim igračima kriminalnog podzemnog svijeta, film vodi gledatelje u New York, Pariz, Osaku i Berlin.", "Chad Stahelski", 169, "akcija", true, "JOHN WICK 4", "/9j/4AAQSkZJRgABAQEAYABgAAD/2wBDAAcFBQYFBAcGBQYIBwcIChELCgkJChUPEAwRGBUaGRgVGBcbHichGx0lHRcYIi4iJSgpKywrGiAvMy8qMicqKyr/2wBDAQcICAoJChQLCxQqHBgcKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKir/wAARCADkAJgDASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD5tyaktzi4Qk8A5qOnISM7evSgcdHcszOAswJOWII/rUMCh1l3HkJkfmKbJKXdm6butEf8WPSlayLcuaRPEu+Rsk81q2EJ445FUbGItHvNdBp0O5QduD3NZSZ20YaJmjaI25QV4PU+ldXpsbCMFeCQO/FY9nGjqrN8rAgEDvXW2NqojTDY571yVGd8EzQg8w24zuzgHr0rUBZoUDYY4wKsabaq9p82Bu+XnuKeIFScRMQNh5/OubqbCwCYeXnd82CB+Nakfmf8CboTSWdrDIycksMjGelaTRol0FTOB2qyLkccbRjewyx65brXjvxusQbOG5RcANz7V7ikCuwAHbAzXAfFzSPtnhefZhig3ADtiqp6TTMp+9Fo+bNRfzILV88+Vg/gf/r1WtpCjdeuRj17UsxPkhG6oSKgBIr1I7Hiz+K4NkMQeueaTJp0hJkJPU02mZhk0UUUAFOU02nquVoGhh4NTxAC3lY5zkAf1qIAu+FGST0q+8appMIAYPJuck9CM44/Kpk7GlON7vsNhu0hgRSOcc1p2GuiFsbRj3NYpRfLGB261HhQwy2Knlizb2k4bHpGj6ra3cyxk+UTxg9DXQ+e9q0WGDKTnrn9a8dWZ4iHR/8AgQzxWnaeILyHjzy6+jGsZULvQ6oYvpJHu2k68GWKIHBOWwPWrMGsJc6nOpJXeSFI/wA+9eS+GdbuW1yJ3YBDwR2Fd7p+mz3lrLIH2vglGX+E1yyp8jO2NRTV0bGmeIWt9RSCaTDFmyCetdpDqEIlQ3E6qGTI3MBmvm7xBreowau259kkbclT3rJvfF2qXUqs16wKjgDJrZUWznlXUdz6iuPHWkaUjLNKJCnGFIyR64rmdU+IvhjULRo57jJkGCAueK+dn1Ka8l/0m6Zif79WEtfOTAn+U9cVXsV1MlWbd4or+JYrWLWJ/wCz5BJbsxKHGMD0NY9aGpW6QMFQk8dT3qgwwa6o7Hn1b8zYE7gCfpSUZoqjIKKKKACnkbV780wVPOAqxgcnb831zSKS0bLei2hvLwoil32/KoGST0qxqUT2V0LcAKACgXdnA5/Wtr4WyQJ4uH2nkeUQnscgf1rN8QIX8Rz5+b963Oa4/at4l03slc9aNFLBKot27GPJH0GelXYLPz7dYVRGIbIbdtJ9jT0tdzHcOK1NP0wmUFDitnUSRjGg29hun+Ebl4ma8l2W4O5YVfd5jdOg4/rXO31pJaXTo0boAfl3DFerWFo1pEGMgx1wAK47xbCr3IaEYDH/ACamnWcpWCvhowjdFbwwxlvoVYkHd1FfSXhzw+G8P72PO3g186+FIxFq0A4685r6h8MTCXw+sK4OxeTmsMQ/eR04dNUz5+8c+Ebt9fmlhTZbluuD3/xrnLPwde3kM/lwsZIz8qr3r6Y1Tw+NTtZPs5KTdVwcZxXBReHVW8kjnDLIrHjv+Ip06r5RzoxlK55pofw31/V78afDaTw28jqZpp7fasYHfcR9eB1rc1r4T3WlXTf2ZcvJH2U/eHrmvU9N0q+twnkSny26j/6xzWz/AGdMLcgxbmI+9nFN12THDQTPlrXNJnsmKzA7l65rIdd1ur91O017r478ISNHJM8W04+ZSOleMTWMka3UeP8AV8sPb1renUTRzVqNmZVFFFbnnBRRRQACrMqeZGzj+AKD7cVWqRpGCkA8MMEetJlxaSdy1pFw9tqcTxuUJO3IPTNa08LSa5fT/ejik2lvfpXOxttkVvQg11mllzpt/bADNxMr7m9Bn+ea5q3uvnXp+J6WCftI+zfR3/AltNm4Zxg+veui061iLAjoa5QK0RG7OB0NdBp0oEeQx4Fc8lpoejGS2Zu3LxxwEJnBHc1w2uyB7oICcLXTzTkwkk5IzmuMvZhJfuc/StKMdTkxMtLFvRDjU4ccHdX0r4KLTaZtGT8h5FfM2msVv4mX+9619MeAJjPpIK9WTp79KnELVDw7/ds2rWUKy54XPNLrXh611PFwq+XOBjeveqU1zHYyAS5wGAJrdtLsSxDY4ZTxxziueJrUutUc9p+m3NrdKs8wIwOa6pbSKKMOWJbjLMelUNQtgY/MgOGU5AFYdxql5DlHflTzxVLR6iadRaMl8XQRXOnyLwS3UivmjxXAum6leY4EkDLj6kCvdtU1nfCyu34ZrwDx9eCbVmQHoO351tQu5EYi0KRyFFFFegeEFFFFABTiPkBptSsf3Ix3xSKS3Iq63T7oT6bDjiWMbSfUetclV+zmYRbM4289e1ZVoc8TswVb2U35ncaNaRaiksL4zjKn096oRStbSvC/BVipB9qb4Qu5F1qDc5EchChQOueuT/Wrvia3W21t2j+43P0NeerxrOD6nsykp0lURHc3W22J3du9cmGa61ByOlX9WutsGxSTWVp199ikdvLV9wx8wzivQpxsjyK9S8kjb0SAxX4LdC+Bmvo34ctizVQwHAO2vmez1t94jlUIpbIYdjXpvh3xyljpjs0ux0U5A6/hWNeDdjfDTjyuJ7XeW0OoxXdvN8u9cBgPunsfzrjvD3iebT76XT7/AP4+IX8tlZuPqK47w58TNf1zXBp+l6RLMJW++zY4Hc54A/Guk8c6DdWsMGtRqDPFgTmPPI9fwrklFxdmdkZxktD0RtUinthIOvTjtXOazeLg7Rlj0x2rO8O6q09opzkMORio/EMsUVlPPK4UIvHqx9BSjq9SrKKObvZg6Sys/wAiZLMDn8K8a8RXK3esTOFwoHArtfEniYSR/Y7VQgPyvt9ccmuEvA3kPK2Rk7VB716FKNtTzsTPmVkZdFFFdB5YUUUUAFPZcRL7nNMFPzlecgUikMq5aRO+NmQfX1qoetaekR/aJhFuG9vlAPQA9TUzdo3NaCvUSN3Q0CajaFI2Qpgrnsc9Tnr/APXrW8cuE1nAPVQwwcgA9qk8NWtvL4gtWnaRv3TlVYZ3FV6jPbjr+VYPiKR/7QkFxwd2AM5wK81e/XXkj3J/u8O15mNckOfnP0qhJtBwKfOxMh5yB6H3qHaSCeuPSvUSsjwZyux0UZlfbkD6mux0ZrOwRRERczuCu5+g5xxnt71ykMIBHm/KWHBPSrlv5gKwEfNnjHQUpK46cnF3O98LeOD4e1RTaoZYScTQlOfT+eD7V67Y+PtD8RWcmn3pWKSQbNjHGQeAfce9eCQwC2m8z5RKV5c8Z/8Ar1ltqctrIcNiRTlSeq8frWE6UZnXGtKn8R7XpUb6Vqs1izY8t8IT3Hasnx7qS3Esdqw+UDLlD8wAPOR+Oao+GfEB15owzZuocZKtncp/+vVbxlC8PiBbzhQw2be+49RntxWEIWnZnbOopU7o85m3vesqPvRMjcec1W1RirRxuTvC/OpGNp9KfdN9lvn8s5KtkGqNzM1xcNLISzMckscmu5HkzlpYioooqjnCiiigApc/lSUUATId1vJkcjGKdYy+TeRyZwAecU60iMvyg/fBUcdTjOKrfdINTvdGzvHlkdrpWrmK4L7vkWMxsrHGCwIO30+9zVPxZdB9SinQ7yEXOeeg9+tUrPUVlYqERMkkM56HgZ/AVFrs6XF0JI/MCsAfnOSTXLGnaqmejUr81Bq5mYkuJMhck9cCpUhnYbVA+lW7EIU7AjrVqG5hhucSA4yOQK6eY4FBLVsqRaZqEp+SE/Xmuk03wZ4hutphtl55zz09a2NH1K1hUneFjK/MD+NdVD4xtIl3nzcuSilOMDk/lz+lc9SpPZI9ClRo2u2Ylr8JdYmty99dQ20fGCEz/M1Q1T4U3f2GeTTrmS4eP5sOuN2OuK9HPiywmtg99ejpkx5BJ44Jx7da1NM123vYGe0XK5Ck5HNYKrUWrOiVKjJWSPAfBFy2m+IlWYeWxYKxPGK6z4gXm6VVzuHDHYfunsP0rD8Z2cNj46kmt/3cDyBiyjKjPUfnWf4i1o3N1OUJKFsA544A5HvXVbmkpHEmqcHBnP3kiyXMkmSewB4qkTk1Y2yyxu2Cc8n3qvW6PPlcKKKKZAUUUUAFFFFAFq0lMWJEOHicOKjuFDTloxhXOVHp7VGjlGBH4j1q55bKsTN8ys25R3xUPR3OiN5x5exWhcwzLuxgN0PSta7T+0LZZLZTI648wKD19QBwAP61HfafvUSw8gjPHeqlnMbeYHe8cit8pU4I61N1LVFOLptwlsxbWQqxVuMdRirEyuw3JnOOCPSieFci6h3kMTknn5s9KtQXEUTFX+fC5IPANDfVAl0ZQia58wAIzBf4e2KuWst3d3AhhMmQwCqMnpVmO6Xzj93a0ZBBGTj39639G1KwtWRhAiM2MsOpA6mlKTS2LhTi3uXtI8G6leeXJfRzRQSMDvziu01Ke38Mab5DsI/l+Unj/JNZzeOmCxxrJH5SR+WoQZ25Geh6g/nXFeNdcXULpky+6JQCpPAxWCjKb947OaFOPumf4guRfXX2qN3Idi2XO4jjkY/WucEb3tykMQy7NjHalubuRmKIxbgYPfpXpvwk+Htxq19/aN7EYraJuXYd/Qe9dPwo4b88jW+H3w8haJr3UYd8Ua7QjjhnP8wP8K8z8feHR4b8V3FtCpFtJ+9h9ge34GvrA2sNrarb2yCOKNcKo7V4x8cdIV9JtNSRfmhl2MfZv/rgUR0FUtJHiNFFFaHKFFFFABRRRQACva/AXw9sdb+HEfiSeUM4ke22ZwUKnt9QQa8Ur274O64F8C6ppEzcC48+LJ6HAB/pXm5k5Rw/NF63PSy2/t7Iy7zwktv5iQMWGScGuO1bw+6ksibWH616TdajtmYHnms+6lhuh8wGfWuXDVKq1Z6uKp0paI8xt5BGkkE2YyxIxkDbn+L+lVbkeVcEbtwHRvauz1fw9FdKXhO2QcgiuQuoZrWTybqPHOd3rxivYjJPU8GpCUNGQrcMFYZwMetWrW9MTZlOVI59z2qmsW5QyHjOCM1GeGI7VdjHmaNGTVZX6scgAdewqtcXLzTOznk+gquqF2CqCWPavVvht8IrnXpI9T1+J7fTQdyhuGn/AN0env8AlS0RacpFL4ZfDO48V3i394rQ6bG3zSMOX9l9T/KvpKysrbTNPisrCJYbeFdqIO3ufUnuaW1toLG0itrOFIYIlCxxoMBQKe2aRp0siCb5gcVwHxSslufAGqBhkxx+YPYgg16A461xnxLdYfh/q7n/AJ4FR9TQHQ+V6KKKs5QooooAKKKKACuz8A3rQ/bIlbB4YfyrjK3PCdx5GtBe0iFaxrx56bR1YSbhWTO+nJfnP1qnMzKvFXOq1G8O/tXNRjZHo1pNsoi7YDBzmoLqK3vojHPFuHrjkVqpp245xWla6VaRWc+oanKLbT7Nd88xHPsqjuxPAFdDsjl1tqeXalozWCGYPiFjtXeOSfT3rJXG75s49q1fEeuPruqNOsfkWyfLbwA5Eaf1J6k+tZNbK9tTgla+h7/8Ifhr4dvtPi16S+i1WZTjyFHyQt1wwPJP14+te2eRhQoAAAwAB0FfHHgfxvqfgbXkv9OffExC3Fsx+SZPQ+h9D2r668L+JtM8X6BDq2jy74ZOHQ/eifurDsRU2NYyui55OKa6VbK55FRyR5FMoz3XivMvjdefZPh/JEDhrmdIx7jOT/KvUpU68V4X+0PfbU0fTgeWLzsPp8o/maBN2R4fRRRVHOFFFFABRRRQAVb0qXyNUgf0aqlKjbHDDqDkUmrqw4uzuesQnfGrDuKuRQ7iOKy9FlFzYxOOQyiujjRY7fceO9c8dND1W+bULWxmvLyKztk3SzMAAK4H4ieK01S8TRNJkB0nT3IV16XUvRpT7dl9Bz3NegatJPpPhciDK6nrSNHGR1gtujv7Fvuj23GvLNW0Ty4Q6LseHh8Dqnr+H8quNr6nNVvJWic5RVuXTp4pnheNhKozjHb1+lRtaTJEsskbKjnCkj7309a1TTORxa3IK77wL4q1H4b32n6mC8ljqWftVmD/AKyMHhh/tDOQfw71ydholzfapHaKjLuYbyRjYvdj+Fe0eGvAKa/dtqmrQNHZRwfZ7CEjHyAY30xxi2e66Zf2esaXb6hpk6z2lygeORe4/ofarLR14t8P9auPhz4yl8Ka85Gk6hJutJ2+7HIf5Buh969yMfUGpNDMnTapJr5W+OOqC/8AiTPAjZSxgSDHo2Nx/wDQq+rNTdYLd3c4VRuY+gHWvh/xDqbaz4k1DUnOTdXDyD6E8fpihbkzehnUUUVRkFFFFABRRRQAUUUUAegeAp/tFm0BPzQtjHsa9G0fTYtT1LZduY9PtIzc3sg7Rr/CPcnAA9TXjfgrUfsOtkMcLKhH4jkV7xFbGw8O22mMP9LvyLy+PdV/5ZR/l8x+orCStK56FOV6djNa3k1vVZ9RuIhG0xAjiHSKMcIg9gMCqOteF98e+NfmA44rtbCyCIOKvSWivGQQDxU2url3seDX+nCWVYZiYri3ibZ/01jH8B9SB0HcfSqHlCZmuywebYkcUQj3hVPG8nt0xx6dq9J8V6fDDJ5pjjkKnO11yD7GuTk0x/8AhLFgSBhHcIsmeG2KMHfgjJ7KOnJ61lGSUrFVI80bnZfDfwL9qB1S+Cm13eWQ6ndKB2U+5GSTnivWzb9MKFAGAo6KOwFGlQ7LOCPCgJGFAAwBxWgYuK6Ucuxx3jDwbB4q0drdwEuYxugl/ut6fSp/hd4ym1S1l8Oa+SmuaUuxt/WeMcBvcjv+ddVsGOK87+ImgXNld2/i3w5+61TT2DuF/wCWqdwfXj9KtEs2Pi1ro0bwHqs6PtkaAxRn/af5R/OvjyvZfjB48tvE/hXTFsXCm6l8yeHPzRlRyp/E141TRjN6hRRRTICiiigAooooAKKKKAJrS6ksryK5h2+ZE4ddwyCR6ivoDwLrkvivSv7UvXD3jSFbjAwNw6cdhjFfPNelfBjWfsviC40uRsJdx74wT/Gv+Iz+VZ1FdG9GVpW7nu0K4XilupxDASTjikVwkeTXK+KNcFvauFPIHQVneyOu12Zt3JBqmsrDdzBLZTukPcgdh71TluLO58WP9naS0DqI484dmXG3axI754qLTbR47eW8uzmRxnBP3R2UVo6MJLfWLaK4bbFdcR42HecZZcHkHgHcO3HeuSKcp8x0yfLDlPS/DF5MLaO2vG3EDEUv/PRR2P8AtD9a6cj5a5pIkS2hmVdsTYVgD9xh0NblrcF4ykhBdOuO/oa70ecycVgeJL6O2s5GkI2hSWz6VtSyBEJzXj/xf8R/YfDV0kb4knHkrg+vX9M1RPmfPmr3SXus3dzCgSOWZmRR2GeKp0VJBby3MyxQI0jt0VRkmq2MEnJ2RdsNA1LU4TLZWzyoDglfWrDeE9aQAtZSAE4zXY6Fbvp2kxrKpjkitpHZWGCGfIH6JWrqUsFppJwysBsxg9Y4l/kXz+dePPHVFU5YpWPpKGVUZwTm2nbU8kmhe3meKUbXQ4YHsaKLiVpriSRjksxJNFeur21PnJW5ny7EdFSW0qQXUUssSzIjhmjY8OAeh9jXRReK7GKNUPhywkwcksOTzk9vwpknM0VuX/iG2vLGSCLRrO3ZxgSooyvIPHHsR+JrDoAKvaLqUmj63Z6hD963lV+O4B5H5ZqjRQC0PqiXVYptNS4hfMcqB1I7gjNcDe3Iv9aEZOUjO4/XtWT4R8SG48Gi2lfMllmPr/D1X/D8KzINcSG8WTdh3cs5YjaU9O5H5Vxzi9j1ITjZM7q6cfuLYcFmy34Vea3guzaXG9jbo6EbM7ZkBycMAfm3FcDgnbXBHxNDAhaO8McscoaOVYxuVRg5GerE+vBpw8VPZv5sssjEFiFY5Uk5CknqSAzdh25NZqMi3KLPeNG1WzvV8jzlMcxKsCcMj9cEHkH2NS/2gNOu1WZuFbYx9VPQ/ga8L1LxP9otYJLgLHJNHGvlRyboSVYnfgfxHp27DNbGpfESG50zzZGUFMRkRqQMY64rpg3azOadrntWq3whtWJOOK+Zvizrh1HXI7RGykILt9T/APW/nXpOp+NFuPCVrd+YP3kAJwe4GD/KvANSvH1DUp7qQ5Mjk/h2rVHPPRWKta3h2eGDUHaeURExMqOegYjHNZNKjbHVh1U55onHni4io1XSqKouh6TfarpsstxbxahF++h2rId21cIFAJx15Y1keItSsxZOljcpKDFHbxhc/KijLE59WqNPFRuZnupDZQyyLsZHWRhjcx6dP4jz2rG1rVjfx29qBGYrUYR0LHI2qO/+7XHTwUYNO+x6VTNKk4yXKtTJoooruPICiiigAooooAKKKKANTQ7qW3muEjbCyQtuHrjkVTjlcBuevWiip6mieiFE7n7x3c55559aeLiX5/nbDDJGTzRRQNNkbSuNzZ5YYNHnyiHYHIXPTNFFUiG2a0t/cf8ACK20G87F3AD23GsGiigJBRRRQSFFFFABRRRQB//Z", 2023 },
                    { new Guid("e527d939-2af6-4e66-8970-30780d7f3506"), "Metallica", "SAD", "Budite prvi koji će čuti novi album benda, 72 Seasons, dan prije njegovog objavljivanja, na velikom platnu sa zapanjujućim surround zvukom u ovom specijalnom događaju ekskluzivno u kinima na samo jednu noć.72 Seasons je dugoočekivani 12. studijski album Metallice, kojem prethodi prvi singl „Lux Aterna“— pozdravljen po njegovom izdanju 28. novembra 2022., kao „gromovit, vratoloman“ (Billboard), „emocionalno pogađajući“ (Rolling Stone) i „ vatren“ (USA Today)..", "Tim Saccenti ", 120, "koncertni film", true, "METALLICA: 72 SEASONS – GLOBAL PREMIERE", "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", 2023 },
                    { new Guid("eedbb3d0-d101-43e6-8037-32ffe13e781d"), "Zachary Levi, Helen Mirren, Lucy Liu", "SAD", "Svi imamo superjunake u sebi, potrebno je samo malo magije. U slučaju 14-godišnjeg dječaka Billyja Batsona potrebno je samo reći SHAZAM!Henry Gayden je i ovog puta napisao scenarij pun akcije i smijeha.Superheroj Shazam je cinični tinejdžer koji se trudi pronaći svoje mjesto u svijetu i ne zna ništa o takvim junacima, a kamoli kako biti jedan. U njegovomse životu sve vrti oko magične riječi koja ga transformira u njegov odrasli alter ego superheroja, Shazama.", "David F. Sandberg ", 130, "akcija, avantura", true, "SHAZAM! BIJES BOGOVA", "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", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("9a2c24fa-afa6-4824-91b8-c445506be48b"), "Vecernja projekcija", 7m },
                    { new Guid("d32c1a21-6aeb-4b75-bf53-79606bf3dc60"), "Vikend projekcija", 8m },
                    { new Guid("e31fbf6e-0acb-4e6a-bb50-88fd5c289735"), "Dnevna projekcija", 6m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("01499deb-c3d7-41e6-95ad-24c932696219"), "User" },
                    { new Guid("0954f100-31fb-4b36-951a-77b3316a65b8"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Projections",
                columns: new[] { "Id", "EndTime", "HallId", "IsActive", "MovieId", "PriceId", "StartTime", "StateMachine" },
                values: new object[,]
                {
                    { new Guid("03a95204-50ce-4951-acfb-08997b2295a0"), new DateTime(2023, 5, 14, 20, 2, 8, 583, DateTimeKind.Local).AddTicks(8178), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), true, new Guid("6d9c6b8e-d803-435a-9261-e899c33585f6"), new Guid("e31fbf6e-0acb-4e6a-bb50-88fd5c289735"), new DateTime(2023, 5, 15, 4, 2, 8, 583, DateTimeKind.Local).AddTicks(8174), "Active" },
                    { new Guid("0aef42e2-1850-41c1-a2bb-3e80ce27868d"), new DateTime(2023, 5, 14, 23, 2, 8, 583, DateTimeKind.Local).AddTicks(8210), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), true, new Guid("7cc179d8-1753-441c-bcfa-c89bfe41e324"), new Guid("9a2c24fa-afa6-4824-91b8-c445506be48b"), new DateTime(2023, 5, 14, 21, 2, 8, 583, DateTimeKind.Local).AddTicks(8206), "Active" },
                    { new Guid("14fd4827-2238-49dd-a305-f5eee1880301"), new DateTime(2023, 5, 15, 6, 2, 8, 583, DateTimeKind.Local).AddTicks(8199), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), true, new Guid("7cc179d8-1753-441c-bcfa-c89bfe41e324"), new Guid("e31fbf6e-0acb-4e6a-bb50-88fd5c289735"), new DateTime(2023, 5, 15, 4, 2, 8, 583, DateTimeKind.Local).AddTicks(8196), "Active" },
                    { new Guid("19757ca0-17ff-4db8-90fc-5a8ed5a8350e"), new DateTime(2023, 5, 14, 20, 2, 8, 583, DateTimeKind.Local).AddTicks(8085), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), true, new Guid("c4443570-d753-4403-8079-406d19cbb023"), new Guid("e31fbf6e-0acb-4e6a-bb50-88fd5c289735"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8081), "Active" },
                    { new Guid("27712359-478f-44e6-bc82-9dcc619fdc79"), new DateTime(2023, 5, 15, 0, 2, 8, 583, DateTimeKind.Local).AddTicks(8073), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), true, new Guid("eedbb3d0-d101-43e6-8037-32ffe13e781d"), new Guid("e31fbf6e-0acb-4e6a-bb50-88fd5c289735"), new DateTime(2023, 5, 14, 22, 2, 8, 583, DateTimeKind.Local).AddTicks(8070), "Active" },
                    { new Guid("3e78fdda-2e5f-421b-85e3-288bc6c87c58"), new DateTime(2023, 5, 14, 23, 2, 8, 583, DateTimeKind.Local).AddTicks(8247), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), true, new Guid("65b41d0c-0d4e-41ef-8093-45a37a546560"), new Guid("9a2c24fa-afa6-4824-91b8-c445506be48b"), new DateTime(2023, 5, 14, 21, 2, 8, 583, DateTimeKind.Local).AddTicks(8243), "Active" },
                    { new Guid("49c1a7ce-e11e-46f0-8d97-b3a360148d92"), new DateTime(2023, 5, 15, 9, 2, 8, 583, DateTimeKind.Local).AddTicks(8169), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), true, new Guid("6d9c6b8e-d803-435a-9261-e899c33585f6"), new Guid("9a2c24fa-afa6-4824-91b8-c445506be48b"), new DateTime(2023, 5, 15, 7, 2, 8, 583, DateTimeKind.Local).AddTicks(8165), "Active" },
                    { new Guid("5bd2f66d-6dc4-46ef-a481-923fba3ac416"), new DateTime(2023, 5, 14, 23, 2, 8, 583, DateTimeKind.Local).AddTicks(8190), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), true, new Guid("6d9c6b8e-d803-435a-9261-e899c33585f6"), new Guid("9a2c24fa-afa6-4824-91b8-c445506be48b"), new DateTime(2023, 5, 14, 21, 2, 8, 583, DateTimeKind.Local).AddTicks(8186), "Active" },
                    { new Guid("5c26e942-4e2a-4d70-89de-43aa9c416282"), new DateTime(2023, 5, 15, 20, 2, 8, 583, DateTimeKind.Local).AddTicks(8094), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), true, new Guid("9cc5cec2-38f1-4f49-8acb-d7c6371569dd"), new Guid("e31fbf6e-0acb-4e6a-bb50-88fd5c289735"), new DateTime(2023, 5, 15, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8090), "Active" },
                    { new Guid("6e18c7a2-d05a-48fe-ac9a-1a4d0dcbf3c6"), new DateTime(2023, 5, 14, 23, 2, 8, 583, DateTimeKind.Local).AddTicks(8229), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), true, new Guid("04a7cc9c-491d-4972-a73f-5a4152c3de11"), new Guid("9a2c24fa-afa6-4824-91b8-c445506be48b"), new DateTime(2023, 5, 14, 21, 2, 8, 583, DateTimeKind.Local).AddTicks(8226), "Active" },
                    { new Guid("7d7ec88d-907b-4f6b-9345-cbaa9b61bff3"), new DateTime(2023, 5, 14, 23, 2, 8, 583, DateTimeKind.Local).AddTicks(8268), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), true, new Guid("9a908f71-bf03-4d02-82e7-0e4690a213f5"), new Guid("9a2c24fa-afa6-4824-91b8-c445506be48b"), new DateTime(2023, 5, 14, 21, 2, 8, 583, DateTimeKind.Local).AddTicks(8264), "Active" },
                    { new Guid("7ea14d95-e9cd-4cbc-a088-3e67633631bc"), new DateTime(2023, 5, 14, 23, 2, 8, 583, DateTimeKind.Local).AddTicks(8122), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), true, new Guid("e527d939-2af6-4e66-8970-30780d7f3506"), new Guid("9a2c24fa-afa6-4824-91b8-c445506be48b"), new DateTime(2023, 5, 14, 21, 2, 8, 583, DateTimeKind.Local).AddTicks(8118), "Active" },
                    { new Guid("922557f4-01f9-4008-9c53-1426389610ce"), new DateTime(2023, 5, 15, 6, 2, 8, 583, DateTimeKind.Local).AddTicks(8238), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), true, new Guid("9a908f71-bf03-4d02-82e7-0e4690a213f5"), new Guid("e31fbf6e-0acb-4e6a-bb50-88fd5c289735"), new DateTime(2023, 5, 15, 4, 2, 8, 583, DateTimeKind.Local).AddTicks(8234), "Active" },
                    { new Guid("925c51cf-2b8b-496a-ab02-d6110ce89dd7"), new DateTime(2023, 5, 14, 20, 2, 8, 583, DateTimeKind.Local).AddTicks(7994), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), true, new Guid("eedbb3d0-d101-43e6-8037-32ffe13e781d"), new Guid("e31fbf6e-0acb-4e6a-bb50-88fd5c289735"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(7944), "Active" },
                    { new Guid("b2e71a45-2e7e-4020-a98c-c0329745e7a6"), new DateTime(2023, 5, 14, 23, 2, 8, 583, DateTimeKind.Local).AddTicks(8140), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), true, new Guid("b53a3339-6d07-43af-9d1d-fa4c51d647b7"), new Guid("9a2c24fa-afa6-4824-91b8-c445506be48b"), new DateTime(2023, 5, 14, 21, 2, 8, 583, DateTimeKind.Local).AddTicks(8136), "Active" },
                    { new Guid("b813ac49-9558-4ec0-a2b8-b3d36559d345"), new DateTime(2023, 5, 14, 22, 2, 8, 583, DateTimeKind.Local).AddTicks(8063), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), true, new Guid("eedbb3d0-d101-43e6-8037-32ffe13e781d"), new Guid("e31fbf6e-0acb-4e6a-bb50-88fd5c289735"), new DateTime(2023, 5, 14, 20, 2, 8, 583, DateTimeKind.Local).AddTicks(8058), "Active" },
                    { new Guid("bcb05092-a4f6-46e5-b6f4-adf8a6c0a555"), new DateTime(2023, 5, 14, 20, 2, 8, 583, DateTimeKind.Local).AddTicks(8112), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), true, new Guid("e527d939-2af6-4e66-8970-30780d7f3506"), new Guid("e31fbf6e-0acb-4e6a-bb50-88fd5c289735"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8108), "Active" },
                    { new Guid("d0309dc1-070f-46a6-8d45-265967ffbcb2"), new DateTime(2023, 5, 14, 23, 2, 8, 583, DateTimeKind.Local).AddTicks(8103), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), true, new Guid("c4443570-d753-4403-8079-406d19cbb023"), new Guid("9a2c24fa-afa6-4824-91b8-c445506be48b"), new DateTime(2023, 5, 14, 21, 2, 8, 583, DateTimeKind.Local).AddTicks(8100), "Active" },
                    { new Guid("d30b69ca-3d18-4ca8-82e9-859ed21a99b2"), new DateTime(2023, 5, 15, 6, 2, 8, 583, DateTimeKind.Local).AddTicks(8257), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), true, new Guid("65b41d0c-0d4e-41ef-8093-45a37a546560"), new Guid("e31fbf6e-0acb-4e6a-bb50-88fd5c289735"), new DateTime(2023, 5, 15, 4, 2, 8, 583, DateTimeKind.Local).AddTicks(8253), "Active" },
                    { new Guid("e1a1ebe0-6518-47c3-8e78-648665342b0f"), new DateTime(2023, 5, 15, 6, 2, 8, 583, DateTimeKind.Local).AddTicks(8219), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), true, new Guid("04a7cc9c-491d-4972-a73f-5a4152c3de11"), new Guid("e31fbf6e-0acb-4e6a-bb50-88fd5c289735"), new DateTime(2023, 5, 15, 4, 2, 8, 583, DateTimeKind.Local).AddTicks(8215), "Active" },
                    { new Guid("f1fdac97-1aba-4c1d-9896-2f26626e0f45"), new DateTime(2023, 5, 14, 23, 2, 8, 583, DateTimeKind.Local).AddTicks(8150), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), true, new Guid("b53a3339-6d07-43af-9d1d-fa4c51d647b7"), new Guid("d32c1a21-6aeb-4b75-bf53-79606bf3dc60"), new DateTime(2023, 5, 14, 21, 2, 8, 583, DateTimeKind.Local).AddTicks(8146), "Active" },
                    { new Guid("f4bc8972-d8ad-4304-b1a6-39def849f4e2"), new DateTime(2023, 5, 14, 20, 2, 8, 583, DateTimeKind.Local).AddTicks(8130), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), true, new Guid("b53a3339-6d07-43af-9d1d-fa4c51d647b7"), new Guid("e31fbf6e-0acb-4e6a-bb50-88fd5c289735"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8127), "Active" },
                    { new Guid("f8b31f61-b1a5-45f8-9ba8-fe6f61570cb3"), new DateTime(2023, 5, 14, 20, 2, 8, 583, DateTimeKind.Local).AddTicks(8159), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), true, new Guid("b53a3339-6d07-43af-9d1d-fa4c51d647b7"), new Guid("e31fbf6e-0acb-4e6a-bb50-88fd5c289735"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8156), "Active" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Name" },
                values: new object[,]
                {
                    { new Guid("0176c19d-cd7a-432b-9a70-6b5e1499b50a"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "B3" },
                    { new Guid("01b4ef3c-433a-4e49-a504-ace2b8f094db"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "B3" },
                    { new Guid("01c12f6a-b4d9-41f5-a521-985b6c17400b"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "A4" },
                    { new Guid("05cbe219-bb5d-4911-a4a6-bcd767ec8f56"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "A4" },
                    { new Guid("061e2e31-fda7-4969-bd70-ccd299ab8eb6"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "D2" },
                    { new Guid("064c83cf-c56e-40cb-a768-61e89b43f5e9"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "D1" },
                    { new Guid("0742ba56-18aa-4d5d-879d-388f3694ef9b"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "A2" },
                    { new Guid("07e2f677-2e48-47ce-9321-214e88043b58"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "C5" },
                    { new Guid("0a477f79-53c8-44b7-a90d-716ce06db0e2"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "D2" },
                    { new Guid("0b288c6f-13ee-45e0-abc5-e4eb738bc150"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "C3" },
                    { new Guid("0b65488e-b346-49bb-8caf-25b0528a5460"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "B1" },
                    { new Guid("0b719df4-994b-42e2-94a6-e8af290cf16a"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "D1" },
                    { new Guid("0cc81ce5-cb55-4333-9420-e10ff7816125"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "C3" },
                    { new Guid("112f7486-e80c-4e69-81f9-15aa3163301b"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "D4" },
                    { new Guid("1194cd3c-49af-47d8-9fe1-8fef4e9abf90"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "C4" },
                    { new Guid("12d9feb8-6472-4d80-ab14-3ab6d30d547d"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "A2" },
                    { new Guid("22dd8ca5-26c1-49b3-be2c-18ca1864205a"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "D3" },
                    { new Guid("24be502d-11a1-42e2-8442-bcc22373041e"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "C1" },
                    { new Guid("252d0e27-1d51-4522-92e6-aceb2b6a3023"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "D4" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Name" },
                values: new object[,]
                {
                    { new Guid("2609d3db-59dd-4a1d-add9-3ae42b75305b"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "B5" },
                    { new Guid("2699643d-0b18-40a4-b596-49330f0bccf6"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "D3" },
                    { new Guid("28070a17-ea7a-4a25-9e7d-4cd69a0719b8"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "A1" },
                    { new Guid("2b1ab73b-d933-44b8-b955-4510cc718cf9"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "A4" },
                    { new Guid("2c766df2-3a65-4c21-8d5a-1a6453209c5b"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "B1" },
                    { new Guid("2ea54008-ddde-479d-9c11-bcdd68a00673"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "A0" },
                    { new Guid("334d619c-52e7-4ae4-ac4d-582d28a7489b"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "C1" },
                    { new Guid("34d841ee-d150-4c2b-8e2c-e04240eed3d0"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "C2" },
                    { new Guid("3ae077b6-7cdf-456a-92ac-b783f3acb49a"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "B1" },
                    { new Guid("40dde5ed-29bc-40f5-8269-18b22d987ff1"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "C5" },
                    { new Guid("4355f73a-47dc-467e-b100-608f4ca3bcfc"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "B3" },
                    { new Guid("43f23fc6-9af4-4b95-9158-647dcfad26f3"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "C2" },
                    { new Guid("489ef346-3708-46d0-b602-6675eb26ec7a"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "D1" },
                    { new Guid("50990119-23a8-4660-8338-70db4341e99c"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "A0" },
                    { new Guid("50f009e0-7d38-4186-a07b-c4dc50741091"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "A1" },
                    { new Guid("555bcd8e-4769-43e8-ac59-ab71c21a7a0a"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "D4" },
                    { new Guid("5911286d-31c0-4193-8500-95934e52dc4f"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "A1" },
                    { new Guid("5e0df22f-318c-44b6-853a-a01a08a65af8"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "A4" },
                    { new Guid("6225fe8d-8c73-40e7-8da2-320177cdd209"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "A2" },
                    { new Guid("641eb31a-0fd3-41de-8d7a-e7640223137a"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "A0" },
                    { new Guid("64e51afe-a7c7-4b82-85ad-d664f90459ba"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "A0" },
                    { new Guid("6af8f630-49e2-4cf4-9c38-cc69e27a560a"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "B3" },
                    { new Guid("6c96228f-9212-477e-8fe2-8362586bb2ee"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "D1" },
                    { new Guid("722cffa8-c743-4ff9-8655-e492a75ee740"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "D1" },
                    { new Guid("72b74e6a-4a17-4331-8a3f-c6de46f5f747"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "B2" },
                    { new Guid("744bde57-9549-4a13-b06d-336ad55bd49c"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "D4" },
                    { new Guid("74a2c5d1-2bd4-4b8a-946d-a588950b06d9"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "B4" },
                    { new Guid("7b1dbaf2-40db-49c9-9fb1-71e75b5e7cf4"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "A1" },
                    { new Guid("7c4748cc-2321-4586-8633-d96265cc4909"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "B4" },
                    { new Guid("7d40f59e-d82c-4632-8517-6d0aec89d78b"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "D3" },
                    { new Guid("7d7215bb-a610-46f1-9c2b-f422c9007fea"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "A3" },
                    { new Guid("84acd473-7965-4299-8b34-3c8ce5c2e13e"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "D2" },
                    { new Guid("84daa2eb-4489-4aad-b507-d4d4db1424c0"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "A5" },
                    { new Guid("876b0f9f-101d-4ceb-91fb-f8d1bb12f52a"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "D4" },
                    { new Guid("88112c27-38d5-47fb-b2b8-1d6d5529635f"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "D3" },
                    { new Guid("88facb53-df05-4cd8-bf12-3cac603b73dd"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "A3" },
                    { new Guid("8db0712e-972a-4317-b438-6dcb73574ef4"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "A5" },
                    { new Guid("8ff7b747-dfd9-473a-a62b-61dda2c67669"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "B5" },
                    { new Guid("936a0a10-0a28-4feb-a574-84830fed3a99"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "A5" },
                    { new Guid("a6b13681-792a-44ff-b1a8-9d41397d100e"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "C3" },
                    { new Guid("ae3dcde9-bc52-4ae0-9310-3fc99eeab2ab"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "C5" },
                    { new Guid("b384f37f-6695-4629-b83e-7efc18f29b9c"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "B5" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Name" },
                values: new object[,]
                {
                    { new Guid("b4458792-7b78-4918-9f06-8b7d7e3ffe75"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "A1" },
                    { new Guid("b4d1c2ae-6a1e-4ba5-a208-598197ad82a1"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "B2" },
                    { new Guid("b60655de-db94-4ff8-8b7e-474a9437f945"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "A3" },
                    { new Guid("b87715b0-482e-43da-8db6-ad5a05892a73"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "C1" },
                    { new Guid("b9d15712-cb13-4ae3-84a7-7d4f82d9dfba"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "C5" },
                    { new Guid("ba13b5e7-e83b-4fef-99b7-a542566e2cd1"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "A3" },
                    { new Guid("bbc37fe2-5951-4748-a62d-84e73e567192"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "C1" },
                    { new Guid("bd6d3116-7b4b-49ad-aa52-f699b70f6dba"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "A4" },
                    { new Guid("c00dd455-83ec-4d96-b1de-d7ecd0d974b3"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "A2" },
                    { new Guid("c0896506-99ee-4e4c-a85f-53802d004b8b"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "C2" },
                    { new Guid("c14953aa-4b9e-4d87-9d78-1076d9f3b1a1"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "C1" },
                    { new Guid("c165c66a-6292-425c-927b-a9568578b8f7"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "B4" },
                    { new Guid("c174a6af-40b4-4dca-bd73-b687c998663a"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "D3" },
                    { new Guid("c7a96704-4118-4ef4-a0ed-3ae570016d57"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "C3" },
                    { new Guid("cb1f2850-cdb2-4a87-9437-4773ca291b4d"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "B2" },
                    { new Guid("cd346e34-5c36-4f4f-82f5-03646be7a033"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "D2" },
                    { new Guid("cf604c76-0b9c-45c3-adc9-1ab0c1e0b3e3"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "C4" },
                    { new Guid("cfcbe78a-364f-4734-8e69-8b66ced0e453"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "B4" },
                    { new Guid("d1bcdcb2-c4f0-41f0-b0a7-d7fe9a50251f"), new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"), "D2" },
                    { new Guid("d4354d20-7c10-438e-b7aa-90b62360ef1d"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "A0" },
                    { new Guid("d5ee1fea-d1dd-4e30-b20f-7306f20f4cd0"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "B1" },
                    { new Guid("df9e5aeb-6882-4712-abfd-ec9dd3940693"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "B5" },
                    { new Guid("e36ab0e5-6b50-47e5-ba04-6b3156a1496f"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "C2" },
                    { new Guid("e38e5d18-7f55-401c-8822-d69b132abbe2"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "B3" },
                    { new Guid("e4978f75-b176-4011-80be-94e5b5b2efd9"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "C2" },
                    { new Guid("e4cd71ba-107e-4a32-82ec-caca094ff2b2"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "C4" },
                    { new Guid("e830e8e4-9ce6-4985-b188-72d61742f1db"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "C4" },
                    { new Guid("ee1efda6-6e08-4504-bdc1-afcafe18b568"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "B2" },
                    { new Guid("eeced687-1d11-4d08-8bd3-4049de2d6a61"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "A5" },
                    { new Guid("ef915c1f-e499-4efa-ac95-007dcf80833c"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "A5" },
                    { new Guid("f175e00a-f748-4cdc-8ac4-f098b89d3b31"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "C5" },
                    { new Guid("f2d760fc-eb4c-468d-879d-baa08e5e9247"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "B1" },
                    { new Guid("f51729e5-a6a3-452e-be1a-6f7c7c0d6476"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "C3" },
                    { new Guid("f75b65a9-9eb6-45fb-8a09-481bdcb426ce"), new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"), "B5" },
                    { new Guid("fc1f884b-cebc-4c33-a1fd-3a57391ca577"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "B4" },
                    { new Guid("fd4a6db3-3b15-448c-a2bf-58bc350c2629"), new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"), "A3" },
                    { new Guid("fd520f32-384d-4878-8142-bdb2bc9ff29c"), new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"), "A2" },
                    { new Guid("fe4789e4-94d4-45e6-ad05-a7b04eb1548e"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "C4" },
                    { new Guid("ff4b8446-0918-463c-b46a-f9dd2034f3a0"), new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"), "B2" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CustomerId", "Email", "FirstName", "IsActive", "LastName", "LozinkaHash", "LozinkaSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[,]
                {
                    { new Guid("0dc23f95-f30f-43cd-bea5-84126fb66f98"), null, "admin@gmail.com", "Admin", true, "Admin", "7kKsDa+6hRdt7XcqMDgm2S7rTrU=", "TtmLiJiC01TGrl3icOum+A==", null, new Guid("0954f100-31fb-4b36-951a-77b3316a65b8"), "admin" },
                    { new Guid("5ac443c9-b25d-4d2e-9cab-be15efd38b34"), null, "user@gmail.com", "User", true, "User", "RwsT35IUY+GKpNRo75oAKGAXwPQ=", "v943l82AjZizCeAHQUBXbQ==", null, new Guid("01499deb-c3d7-41e6-95ad-24c932696219"), "user" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "AuthorId", "Date", "Description", "IsActive", "NotificationType", "Picture", "Title" },
                values: new object[,]
                {
                    { new Guid("159f203e-3075-434b-9fec-8ef601699793"), new Guid("0dc23f95-f30f-43cd-bea5-84126fb66f98"), new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sretan Dana nezavisnosti BiH. ", true, "Neradni dan", "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", "Neradni dan povodom Dana nezavisnosti BiH." },
                    { new Guid("c522b388-823a-46ff-b357-099775c15e56"), new Guid("0dc23f95-f30f-43cd-bea5-84126fb66f98"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8337), "Novi film stiže u eCinema kina. ", true, "Ponuda", "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", "Novi film u ponudi." },
                    { new Guid("efa27493-aa1e-48c2-9533-efd3911415a9"), new Guid("0dc23f95-f30f-43cd-bea5-84126fb66f98"), new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sretan 1. maj praznik rada. ", true, "Neradni dan", "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", "Neradni dan povodom Praznika Rada." }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "DateTime", "IsActive", "ProjectionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("08df53fc-b63f-4475-b967-d9c25a95a9ba"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8364), true, new Guid("925c51cf-2b8b-496a-ab02-d6110ce89dd7"), new Guid("5ac443c9-b25d-4d2e-9cab-be15efd38b34") },
                    { new Guid("1b47c17b-e542-4b0b-9b34-e2754aee0ba1"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8440), true, new Guid("49c1a7ce-e11e-46f0-8d97-b3a360148d92"), new Guid("5ac443c9-b25d-4d2e-9cab-be15efd38b34") },
                    { new Guid("1bda6e09-c03a-407d-9251-70b057401fb3"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8516), true, new Guid("0aef42e2-1850-41c1-a2bb-3e80ce27868d"), new Guid("5ac443c9-b25d-4d2e-9cab-be15efd38b34") },
                    { new Guid("2d15d5e4-3439-40f6-99f9-fc028bec5b6f"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8528), true, new Guid("6e18c7a2-d05a-48fe-ac9a-1a4d0dcbf3c6"), new Guid("5ac443c9-b25d-4d2e-9cab-be15efd38b34") },
                    { new Guid("32e733c3-6c4f-4f97-b5a3-9bf803c9bb0a"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8411), true, new Guid("7ea14d95-e9cd-4cbc-a088-3e67633631bc"), new Guid("0dc23f95-f30f-43cd-bea5-84126fb66f98") },
                    { new Guid("3777ba50-b66c-4c2f-8cda-26bea0d8ed5b"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8450), true, new Guid("5bd2f66d-6dc4-46ef-a481-923fba3ac416"), new Guid("5ac443c9-b25d-4d2e-9cab-be15efd38b34") },
                    { new Guid("560796d4-48c1-475f-9887-5ca745ab7496"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8403), true, new Guid("bcb05092-a4f6-46e5-b6f4-adf8a6c0a555"), new Guid("5ac443c9-b25d-4d2e-9cab-be15efd38b34") },
                    { new Guid("5a8e6d6a-c145-49c2-b682-91b55c31089c"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8390), true, new Guid("5c26e942-4e2a-4d70-89de-43aa9c416282"), new Guid("5ac443c9-b25d-4d2e-9cab-be15efd38b34") },
                    { new Guid("67b10187-7bcc-426f-86cb-71f56ac4ae0a"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8523), true, new Guid("e1a1ebe0-6518-47c3-8e78-648665342b0f"), new Guid("0dc23f95-f30f-43cd-bea5-84126fb66f98") },
                    { new Guid("73f55195-b6ad-49df-a4d8-1a6068aacc79"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8398), true, new Guid("d0309dc1-070f-46a6-8d45-265967ffbcb2"), new Guid("0dc23f95-f30f-43cd-bea5-84126fb66f98") },
                    { new Guid("7dd34985-53cf-4dca-a47c-ce2461a69cc4"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8435), true, new Guid("f8b31f61-b1a5-45f8-9ba8-fe6f61570cb3"), new Guid("0dc23f95-f30f-43cd-bea5-84126fb66f98") },
                    { new Guid("7e07eda3-c464-4d9e-9a39-c01418f2aaf3"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8379), true, new Guid("27712359-478f-44e6-bc82-9dcc619fdc79"), new Guid("5ac443c9-b25d-4d2e-9cab-be15efd38b34") },
                    { new Guid("85848bc5-ff57-4fe1-9eb6-87158cb52db0"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8418), true, new Guid("f4bc8972-d8ad-4304-b1a6-39def849f4e2"), new Guid("5ac443c9-b25d-4d2e-9cab-be15efd38b34") },
                    { new Guid("8bc030d1-8767-4f07-8912-44fcba55a332"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8542), true, new Guid("d30b69ca-3d18-4ca8-82e9-859ed21a99b2"), new Guid("0dc23f95-f30f-43cd-bea5-84126fb66f98") },
                    { new Guid("8c2da7f6-1a0c-461b-9643-808b09e9c1f6"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8430), true, new Guid("f1fdac97-1aba-4c1d-9896-2f26626e0f45"), new Guid("5ac443c9-b25d-4d2e-9cab-be15efd38b34") },
                    { new Guid("917126c0-40b0-4444-8838-2e43b501afcb"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8425), true, new Guid("b2e71a45-2e7e-4020-a98c-c0329745e7a6"), new Guid("0dc23f95-f30f-43cd-bea5-84126fb66f98") },
                    { new Guid("99366015-e9f9-4434-af7a-3372b61a6726"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8374), true, new Guid("b813ac49-9558-4ec0-a2b8-b3d36559d345"), new Guid("0dc23f95-f30f-43cd-bea5-84126fb66f98") },
                    { new Guid("a31d18c6-ba7a-453c-a7d4-c4bdc1ec7100"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8537), true, new Guid("3e78fdda-2e5f-421b-85e3-288bc6c87c58"), new Guid("5ac443c9-b25d-4d2e-9cab-be15efd38b34") },
                    { new Guid("ab971902-191b-4a3d-b462-4e04205be697"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8384), true, new Guid("19757ca0-17ff-4db8-90fc-5a8ed5a8350e"), new Guid("0dc23f95-f30f-43cd-bea5-84126fb66f98") },
                    { new Guid("bdbbd1ba-9063-41fc-858b-3b4d970639e8"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8509), true, new Guid("14fd4827-2238-49dd-a305-f5eee1880301"), new Guid("0dc23f95-f30f-43cd-bea5-84126fb66f98") },
                    { new Guid("d29c10d5-3216-4495-bd70-896d035044af"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8445), true, new Guid("03a95204-50ce-4951-acfb-08997b2295a0"), new Guid("0dc23f95-f30f-43cd-bea5-84126fb66f98") },
                    { new Guid("ec913671-4fca-4254-b903-fddeddf78cd6"), new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8532), true, new Guid("922557f4-01f9-4008-9c53-1426389610ce"), new Guid("0dc23f95-f30f-43cd-bea5-84126fb66f98") }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "Created", "ReservationId", "StripePaymentId" },
                values: new object[,]
                {
                    { new Guid("0abcaf7f-5301-417d-b931-c930a9aad250"), 18m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8794), new Guid("73f55195-b6ad-49df-a4d8-1a6068aacc79"), "stripe payment id" },
                    { new Guid("1c0ec356-b9a8-4df2-8e36-0e536adce2ae"), 24m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8882), new Guid("a31d18c6-ba7a-453c-a7d4-c4bdc1ec7100"), "stripe payment id" },
                    { new Guid("1cee42d3-4137-4606-8d36-6d55b952c098"), 24m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8835), new Guid("1b47c17b-e542-4b0b-9b34-e2754aee0ba1"), "stripe payment id" },
                    { new Guid("24ce11b5-1411-4104-b048-b77f603bd9c7"), 18m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8840), new Guid("d29c10d5-3216-4495-bd70-896d035044af"), "stripe payment id" },
                    { new Guid("2afe51f4-e3b0-4dac-b0b4-c2fd8f7bd56c"), 18m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8769), new Guid("99366015-e9f9-4434-af7a-3372b61a6726"), "stripe payment id" },
                    { new Guid("3e57e581-67ce-4c52-9558-d72751104c5f"), 18m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8830), new Guid("7dd34985-53cf-4dca-a47c-ce2461a69cc4"), "stripe payment id" },
                    { new Guid("4a91fffe-8752-4a76-a260-390883158151"), 24m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8787), new Guid("5a8e6d6a-c145-49c2-b682-91b55c31089c"), "stripe payment id" },
                    { new Guid("51a52ba9-2857-41de-ab04-3ded0db55119"), 24m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8753), new Guid("08df53fc-b63f-4475-b967-d9c25a95a9ba"), "stripe payment id" },
                    { new Guid("66ab825d-797a-403c-a9e7-4fef86818367"), 24m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8845), new Guid("3777ba50-b66c-4c2f-8cda-26bea0d8ed5b"), "stripe payment id" },
                    { new Guid("6743e2c2-41c5-4579-bbf5-5719ae7b16f4"), 24m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8799), new Guid("560796d4-48c1-475f-9887-5ca745ab7496"), "stripe payment id" },
                    { new Guid("7380fe20-b7f0-4cfa-8176-6cf4b5b8f0f1"), 24m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8775), new Guid("7e07eda3-c464-4d9e-9a39-c01418f2aaf3"), "stripe payment id" },
                    { new Guid("7438ef0a-1e3d-4e72-9278-30e20bae6579"), 18m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8866), new Guid("67b10187-7bcc-426f-86cb-71f56ac4ae0a"), "stripe payment id" },
                    { new Guid("7c824691-b4f1-43e3-8e1e-13c23681ac2e"), 24m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8871), new Guid("2d15d5e4-3439-40f6-99f9-fc028bec5b6f"), "stripe payment id" },
                    { new Guid("8d21808d-acaa-4a18-9428-d86e6e64f72f"), 24m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8810), new Guid("85848bc5-ff57-4fe1-9eb6-87158cb52db0"), "stripe payment id" },
                    { new Guid("9ba60e7c-ede4-440f-8e5a-774cd95192b1"), 24m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8856), new Guid("1bda6e09-c03a-407d-9251-70b057401fb3"), "stripe payment id" },
                    { new Guid("b62f8e9b-7a6a-4456-ad99-f3926c9e24d6"), 18m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8877), new Guid("ec913671-4fca-4254-b903-fddeddf78cd6"), "stripe payment id" },
                    { new Guid("b8f3a041-c533-4c95-98f8-5af7cb9d167d"), 18m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8804), new Guid("32e733c3-6c4f-4f97-b5a3-9bf803c9bb0a"), "stripe payment id" },
                    { new Guid("b98acc72-5c62-42cf-8026-325767d40d03"), 18m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8850), new Guid("bdbbd1ba-9063-41fc-858b-3b4d970639e8"), "stripe payment id" },
                    { new Guid("c119951c-0f8b-4eae-af34-245acbff0db4"), 18m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8780), new Guid("ab971902-191b-4a3d-b462-4e04205be697"), "stripe payment id" },
                    { new Guid("c88233e4-40df-43fa-ac3d-77eebdaaad40"), 18m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8887), new Guid("8bc030d1-8767-4f07-8912-44fcba55a332"), "stripe payment id" },
                    { new Guid("dc51a0cf-7766-4987-9c93-62990820a745"), 24m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8825), new Guid("8c2da7f6-1a0c-461b-9643-808b09e9c1f6"), "stripe payment id" },
                    { new Guid("f72bb4ef-89d5-4b6c-a3fd-245aeecb892b"), 18m, new DateTime(2023, 5, 14, 18, 2, 8, 583, DateTimeKind.Local).AddTicks(8820), new Guid("917126c0-40b0-4444-8838-2e43b501afcb"), "stripe payment id" }
                });

            migrationBuilder.InsertData(
                table: "SeatReservations",
                columns: new[] { "Id", "IsTaken", "ReservationId", "SeatId" },
                values: new object[,]
                {
                    { new Guid("0039ad8c-624f-4a2e-afb2-10bad61ccca8"), true, new Guid("67b10187-7bcc-426f-86cb-71f56ac4ae0a"), new Guid("744bde57-9549-4a13-b06d-336ad55bd49c") },
                    { new Guid("05f828de-3a48-47fa-9019-37f928d0e842"), true, new Guid("32e733c3-6c4f-4f97-b5a3-9bf803c9bb0a"), new Guid("fc1f884b-cebc-4c33-a1fd-3a57391ca577") },
                    { new Guid("0804ead9-8921-46f2-af5d-112e2de736ce"), true, new Guid("73f55195-b6ad-49df-a4d8-1a6068aacc79"), new Guid("84daa2eb-4489-4aad-b507-d4d4db1424c0") },
                    { new Guid("12b2b5f5-bd08-4275-8236-0b9669fb6c5e"), true, new Guid("85848bc5-ff57-4fe1-9eb6-87158cb52db0"), new Guid("01b4ef3c-433a-4e49-a504-ace2b8f094db") },
                    { new Guid("2894e839-4954-48c6-90d3-45a8108b8524"), true, new Guid("73f55195-b6ad-49df-a4d8-1a6068aacc79"), new Guid("cb1f2850-cdb2-4a87-9437-4773ca291b4d") },
                    { new Guid("38e1af6b-a157-4c67-b043-adf893631d18"), true, new Guid("a31d18c6-ba7a-453c-a7d4-c4bdc1ec7100"), new Guid("d4354d20-7c10-438e-b7aa-90b62360ef1d") },
                    { new Guid("439b23be-4249-4402-acec-d34392346ebe"), true, new Guid("7dd34985-53cf-4dca-a47c-ce2461a69cc4"), new Guid("bbc37fe2-5951-4748-a62d-84e73e567192") },
                    { new Guid("502af690-198d-4540-8014-ee1a03e77592"), true, new Guid("32e733c3-6c4f-4f97-b5a3-9bf803c9bb0a"), new Guid("ee1efda6-6e08-4504-bdc1-afcafe18b568") },
                    { new Guid("536ff475-7785-47c2-af26-ecc500b5ab14"), true, new Guid("917126c0-40b0-4444-8838-2e43b501afcb"), new Guid("c14953aa-4b9e-4d87-9d78-1076d9f3b1a1") },
                    { new Guid("5979614d-bd31-4fa2-a9eb-2a70332c9313"), true, new Guid("560796d4-48c1-475f-9887-5ca745ab7496"), new Guid("6af8f630-49e2-4cf4-9c38-cc69e27a560a") },
                    { new Guid("5bc3ccda-5b3c-4a6e-afbd-dd5439df58be"), true, new Guid("ab971902-191b-4a3d-b462-4e04205be697"), new Guid("ef915c1f-e499-4efa-ac95-007dcf80833c") },
                    { new Guid("5d39db49-a307-4bd6-ad37-de5a46d0efb1"), true, new Guid("08df53fc-b63f-4475-b967-d9c25a95a9ba"), new Guid("2ea54008-ddde-479d-9c11-bcdd68a00673") },
                    { new Guid("607f3052-ee6f-4d08-851d-116e5c3fabf9"), true, new Guid("8bc030d1-8767-4f07-8912-44fcba55a332"), new Guid("50f009e0-7d38-4186-a07b-c4dc50741091") },
                    { new Guid("6351eeed-5b18-4841-9e3d-d0623fada727"), true, new Guid("8c2da7f6-1a0c-461b-9643-808b09e9c1f6"), new Guid("e36ab0e5-6b50-47e5-ba04-6b3156a1496f") },
                    { new Guid("67e674f4-5440-4f69-b692-4e829fe34015"), true, new Guid("08df53fc-b63f-4475-b967-d9c25a95a9ba"), new Guid("fd520f32-384d-4878-8142-bdb2bc9ff29c") },
                    { new Guid("6803acc9-b674-4db2-960e-899758f96b46"), true, new Guid("1b47c17b-e542-4b0b-9b34-e2754aee0ba1"), new Guid("e4cd71ba-107e-4a32-82ec-caca094ff2b2") },
                    { new Guid("69e36153-83a4-4dfe-b4dc-454ab00e9edc"), true, new Guid("bdbbd1ba-9063-41fc-858b-3b4d970639e8"), new Guid("0a477f79-53c8-44b7-a90d-716ce06db0e2") },
                    { new Guid("6aa99bfd-e80e-4bb5-b70a-0fb36a3435c3"), true, new Guid("67b10187-7bcc-426f-86cb-71f56ac4ae0a"), new Guid("cd346e34-5c36-4f4f-82f5-03646be7a033") },
                    { new Guid("7605bb6e-6da3-47c1-8e7f-c785053d56c5"), true, new Guid("ab971902-191b-4a3d-b462-4e04205be697"), new Guid("88facb53-df05-4cd8-bf12-3cac603b73dd") },
                    { new Guid("833a33a4-cf91-47d5-8e86-27a348c38b80"), true, new Guid("5a8e6d6a-c145-49c2-b682-91b55c31089c"), new Guid("2b1ab73b-d933-44b8-b955-4510cc718cf9") }
                });

            migrationBuilder.InsertData(
                table: "SeatReservations",
                columns: new[] { "Id", "IsTaken", "ReservationId", "SeatId" },
                values: new object[,]
                {
                    { new Guid("840618ad-d336-43a1-9e39-2939e95cfacc"), true, new Guid("560796d4-48c1-475f-9887-5ca745ab7496"), new Guid("f2d760fc-eb4c-468d-879d-baa08e5e9247") },
                    { new Guid("857c9b15-0d8e-4d36-b393-f13e9aae9e59"), true, new Guid("5a8e6d6a-c145-49c2-b682-91b55c31089c"), new Guid("0b65488e-b346-49bb-8caf-25b0528a5460") },
                    { new Guid("8ab7f57f-911c-43e1-bdb3-1011002e5bf1"), true, new Guid("2d15d5e4-3439-40f6-99f9-fc028bec5b6f"), new Guid("22dd8ca5-26c1-49b3-be2c-18ca1864205a") },
                    { new Guid("92e4ec05-fe04-4d21-983b-bfc11ea4416f"), true, new Guid("917126c0-40b0-4444-8838-2e43b501afcb"), new Guid("cfcbe78a-364f-4734-8e69-8b66ced0e453") },
                    { new Guid("979e22e5-59b7-4fcf-8f4b-12c61a5890d9"), true, new Guid("1bda6e09-c03a-407d-9251-70b057401fb3"), new Guid("722cffa8-c743-4ff9-8655-e492a75ee740") },
                    { new Guid("999410c3-fe46-4778-bb0f-6638c090287c"), true, new Guid("7dd34985-53cf-4dca-a47c-ce2461a69cc4"), new Guid("0b288c6f-13ee-45e0-abc5-e4eb738bc150") },
                    { new Guid("9a72b901-d6d9-48e8-8fd0-d9105a8d8ffa"), true, new Guid("ec913671-4fca-4254-b903-fddeddf78cd6"), new Guid("876b0f9f-101d-4ceb-91fb-f8d1bb12f52a") },
                    { new Guid("ac07b04a-c0e4-4de3-89d4-7b9ffcbd8422"), true, new Guid("8c2da7f6-1a0c-461b-9643-808b09e9c1f6"), new Guid("f75b65a9-9eb6-45fb-8a09-481bdcb426ce") },
                    { new Guid("adc93a74-4055-4f3e-89fb-1fec9d17d0aa"), true, new Guid("7e07eda3-c464-4d9e-9a39-c01418f2aaf3"), new Guid("12d9feb8-6472-4d80-ab14-3ab6d30d547d") },
                    { new Guid("bb8edf51-7635-4941-9911-127907cae557"), true, new Guid("99366015-e9f9-4434-af7a-3372b61a6726"), new Guid("28070a17-ea7a-4a25-9e7d-4cd69a0719b8") },
                    { new Guid("bbbc8965-043f-40ae-964f-3551aa7fb3e8"), true, new Guid("1b47c17b-e542-4b0b-9b34-e2754aee0ba1"), new Guid("e4978f75-b176-4011-80be-94e5b5b2efd9") },
                    { new Guid("d1998e52-4368-4c4b-8d67-02cb41c3dd81"), true, new Guid("d29c10d5-3216-4495-bd70-896d035044af"), new Guid("40dde5ed-29bc-40f5-8269-18b22d987ff1") },
                    { new Guid("d8f2a355-5c1d-47f0-b0fc-66be117b423f"), true, new Guid("99366015-e9f9-4434-af7a-3372b61a6726"), new Guid("b60655de-db94-4ff8-8b7e-474a9437f945") },
                    { new Guid("dd9ce321-3390-46e7-a029-b03904b2c689"), true, new Guid("7e07eda3-c464-4d9e-9a39-c01418f2aaf3"), new Guid("5e0df22f-318c-44b6-853a-a01a08a65af8") },
                    { new Guid("def97640-02d9-462a-9b3f-3d6e3f4e0de3"), true, new Guid("d29c10d5-3216-4495-bd70-896d035044af"), new Guid("c7a96704-4118-4ef4-a0ed-3ae570016d57") },
                    { new Guid("e411d9a4-a2c4-4602-9f9b-0bbe0d7de07e"), true, new Guid("3777ba50-b66c-4c2f-8cda-26bea0d8ed5b"), new Guid("0b719df4-994b-42e2-94a6-e8af290cf16a") },
                    { new Guid("e769f0be-9434-465b-8be2-70d1abe92220"), true, new Guid("1bda6e09-c03a-407d-9251-70b057401fb3"), new Guid("7d40f59e-d82c-4632-8517-6d0aec89d78b") },
                    { new Guid("e7ea3de8-6192-474b-8c63-7b95835ec5ee"), true, new Guid("bdbbd1ba-9063-41fc-858b-3b4d970639e8"), new Guid("ae3dcde9-bc52-4ae0-9310-3fc99eeab2ab") },
                    { new Guid("ebbbb5f7-3941-4a31-a7a0-4c3abfb60adf"), true, new Guid("3777ba50-b66c-4c2f-8cda-26bea0d8ed5b"), new Guid("cf604c76-0b9c-45c3-adc9-1ab0c1e0b3e3") },
                    { new Guid("f5923ade-8e6f-4f98-9b93-d670d3cefda8"), true, new Guid("85848bc5-ff57-4fe1-9eb6-87158cb52db0"), new Guid("df9e5aeb-6882-4712-abfd-ec9dd3940693") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("159f203e-3075-434b-9fec-8ef601699793"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("c522b388-823a-46ff-b357-099775c15e56"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("efa27493-aa1e-48c2-9533-efd3911415a9"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("0abcaf7f-5301-417d-b931-c930a9aad250"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("1c0ec356-b9a8-4df2-8e36-0e536adce2ae"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("1cee42d3-4137-4606-8d36-6d55b952c098"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("24ce11b5-1411-4104-b048-b77f603bd9c7"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("2afe51f4-e3b0-4dac-b0b4-c2fd8f7bd56c"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("3e57e581-67ce-4c52-9558-d72751104c5f"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("4a91fffe-8752-4a76-a260-390883158151"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("51a52ba9-2857-41de-ab04-3ded0db55119"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("66ab825d-797a-403c-a9e7-4fef86818367"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("6743e2c2-41c5-4579-bbf5-5719ae7b16f4"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("7380fe20-b7f0-4cfa-8176-6cf4b5b8f0f1"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("7438ef0a-1e3d-4e72-9278-30e20bae6579"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("7c824691-b4f1-43e3-8e1e-13c23681ac2e"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("8d21808d-acaa-4a18-9428-d86e6e64f72f"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("9ba60e7c-ede4-440f-8e5a-774cd95192b1"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("b62f8e9b-7a6a-4456-ad99-f3926c9e24d6"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("b8f3a041-c533-4c95-98f8-5af7cb9d167d"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("b98acc72-5c62-42cf-8026-325767d40d03"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("c119951c-0f8b-4eae-af34-245acbff0db4"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("c88233e4-40df-43fa-ac3d-77eebdaaad40"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("dc51a0cf-7766-4987-9c93-62990820a745"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("f72bb4ef-89d5-4b6c-a3fd-245aeecb892b"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("7d7ec88d-907b-4f6b-9345-cbaa9b61bff3"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("0039ad8c-624f-4a2e-afb2-10bad61ccca8"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("05f828de-3a48-47fa-9019-37f928d0e842"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("0804ead9-8921-46f2-af5d-112e2de736ce"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("12b2b5f5-bd08-4275-8236-0b9669fb6c5e"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("2894e839-4954-48c6-90d3-45a8108b8524"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("38e1af6b-a157-4c67-b043-adf893631d18"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("439b23be-4249-4402-acec-d34392346ebe"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("502af690-198d-4540-8014-ee1a03e77592"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("536ff475-7785-47c2-af26-ecc500b5ab14"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("5979614d-bd31-4fa2-a9eb-2a70332c9313"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("5bc3ccda-5b3c-4a6e-afbd-dd5439df58be"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("5d39db49-a307-4bd6-ad37-de5a46d0efb1"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("607f3052-ee6f-4d08-851d-116e5c3fabf9"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("6351eeed-5b18-4841-9e3d-d0623fada727"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("67e674f4-5440-4f69-b692-4e829fe34015"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("6803acc9-b674-4db2-960e-899758f96b46"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("69e36153-83a4-4dfe-b4dc-454ab00e9edc"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("6aa99bfd-e80e-4bb5-b70a-0fb36a3435c3"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("7605bb6e-6da3-47c1-8e7f-c785053d56c5"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("833a33a4-cf91-47d5-8e86-27a348c38b80"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("840618ad-d336-43a1-9e39-2939e95cfacc"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("857c9b15-0d8e-4d36-b393-f13e9aae9e59"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("8ab7f57f-911c-43e1-bdb3-1011002e5bf1"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("92e4ec05-fe04-4d21-983b-bfc11ea4416f"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("979e22e5-59b7-4fcf-8f4b-12c61a5890d9"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("999410c3-fe46-4778-bb0f-6638c090287c"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("9a72b901-d6d9-48e8-8fd0-d9105a8d8ffa"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("ac07b04a-c0e4-4de3-89d4-7b9ffcbd8422"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("adc93a74-4055-4f3e-89fb-1fec9d17d0aa"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("bb8edf51-7635-4941-9911-127907cae557"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("bbbc8965-043f-40ae-964f-3551aa7fb3e8"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("d1998e52-4368-4c4b-8d67-02cb41c3dd81"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("d8f2a355-5c1d-47f0-b0fc-66be117b423f"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("dd9ce321-3390-46e7-a029-b03904b2c689"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("def97640-02d9-462a-9b3f-3d6e3f4e0de3"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("e411d9a4-a2c4-4602-9f9b-0bbe0d7de07e"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("e769f0be-9434-465b-8be2-70d1abe92220"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("e7ea3de8-6192-474b-8c63-7b95835ec5ee"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("ebbbb5f7-3941-4a31-a7a0-4c3abfb60adf"));

            migrationBuilder.DeleteData(
                table: "SeatReservations",
                keyColumn: "Id",
                keyValue: new Guid("f5923ade-8e6f-4f98-9b93-d670d3cefda8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0176c19d-cd7a-432b-9a70-6b5e1499b50a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("01c12f6a-b4d9-41f5-a521-985b6c17400b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("05cbe219-bb5d-4911-a4a6-bcd767ec8f56"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("061e2e31-fda7-4969-bd70-ccd299ab8eb6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("064c83cf-c56e-40cb-a768-61e89b43f5e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0742ba56-18aa-4d5d-879d-388f3694ef9b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("07e2f677-2e48-47ce-9321-214e88043b58"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0cc81ce5-cb55-4333-9420-e10ff7816125"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("112f7486-e80c-4e69-81f9-15aa3163301b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1194cd3c-49af-47d8-9fe1-8fef4e9abf90"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24be502d-11a1-42e2-8442-bcc22373041e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("252d0e27-1d51-4522-92e6-aceb2b6a3023"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2609d3db-59dd-4a1d-add9-3ae42b75305b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2699643d-0b18-40a4-b596-49330f0bccf6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c766df2-3a65-4c21-8d5a-1a6453209c5b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("334d619c-52e7-4ae4-ac4d-582d28a7489b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("34d841ee-d150-4c2b-8e2c-e04240eed3d0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3ae077b6-7cdf-456a-92ac-b783f3acb49a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4355f73a-47dc-467e-b100-608f4ca3bcfc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("43f23fc6-9af4-4b95-9158-647dcfad26f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("489ef346-3708-46d0-b602-6675eb26ec7a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("50990119-23a8-4660-8338-70db4341e99c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("555bcd8e-4769-43e8-ac59-ab71c21a7a0a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5911286d-31c0-4193-8500-95934e52dc4f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6225fe8d-8c73-40e7-8da2-320177cdd209"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("641eb31a-0fd3-41de-8d7a-e7640223137a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64e51afe-a7c7-4b82-85ad-d664f90459ba"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c96228f-9212-477e-8fe2-8362586bb2ee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("72b74e6a-4a17-4331-8a3f-c6de46f5f747"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("74a2c5d1-2bd4-4b8a-946d-a588950b06d9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7b1dbaf2-40db-49c9-9fb1-71e75b5e7cf4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7c4748cc-2321-4586-8633-d96265cc4909"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7d7215bb-a610-46f1-9c2b-f422c9007fea"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84acd473-7965-4299-8b34-3c8ce5c2e13e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("88112c27-38d5-47fb-b2b8-1d6d5529635f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8db0712e-972a-4317-b438-6dcb73574ef4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ff7b747-dfd9-473a-a62b-61dda2c67669"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("936a0a10-0a28-4feb-a574-84830fed3a99"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a6b13681-792a-44ff-b1a8-9d41397d100e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b384f37f-6695-4629-b83e-7efc18f29b9c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b4458792-7b78-4918-9f06-8b7d7e3ffe75"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b4d1c2ae-6a1e-4ba5-a208-598197ad82a1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b87715b0-482e-43da-8db6-ad5a05892a73"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b9d15712-cb13-4ae3-84a7-7d4f82d9dfba"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ba13b5e7-e83b-4fef-99b7-a542566e2cd1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bd6d3116-7b4b-49ad-aa52-f699b70f6dba"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c00dd455-83ec-4d96-b1de-d7ecd0d974b3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c0896506-99ee-4e4c-a85f-53802d004b8b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c165c66a-6292-425c-927b-a9568578b8f7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c174a6af-40b4-4dca-bd73-b687c998663a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d1bcdcb2-c4f0-41f0-b0a7-d7fe9a50251f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d5ee1fea-d1dd-4e30-b20f-7306f20f4cd0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e38e5d18-7f55-401c-8822-d69b132abbe2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e830e8e4-9ce6-4985-b188-72d61742f1db"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eeced687-1d11-4d08-8bd3-4049de2d6a61"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f175e00a-f748-4cdc-8ac4-f098b89d3b31"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f51729e5-a6a3-452e-be1a-6f7c7c0d6476"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd4a6db3-3b15-448c-a2bf-58bc350c2629"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fe4789e4-94d4-45e6-ad05-a7b04eb1548e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ff4b8446-0918-463c-b46a-f9dd2034f3a0"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("08df53fc-b63f-4475-b967-d9c25a95a9ba"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("1b47c17b-e542-4b0b-9b34-e2754aee0ba1"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("1bda6e09-c03a-407d-9251-70b057401fb3"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2d15d5e4-3439-40f6-99f9-fc028bec5b6f"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("32e733c3-6c4f-4f97-b5a3-9bf803c9bb0a"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("3777ba50-b66c-4c2f-8cda-26bea0d8ed5b"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("560796d4-48c1-475f-9887-5ca745ab7496"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("5a8e6d6a-c145-49c2-b682-91b55c31089c"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("67b10187-7bcc-426f-86cb-71f56ac4ae0a"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("73f55195-b6ad-49df-a4d8-1a6068aacc79"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("7dd34985-53cf-4dca-a47c-ce2461a69cc4"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("7e07eda3-c464-4d9e-9a39-c01418f2aaf3"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("85848bc5-ff57-4fe1-9eb6-87158cb52db0"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("8bc030d1-8767-4f07-8912-44fcba55a332"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("8c2da7f6-1a0c-461b-9643-808b09e9c1f6"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("917126c0-40b0-4444-8838-2e43b501afcb"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("99366015-e9f9-4434-af7a-3372b61a6726"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("a31d18c6-ba7a-453c-a7d4-c4bdc1ec7100"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ab971902-191b-4a3d-b462-4e04205be697"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("bdbbd1ba-9063-41fc-858b-3b4d970639e8"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d29c10d5-3216-4495-bd70-896d035044af"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ec913671-4fca-4254-b903-fddeddf78cd6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("01b4ef3c-433a-4e49-a504-ace2b8f094db"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0a477f79-53c8-44b7-a90d-716ce06db0e2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b288c6f-13ee-45e0-abc5-e4eb738bc150"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b65488e-b346-49bb-8caf-25b0528a5460"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b719df4-994b-42e2-94a6-e8af290cf16a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12d9feb8-6472-4d80-ab14-3ab6d30d547d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("22dd8ca5-26c1-49b3-be2c-18ca1864205a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("28070a17-ea7a-4a25-9e7d-4cd69a0719b8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b1ab73b-d933-44b8-b955-4510cc718cf9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2ea54008-ddde-479d-9c11-bcdd68a00673"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("40dde5ed-29bc-40f5-8269-18b22d987ff1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("50f009e0-7d38-4186-a07b-c4dc50741091"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5e0df22f-318c-44b6-853a-a01a08a65af8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6af8f630-49e2-4cf4-9c38-cc69e27a560a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("722cffa8-c743-4ff9-8655-e492a75ee740"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("744bde57-9549-4a13-b06d-336ad55bd49c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7d40f59e-d82c-4632-8517-6d0aec89d78b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84daa2eb-4489-4aad-b507-d4d4db1424c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("876b0f9f-101d-4ceb-91fb-f8d1bb12f52a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("88facb53-df05-4cd8-bf12-3cac603b73dd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ae3dcde9-bc52-4ae0-9310-3fc99eeab2ab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b60655de-db94-4ff8-8b7e-474a9437f945"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bbc37fe2-5951-4748-a62d-84e73e567192"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c14953aa-4b9e-4d87-9d78-1076d9f3b1a1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7a96704-4118-4ef4-a0ed-3ae570016d57"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cb1f2850-cdb2-4a87-9437-4773ca291b4d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cd346e34-5c36-4f4f-82f5-03646be7a033"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf604c76-0b9c-45c3-adc9-1ab0c1e0b3e3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cfcbe78a-364f-4734-8e69-8b66ced0e453"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d4354d20-7c10-438e-b7aa-90b62360ef1d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("df9e5aeb-6882-4712-abfd-ec9dd3940693"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e36ab0e5-6b50-47e5-ba04-6b3156a1496f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e4978f75-b176-4011-80be-94e5b5b2efd9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e4cd71ba-107e-4a32-82ec-caca094ff2b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ee1efda6-6e08-4504-bdc1-afcafe18b568"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ef915c1f-e499-4efa-ac95-007dcf80833c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f2d760fc-eb4c-468d-879d-baa08e5e9247"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f75b65a9-9eb6-45fb-8a09-481bdcb426ce"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fc1f884b-cebc-4c33-a1fd-3a57391ca577"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd520f32-384d-4878-8142-bdb2bc9ff29c"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("03a95204-50ce-4951-acfb-08997b2295a0"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("0aef42e2-1850-41c1-a2bb-3e80ce27868d"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("14fd4827-2238-49dd-a305-f5eee1880301"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("19757ca0-17ff-4db8-90fc-5a8ed5a8350e"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("27712359-478f-44e6-bc82-9dcc619fdc79"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("3e78fdda-2e5f-421b-85e3-288bc6c87c58"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("49c1a7ce-e11e-46f0-8d97-b3a360148d92"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("5bd2f66d-6dc4-46ef-a481-923fba3ac416"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("5c26e942-4e2a-4d70-89de-43aa9c416282"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("6e18c7a2-d05a-48fe-ac9a-1a4d0dcbf3c6"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("7ea14d95-e9cd-4cbc-a088-3e67633631bc"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("922557f4-01f9-4008-9c53-1426389610ce"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("925c51cf-2b8b-496a-ab02-d6110ce89dd7"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("b2e71a45-2e7e-4020-a98c-c0329745e7a6"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("b813ac49-9558-4ec0-a2b8-b3d36559d345"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("bcb05092-a4f6-46e5-b6f4-adf8a6c0a555"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("d0309dc1-070f-46a6-8d45-265967ffbcb2"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("d30b69ca-3d18-4ca8-82e9-859ed21a99b2"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("e1a1ebe0-6518-47c3-8e78-648665342b0f"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("f1fdac97-1aba-4c1d-9896-2f26626e0f45"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("f4bc8972-d8ad-4304-b1a6-39def849f4e2"));

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: new Guid("f8b31f61-b1a5-45f8-9ba8-fe6f61570cb3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0dc23f95-f30f-43cd-bea5-84126fb66f98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ac443c9-b25d-4d2e-9cab-be15efd38b34"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("732bc4c2-9a1d-445c-bb61-efd5faafd8ee"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("8ba12041-80ad-416a-9ba1-628ba901d748"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("d562f081-ebce-4966-bd0b-bd6e8f740063"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("e868350f-95b2-49a7-8af0-81e6e696042e"));

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: new Guid("f431adb2-59e7-494d-8ac2-ef2bd33db72c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("04a7cc9c-491d-4972-a73f-5a4152c3de11"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("65b41d0c-0d4e-41ef-8093-45a37a546560"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6d9c6b8e-d803-435a-9261-e899c33585f6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7cc179d8-1753-441c-bcfa-c89bfe41e324"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9a908f71-bf03-4d02-82e7-0e4690a213f5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9cc5cec2-38f1-4f49-8acb-d7c6371569dd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b53a3339-6d07-43af-9d1d-fa4c51d647b7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c4443570-d753-4403-8079-406d19cbb023"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e527d939-2af6-4e66-8970-30780d7f3506"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("eedbb3d0-d101-43e6-8037-32ffe13e781d"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("9a2c24fa-afa6-4824-91b8-c445506be48b"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("d32c1a21-6aeb-4b75-bf53-79606bf3dc60"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("e31fbf6e-0acb-4e6a-bb50-88fd5c289735"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("01499deb-c3d7-41e6-95ad-24c932696219"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0954f100-31fb-4b36-951a-77b3316a65b8"));

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "Hall 5" },
                    { new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "Hall 1" },
                    { new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "Hall 2" },
                    { new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "Hall 4" },
                    { new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "Hall 3" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Country", "Description", "Director", "Duration", "Genres", "IsActive", "Name", "Picture", "ReleaseYear" },
                values: new object[,]
                {
                    { new Guid("0f453479-a1e1-4668-b25f-46caf0712d37"), "Metallica", "SAD", "Budite prvi koji će čuti novi album benda, 72 Seasons, dan prije njegovog objavljivanja, na velikom platnu sa zapanjujućim surround zvukom u ovom specijalnom događaju ekskluzivno u kinima na samo jednu noć.72 Seasons je dugoočekivani 12. studijski album Metallice, kojem prethodi prvi singl „Lux Aterna“— pozdravljen po njegovom izdanju 28. novembra 2022., kao „gromovit, vratoloman“ (Billboard), „emocionalno pogađajući“ (Rolling Stone) i „ vatren“ (USA Today)..", "Tim Saccenti ", 120, "koncertni film", true, "METALLICA: 72 SEASONS – GLOBAL PREMIERE", "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", 2023 },
                    { new Guid("37f256ba-d472-4dc2-9e18-4f536e50bc59"), "Colin Farrell, Brendan Gleeson, Kerry Condon, Barry Keoghan", "Velika Britanija, Irska ", "Crna komedija scenarista i redatelja filma „Tri plakata izvan grada” u kojoj su zvijezde Colin Farrell i Brendan Gleeson, nasmijat će vas, ali i rastužiti do suza.Smješten na udaljenom otoku u blizini zapadne obale Irske, film prati dugogodišnje prijatelje Pádraica (Colin Farrell) i Colma (Brendan Gleeson), koji se nađu u slijepoj ulici kada Colm neočekivano prekine njihovo prijateljstvo.", "Martin McDonagh ", 114, "komedija, drama", true, "DUHOVI OTOKA", "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", 2023 },
                    { new Guid("3d81dd51-584c-46be-a7d2-2333c2bebb00"), "Martin Freeman, Letitia Wright, Angela Bassett, Lupita Nyong’o, Danai Gurira", "SAD", "Pripremite se za povratak u Wakandu! Nastavak filma Black Panther iz 2018. godine koji je oduševio kritičare i publiku diljem svijeta. Uz to, film je osvojio i tri Oscara, za najbolju originalnu glazbu, najbolji dizajn kostima i najbolju scenografiju.Wakanda se mora zaštititi od svjetskih sila koje interveniraju nakon smrti kralja T’Challe. Dok Wakanđani nastoje prihvatiti gubitak voljenog vođe, heroji se moraju udružiti te uz pomoć Nakiae i Everetta Rossa iskovati novi plan za kraljevstvo Wakande.", "Ryan Coogler", 161, "akcija, avantura", true, "BLACK PANTHER: WAKANDA ZAUVIJEK", "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", 2022 },
                    { new Guid("5e24ca83-02d0-46c8-ad0f-be936de3a255"), "Brendan Fraser, Sadie Sink, Hong Chau", "SAD", "Priča govori o povučenom učitelju engleskog, ozbiljno pretilom, koji se bori sa zdravstvenim problemima te se pokušava ponovno povezati sa svojom otuđenom sedamnaestogodišnjom kćeri. Nju i njezinu majku ostavio je prije mnogo godina, zbog veze s muškarcem.Na ovogodišnjem Venecijanskom filmskom festivalu film je dobio sve pohvale, kako kritike, tako i publike koja ga je nagradila višeminutnim ovacijama..", "Darren Aronofsky", 117, "drama", true, "KIT", "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", 2022 },
                    { new Guid("8f41e10c-85ed-4ef2-9064-dd8394f3b2e2"), "Michelle Williams, Gabriel LaBelle, Paul Dano", "SAD", "Višestruko nagrađivani Steven Spielberg, jedan od najznačajnijih reditelja u povijesti kinematografije, nakon ekranizacija svih mogućih priča, od fantastičnih avantura do ozbiljnih ratnih filmova, napokon je snimio film o sebi.U novoj uzbudljivoj filmskoj priči Spielberg donosi intimni pogled u svoje djetinjstvo u polu-autobiografskom filmu koji prati osjetljive godine mladića koji će otkriti potresnu porodičnu tajnu što će ga potaknuti da uroni u svijet filmova koji će mu pomoći da spozna istinu o sebi i drugima.", "Steven Spielberg", 151, "drama", true, "FABELMANOVI", "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", 2022 },
                    { new Guid("bb0f3ad3-9f5e-4faa-a989-b4d987b3e150"), "Tom Cruise, Miles Teller, Jennifer Connelly, Jon Hamm, Glen Powell", "SAD", " Nakon više od 30 godina služenja u mornarici, kao jedan od najboljih pilota, Pete “Maverick” Mitchell (Tom Cruise) je tamo gdje i treba da bude. Ne preza da probije barijere kao hrabar test pilot i izbjegava da prihvati unapređenje koje bi ga zauvijek spustilo na zemlju. Kada je počeo da podučava vod mladih pilota koji su na obuci za specijalne misije, kakve ni jedan živi pilot nikada još nije vidio, Maverick sreće poručnika Bradleya Bradshawa čiji je nadimak “Rooster”, sina Maverickovog pokojnog prijatelja i oficira za presretanje radara, poručnika Nicka Bradshawa, zvanog “Gus”.", "Joseph Kosinski ", 131, "akcija, avantura", true, "TOP GUN: MAVERICK", "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", 2022 },
                    { new Guid("bb1759c3-3375-4513-8f31-eb209c65d2a9"), "Emma Roberts, Luke Bracey, Richard Gere, Diane Keaton, William H. Macy, Susan Sarandon", "SAD", "Multigeneracijska romantična komedija predvođena Richardom Gereom, oskarovkama Diane Keaton i Susan Sarandon te Williamom H. Macyjem.Michelle i Allen su u svojoj vezi došli do točke kada trebaju poduzeti slijedeći korak prema braku. Misleći da je dobra ideja pozvati roditelje da se konačno upoznaju, priprema se večera i igre počinju.", "Michael Jacobs ", 95, "romantična komedija", true, "UZIMAM, MOŽDA", "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", 2023 },
                    { new Guid("d5a6425b-c53f-4a17-8b0b-88c8c4a95f99"), "Keanu Reeves, Donnie Yen, Bill Skarsgard, Laurence Fishburne", "SAD", "U četvrtom nastavku velikog akcijskog spektakla John Wick se suočava sa dosad najsmrtonosnijim protivnicima.John Wick (Keanu Reeves) otkriva put do pobjede nad Visokim stolom. Ali prije nego što uspije zaslužiti slobodu, Wick se mora suočiti s novim neprijateljem i moćnim savezima diljem svijeta, te silama koje stare prijatelje pretvaraju u neprijatelje.Radnja novog filma odvija se diljem svijeta i donosi precizno-koreografiranu akciju posebne vrste. U potrazi za najmoćnijim igračima kriminalnog podzemnog svijeta, film vodi gledatelje u New York, Pariz, Osaku i Berlin.", "Chad Stahelski", 169, "akcija", true, "JOHN WICK 4", "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", 2023 },
                    { new Guid("e843cb70-2cf0-47cc-a7f7-c08a139dc98e"), "Michael B. Jordan, Jonathan Majors, Tessa Thompson", "SAD", "Nakon uspjeha u svijetu boksa, Adonis Creed napreduje i u karijeri i u porodičnom životu. Kada se nakon odslužene zatvorske kazne pojavi njegov prijatelj iz djetinjstva, i nekadašnje boksačko čudo, Damian (Jonathan Majors) će zaželjeti priliku u ringu. Sučeljavanje bivših prijatelja više je od obične tučnjave. Kako bi poravnao račune, Adonis mora staviti svoju budućnost na kocku kako bi se borio protiv Damiana - borca koji nema što izgubiti.", "Michael B. Jordan", 116, "sportska drama", true, "CREED III", "/9j/4AAQSkZJRgABAQEAYABgAAD/2wBDAAcFBQYFBAcGBQYIBwcIChELCgkJChUPEAwRGBUaGRgVGBcbHichGx0lHRcYIi4iJSgpKywrGiAvMy8qMicqKyr/2wBDAQcICAoJChQLCxQqHBgcKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKir/wAARCADiAJgDASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD2e2jhExCSeaFIAO7qPxq0ZWLHZHnbwccZqNIljhKJt4bcD0/SpEQSKTgKccMSea1ZgQSFnLBcKAuckVnzucM8jhFUZZjwAB3rYaBwAGUAYwCB1rgfi3rA0PwmYbd2huL5xGpBzhf4vz6UR1dhSdlc8w+I/j8atKbPTpJItPi42HAMzjqzY5246CvPNM0nVPEt8yafEzxr9+ZjhI/Tn+ldt4d8DSapt1TXcw2mQ0cDD5pu+T6L/OunG2G4+z6dHGFDHCRjCiqqVEtIlUaN/emYHhz4Oxz3Ql8Sa8ttAOWSyQbh9GOMfka9C0j4G+DLi3doNcv7pSwIcmP5fUH5ecjj8KxU0q5uJG8yRljUZba3rXR2TtpzPCY47GwjRWmurxvLU5Gfx4z0rnVWdzqlRhY4LxDp2s/B3xQt3pDyX2lsNzCVvlljJ5U+hH6fjXvnhe5tfEeg2msafIrWl3EJIyDyvqp9wcg+4ryzxFq2i+Ign9i+JLTVIIhtlgRWyo9fmHIyBXY/B2EaZpuoaVbkmxjkW4t+QdhcfOv0yMj/AHqvn5tzH2ajsehR2kadfmNTBQOgxS0VJQUUUUAV7+9h03T5ry53CGBC7lRkgDrxWfD4msZ445IRMySIZA2wDChA+Tk+hH51fv7iK3sZZZommjRdzRom9mHsvf6VwU9zqjNEyJceZ9ileMfZQFDbZgG5ThuIgO+COOaZLdjrI/FGnXLRxwmRmlWJlG3HEgYr39EOfqKhbW7ZJ7FTv/08Ewnb/s7ufTg1ySXmpw3Vo1xDOzpbO7xeQGBZfPwCwQZYERAHjPYc1UtbnWPtmhQ3MDtDErR3RkgUFWDPh+BgZAXpxyKdiHI9LW+ULzzRXP8A2og9aKLBzM3I7ZmA+U7cnqORUyWWOpyKt0Url8qK4tEHWvD/AI/Wstzr+g2kSs6GGRwnPzkMOM/SveK4T4raPcXfh+21fT1zd6PMZ/fyiNsmB0PHOD6VUXZkzjoeXXOpi4WNYwVR0BVVOdox0qtNrFloVuLm/K20oIKJvy78ccdvxrX8SWcel+G49RtHU6hfIps2VeFYnliPbmvGbyxhvvEQso550hR3juNUmBk3yKDnHYDdwB1Oc1ktWdF7I9BsvEUtzE02ms8kjQkOgUsCNxOPfHrXAeJNa1a9nWGWe4v0Zywt5CzIrDoNlekfCfQ57AXEkriRZMoCB39P1ravvBF3Nq9xqKQWr+Z8jW8eUd+OuScH6+tQk4rmN7Kel7HOaToN3dS2y6PqFtcxSW6GeGa2WNopSOVRlAyATj35roLK6u9LtrvS5rySz+Zd7x5+QDIJwO3Tr6GrmkaZJY4uLSUsYs/upBzG3uB3rM1O6kh1NrksWLH5j2bIIqFNtjcFFHvVjqEbaZbPLMskjQoWZOQxIGSKkOoR/wAI/OuJ0i+RtFsDBkRG3QKcAZwMZx26Vorecda6UtDglKzsdEb/AD0qN733rC+1k96Q3OR1p2J5i9ql+Y9Lu3WVoysLkOmSV4PIxzx14rnLvxjYQ3FvNJfSLbpA7SqY39QoZhjsQRz6irl1Ks1rNE7ELJGyEjqARiuNuNK0eabAvZ42nKwN+6H70sd6jOPbGfbFBLZrT+JoduoWy6hI87zFIDGrtsLKCqghcZxngdqYviGG7vrGC2vgHUZmjZGUygrgEZHIyCfwrGXTtEtreeSB2VJQrCSSIP5YDFcDcO5/H0qK303TbTVLZ/tk8lxDJ5EQdQOUU5UkDnhs59qYjsjdUVlmaigD1mim7hSF/SoOgfTX2MpVwGVhgg9xUbzBRVSW5GcbseuKYmzxrXkt1WXw1KDH9jvGeziZzvWJj347HkY7GsvVNCs7KNLXEaPCxCYGTknJOOhySTXo3jDTjeXOn6rAu5tPkbzYv+ekTABvxAGR+NeSeIro2fiOe2acuEkILEYyM4FZy0NYWZv21+vhixtAiyPAqyyOiLlnIQsB+JHWvI/E/wAVtf8AEUEyyqmnmY4DxsQyp6D0r1XWtUtNK0Z9TmV5Y7WL5UX+JjwBmvF9OEut+IDeOts11cZkDXLKkVug/iYtwP19hmrSuglKx6H8O/id4a0vw7Cnie51D+0I/kaaKHf5i54JJPzYGB6102tajp2u2A1DS5op7aXISaPIDfUdiO4ry2TSjdXUjWeqNd2cKl768e3KQA/3I9xy5PQEgV0ugquneGXjh4SUmUKOzVMopFRlJ7npHhTUBLoccQ4MBKH+f9a6GO43dT+tcX4TVodH3PwZX3AHsK6CO4JO3v7Volocc37zNfz+cZ/Kj7R75zWYJ/mx36Yp3mZyO/finYm4utXUg0S88hVMvkkIGXcCe2R3Fc9DfXD3Fq09kI99yzTIIM7FGFjyexGetbjzCPktg44xXC+Fte1O91yRLy+lnQQSEIx4BGMHFZyqKElF9T0MLgKmKo1a0Wkqau/x2+415b8vKotkVbZ2cRp5AAZRg46djk/Wo7O5ma6sjcKqvI7sy+Wobdz8xwPTuD6Vk+F9Z1LUdVnS7vpZlW2dwrNwCMc4p3hDVrzUNWlS+vJJkEBYKzcZyOcVnHExly2W534jIa9BVXKS/dpN79b7aeR2YkB96KTz4I/eius+fPVTdqB9/px+NL524DJxzxWIbr5Bu6g8570/7YXYbADgZ4rM0uaEs4DHnB78dKoy3HHXBA496imug8eScc4ww61CZ424OCDwTnb+VAmwkkZ8YLFs8CvFfixpj2GpLqcZzFcfN8xwQw4Zfp908+teuzzKudmDjgA9RXBfE+S3/wCEeFlqUYCyHzI3IJeN+gwO6kdfqPSlK1tS6d+bQ8jl8SLqGkTafcycSIV2E/1rEtBZafGbi806G+KjhXdhs9OlZ99pt3bSPlPNCn78IJFW9P0XXtSX9zo0soI5ab92D75YjNStNjZ3uWdU8Z3F9aLawqsVuhysSLtjjx3x1Y+5pLfxRcPJbwROSu5QcdxnpjuTU7/DPxjcLuGjMw6ALNGQAPx60/R/CWraJqcNxrmmXdmmSBJNCRGp9d3IzVaWE3OTuz2+xKCygEPEaxhR+Aq2JVXHOSOgrD0NhJpMR8wYDMPXv1rS86JOrqT0BJrSOxyS0ky6ZiT8vTrTgzsoJPArOe/APydO2O9RNfsRlWXr908Yp2JudR4dihm16BZ0jkXDnY4yDhCeRU/gVbbVoZtRuvD1jpcjCENvtlHnx+WxZ0AHAbGQPRe9cdb6vc2F2t1Zy7Jo87XAHGRjv171k6T458Q3OrtJd6nI+AJBiNBhkBC8AdBk8e9c1ZpVIp9T3Mvozq4PEShb3Um9Xt20326noOkDS7fVdItraPSo0l0Q3Txmw/eD5eJHf+JT/d68VX0ZrGbw6s0Vppjm6sNQnN1b2Yi3mOZVRk7quDnH0rhtF8e+JPOSJtS/d28LCEeRH8nGMfd6YPSk0rxx4ivBcWd1qRe3mjcugiQZ3H5uQvGfauenOLcbdf8AgHs4zBVqcK/NZ8iTeu9+a3T+rdTSE5I60VS83Aor1LHw9z1EXW5duR6AmnJdYwRwegycZrKMi9x1GOvSnJOR0+YKc4rKxsaEl3nqdwxyT3qOJzJJz8wBzjOP6VT812+Ur9Peo5LqO2tZ7q6A8i3TzHC8E46AfUkD8aNhrV2IvEPiSPQbaJti3F1OcpCw+VVH8be2eAO59hXE6n5viG0+2X999quQDsVlwuM9z61FqVw+o3U9/fODPuUkJ0AI+RR6YA71VhieX9wYmVgcktkfhg9KwcrnbGHKtCsY7awhIgULIThnKBcey1CLje3XcM/xdauXNnBCMPArbhgksSV+lVpYreAqqxNuY8Enr+FZu5qrG1perfZyoVWRhj5o5Cv4EdDXd6F4nRP3bs0kb8NFJ91vqK8ma7jtxkjB6Y9KfB4mkglUJyc45OcGlew7XPaNU8HWOq6e134fgjsLliXaKLhXPrgcV5veR3VnePBeRvHMP4SvX3z3FSaJ8SLzT7pfu+Sxxt3Zrq59Y0v4hWpt2i+z3sf+ruEUkBj647e1bU6vRnLVoN6o4X7QXwTkAdcnpSiUlthwe/BqHVLC80jUJLDUI/KmjOQnO1x2ZT3Bqp5pwv6ZFdaPPd1ozXs4xd30Vu0vkpLIEMjY2pk9Tz/WrCeDo7IXlzbyMPs9xHakSIcsJNuW6kDG5e/OeKpeG1+1eJtMhMjxiS5RC8ZwyZPUH1rt7fRvtl5e2suqXqBZthmaUBJW8hZBLgDG0sqEf7IFZzjFtNrY6aNarThKEJNKW9nv6mA3w7Glai1u92qSNCzBgpcEeYUXvxuADewNYem6DENHuNUgk2eUGUo2TnGzv/wP9K9C/wCEfbzrxYNZurWZN0ayzTArt89w4PH9xCR7isPWNCbSPCOrtYTXYgS/ZfLZgY3gWQRjPGd24A59BURhBWslob1MZipqXNUb5lrq9bbXOSM3OM0VQ84n60V0HmnqdxcWtpbvPeXKQxquXeTOFFYI+JngaKfyX1W8yDjzBYnZ9eWzj8K434weJdNj0SwsdJu5nnlPmzK2MAdun8q8Ze4M/POfXNTyrZmqblqj6+shb69Zi68O6naajGRwqPscf8BNLDp7zaLrCahayb0jjRIGGC8hcFQPbOPzr5KsLq9s5FltpjGynIIJzXq/hD4p6vB5VhrfmXdocYZid6e4NW6TkvdEqnJJcxtSCGfUpbC1uSbVJGkllzneQAoA9s9D6GrFzi38t5SYoyAFGcM31rXs9Mhs4v7RtHEtpgkOoyR7EVw+t6pLdXhwd65xjqMZ6AfhXnyTjoz04yU1dC3esASMkAyoBx3H1qhcaxllSbnZyDxkccVnSMC0iEJzyGBIx9PX6GqJhfzCGVyzAc9ePWp1L0NCTURIgJQAlup7fSoh5kkoEEfzkAAD/PWoGsX3oTkAjH+fyrpfDmiGFTdTgmQj5OOmeKRXmJpmjmW5DSyM5U5Jzwvtnua9H0Tx3H4dtDaWdlHcyE8lhtxx04rAtNOCqBK+Aqt90YIPbPrVKw1TR7aQySQtJNuO7ecqPSq2F8R6JD4xfxIyrqPhezv/ACwdgZdxTPuQcVa1Hw94JnhDalZ22mStw5trgqyH0wOCfwrya98Y6rcMywTfZoVX/VQ4UY4yeOTmudl1OZmaR3YsfmOTmqVRozlSi9z1ST4dLdbrrwR4ht9Q8o5ETyeXKhB4ww7++BXHarFrmiTfY9X+3WjY2hJHYKy4xwc4Ixxx2rofCOlw6Z4Yj1DUZmtnuyR5ithlU5xj9K9A002bWCWFzJ9ttx95LthLz3wa2jUfU5Z0F9k8Rk1S8mDCS8uJAxyweVjk5z3PqSfxNJJqN3MWMt1O+5drb5Sdwzkg+2efrzXtt78NfBWoSF/Il08/3oJiiH8DkD9Kyrz4OeHYGwdYvrU9QZTGQfxwK154nO6UzyEPRXpEnwo0x2IsfFkbkdd1tuA/FWxRT54k+yn2PnTxHq1prt4kqQSK6IExu+XA/Wqdtpsk5GD5a+wqK2hWMhjye9dBZzpJHtQc/wB0da6acFJ3kYVqjpxtAbDogmVY40Zm6ZA5rodP8N2l5p8rm7kj1K24WNjz+VV7XxBceGMXMmnB2cYQzH9cVV06e/1nVJb+5C2do5PnTudqjPp6/hXU504HEo16mt9Dv/AfjC90bWorO9jDW0hEciMvDf411PxH8C2CqmreG3QeapZ7QPgt/u/4V5O3i6HwzazRaeba5mU7o5HXJHvg9K52fx3rF/qq3NzqMi4wV54Brza1qk7nqUOanCyNxZY0dlZmAY4bI6H/ABq0urW8duqq0QJG0sxx3xWfb+KbbUJMSRr5rfeIPBb1H1qtewwMM7Rk5HI/WuOUbOx6MZuUbmv9uLZ8m4SVA3GDwQPUVv2HiiGK38q4gd2VsblbG7jAFeT37G2kURMRIwyqoSMe/tU9rrd3asBJI06HoG6gfXvQ4dUNVOjPUNV8US30Jt7cLbxgAOoBy2PXNc29w/mFS5+g7ZqrZX0V+AYmBZuobgip3tSWBGARxjP9aizNVJW0JTKwOQRycZx1HrUizQoWyoJ7jGR9KzpGkjY5UhewA4NOLuQ2z5X7cY5osM2b7XLy9kQ3M7MIiNqcbV+g7dqSLxRq1lIPs99KgAIHOcZ6/nXPtdPuPmDdjv3NQSXe3Lbchveiwj1HTPjJq9sqw3NvazwqwLIydRg8V0P/AAnmg61NdXF5qGoW0fkrmyumEsLtjAVR1GCTyOa8LWcOVCkrns3enTS4bl8FhxkVepm0j0Hxf4jgu4LWHw7rRh09LXZdW0JKFWVsFiDgtnINFeXv5gk8xnEhyCN3NFFmCsUFOKsWu7zlKkgg5yO1RworrkMCKfLdx2q/KQT7V6XNY8pq7sdKniGG3jA1aBbsAYUE9Kw9V8R/2hKNqxiNfuIMgJ9B0rnri7edjuOar5rCVRtm0KCii1PJvYjopOSSck1Wds9KKCOKzbudCVhYJmhlDKcc12KzTXMMQ3EggHrXI2lsbq8jiX+I8n0FdiF8qMJGxAA+nFZsuJh3m5rplXLEOccZGOnHtVckmTB5HoTTsFnds/xdjUhhPyoeOe4+6KdyWhYl+ZGj3l1HzBT29q2NLlup5vLWd+ehPJz71gySESLGi5bPB9a6DQJRHMq92ILYFJ6jWhemlnhnaOUrIUPO3jr3xRte4wqxspY4BI4/OnXS/wDE6mY7QGIVOeuAAa24YV+xmQJjB6VNka8ztoYMum3G37jZIxjOfwqs9tLAMOp9cEf1rp24Y5zmmvg5BGfXI61v7FNXTOT6007SRyW3I4BB9M1BKXGQwLcdq6eSyt36xgHsRxVG60ZJhmKTa3uKXs5ItYiLZz4fBCnOKK05NGuNjDCMexDYzRS5WVzxfUzLHw/dahG5sJU3KMiOQlS/0OMfrWLdQzQTNHOrJIpwVYcium1O9hZ97yGKJQAsIO7OB17YrJudXe/UwTIsij/VM4y6e27+lbzUdkclKU3q0ZGKAM1K6YODwRSRRmR9qjJJxgCsbanVfQVEwM00+wyTXY6d8O9Xv41luFWzhZcgy/eI/wB3rWvB4S0/RsPITcTrxucfKp9hUykkOMZS1MDR9K+w25mufluJBkL/AHR6VPeN5duxzzg9av3DYbcOMVkXkwkkCg8DrWV7s2tZFe2h3jG0Y7cVNJCAfQ5xz2qS2zn7p2+tOxukOBnBxTuLlKPkKR93ucEDv9auabmG4QlNwHGAcZqT7MScHgfyp7yR20QEYzn3707hyk06zC98wxF+csR2rprm8hsdLhgPzz3C844CjrXH22rypK0cuZI5CMqfX1ps15L/AGsokkLqE/d57CgStc7NM3EAGQJFHyjNVWbBp2lzh4lORnt9a17Hw1eeIdXS10xrcSycnz5RGB789foOa1oyt7rObEU7++jDLc1YsNPvdVuhbaZaTXc5/ghQsfxx0/GvT9N+G2gaRtfXbl9XuVbmCJjFFn0x95vzH0ruNNtQdPCWgh0Wxb7kNtCFZh6np+tdVmcdjy/TPhVcBRP4m1GPT4+9tBiWY+x/hX9aK9Mu/D9hcROU1ySGUjh5VVwD9Mgn86KNB2PjLVbhpJEXfI0YX5BIAPy9qzR1qSSV5n3Oc4GB7ChRwcDmuV6s7orlViyjCeIK+TJ0XA5avqr4H/DPRNK8A23iK5tUuNZv4XYzSjd5AyQFQHgHjk9a+edC0hLSFbi5UGduQD/AP8a+svg3cfavhXYIefJeaL/yIx/rVTTUbmUJJzsjzrxCFhupct90nn1rz/Vpw7HcfpXb+OJhDqlxH0w54zXmGq3RDEbiTmuTqehfQo3lyFGB1NZ8bRmbrz1q3DZfaPnmbCmkltoIiQqjj25qlYizGSzpEpBxn1ptnIWU4HJ5Ge9VLskxjaSRn8qmhkfYscCbnP8AnrTDqWbmbyYwC2D1PNZjXmX55Pf2q5PZMqmS6bc2OB6VkTMokO3ge1NCk2W4g08wIG1R0p17K0dxbFwcgEZz15qtBKyt8pwuec0/UbkTWak/fR8g45xTJNyw1dLeIsX6cjNer/B37BqmvPLrCB2ZMRAnGz6e/vXgNmxklXccqp6Zr2/4PW0t2NQvtqkWoSOIKvKsfmJH4AVUI3lYmpK0LnvP2Wz0CyuJrSF5JG3Ylc5ZfQA9hWLY38Os6At87ETOh3gNkrIDhlz7HNV/EniyPT9EEd4dskqZ3qOPy61w3gvxAJ7/AFbS4GeWDzVnhkABjTevzJnsSRu59a7Yx01PMnO7sXL66cTMN5/Oiq+ooVmf1FFanLc+YM47cVueH9ONxL9qmH7pD8oP8RqnpGnpfXyC6aRLVWHmsi5YL3x717rp/wAOvDniTR4z4C8QCS7jQbrC9wj/AIVxQj1Z6tWf2VucBuGOa+hvgNdBvh9dxlube+k/AFUb/GvB9b8P6r4cvDbazZSW0meCw+Vvoe9esfAW+/4lHiGy7hkl+gZGXP5qKqp8JjR0mcX42vDc+JbyQH5N5xg1w4g+03mXzsU8+9dHrTl9TuhITnzCM+vNY8alA5UDb9cZrz76Hr2K12yRcIMLWPLN1AOBWhfuSp3YB9qw7h8KSBz7VcRSGyEyYTPOa1YJBbrjgnFc/BMzz5A4HXJq5JcuAFi5PUc1oZXHalfs7kE1lB9z0twHJJkbnuKn0fSdQ17U49P0W1e6unBIVew7kk8Ae5ppaWJcurFRk27WwF7mtGHw9qWr6DqGoaZYyz2mnoJLi5A+RRkDaD/Eeeg6AE16d4Q+C9naj7Z4znjuXDAJaRSYhBP95uN3PYcfWvVVZjosllp9rFBbiEiGEKArDO3AUcAD071tGi2tTmliIp2R8uXmgXPh+eGHUB5UssJmVW67c4GR7kH8q9Q+BeteRq2o6e/+reNJ1P8AtA7SP1FeY+KtW1DVvEU1xqpPnxnycEY2hSRt/A5rQ8Ba5DpHimN7p/LgmQxO3pnpUQfLM1qe9TPV/iXqlrJcSuCytGp+VDnp7dqv+DNNk8MeFgZwBql+BNcnH3c/dX8AcVoPY213ncsTM6dcD5wefxzUN1eqWKs3K8Hnoa9C12eO20mVr1zIGJPJ96Kz724C5+bj1zRVWMmzivh7o8WcqnmzSjCrtz8vqa2Nc8KNpErazoqzQvbHcwiYja3qtU/APi7+xoZ7eC2QzyR8Ow5H0q3qPiXULPQ57ue8PzHb5JUEHP8AKsnNpLlOjlvJ8x3vhH4jaX450kaB4+tEErLtjuHGN3oc9jWt4M+HWo+DfHF9JbzRy6Je22xJTIN5OQVXb34zzXzoPEM9+43kAIfkKjBH417p8J/iQNQt00XWJwZoCGgkZsk4rmcW02tjrjJKS5t0ed+JoXs9au4JgQ6TMOR71hSy+VGTn8K9S+K2m266w19Ft2zfMGXvXlV26qpyQOOM1wuNnY9VTTRk3M24k85+lZc5DAk9T710mm+Gtc1+Tbo+lz3Ck8y7dqD/AIEcCuu034IMxWXxVrUdsp5MFkN7fQueB+RraFOUtkY1KsIrVnj4dYVbJGD3zV/TNG1rWX26PpdxcbiAJAmEGf8AaPAr3ez8HeFdFQrpOiwPcDpdXmZmHXJBbjPQjA/Cpre+v9bt4zaGO0seQkjplyAcHbGOnI/iP/Aa644fuzgli/5UcD4e+Dhkkjm8R3pldWzJZ2vQAHkNJ2+o/OvRNJgiitUj8PafbWNnj93MYtof3VR8zfUkZ96il0bT7yxuY7C5abUYxj7Sbgl1fGQpxgAHptAxzVfT79tT8EvCjSJcWaiORY2Ksypg7cjkZQY471vGEY7HLOpKe7N22nNt4higvX88TwfuXkUAgg/MoA479u1bEB8hnjPKxPvRv70b8Efga4wzs+g2tyrb5dLuQS2eWjB6/ihU11VnfJLdvZy4ZJoPMhcdx0I/kfxq2iEzwzxhpUA8TanayoBsuXIIHIyc/wBa5Kfw9Lv/AHMyFe27givU/HWgTTa1DeaXDcXc18P38UcZcpL0GMeqgH2qXR/hHrt6ol1ma30aDGcTtvmI9kU8fiRXNKmmzphUklozlfDniTWdHt0tL+6F7ZxrtRH+/GOwV/T2Oa7XS59Q8TRldG8OX107cmdMJGD6l24roNL8I+FfDMwujH/a8sZ4nviFRPcJ93P1zRrPxesYcw2s810E+VVgUKo/HgflWi5oqxlJRm7s5zxDoWueHwn9rQrskUHfFIJEQ+hI6GisrVfiPqt+jxWscVrG4wePMYj6nj9KKv2iMnS10OG0a/EFyjdPlwcV0tveQavA9pKV8txhhjpXB2Uvyow6g4rTsrv7HfM+0lT0GcVxRm9jvqU1e6K39lX66hc2+n20lz5By3ljOF7E10WgaTromivrWIrNA2fKPDADGf5j86zdO1h7fWLz7PdpbNcRruBhVlbDZxyeMda7HT5542LJrUCyTvtdzCnCtyWwW4HyCmpWKcOaKZ3M+qafrZ+x31hOIxIQMxAlDgEA89eprQg0Hwxp0wnXw8skm7YsksfmYOfQnANeaaXeXa7ryTVYBLNOHk/dRgN/ACDuz90Dj1NelwSyGzG26Vo1kVjLsUjOckjnnnnHvWlNRfTUwquceuhrzaiRY7TYyoVYIi+VhQc8cZ7/AM6z75RNe2yGC9ZG3byybuR0X0HGe2eKtpIZZHE9/ETkcsi4yuCMDPvmq11eXLrbyG/iBRxIxCp9MdenJ/KtdjIz5bOzsrqO7tNKupImBa4jClmkH8L8nJIPv0pbI6fBPcQpYXMdrNumiZUwpLHlf5H8TTpdQubXUBNJqdukDQ7FTy1yCG+vI6VXvoZbJ4oY9XhMCSrJDmNflP8AEmc9CMkflSuBV0uwsdH1Z7eDTr6KMfucLHwyn5kc49CWXP0qS2Gm6P4sAWyvNupncqupKsw6/rn8xUtzdT3M6XL6zbwRCNgGVEy67xgcnrkZ4zSXMsmoQxi31qCHyyNsgjRjg84HPqBRdgrdDRt7aytpnjGmstvIpQqIzlgMgd+wIH4VEl1YWJgR7S4juImMUKmLdkYGMAHjIGcH0rImutWlYRQ6xZo4maN22pnbjry31qtHp1y2qNcvqsckyx/M3loQ+OAQM46MckUrjsdZYalarG+yzu0O7lwm0kHH6VheKW1a30v7VorSzycl1uFywX1X1x6GqkM15HHcKNTiyF6si4bgYA5z3Nai+bbr5MuoxShUwNsa5GTjnn2qr2FY8i1qbV5LgLrb3BcjcqTHAA9l6Cs3dXrPiTwlba3axXLXKRXjO6JKv3eDwCM98dRXlmo6fc6VqElnfII5ozyAcg+hB7g1LT3ZSaeiIg3rRTVFFIZylleNAxAwM9Ce1eq6NqVxFCv9s+Gmublk2osdqqlwvcKeW6jJHrXkMqJGwCPv4+bjofStSLxVrMdo9ut/KVdg24sSy4O7CnsCQCcdcCuS53uNzqNX8U6Fc2ws/wCxvJlVDHJKqJk5AB98g5NV7DWvD2nwXEMelyXEbnMbyojFMqB3569q40uZHLucsxyT6mrERyKpC2R6Lpt3aavpaR2PhuOSbe+Jv3Ks3Xgjg/xL+VemaJIw8OwuujbNqgBU8s7cDDfnivBNDuNQt52bTrxLXBDMXkVM+nLfSvbPD8+qDw1bpJqUG4rn/XR4OQec1vR3OTEPRG24B2SPpXywneyDYMALgA/57Uy6uYo7eSOXR0UMN2V8s4GMj+RrHe+v4w2+/SQMo37Z4xu+pP1qvLrsskgjudVtoYAAJG86MMRgggZPP/162aRyps3ywWKKR9Ki86IAbAY9zbuMEn3/AJVz13FNqVuZbTSVQLtZfmj/AHmG3EYzxwe9Q6n400NEQNrUo+ZQGSSFmLZ4Jwe3P0rnD4k0eyWVbDVrkyyLkgzQ+Wzcnk596zcl3No05PobU1jHqN1J9s0Y2yRAllLRggN90YB6Dmq13JbXVyY9P0OW3jt33y4MaF8ggcD6E/hWY3i6C4kOdauYty/vCZYCSPQGudm1zVXvZRBrUZtpGAXzJ4dzIOQG9Dyaz5kdHI+p6Pp8GnwWCpPoe+7wNwmki3AjGec89RWrfeQumiKXSfs8SY3GNoy3AyeRznivJdR1O7u7iCcalCGgYvG32qPcrkcnA+mPfitzTvE+p3yxi91SBpFORtuIvnJHp2OK0T1MZRaVz0yFLDS9JhafRN0asCspCMdp5Hv0qzb6vo0aiR9MXJyyqY075PX8q80vvGWsxRGG8vVuEf8A5Zgq2Me4p0fjCKRTG8XBGBnnFaxUXuYScl8J6npasuhxNFpu9HJeMJs3cE9s8datNpenXMLz6loUMx8opMZokJAxkHd1GAO1eT3vi2Se3itLf93AuQi9Tz1PtS2mrXl9ciLz3MUa5fJ4C+n41TSuSpNIm8QeCLufZqnhvTWaxuGKi2gJZoiDwcHnBFFdNpuv3quiQ/JHGg6jjJ70UvZpjVSx8006iivMPZJFqwn9KKK0iQyz0sxj1r1ez48OwkdVjXafTpRRXRA4q/Q4/Wr26VZttzMMMMYkPrR4QijvrO4kvY1uJPPA3zLvOPTJoopvcmHwkmrWVqobbbQjk9Ix61yd9DGkeVjVTnsooorGZ1UzNH8VS2//AB8J9aKKiO5s9ia6AE7YFaN2oSztSgCnaDkDHaiitVuzGXQ0ZGLQKzEk5AyT7UW5O4nvtooroOPoTwEm6fJz8q11PhQBlutwzyRzRRTRlI7JwFuFCjA44H1oooroWxzs/9k=", 2023 },
                    { new Guid("ec655172-0c4d-4911-8986-b34fef20c06c"), "Zachary Levi, Helen Mirren, Lucy Liu", "SAD", "Svi imamo superjunake u sebi, potrebno je samo malo magije. U slučaju 14-godišnjeg dječaka Billyja Batsona potrebno je samo reći SHAZAM!Henry Gayden je i ovog puta napisao scenarij pun akcije i smijeha.Superheroj Shazam je cinični tinejdžer koji se trudi pronaći svoje mjesto u svijetu i ne zna ništa o takvim junacima, a kamoli kako biti jedan. U njegovomse životu sve vrti oko magične riječi koja ga transformira u njegov odrasli alter ego superheroja, Shazama.", "David F. Sandberg ", 130, "akcija, avantura", true, "SHAZAM! BIJES BOGOVA", "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", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("88ad3600-f9fa-4b4d-853e-bbf1bfd2773a"), "Dnevna projekcija", 6m },
                    { new Guid("96a55b26-ffa7-4783-9a87-d875c1cb1f31"), "Vecernja projekcija", 7m },
                    { new Guid("a2be7227-b866-42a3-be4b-a4ab8da5183d"), "Vikend projekcija", 8m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c4724d5c-38b9-4124-a06d-54eb62607e82"), "User" },
                    { new Guid("f952e116-fddc-4a93-b3cb-955c25376720"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Projections",
                columns: new[] { "Id", "EndTime", "HallId", "IsActive", "MovieId", "PriceId", "StartTime", "StateMachine" },
                values: new object[,]
                {
                    { new Guid("04c73069-65bd-4562-b559-49488e2a1cfe"), new DateTime(2023, 5, 14, 3, 34, 44, 260, DateTimeKind.Local).AddTicks(3036), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), true, new Guid("ec655172-0c4d-4911-8986-b34fef20c06c"), new Guid("88ad3600-f9fa-4b4d-853e-bbf1bfd2773a"), new DateTime(2023, 5, 14, 1, 34, 44, 260, DateTimeKind.Local).AddTicks(3033), "Active" },
                    { new Guid("0983503e-15e9-4e6f-a091-f1072d335dba"), new DateTime(2023, 5, 14, 9, 34, 44, 260, DateTimeKind.Local).AddTicks(3157), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), true, new Guid("3d81dd51-584c-46be-a7d2-2333c2bebb00"), new Guid("88ad3600-f9fa-4b4d-853e-bbf1bfd2773a"), new DateTime(2023, 5, 14, 7, 34, 44, 260, DateTimeKind.Local).AddTicks(3155), "Active" },
                    { new Guid("0a6a1b7f-2b04-47aa-8559-653ee4ce8618"), new DateTime(2023, 5, 14, 2, 34, 44, 260, DateTimeKind.Local).AddTicks(3140), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), true, new Guid("37f256ba-d472-4dc2-9e18-4f536e50bc59"), new Guid("96a55b26-ffa7-4783-9a87-d875c1cb1f31"), new DateTime(2023, 5, 14, 0, 34, 44, 260, DateTimeKind.Local).AddTicks(3138), "Active" },
                    { new Guid("1bf4537b-18a3-4e64-b607-dbf0028e669d"), new DateTime(2023, 5, 14, 2, 34, 44, 260, DateTimeKind.Local).AddTicks(3129), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), true, new Guid("bb1759c3-3375-4513-8f31-eb209c65d2a9"), new Guid("96a55b26-ffa7-4783-9a87-d875c1cb1f31"), new DateTime(2023, 5, 14, 0, 34, 44, 260, DateTimeKind.Local).AddTicks(3126), "Active" },
                    { new Guid("204c516f-0744-47ec-98bf-7f4e2f6f9afc"), new DateTime(2023, 5, 14, 1, 34, 44, 260, DateTimeKind.Local).AddTicks(3028), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), true, new Guid("ec655172-0c4d-4911-8986-b34fef20c06c"), new Guid("88ad3600-f9fa-4b4d-853e-bbf1bfd2773a"), new DateTime(2023, 5, 13, 23, 34, 44, 260, DateTimeKind.Local).AddTicks(3025), "Active" },
                    { new Guid("20b4d454-630d-4e34-924b-a1759a070ab1"), new DateTime(2023, 5, 13, 23, 34, 44, 260, DateTimeKind.Local).AddTicks(3065), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), true, new Guid("0f453479-a1e1-4668-b25f-46caf0712d37"), new Guid("88ad3600-f9fa-4b4d-853e-bbf1bfd2773a"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3063), "Active" },
                    { new Guid("2ba0efc4-0616-4cc7-86dd-ab5911a548a7"), new DateTime(2023, 5, 14, 12, 34, 44, 260, DateTimeKind.Local).AddTicks(3111), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), true, new Guid("bb1759c3-3375-4513-8f31-eb209c65d2a9"), new Guid("96a55b26-ffa7-4783-9a87-d875c1cb1f31"), new DateTime(2023, 5, 14, 10, 34, 44, 260, DateTimeKind.Local).AddTicks(3109), "Active" },
                    { new Guid("30cab3fa-badc-4c9f-bfe6-d1bdd6a5acfd"), new DateTime(2023, 5, 13, 23, 34, 44, 260, DateTimeKind.Local).AddTicks(3018), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), true, new Guid("ec655172-0c4d-4911-8986-b34fef20c06c"), new Guid("88ad3600-f9fa-4b4d-853e-bbf1bfd2773a"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(2976), "Active" },
                    { new Guid("3996354a-6603-40f0-9df9-42e29c84abe4"), new DateTime(2023, 5, 14, 23, 34, 44, 260, DateTimeKind.Local).AddTicks(3050), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), true, new Guid("5e24ca83-02d0-46c8-ad0f-be936de3a255"), new Guid("88ad3600-f9fa-4b4d-853e-bbf1bfd2773a"), new DateTime(2023, 5, 14, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3048), "Active" },
                    { new Guid("3a4c09bd-6d76-44a8-8cab-c363798a7e7f"), new DateTime(2023, 5, 14, 9, 34, 44, 260, DateTimeKind.Local).AddTicks(3168), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), true, new Guid("8f41e10c-85ed-4ef2-9064-dd8394f3b2e2"), new Guid("88ad3600-f9fa-4b4d-853e-bbf1bfd2773a"), new DateTime(2023, 5, 14, 7, 34, 44, 260, DateTimeKind.Local).AddTicks(3166), "Active" },
                    { new Guid("4076619e-b114-483e-a7de-a436b82d1b92"), new DateTime(2023, 5, 14, 9, 34, 44, 260, DateTimeKind.Local).AddTicks(3134), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), true, new Guid("37f256ba-d472-4dc2-9e18-4f536e50bc59"), new Guid("88ad3600-f9fa-4b4d-853e-bbf1bfd2773a"), new DateTime(2023, 5, 14, 7, 34, 44, 260, DateTimeKind.Local).AddTicks(3132), "Active" },
                    { new Guid("4cac76b5-dc72-4bff-9c2a-27b04462fcdc"), new DateTime(2023, 5, 13, 23, 34, 44, 260, DateTimeKind.Local).AddTicks(3084), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), true, new Guid("e843cb70-2cf0-47cc-a7f7-c08a139dc98e"), new Guid("88ad3600-f9fa-4b4d-853e-bbf1bfd2773a"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3082), "Active" },
                    { new Guid("560219eb-51c7-4b9c-a253-b17cf4f67fc9"), new DateTime(2023, 5, 13, 23, 34, 44, 260, DateTimeKind.Local).AddTicks(3106), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), true, new Guid("e843cb70-2cf0-47cc-a7f7-c08a139dc98e"), new Guid("88ad3600-f9fa-4b4d-853e-bbf1bfd2773a"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3104), "Active" },
                    { new Guid("65648c6a-ce0f-49e0-b95e-d660c7f37bc6"), new DateTime(2023, 5, 14, 2, 34, 44, 260, DateTimeKind.Local).AddTicks(3152), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), true, new Guid("bb0f3ad3-9f5e-4faa-a989-b4d987b3e150"), new Guid("96a55b26-ffa7-4783-9a87-d875c1cb1f31"), new DateTime(2023, 5, 14, 0, 34, 44, 260, DateTimeKind.Local).AddTicks(3150), "Active" },
                    { new Guid("6d9a93b2-89e5-481d-876f-56b3d0a17478"), new DateTime(2023, 5, 14, 2, 34, 44, 260, DateTimeKind.Local).AddTicks(3174), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), true, new Guid("3d81dd51-584c-46be-a7d2-2333c2bebb00"), new Guid("96a55b26-ffa7-4783-9a87-d875c1cb1f31"), new DateTime(2023, 5, 14, 0, 34, 44, 260, DateTimeKind.Local).AddTicks(3172), "Active" },
                    { new Guid("72672abe-3874-4c9c-abda-8c986561d7e8"), new DateTime(2023, 5, 14, 2, 34, 44, 260, DateTimeKind.Local).AddTicks(3099), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), true, new Guid("e843cb70-2cf0-47cc-a7f7-c08a139dc98e"), new Guid("a2be7227-b866-42a3-be4b-a4ab8da5183d"), new DateTime(2023, 5, 14, 0, 34, 44, 260, DateTimeKind.Local).AddTicks(3097), "Active" },
                    { new Guid("a75b1622-5153-4117-aa2d-2c78166a884f"), new DateTime(2023, 5, 13, 23, 34, 44, 260, DateTimeKind.Local).AddTicks(3043), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), true, new Guid("d5a6425b-c53f-4a17-8b0b-88c8c4a95f99"), new Guid("88ad3600-f9fa-4b4d-853e-bbf1bfd2773a"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3041), "Active" },
                    { new Guid("b2f6fd09-fa95-4e8d-a83e-13fac4cb583f"), new DateTime(2023, 5, 13, 23, 34, 44, 260, DateTimeKind.Local).AddTicks(3120), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), true, new Guid("bb1759c3-3375-4513-8f31-eb209c65d2a9"), new Guid("88ad3600-f9fa-4b4d-853e-bbf1bfd2773a"), new DateTime(2023, 5, 14, 7, 34, 44, 260, DateTimeKind.Local).AddTicks(3118), "Active" },
                    { new Guid("c2c0e52a-78a1-4327-a7b9-07aa6d5617ec"), new DateTime(2023, 5, 14, 2, 34, 44, 260, DateTimeKind.Local).AddTicks(3163), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), true, new Guid("8f41e10c-85ed-4ef2-9064-dd8394f3b2e2"), new Guid("96a55b26-ffa7-4783-9a87-d875c1cb1f31"), new DateTime(2023, 5, 14, 0, 34, 44, 260, DateTimeKind.Local).AddTicks(3161), "Active" },
                    { new Guid("d497724d-fb94-4567-8ecc-dfe1a7e25c5e"), new DateTime(2023, 5, 14, 2, 34, 44, 260, DateTimeKind.Local).AddTicks(3091), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), true, new Guid("e843cb70-2cf0-47cc-a7f7-c08a139dc98e"), new Guid("96a55b26-ffa7-4783-9a87-d875c1cb1f31"), new DateTime(2023, 5, 14, 0, 34, 44, 260, DateTimeKind.Local).AddTicks(3089), "Active" },
                    { new Guid("d5b3d0e3-d66a-48c1-9508-00e3a0e2fb5e"), new DateTime(2023, 5, 14, 2, 34, 44, 260, DateTimeKind.Local).AddTicks(3058), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), true, new Guid("d5a6425b-c53f-4a17-8b0b-88c8c4a95f99"), new Guid("96a55b26-ffa7-4783-9a87-d875c1cb1f31"), new DateTime(2023, 5, 14, 0, 34, 44, 260, DateTimeKind.Local).AddTicks(3056), "Active" },
                    { new Guid("e5fe1952-b3d8-41c6-81ca-736cb17cf41d"), new DateTime(2023, 5, 14, 9, 34, 44, 260, DateTimeKind.Local).AddTicks(3146), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), true, new Guid("bb0f3ad3-9f5e-4faa-a989-b4d987b3e150"), new Guid("88ad3600-f9fa-4b4d-853e-bbf1bfd2773a"), new DateTime(2023, 5, 14, 7, 34, 44, 260, DateTimeKind.Local).AddTicks(3144), "Active" },
                    { new Guid("f3a0b5a0-0fbd-4d92-828d-e722d719a13f"), new DateTime(2023, 5, 14, 2, 34, 44, 260, DateTimeKind.Local).AddTicks(3076), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), true, new Guid("0f453479-a1e1-4668-b25f-46caf0712d37"), new Guid("96a55b26-ffa7-4783-9a87-d875c1cb1f31"), new DateTime(2023, 5, 14, 0, 34, 44, 260, DateTimeKind.Local).AddTicks(3074), "Active" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Name" },
                values: new object[,]
                {
                    { new Guid("055238a8-4888-4d8e-bce4-ec90be680b8e"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "D1" },
                    { new Guid("0caaff76-7ccc-41bb-9d9b-734fd2ad2827"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "A0" },
                    { new Guid("0d549b84-83f9-4d20-9da9-65370b968dcb"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "B2" },
                    { new Guid("0d94fb5c-1f1a-4fa3-b1c4-a1ff71ce95b8"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "C2" },
                    { new Guid("1033ffae-94b0-458a-9d72-ea804feda152"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "C3" },
                    { new Guid("1342d65d-611f-4afd-9a4e-ab8b7db50dec"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "A2" },
                    { new Guid("14752418-ec08-489e-8656-ef54e6cb2991"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "A5" },
                    { new Guid("174c0b85-7f39-49e6-9ab3-82777503ee29"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "A4" },
                    { new Guid("1b8b72d0-2c2a-4400-8eaa-61e712a76018"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "A3" },
                    { new Guid("1d58cc10-d97d-49bb-8efd-50dc5c44bc7e"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "C2" },
                    { new Guid("1e16ca1c-7545-4318-aab1-260975280f39"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "B4" },
                    { new Guid("1ff4c441-6029-4833-b31a-3d82eb5eb71f"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "C1" },
                    { new Guid("20a2ac77-8459-46c7-bbaa-4e86f666fc47"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "D4" },
                    { new Guid("249756b0-df5c-4ffb-a7b3-32fedf70b84a"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "D3" },
                    { new Guid("29966b8c-d6ab-4f37-8c24-81f24b54cb8c"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "A5" },
                    { new Guid("2b6f1d0a-5c8d-4c1b-904f-ad59e36f018d"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "A4" },
                    { new Guid("2b72c3c9-d626-4d95-9ec3-493994e0f47c"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "D4" },
                    { new Guid("2dd168e4-e2ac-4470-bcaf-dc3cc047ac74"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "C4" },
                    { new Guid("30477a37-d5a2-4fb2-83f3-2d5d18dd99a3"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "B4" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Name" },
                values: new object[,]
                {
                    { new Guid("331683b7-de99-447d-bd67-ff3b926d2ce7"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "C2" },
                    { new Guid("33278bae-dd5d-4a67-99ff-c7519805e75f"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "C4" },
                    { new Guid("35b9d43c-c1dd-4da3-af40-584225214c8e"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "A4" },
                    { new Guid("364b6305-1d24-4e61-9dc1-c00b1e8f4710"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "C1" },
                    { new Guid("3aa1a9b6-de1e-42c2-b8c8-090e32cb7b57"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "C5" },
                    { new Guid("3aa84e02-1b27-47b4-849a-16c190bb4432"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "C2" },
                    { new Guid("3c666582-22fd-4161-9a9d-c2a26697e50f"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "B1" },
                    { new Guid("403f0100-dfb7-4af8-a399-134ecb66a4c8"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "B3" },
                    { new Guid("41a3408d-c4d3-47c8-b2b5-2a6bd6eb2ed6"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "B3" },
                    { new Guid("4e60fceb-276b-44bb-8e95-3188d71e9cd4"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "B1" },
                    { new Guid("5542e314-4504-4943-b67d-83b6582bc02b"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "C1" },
                    { new Guid("598d35c7-6e7a-4c42-9da2-aede7c99f267"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "B2" },
                    { new Guid("5be8cd33-597c-4f02-a6e0-49a147a0a830"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "A5" },
                    { new Guid("5d8449b7-3610-4eae-96bc-3a1c6f98716a"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "B5" },
                    { new Guid("5d8a354f-ff59-4968-9167-99d636574f44"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "B2" },
                    { new Guid("5f65b725-175f-4c5f-a1da-0c52dc936318"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "D2" },
                    { new Guid("612c2066-1ecb-4b33-a723-54dd105b602a"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "C4" },
                    { new Guid("634440dd-888e-44d9-b4bb-d4477982faca"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "D3" },
                    { new Guid("6782d89f-aaaf-4a56-8550-cce52ed7d44b"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "A2" },
                    { new Guid("67a556ab-82bc-496e-988a-3cd2853f703b"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "A1" },
                    { new Guid("6844dc5d-4e2d-4bcb-813b-29f023b8ef01"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "A4" },
                    { new Guid("6cf96063-dc29-41f7-8e05-830bba21462c"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "A3" },
                    { new Guid("75a1d3b3-cf70-4c30-9ecb-ab8c74392d9b"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "A5" },
                    { new Guid("787dc146-4128-472b-82b3-9005ab28f2d1"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "C2" },
                    { new Guid("7a4fc300-260f-490a-b826-6f678eaecbb7"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "B1" },
                    { new Guid("7aa964f4-1a49-421c-b9e3-cf7ff6968136"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "D4" },
                    { new Guid("7dd0b9b0-69b1-4c25-834f-a63d7e94c8f0"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "D4" },
                    { new Guid("83ff7ab9-d126-449e-aade-ed00653b1629"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "C4" },
                    { new Guid("845829b6-431b-46b2-8b0c-d97b8383da70"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "B1" },
                    { new Guid("86aa1b91-686b-4cfd-b154-524d6b8cd6f0"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "A1" },
                    { new Guid("87521de9-cd0f-4313-a70a-8413f6e9b0f4"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "B2" },
                    { new Guid("8a99e99d-5f05-46b0-8ca3-0f23902a7506"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "B5" },
                    { new Guid("92dc89cb-7cdb-4359-ac68-b82cc0ea05b3"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "B4" },
                    { new Guid("9e4c98e6-dedf-4a49-a00a-77dfdcd74c60"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "A0" },
                    { new Guid("a19f2e7f-7439-4c98-94f3-d6f2f9b57c84"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "B5" },
                    { new Guid("a54c5b5a-916e-4068-bfd7-c01d6b1a3d16"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "A3" },
                    { new Guid("a5ad1211-5b31-469d-b98e-77ff1c241ba2"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "C1" },
                    { new Guid("a6accafd-4d56-4890-a6a6-89af450bc566"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "B2" },
                    { new Guid("aaad1a9f-b831-4474-a8a4-b36e3e6a3ae9"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "B3" },
                    { new Guid("ac23c91d-1361-4f60-a7ca-7cce9e9e3c12"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "B3" },
                    { new Guid("b05a968c-f9b0-42f8-84cc-f7327bba26f8"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "D2" },
                    { new Guid("b0a6407a-6da1-444c-9246-d3beecfaed0e"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "D3" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Name" },
                values: new object[,]
                {
                    { new Guid("b0cc744f-7976-499b-a797-3e61547e7d8e"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "C3" },
                    { new Guid("b3050775-329d-4326-8934-b5d3ca91eaa0"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "A1" },
                    { new Guid("b69552f4-30d9-46de-be0f-d3dc493d5016"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "A2" },
                    { new Guid("b931ab61-ee95-441d-b3c7-bbbf97e5359a"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "A1" },
                    { new Guid("b9fabe57-ac7a-44ba-8476-f3b7b23dc1ae"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "D2" },
                    { new Guid("bbf35135-a5ef-4c96-8ae8-dcd108cdca98"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "A3" },
                    { new Guid("bc880064-28ec-44b3-96a8-2a943ffcfa72"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "A4" },
                    { new Guid("c0af86f0-f54c-45a9-bcab-de7db5cfb8e7"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "B5" },
                    { new Guid("c2754c58-32bd-4594-a469-24900a6340b0"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "D2" },
                    { new Guid("c2ba9d73-df65-48c8-94fe-a4394dee93f1"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "C3" },
                    { new Guid("c52f8ab4-d33a-43c5-b225-8841a02ba4b8"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "A0" },
                    { new Guid("c629ec67-732e-4796-8c57-a43fafec1eca"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "A5" },
                    { new Guid("c7e0bbfd-7554-48bb-a240-657338dcf0a6"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "C5" },
                    { new Guid("cae51a41-ccb5-42e2-b3fe-4fe0673ab7cc"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "C3" },
                    { new Guid("d3467857-1557-44b1-9f22-6af9b762bd95"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "D1" },
                    { new Guid("da2c86af-8676-433c-93d4-6e65723bf6ad"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "A0" },
                    { new Guid("dabc1f88-50f2-4b33-a30a-8e621d770efe"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "A2" },
                    { new Guid("db421cc6-2d98-41bf-ba89-62910316a3a5"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "D4" },
                    { new Guid("df2e6131-bb1f-4a1a-bb7a-c3686066c1f6"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "B1" },
                    { new Guid("e4ad5923-62c5-4215-8378-b4649cbf01e8"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "C1" },
                    { new Guid("e990ef43-b4a5-4333-90b0-dd25c0448367"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "A0" },
                    { new Guid("e9c59ed5-03fa-45a0-86dd-d5e3b826f08c"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "A1" },
                    { new Guid("ea225f4b-4a2d-486b-b940-2b178d97a537"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "D1" },
                    { new Guid("ec78fd21-22f5-441f-bfe9-02d0c93c3255"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "B4" },
                    { new Guid("ed22f82a-bd2b-4d2e-95b4-8475dc6b94d7"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "A3" },
                    { new Guid("ed4b6868-e79f-4cd3-a373-e139978ab437"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "C3" },
                    { new Guid("ee93e6f9-9fc6-45da-b489-76571d9ed11b"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "A2" },
                    { new Guid("f01d41ec-c612-4d44-9c77-7a5b16e139b8"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "B5" },
                    { new Guid("f0fe48e9-86cd-477d-8398-a4300bf4b470"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "D1" },
                    { new Guid("f14414c6-a2ad-4ed2-ac40-51ef0ee67c7d"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "C5" },
                    { new Guid("f2148edc-3e78-4326-a888-7b61caf7e917"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "B3" },
                    { new Guid("f363cb49-4134-452b-a6d3-06d63d5f8e07"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "D2" },
                    { new Guid("f5f88765-463e-4897-9815-46a5ee085dbb"), new Guid("f689a67f-7609-4715-b304-d3d871cdbc5b"), "D3" },
                    { new Guid("f7653960-b2fb-46fc-b02f-500ed6245b06"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "C5" },
                    { new Guid("f9e1a66f-529e-47b5-8078-46481bba4708"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "C5" },
                    { new Guid("fc99de05-2eb7-4f62-bd25-3d86d956889c"), new Guid("0c2c572a-004a-4afb-96ca-702de1b99459"), "C4" },
                    { new Guid("fcbc3ae1-1cac-4e1f-9f5a-89ff8da683c4"), new Guid("352e5970-72bf-43fc-ba23-e7e5742eda66"), "D3" },
                    { new Guid("ff4d2cee-138b-495d-81cc-cfcbcfd55fab"), new Guid("4e5cddeb-0ea4-4690-bee4-ac9f89f0fd79"), "B4" },
                    { new Guid("ff70d08e-5586-4a0a-9fd0-e40b9b947988"), new Guid("25ffdb23-bc4a-4f7a-825e-eef8c9216857"), "D1" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CustomerId", "Email", "FirstName", "IsActive", "LastName", "LozinkaHash", "LozinkaSalt", "PhoneNumber", "RoleId", "Username" },
                values: new object[,]
                {
                    { new Guid("67021f71-3c90-4edd-a1c8-6d3f0a968810"), null, "user@gmail.com", "User", true, "User", "w/0BHjwv7v0mw9H05lkm4Og3buI=", "yPoj+qydANyumT0AmtjDGQ==", null, new Guid("f952e116-fddc-4a93-b3cb-955c25376720"), "user" },
                    { new Guid("bb5ff9c1-059f-4bf7-8e05-3dec90c862a2"), null, "admin@gmail.com", "Admin", true, "Admin", "UOALub73v5yxKsHo8MZhDeDegtw=", "iNN9mi3V7dQEYyxie90OVw==", null, new Guid("f952e116-fddc-4a93-b3cb-955c25376720"), "admin" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "AuthorId", "Date", "Description", "IsActive", "NotificationType", "Picture", "Title" },
                values: new object[,]
                {
                    { new Guid("1d6afdd1-aa90-4d75-ac49-a259b80da5a0"), new Guid("bb5ff9c1-059f-4bf7-8e05-3dec90c862a2"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3267), "Novi film stiže u eCinema kina. ", true, "Ponuda", "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", "Novi film u ponudi." },
                    { new Guid("4e3b258c-85e6-4a9e-b265-c0893671f2e0"), new Guid("bb5ff9c1-059f-4bf7-8e05-3dec90c862a2"), new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sretan 1. maj praznik rada. ", true, "Neradni dan", "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", "Neradni dan povodom Praznika Rada." },
                    { new Guid("6eba16cc-94a8-4bcf-a1ae-62686cd2dbf6"), new Guid("bb5ff9c1-059f-4bf7-8e05-3dec90c862a2"), new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sretan Dana nezavisnosti BiH. ", true, "Neradni dan", "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", "Neradni dan povodom Dana nezavisnosti BiH." }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "DateTime", "IsActive", "ProjectionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("09aeb923-8f2d-44ed-b24d-b48434cce049"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3306), true, new Guid("3996354a-6603-40f0-9df9-42e29c84abe4"), new Guid("67021f71-3c90-4edd-a1c8-6d3f0a968810") },
                    { new Guid("192d87a6-2421-45a0-8edb-bc049e1bb8a6"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3356), true, new Guid("e5fe1952-b3d8-41c6-81ca-736cb17cf41d"), new Guid("bb5ff9c1-059f-4bf7-8e05-3dec90c862a2") },
                    { new Guid("228f150c-f920-4bd3-9aa3-f10f08c99663"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3365), true, new Guid("c2c0e52a-78a1-4327-a7b9-07aa6d5617ec"), new Guid("67021f71-3c90-4edd-a1c8-6d3f0a968810") },
                    { new Guid("2b31c844-1506-4ec3-b2f5-b0d9fddd73fc"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3350), true, new Guid("0a6a1b7f-2b04-47aa-8559-653ee4ce8618"), new Guid("67021f71-3c90-4edd-a1c8-6d3f0a968810") },
                    { new Guid("365f2e8d-f7a1-4444-8db8-8c58231c4bb1"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3302), true, new Guid("a75b1622-5153-4117-aa2d-2c78166a884f"), new Guid("bb5ff9c1-059f-4bf7-8e05-3dec90c862a2") },
                    { new Guid("552d500e-c57d-4513-893f-a3f64205e70a"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3317), true, new Guid("f3a0b5a0-0fbd-4d92-828d-e722d719a13f"), new Guid("bb5ff9c1-059f-4bf7-8e05-3dec90c862a2") },
                    { new Guid("616611a5-21ae-4634-94b4-82912199a9fa"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3369), true, new Guid("3a4c09bd-6d76-44a8-8cab-c363798a7e7f"), new Guid("bb5ff9c1-059f-4bf7-8e05-3dec90c862a2") },
                    { new Guid("6cc6418a-fdce-424b-ae5c-8339b027ee97"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3334), true, new Guid("560219eb-51c7-4b9c-a253-b17cf4f67fc9"), new Guid("bb5ff9c1-059f-4bf7-8e05-3dec90c862a2") },
                    { new Guid("740ea0e0-41ca-4965-bc35-8a6408f077af"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3295), true, new Guid("204c516f-0744-47ec-98bf-7f4e2f6f9afc"), new Guid("bb5ff9c1-059f-4bf7-8e05-3dec90c862a2") },
                    { new Guid("766d5915-1e08-49f7-bb43-7cb65b8ab996"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3311), true, new Guid("d5b3d0e3-d66a-48c1-9508-00e3a0e2fb5e"), new Guid("bb5ff9c1-059f-4bf7-8e05-3dec90c862a2") },
                    { new Guid("835e86c4-902c-495d-8986-fe7a3eb068b0"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3299), true, new Guid("04c73069-65bd-4562-b559-49488e2a1cfe"), new Guid("67021f71-3c90-4edd-a1c8-6d3f0a968810") },
                    { new Guid("8925ba7a-09fb-4a1b-9e3c-6a44a3bdd827"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3337), true, new Guid("2ba0efc4-0616-4cc7-86dd-ab5911a548a7"), new Guid("67021f71-3c90-4edd-a1c8-6d3f0a968810") },
                    { new Guid("959f86ab-ebff-414c-9dc4-8496e69368cc"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3359), true, new Guid("65648c6a-ce0f-49e0-b95e-d660c7f37bc6"), new Guid("67021f71-3c90-4edd-a1c8-6d3f0a968810") },
                    { new Guid("9efe89a0-bb30-4368-b4dd-8ee7de95acc2"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3343), true, new Guid("1bf4537b-18a3-4e64-b607-dbf0028e669d"), new Guid("67021f71-3c90-4edd-a1c8-6d3f0a968810") },
                    { new Guid("a29ffaca-4571-4e0b-b651-f905c90515ea"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3321), true, new Guid("4cac76b5-dc72-4bff-9c2a-27b04462fcdc"), new Guid("67021f71-3c90-4edd-a1c8-6d3f0a968810") },
                    { new Guid("a47aafcf-7639-443f-8e84-5e2efae0d27d"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3346), true, new Guid("4076619e-b114-483e-a7de-a436b82d1b92"), new Guid("bb5ff9c1-059f-4bf7-8e05-3dec90c862a2") },
                    { new Guid("ac9145c7-c368-4d80-a93b-c4f83d09eaeb"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3314), true, new Guid("20b4d454-630d-4e34-924b-a1759a070ab1"), new Guid("67021f71-3c90-4edd-a1c8-6d3f0a968810") },
                    { new Guid("af868671-4e22-4bad-9b79-f6112418fb07"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3331), true, new Guid("72672abe-3874-4c9c-abda-8c986561d7e8"), new Guid("67021f71-3c90-4edd-a1c8-6d3f0a968810") },
                    { new Guid("c0a09475-3173-40eb-bc87-51cbb0b639c8"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3327), true, new Guid("d497724d-fb94-4567-8ecc-dfe1a7e25c5e"), new Guid("bb5ff9c1-059f-4bf7-8e05-3dec90c862a2") },
                    { new Guid("c3ba2f42-9e6d-47aa-93f2-2bf5dc838190"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3362), true, new Guid("0983503e-15e9-4e6f-a091-f1072d335dba"), new Guid("bb5ff9c1-059f-4bf7-8e05-3dec90c862a2") },
                    { new Guid("cbab20aa-edc8-4ffa-86e4-ac5d6a0f0b96"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3286), true, new Guid("30cab3fa-badc-4c9f-bfe6-d1bdd6a5acfd"), new Guid("67021f71-3c90-4edd-a1c8-6d3f0a968810") },
                    { new Guid("f718bf63-8a5a-4253-9bd5-801b256a2949"), new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3340), true, new Guid("b2f6fd09-fa95-4e8d-a83e-13fac4cb583f"), new Guid("bb5ff9c1-059f-4bf7-8e05-3dec90c862a2") }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "Created", "ReservationId", "StripePaymentId" },
                values: new object[,]
                {
                    { new Guid("08b33276-70f8-4359-af5e-1ef5fe93dd1d"), 18m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3577), new Guid("a47aafcf-7639-443f-8e84-5e2efae0d27d"), "stripe payment id" },
                    { new Guid("275165a2-390a-46ac-b2c4-474fb234a959"), 18m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3584), new Guid("192d87a6-2421-45a0-8edb-bc049e1bb8a6"), "stripe payment id" },
                    { new Guid("290ea445-5cf1-4238-ab29-741cec47cd57"), 18m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3523), new Guid("740ea0e0-41ca-4965-bc35-8a6408f077af"), "stripe payment id" },
                    { new Guid("306f1ffd-845d-4d0c-8bb2-1cf8610f1e06"), 24m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3573), new Guid("9efe89a0-bb30-4368-b4dd-8ee7de95acc2"), "stripe payment id" },
                    { new Guid("37f13a82-949f-44fb-a8fb-7265e626c6a9"), 24m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3580), new Guid("2b31c844-1506-4ec3-b2f5-b0d9fddd73fc"), "stripe payment id" },
                    { new Guid("44812a9b-40ef-48e8-8109-4afb6d7501af"), 18m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3555), new Guid("c0a09475-3173-40eb-bc87-51cbb0b639c8"), "stripe payment id" },
                    { new Guid("5341c14a-f139-4a07-b9af-a67c326dbadb"), 24m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3536), new Guid("09aeb923-8f2d-44ed-b24d-b48434cce049"), "stripe payment id" },
                    { new Guid("5b32c8b9-c4df-4f8f-aa33-2340d8edda56"), 18m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3541), new Guid("766d5915-1e08-49f7-bb43-7cb65b8ab996"), "stripe payment id" },
                    { new Guid("5f252452-2196-48b1-ad61-5ef263750248"), 18m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3564), new Guid("6cc6418a-fdce-424b-ae5c-8339b027ee97"), "stripe payment id" },
                    { new Guid("70fba6a5-d183-4647-a8fd-10704893433d"), 24m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3527), new Guid("835e86c4-902c-495d-8986-fe7a3eb068b0"), "stripe payment id" },
                    { new Guid("736ea45b-8f77-41ad-9063-f3bb7d302cd3"), 24m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3544), new Guid("ac9145c7-c368-4d80-a93b-c4f83d09eaeb"), "stripe payment id" },
                    { new Guid("8b1b16d8-25b1-429f-b825-e55335fd185a"), 18m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3599), new Guid("616611a5-21ae-4634-94b4-82912199a9fa"), "stripe payment id" },
                    { new Guid("9b7fc596-a548-422c-a420-c611341842d7"), 24m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3558), new Guid("af868671-4e22-4bad-9b79-f6112418fb07"), "stripe payment id" },
                    { new Guid("9eff2b34-db53-47fa-8028-e9c1e9d41fa8"), 24m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3596), new Guid("228f150c-f920-4bd3-9aa3-f10f08c99663"), "stripe payment id" },
                    { new Guid("a4b573b1-092f-4e75-9227-3fc25b3e2c56"), 18m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3570), new Guid("f718bf63-8a5a-4253-9bd5-801b256a2949"), "stripe payment id" },
                    { new Guid("a61941ff-a85e-4457-866b-06fcd66cfedd"), 24m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3588), new Guid("959f86ab-ebff-414c-9dc4-8496e69368cc"), "stripe payment id" },
                    { new Guid("b289cdf1-2372-480b-a60f-1ff272ede29b"), 24m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3567), new Guid("8925ba7a-09fb-4a1b-9e3c-6a44a3bdd827"), "stripe payment id" },
                    { new Guid("c6597743-9eff-4544-b947-2b69417aea4c"), 24m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3551), new Guid("a29ffaca-4571-4e0b-b651-f905c90515ea"), "stripe payment id" },
                    { new Guid("cb26ae8b-74c5-44a5-9fe5-6c328e602412"), 18m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3547), new Guid("552d500e-c57d-4513-893f-a3f64205e70a"), "stripe payment id" },
                    { new Guid("e0d85c7d-d384-45cf-9a35-291a3d1ae4ca"), 18m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3532), new Guid("365f2e8d-f7a1-4444-8db8-8c58231c4bb1"), "stripe payment id" },
                    { new Guid("e9098413-af75-4e55-99f8-8b9be65622a4"), 18m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3593), new Guid("c3ba2f42-9e6d-47aa-93f2-2bf5dc838190"), "stripe payment id" },
                    { new Guid("f1e97317-0be3-470b-8d05-f4703852505c"), 24m, new DateTime(2023, 5, 13, 21, 34, 44, 260, DateTimeKind.Local).AddTicks(3517), new Guid("cbab20aa-edc8-4ffa-86e4-ac5d6a0f0b96"), "stripe payment id" }
                });

            migrationBuilder.InsertData(
                table: "SeatReservations",
                columns: new[] { "Id", "IsTaken", "ReservationId", "SeatId" },
                values: new object[,]
                {
                    { new Guid("0df6fa05-9463-40b5-bc55-9a06804725da"), true, new Guid("cbab20aa-edc8-4ffa-86e4-ac5d6a0f0b96"), new Guid("1342d65d-611f-4afd-9a4e-ab8b7db50dec") },
                    { new Guid("13547568-51b6-4254-bde4-404fd4c72900"), true, new Guid("835e86c4-902c-495d-8986-fe7a3eb068b0"), new Guid("ee93e6f9-9fc6-45da-b489-76571d9ed11b") },
                    { new Guid("150a78e3-e085-41b9-85f0-068666f89326"), true, new Guid("a29ffaca-4571-4e0b-b651-f905c90515ea"), new Guid("8a99e99d-5f05-46b0-8ca3-0f23902a7506") },
                    { new Guid("2c458291-117b-41bd-a9f2-25464ae24547"), true, new Guid("f718bf63-8a5a-4253-9bd5-801b256a2949"), new Guid("f7653960-b2fb-46fc-b02f-500ed6245b06") },
                    { new Guid("2f4278b8-084c-480d-86b5-c9f1d7fea55e"), true, new Guid("740ea0e0-41ca-4965-bc35-8a6408f077af"), new Guid("e9c59ed5-03fa-45a0-86dd-d5e3b826f08c") },
                    { new Guid("37cef1e0-098f-4788-b708-77e19b09049c"), true, new Guid("365f2e8d-f7a1-4444-8db8-8c58231c4bb1"), new Guid("6cf96063-dc29-41f7-8e05-830bba21462c") },
                    { new Guid("4079fb17-3765-4b8b-bff1-bf27d72e3269"), true, new Guid("af868671-4e22-4bad-9b79-f6112418fb07"), new Guid("0d94fb5c-1f1a-4fa3-b1c4-a1ff71ce95b8") },
                    { new Guid("43afd2b4-cf9e-4c93-9c9c-1266bc656029"), true, new Guid("766d5915-1e08-49f7-bb43-7cb65b8ab996"), new Guid("5be8cd33-597c-4f02-a6e0-49a147a0a830") },
                    { new Guid("4cb29952-80d7-498b-bd7e-785d58d56e0f"), true, new Guid("8925ba7a-09fb-4a1b-9e3c-6a44a3bdd827"), new Guid("787dc146-4128-472b-82b3-9005ab28f2d1") },
                    { new Guid("4f3a38eb-9c32-4c27-b7b5-2a7ea2ad0cf9"), true, new Guid("ac9145c7-c368-4d80-a93b-c4f83d09eaeb"), new Guid("41a3408d-c4d3-47c8-b2b5-2a6bd6eb2ed6") },
                    { new Guid("63a22d59-26d3-46a2-91b8-d2d2564941b9"), true, new Guid("552d500e-c57d-4513-893f-a3f64205e70a"), new Guid("ec78fd21-22f5-441f-bfe9-02d0c93c3255") },
                    { new Guid("6cc23e03-9406-42d8-8417-30d97f988aeb"), true, new Guid("6cc6418a-fdce-424b-ae5c-8339b027ee97"), new Guid("1ff4c441-6029-4833-b31a-3d82eb5eb71f") },
                    { new Guid("6e1b456f-3403-4c00-a85a-876fbc2d51d8"), true, new Guid("6cc6418a-fdce-424b-ae5c-8339b027ee97"), new Guid("ed4b6868-e79f-4cd3-a373-e139978ab437") },
                    { new Guid("6f25c1bb-6928-4c90-9044-b9f05c276eeb"), true, new Guid("a47aafcf-7639-443f-8e84-5e2efae0d27d"), new Guid("c2754c58-32bd-4594-a469-24900a6340b0") },
                    { new Guid("82e07a5a-4a13-4501-bfcb-3f5a57f97e23"), true, new Guid("9efe89a0-bb30-4368-b4dd-8ee7de95acc2"), new Guid("055238a8-4888-4d8e-bce4-ec90be680b8e") },
                    { new Guid("8865cefa-fbf4-44cc-800e-4fdfc7065711"), true, new Guid("365f2e8d-f7a1-4444-8db8-8c58231c4bb1"), new Guid("14752418-ec08-489e-8656-ef54e6cb2991") },
                    { new Guid("89481f7d-5daf-4f02-adc0-d985f44c6aa8"), true, new Guid("616611a5-21ae-4634-94b4-82912199a9fa"), new Guid("b931ab61-ee95-441d-b3c7-bbbf97e5359a") },
                    { new Guid("8c015deb-f5a9-476b-acea-78a1c1040341"), true, new Guid("09aeb923-8f2d-44ed-b24d-b48434cce049"), new Guid("3c666582-22fd-4161-9a9d-c2a26697e50f") },
                    { new Guid("9109e0f8-b930-4def-8eb9-6ce93ca6a44e"), true, new Guid("f718bf63-8a5a-4253-9bd5-801b256a2949"), new Guid("b0cc744f-7976-499b-a797-3e61547e7d8e") },
                    { new Guid("977b98a8-924e-4a2d-b29c-cd8edcf4aae9"), true, new Guid("835e86c4-902c-495d-8986-fe7a3eb068b0"), new Guid("2b6f1d0a-5c8d-4c1b-904f-ad59e36f018d") }
                });

            migrationBuilder.InsertData(
                table: "SeatReservations",
                columns: new[] { "Id", "IsTaken", "ReservationId", "SeatId" },
                values: new object[,]
                {
                    { new Guid("9b9e848f-346f-4535-85dc-3b9eb3d3b5be"), true, new Guid("a47aafcf-7639-443f-8e84-5e2efae0d27d"), new Guid("f9e1a66f-529e-47b5-8078-46481bba4708") },
                    { new Guid("a80ba98c-ddeb-403c-b86f-8b9114d45b81"), true, new Guid("cbab20aa-edc8-4ffa-86e4-ac5d6a0f0b96"), new Guid("e990ef43-b4a5-4333-90b0-dd25c0448367") },
                    { new Guid("a8827940-45af-4f61-aa1b-c7228c8b1c97"), true, new Guid("8925ba7a-09fb-4a1b-9e3c-6a44a3bdd827"), new Guid("2dd168e4-e2ac-4470-bcaf-dc3cc047ac74") },
                    { new Guid("a8c19546-60a9-4894-8ed3-f1718d1ddcf0"), true, new Guid("2b31c844-1506-4ec3-b2f5-b0d9fddd73fc"), new Guid("ff70d08e-5586-4a0a-9fd0-e40b9b947988") },
                    { new Guid("ab0952eb-e818-408c-a623-f36234724d34"), true, new Guid("228f150c-f920-4bd3-9aa3-f10f08c99663"), new Guid("0caaff76-7ccc-41bb-9d9b-734fd2ad2827") },
                    { new Guid("b3a79afc-70db-4d09-8151-2810a47ea848"), true, new Guid("192d87a6-2421-45a0-8edb-bc049e1bb8a6"), new Guid("b05a968c-f9b0-42f8-84cc-f7327bba26f8") },
                    { new Guid("ccb60dd2-7561-4896-876c-064ee88dff95"), true, new Guid("af868671-4e22-4bad-9b79-f6112418fb07"), new Guid("5d8449b7-3610-4eae-96bc-3a1c6f98716a") },
                    { new Guid("d0e2e822-b733-404a-a7ab-0ba31d70d725"), true, new Guid("c3ba2f42-9e6d-47aa-93f2-2bf5dc838190"), new Guid("db421cc6-2d98-41bf-ba89-62910316a3a5") },
                    { new Guid("d80d911b-2f38-4902-b049-794553201866"), true, new Guid("552d500e-c57d-4513-893f-a3f64205e70a"), new Guid("a6accafd-4d56-4890-a6a6-89af450bc566") },
                    { new Guid("e1a027a4-c340-4313-98f5-346448246663"), true, new Guid("2b31c844-1506-4ec3-b2f5-b0d9fddd73fc"), new Guid("fcbc3ae1-1cac-4e1f-9f5a-89ff8da683c4") },
                    { new Guid("e2823a91-2b85-4535-8f37-152765330781"), true, new Guid("740ea0e0-41ca-4965-bc35-8a6408f077af"), new Guid("ed22f82a-bd2b-4d2e-95b4-8475dc6b94d7") },
                    { new Guid("eaba5668-4ccb-4a0a-8c01-1ef2542455fe"), true, new Guid("a29ffaca-4571-4e0b-b651-f905c90515ea"), new Guid("f2148edc-3e78-4326-a888-7b61caf7e917") },
                    { new Guid("eafc027a-4c0e-4087-95ea-ade36f88487b"), true, new Guid("ac9145c7-c368-4d80-a93b-c4f83d09eaeb"), new Guid("df2e6131-bb1f-4a1a-bb7a-c3686066c1f6") },
                    { new Guid("ed69d0db-591b-4dff-9d79-dc1935e117ac"), true, new Guid("9efe89a0-bb30-4368-b4dd-8ee7de95acc2"), new Guid("612c2066-1ecb-4b33-a723-54dd105b602a") },
                    { new Guid("ef2fb245-5d21-4c94-9743-ca1f86d382df"), true, new Guid("c0a09475-3173-40eb-bc87-51cbb0b639c8"), new Guid("1e16ca1c-7545-4318-aab1-260975280f39") },
                    { new Guid("ef3dc20a-daaa-4a8b-ae33-0ca2d1566611"), true, new Guid("192d87a6-2421-45a0-8edb-bc049e1bb8a6"), new Guid("2b72c3c9-d626-4d95-9ec3-493994e0f47c") },
                    { new Guid("f1356d0d-55e8-41b7-b7eb-2ef14aca15ab"), true, new Guid("c0a09475-3173-40eb-bc87-51cbb0b639c8"), new Guid("5542e314-4504-4943-b67d-83b6582bc02b") },
                    { new Guid("f835d54b-6e7f-44dc-89b3-dac935da0237"), true, new Guid("959f86ab-ebff-414c-9dc4-8496e69368cc"), new Guid("b0a6407a-6da1-444c-9246-d3beecfaed0e") },
                    { new Guid("f89a67c5-7aea-4750-bd10-cf9f11ff864e"), true, new Guid("766d5915-1e08-49f7-bb43-7cb65b8ab996"), new Guid("0d549b84-83f9-4d20-9da9-65370b968dcb") },
                    { new Guid("ff91c737-2987-43ec-ade8-47867c38ae1a"), true, new Guid("09aeb923-8f2d-44ed-b24d-b48434cce049"), new Guid("35b9d43c-c1dd-4da3-af40-584225214c8e") }
                });
        }
    }
}
