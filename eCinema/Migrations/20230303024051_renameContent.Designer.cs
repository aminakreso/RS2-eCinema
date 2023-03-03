﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCinema.Services.Database;

#nullable disable

namespace eCinema.Migrations
{
    [DbContext(typeof(CinemaContext))]
    [Migration("20230303024051_renameContent")]
    partial class renameContent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("eCinema.Services.Database.Hall", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Halls");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b435902d-ba5c-426e-ad15-6f8b6f223296"),
                            Name = "Hall 1"
                        },
                        new
                        {
                            Id = new Guid("eab9738b-3885-4213-ac13-16fd146cd0af"),
                            Name = "Hall 2"
                        },
                        new
                        {
                            Id = new Guid("d54f78ba-5813-4c13-9a05-6706e2c375b9"),
                            Name = "Hall 3"
                        },
                        new
                        {
                            Id = new Guid("58de40f5-6d1f-4354-b1d8-6bb231f08937"),
                            Name = "Hall 4"
                        },
                        new
                        {
                            Id = new Guid("60078146-c136-4659-a5e1-535f29c16c6e"),
                            Name = "Hall 5"
                        });
                });

            modelBuilder.Entity("eCinema.Services.Database.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Actors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Genres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReleaseYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("364fb6c4-d645-454d-92d8-27565fc9c23b"),
                            Actors = "Ima",
                            Country = "SAD",
                            Description = "Lol",
                            Director = "Ima",
                            Duration = 202,
                            IsActive = true,
                            Name = "Avatar",
                            ReleaseYear = 2010
                        });
                });

            modelBuilder.Entity("eCinema.Services.Database.Notification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("NotificationType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("eCinema.Services.Database.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StripePaymentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("eCinema.Services.Database.Price", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Prices");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c4acf3cc-58f2-410c-8d98-c35f510a8fba"),
                            Name = "Dnevna projekcija",
                            Value = 6m
                        },
                        new
                        {
                            Id = new Guid("4b9508c4-2642-4328-95b5-53b27ea37ee2"),
                            Name = "Vecernja projekcija",
                            Value = 7m
                        },
                        new
                        {
                            Id = new Guid("999b4640-52a8-4c97-8a74-fe10e0d5f5a1"),
                            Name = "Vikend projekcija",
                            Value = 8m
                        });
                });

            modelBuilder.Entity("eCinema.Services.Database.Projection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("HallId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid?>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PriceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProjectionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("StateMachine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.HasIndex("MovieId");

                    b.HasIndex("PriceId");

                    b.ToTable("Projections");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f0ea32bb-9717-463f-958b-e5c6eb1caaab"),
                            EndTime = new DateTime(2023, 3, 1, 19, 30, 0, 0, DateTimeKind.Unspecified),
                            HallId = new Guid("b435902d-ba5c-426e-ad15-6f8b6f223296"),
                            IsActive = true,
                            MovieId = new Guid("364fb6c4-d645-454d-92d8-27565fc9c23b"),
                            PriceId = new Guid("c4acf3cc-58f2-410c-8d98-c35f510a8fba"),
                            ProjectionType = "Late",
                            StartTime = new DateTime(2023, 3, 1, 17, 30, 0, 0, DateTimeKind.Unspecified),
                            StateMachine = "Draft",
                            Status = "Active"
                        });
                });

            modelBuilder.Entity("eCinema.Services.Database.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProjectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProjectionId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("eCinema.Services.Database.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2eb051c4-eb1a-4231-9dcd-663fdb07cf6d"),
                            Name = "Admin"
                        },
                        new
                        {
                            Id = new Guid("8e77c320-7043-4c37-a2e5-863a7863aad2"),
                            Name = "User"
                        });
                });

            modelBuilder.Entity("eCinema.Services.Database.Seat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("HallId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("eCinema.Services.Database.SeatxrefReservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsTaken")
                        .HasColumnType("bit");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SeatId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.HasIndex("SeatId");

                    b.ToTable("SeatReservations");
                });

            modelBuilder.Entity("eCinema.Services.Database.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("089782f3-710f-4f40-84d1-0b99623e7985"),
                            Email = "admin@gmail.com",
                            FirstName = "Admin",
                            LastName = "Admin",
                            LozinkaHash = "J526znSJHRceO6peTbt4Bl8IADc=",
                            LozinkaSalt = "Yr48w5vI11uid1EdDngyNg==",
                            RoleId = new Guid("2eb051c4-eb1a-4231-9dcd-663fdb07cf6d"),
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("d80dacb7-e410-4acc-b923-943e2f3078cf"),
                            Email = "user@gmail.com",
                            FirstName = "User",
                            LastName = "User",
                            LozinkaHash = "6glWKRVrKKpVlIiiVY3hiwaoWpQ=",
                            LozinkaSalt = "HUcmPdVRWNqbzW0uHG//1w==",
                            RoleId = new Guid("2eb051c4-eb1a-4231-9dcd-663fdb07cf6d"),
                            Username = "user"
                        });
                });

            modelBuilder.Entity("eCinema.Services.Database.Notification", b =>
                {
                    b.HasOne("eCinema.Services.Database.User", "Author")
                        .WithMany("Notifications")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("eCinema.Services.Database.Payment", b =>
                {
                    b.HasOne("eCinema.Services.Database.Reservation", "Reservation")
                        .WithOne("Payment")
                        .HasForeignKey("eCinema.Services.Database.Payment", "ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("eCinema.Services.Database.Projection", b =>
                {
                    b.HasOne("eCinema.Services.Database.Hall", "Hall")
                        .WithMany()
                        .HasForeignKey("HallId");

                    b.HasOne("eCinema.Services.Database.Movie", "Movie")
                        .WithMany("Projections")
                        .HasForeignKey("MovieId");

                    b.HasOne("eCinema.Services.Database.Price", "Price")
                        .WithMany("Projections")
                        .HasForeignKey("PriceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hall");

                    b.Navigation("Movie");

                    b.Navigation("Price");
                });

            modelBuilder.Entity("eCinema.Services.Database.Reservation", b =>
                {
                    b.HasOne("eCinema.Services.Database.Projection", "Projection")
                        .WithMany("Reservations")
                        .HasForeignKey("ProjectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCinema.Services.Database.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Projection");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eCinema.Services.Database.Seat", b =>
                {
                    b.HasOne("eCinema.Services.Database.Hall", "Hall")
                        .WithMany("Seat")
                        .HasForeignKey("HallId");

                    b.Navigation("Hall");
                });

            modelBuilder.Entity("eCinema.Services.Database.SeatxrefReservation", b =>
                {
                    b.HasOne("eCinema.Services.Database.Reservation", "Reservation")
                        .WithMany("SeatsReservations")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCinema.Services.Database.Seat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("eCinema.Services.Database.User", b =>
                {
                    b.HasOne("eCinema.Services.Database.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("eCinema.Services.Database.Hall", b =>
                {
                    b.Navigation("Seat");
                });

            modelBuilder.Entity("eCinema.Services.Database.Movie", b =>
                {
                    b.Navigation("Projections");
                });

            modelBuilder.Entity("eCinema.Services.Database.Price", b =>
                {
                    b.Navigation("Projections");
                });

            modelBuilder.Entity("eCinema.Services.Database.Projection", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("eCinema.Services.Database.Reservation", b =>
                {
                    b.Navigation("Payment");

                    b.Navigation("SeatsReservations");
                });

            modelBuilder.Entity("eCinema.Services.Database.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("eCinema.Services.Database.User", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
