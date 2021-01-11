﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    partial class BookStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CommonLayer.Models.AdminUserRegistration", b =>
                {
                    b.Property<long>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeId");

                    b.ToTable("adminUserRegistrations");
                });

            modelBuilder.Entity("CommonLayer.Models.CartItem", b =>
                {
                    b.Property<int>("cartItem_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("NewOrderorderId")
                        .HasColumnType("int");

                    b.Property<bool>("addedTocart")
                        .HasColumnType("bit");

                    b.Property<string>("loginUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("quantityToBuy")
                        .HasColumnType("int");

                    b.HasKey("cartItem_id");

                    b.HasIndex("NewOrderorderId");

                    b.HasIndex("product_id");

                    b.ToTable("cartItems");
                });

            modelBuilder.Entity("CommonLayer.Models.CustomerDetails", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("addressType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pincode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("customerDetails");
                });

            modelBuilder.Entity("CommonLayer.Models.NewOrder", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("orderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("newOrders");
                });

            modelBuilder.Entity("CommonLayer.Models.Product", b =>
                {
                    b.Property<int>("product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("admin_user_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bookImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("discountPrice")
                        .HasColumnType("bigint");

                    b.Property<long>("price")
                        .HasColumnType("bigint");

                    b.Property<long>("quantity")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("product_id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("CommonLayer.Models.UserRegistration", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeId");

                    b.ToTable("userRegistrations");
                });

            modelBuilder.Entity("CommonLayer.Models.CartItem", b =>
                {
                    b.HasOne("CommonLayer.Models.NewOrder", null)
                        .WithMany("orders")
                        .HasForeignKey("NewOrderorderId");

                    b.HasOne("CommonLayer.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CommonLayer.Models.NewOrder", b =>
                {
                    b.HasOne("CommonLayer.Models.CustomerDetails", "customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.Navigation("customer");
                });

            modelBuilder.Entity("CommonLayer.Models.NewOrder", b =>
                {
                    b.Navigation("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
