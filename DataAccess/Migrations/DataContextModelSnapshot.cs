﻿// <auto-generated />
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.DataModels.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1000,
                            DisplayOrder = 1,
                            Name = "Art"
                        },
                        new
                        {
                            Id = 2000,
                            DisplayOrder = 2,
                            Name = "History"
                        },
                        new
                        {
                            Id = 3000,
                            DisplayOrder = 3,
                            Name = "Technology"
                        },
                        new
                        {
                            Id = 4000,
                            DisplayOrder = 4,
                            Name = "Sports"
                        });
                });

            modelBuilder.Entity("Models.DataModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1000,
                            Author = "Smithovision",
                            Description = "It begins with this one",
                            ISBN = "84267913",
                            ListPrice = 40.0,
                            Price = 40.0,
                            Price100 = 20.0,
                            Price50 = 30.0,
                            Title = "Product 1"
                        },
                        new
                        {
                            Id = 2000,
                            Author = "Smithovision",
                            Description = "Right hand man to the main man",
                            ISBN = "258687913",
                            ListPrice = 40.0,
                            Price = 40.0,
                            Price100 = 20.0,
                            Price50 = 30.0,
                            Title = "Product 2"
                        },
                        new
                        {
                            Id = 3000,
                            Author = "Smithovision",
                            Description = "The trio to the pack",
                            ISBN = "123456789",
                            ListPrice = 40.0,
                            Price = 40.0,
                            Price100 = 20.0,
                            Price50 = 30.0,
                            Title = "Product 3"
                        },
                        new
                        {
                            Id = 4000,
                            Author = "Smithovision",
                            Description = "A new product the fourth to be added",
                            ISBN = "789456123",
                            ListPrice = 40.0,
                            Price = 40.0,
                            Price100 = 20.0,
                            Price50 = 30.0,
                            Title = "Product 4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
