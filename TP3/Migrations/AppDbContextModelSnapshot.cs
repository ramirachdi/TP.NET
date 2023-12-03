﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP3.Models;

#nullable disable

namespace TP3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CustomerMovie", b =>
                {
                    b.Property<Guid>("CustomersId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MoviesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CustomersId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("CustomerMovie");
                });

            modelBuilder.Entity("TP3.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Membershiptype")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MembershiptypesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Membershiptype");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TP3.Models.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("84ca0bcd-082c-49cb-aa77-ea2f1f5f8286"),
                            GenreName = "GenreFromJsonFile1"
                        },
                        new
                        {
                            Id = new Guid("79e6f638-d7e7-4f63-8365-f172cb925385"),
                            GenreName = "GenreFromJsonFile2"
                        });
                });

            modelBuilder.Entity("TP3.Models.Membershiptype", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DiscountRate")
                        .HasColumnType("int");

                    b.Property<int>("DurationInMonth")
                        .HasColumnType("int");

                    b.Property<int>("SignUpFee")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Membershiptypes");
                });

            modelBuilder.Entity("TP3.Models.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Genre")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("MovieAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("genre_id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Genre");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("CustomerMovie", b =>
                {
                    b.HasOne("TP3.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP3.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TP3.Models.Customer", b =>
                {
                    b.HasOne("TP3.Models.Membershiptype", "Membershiptypes")
                        .WithMany("Customers")
                        .HasForeignKey("Membershiptype");

                    b.Navigation("Membershiptypes");
                });

            modelBuilder.Entity("TP3.Models.Movie", b =>
                {
                    b.HasOne("TP3.Models.Genre", "Genres")
                        .WithMany("Movies")
                        .HasForeignKey("Genre");

                    b.Navigation("Genres");
                });

            modelBuilder.Entity("TP3.Models.Genre", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("TP3.Models.Membershiptype", b =>
                {
                    b.Navigation("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
