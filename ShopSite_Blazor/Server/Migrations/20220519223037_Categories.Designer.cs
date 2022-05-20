﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopSite_Blazor.Server.Data;

#nullable disable

namespace ShopSite_Blazor.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220519223037_Categories")]
    partial class Categories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShopSite_Blazor.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Movies",
                            Url = "movies"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Video Games",
                            Url = "Video-Games"
                        });
                });

            modelBuilder.Entity("ShopSite_Blazor.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Available at a lower price from other sellers that may not offer free Prime shipping.",
                            ImageUrl = "https://m.media-amazon.com/images/I/311AAjeId7L._AC_.jpg",
                            Price = 1795m,
                            Title = "Sony PlayStation 5"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "This product is intended for EU Region.  This CD Key will not work if your PS5 is not in EU region",
                            ImageUrl = "https://www.cjs-cdkeys.com/product_images/p/21371.jpg",
                            Price = 1200m,
                            Title = "FIFA 22 PSN"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "This product is intended for EU Region.  This CD Key will not work if your PS5 is not in EU region",
                            ImageUrl = "https://www.cjs-cdkeys.com/product_images/p/21371.jpg",
                            Price = 1200m,
                            Title = "FIFA 22 PSN"
                        });
                });

            modelBuilder.Entity("ShopSite_Blazor.Shared.Product", b =>
                {
                    b.HasOne("ShopSite_Blazor.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
