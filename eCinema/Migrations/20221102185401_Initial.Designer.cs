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
    [Migration("20221102185401_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("eCinema.Models.Hall", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Halls");
                });

            modelBuilder.Entity("eCinema.Models.Invoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("VAT")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId")
                        .IsUnique();

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("eCinema.Models.Movie", b =>
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

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReleaseYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("eCinema.Models.Notification", b =>
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

            modelBuilder.Entity("eCinema.Models.Price", b =>
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
                });

            modelBuilder.Entity("eCinema.Models.Projection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("HallId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PriceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProjectionStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectionType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.HasIndex("MovieId");

                    b.HasIndex("PriceId");

                    b.ToTable("Projections");
                });

            modelBuilder.Entity("eCinema.Models.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid?>("PojectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProjectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProjectionId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("eCinema.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("eCinema.Models.Seat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("HallId")
                        .HasColumnType("int");

                    b.Property<Guid?>("HallId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsReserved")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HallId1");

                    b.HasIndex("ReservationId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("eCinema.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("eCinema.Models.Invoice", b =>
                {
                    b.HasOne("eCinema.Models.Reservation", "Reservation")
                        .WithOne("Invoice")
                        .HasForeignKey("eCinema.Models.Invoice", "ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("eCinema.Models.Notification", b =>
                {
                    b.HasOne("eCinema.Models.User", "Author")
                        .WithMany("Notifications")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("eCinema.Models.Projection", b =>
                {
                    b.HasOne("eCinema.Models.Hall", "Hall")
                        .WithMany()
                        .HasForeignKey("HallId");

                    b.HasOne("eCinema.Models.Movie", "Movies")
                        .WithMany("Projections")
                        .HasForeignKey("MovieId");

                    b.HasOne("eCinema.Models.Price", "Price")
                        .WithMany("Projections")
                        .HasForeignKey("PriceId");

                    b.Navigation("Hall");

                    b.Navigation("Movies");

                    b.Navigation("Price");
                });

            modelBuilder.Entity("eCinema.Models.Reservation", b =>
                {
                    b.HasOne("eCinema.Models.Projection", "Projection")
                        .WithMany("Reservations")
                        .HasForeignKey("ProjectionId");

                    b.HasOne("eCinema.Models.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId");

                    b.Navigation("Projection");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eCinema.Models.Seat", b =>
                {
                    b.HasOne("eCinema.Models.Hall", "Hall")
                        .WithMany("Seats")
                        .HasForeignKey("HallId1");

                    b.HasOne("eCinema.Models.Reservation", null)
                        .WithMany("Seats")
                        .HasForeignKey("ReservationId");

                    b.Navigation("Hall");
                });

            modelBuilder.Entity("eCinema.Models.User", b =>
                {
                    b.HasOne("eCinema.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("eCinema.Models.Hall", b =>
                {
                    b.Navigation("Seats");
                });

            modelBuilder.Entity("eCinema.Models.Movie", b =>
                {
                    b.Navigation("Projections");
                });

            modelBuilder.Entity("eCinema.Models.Price", b =>
                {
                    b.Navigation("Projections");
                });

            modelBuilder.Entity("eCinema.Models.Projection", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("eCinema.Models.Reservation", b =>
                {
                    b.Navigation("Invoice");

                    b.Navigation("Seats");
                });

            modelBuilder.Entity("eCinema.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("eCinema.Models.User", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
