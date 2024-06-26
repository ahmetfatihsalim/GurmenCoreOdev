﻿// <auto-generated />
using Gurmen.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Gurmen.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231106051148_SeedPersonTable")]
    partial class SeedPersonTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GurmenAhmetFatihSalim.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surame")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Age = 20,
                            Gender = 0,
                            Name = "Ahmet",
                            Surame = "Salim"
                        },
                        new
                        {
                            ID = 2,
                            Age = 24,
                            Gender = 0,
                            Name = "Fatih",
                            Surame = "Salim"
                        },
                        new
                        {
                            ID = 3,
                            Age = 1000,
                            Gender = 0,
                            Name = "Ali",
                            Surame = "Yıldırım"
                        },
                        new
                        {
                            ID = 4,
                            Age = 25,
                            Gender = 1,
                            Name = "İrem",
                            Surame = "Selin"
                        },
                        new
                        {
                            ID = 5,
                            Age = 32,
                            Gender = 0,
                            Name = "Veli",
                            Surame = "Tunç"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
