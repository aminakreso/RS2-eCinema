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
    [Migration("20230228230333_seed")]
    partial class seed
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
                            Id = new Guid("e9695c6b-61f4-4eae-b580-496c7e58cdf6"),
                            Name = "Hall 1"
                        },
                        new
                        {
                            Id = new Guid("1880b6e1-31a3-4f71-9399-41be26560728"),
                            Name = "Hall 2"
                        },
                        new
                        {
                            Id = new Guid("dba588e4-b2a1-4e83-aa71-5e92da1a4c11"),
                            Name = "Hall 3"
                        },
                        new
                        {
                            Id = new Guid("23a4000b-554d-4401-b4b3-16d33e46b7d2"),
                            Name = "Hall 4"
                        },
                        new
                        {
                            Id = new Guid("fc9c3d5e-f19f-4e74-9902-0fdace6da2a1"),
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

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("ReleaseYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1299c09b-5af0-40cb-add2-c0c5ea5ba263"),
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

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

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
                            Id = new Guid("7b3ac61e-7607-4a7f-989a-48353f2e164b"),
                            Name = "Dnevna projekcija",
                            Value = 6m
                        },
                        new
                        {
                            Id = new Guid("9d83b36d-7963-490c-ba08-12bb1929061f"),
                            Name = "Vecernja projekcija",
                            Value = 7m
                        },
                        new
                        {
                            Id = new Guid("e543e0af-7c51-4ebc-896e-45e5ba29f901"),
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
                            Id = new Guid("3dd8940d-28bf-4e08-9c2f-c2821e13e3eb"),
                            EndTime = new DateTime(2023, 3, 1, 19, 30, 0, 0, DateTimeKind.Unspecified),
                            HallId = new Guid("e9695c6b-61f4-4eae-b580-496c7e58cdf6"),
                            IsActive = true,
                            MovieId = new Guid("1299c09b-5af0-40cb-add2-c0c5ea5ba263"),
                            PriceId = new Guid("7b3ac61e-7607-4a7f-989a-48353f2e164b"),
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
                            Id = new Guid("c7929358-eb84-41fe-99a1-6fb4bcfa05f1"),
                            Name = "Admin"
                        },
                        new
                        {
                            Id = new Guid("7ba66fcc-69b4-465e-8ad4-4f7d1a7b1788"),
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
                            Id = new Guid("46f58fbf-05cb-442d-9068-976e85a9f71c"),
                            Email = "admin@gmail.com",
                            FirstName = "Admin",
                            LastName = "Admin",
                            LozinkaHash = "wj2WOMkGZ1GPUfUvCcGMI0tS97g=",
                            LozinkaSalt = "40gdSB57aPiD7SX3Aq66WA==",
                            RoleId = new Guid("c7929358-eb84-41fe-99a1-6fb4bcfa05f1"),
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("1a5a5f90-f2ff-4ca6-a59e-a6b223615576"),
                            Email = "user@gmail.com",
                            FirstName = "User",
                            LastName = "User",
                            LozinkaHash = "5G6ZjbQa7mUf6K4GGNJ5fNQu4jQ=",
                            LozinkaSalt = "fG4FKgLCM5NwcahfwC8TvQ==",
                            RoleId = new Guid("c7929358-eb84-41fe-99a1-6fb4bcfa05f1"),
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