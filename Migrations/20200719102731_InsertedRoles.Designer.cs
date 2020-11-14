﻿// <auto-generated />
using System;
using Lab2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab2.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200719102731_InsertedRoles")]
    partial class InsertedRoles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab2.Models.Domain.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Lab2.Views.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Iphone"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "SamSung"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Oppo"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Xiaomi"
                        });
                });

            modelBuilder.Entity("Lab2.Views.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<bool>("isConfirm");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Lab2.Views.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Lab2.Views.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Batterycapacity");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Chipset");

                    b.Property<string>("Color");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Descriptions");

                    b.Property<string>("Frontcamera");

                    b.Property<int?>("OrderId");

                    b.Property<string>("ProductImage");

                    b.Property<string>("ProductName");

                    b.Property<double>("ProductPrice");

                    b.Property<int>("ProductQuantity");

                    b.Property<string>("Ram");

                    b.Property<string>("Rearcamera");

                    b.Property<string>("Screen");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Batterycapacity = "2716 mAh",
                            CategoryId = 1,
                            Chipset = "Apple A11 Bionic 6 nhân",
                            Color = "Black",
                            CreateDate = new DateTime(2020, 7, 19, 17, 27, 31, 164, DateTimeKind.Local).AddTicks(7438),
                            Descriptions = "iphoneX 256GB",
                            Frontcamera = "7 MP",
                            ProductImage = "ip.png",
                            ProductName = "IphoneX",
                            ProductPrice = 500.0,
                            ProductQuantity = 100,
                            Ram = "3GB",
                            Rearcamera = "2 camera 12 MP",
                            Screen = "OLED, 5.8 Super Retina"
                        },
                        new
                        {
                            ProductId = 2,
                            Batterycapacity = "2691 mAh",
                            CategoryId = 1,
                            Chipset = "Apple A11 Bionic",
                            Color = "Gold",
                            CreateDate = new DateTime(2020, 7, 19, 17, 27, 31, 165, DateTimeKind.Local).AddTicks(7664),
                            Descriptions = "iphone8+ 64GB",
                            Frontcamera = "7 MP",
                            ProductImage = "ip.png",
                            ProductName = "Iphone 8 Plus",
                            ProductPrice = 200.0,
                            ProductQuantity = 90,
                            Ram = "3 GB",
                            Rearcamera = "2 camera 12 MP",
                            Screen = "Full HD (1080 x 1920 pixels)"
                        },
                        new
                        {
                            ProductId = 3,
                            Batterycapacity = "3.969 mAh",
                            CategoryId = 1,
                            Chipset = "Apple A13 Bionic",
                            Color = "Black",
                            CreateDate = new DateTime(2020, 7, 19, 17, 27, 31, 165, DateTimeKind.Local).AddTicks(7680),
                            Descriptions = "iphone11 ProMax 512GB",
                            Frontcamera = "12 MP, f/2.2",
                            ProductImage = "ip.png",
                            ProductName = "Iphone 11 ProMax",
                            ProductPrice = 700.0,
                            ProductQuantity = 26,
                            Ram = "4 GB",
                            Rearcamera = "12 MP + 12 MP + 12 MP",
                            Screen = " OLED"
                        },
                        new
                        {
                            ProductId = 4,
                            Batterycapacity = "4000 mAh",
                            CategoryId = 2,
                            Chipset = "Exynos 9810 8 nhân 64 bit",
                            Color = "Blue",
                            CreateDate = new DateTime(2020, 7, 19, 17, 27, 31, 165, DateTimeKind.Local).AddTicks(7684),
                            Descriptions = "SamSung Note 9-128GB ",
                            Frontcamera = "8 MP",
                            ProductImage = "ip.png",
                            ProductName = "SamSung Galaxy Note9",
                            ProductPrice = 550.0,
                            ProductQuantity = 46,
                            Ram = "6GB",
                            Rearcamera = "2 camera 12 MP",
                            Screen = "Super AMOLED, 6.4, Quad HD + (2K +)"
                        },
                        new
                        {
                            ProductId = 5,
                            Batterycapacity = "4500 mAh",
                            CategoryId = 2,
                            Chipset = "Exynos 9820 8 nhân 64-bit",
                            Color = "Black",
                            CreateDate = new DateTime(2020, 7, 19, 17, 27, 31, 165, DateTimeKind.Local).AddTicks(7686),
                            Descriptions = "SamSung S10-256GB ",
                            Frontcamera = "24 MP & 10MP & 8 MP (3 camera)",
                            ProductImage = "ip.png",
                            ProductName = "SamSung Galaxy S10",
                            ProductPrice = 720.0,
                            ProductQuantity = 98,
                            Ram = "8GB",
                            Rearcamera = "10 MP & TOF 3D ( 2 Camera )",
                            Screen = "Dynamic AMOLED 6.7'' FullHD+ , 16 triệu màu"
                        },
                        new
                        {
                            ProductId = 6,
                            Batterycapacity = "5000 mAh",
                            CategoryId = 3,
                            Chipset = "Snapdragon 665 8 nhân",
                            Color = "White",
                            CreateDate = new DateTime(2020, 7, 19, 17, 27, 31, 165, DateTimeKind.Local).AddTicks(7689),
                            Descriptions = "OppoA92-256GB ",
                            Frontcamera = "16 MP",
                            ProductImage = "ip.png",
                            ProductName = "Oppo A92",
                            ProductPrice = 192.0,
                            ProductQuantity = 92,
                            Ram = "8GB",
                            Rearcamera = "Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP",
                            Screen = "IPS LCD, 6.5,Full HD + "
                        },
                        new
                        {
                            ProductId = 7,
                            Batterycapacity = "4025 mAh",
                            CategoryId = 3,
                            Chipset = "MediaTek Helio P90 8 nhân",
                            Color = "Pink",
                            CreateDate = new DateTime(2020, 7, 19, 17, 27, 31, 165, DateTimeKind.Local).AddTicks(7691),
                            Descriptions = "Oppo Reno3-256GB ",
                            Frontcamera = "44 MP",
                            ProductImage = "ip.png",
                            ProductName = "Oppo Reno3",
                            ProductPrice = 300.0,
                            ProductQuantity = 70,
                            Ram = "8GB",
                            Rearcamera = "Chính 48 MP & Phụ 13 MP, 8 MP, 2 MP",
                            Screen = "AMOLED, 6.4, Full HD + "
                        },
                        new
                        {
                            ProductId = 8,
                            Batterycapacity = "4720 mAh",
                            CategoryId = 4,
                            Chipset = "Qualcomm Adreno 650",
                            Color = "Black",
                            CreateDate = new DateTime(2020, 7, 19, 17, 27, 31, 165, DateTimeKind.Local).AddTicks(7693),
                            Descriptions = "Xiaomi Black Shark3-128GB ",
                            Frontcamera = "20 MP, f/2.2",
                            ProductImage = "ip.png",
                            ProductName = "XiaoMi Black Shark3",
                            ProductPrice = 600.0,
                            ProductQuantity = 22,
                            Ram = "8GB",
                            Rearcamera = "camera chính 64 MP f/1.8, camera góc rộng 13 MP f/2.25, Portrait mode 5 MP f/2.2",
                            Screen = "Amoled"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "affb4ab3-42d1-49ee-8b9a-45f73179d143",
                            ConcurrencyStamp = "eafe0946-8d01-420a-800a-7104425d299b",
                            Name = "Visitor",
                            NormalizedName = "VISITOR"
                        },
                        new
                        {
                            Id = "6f277834-7737-4b1a-90a3-78f128851162",
                            ConcurrencyStamp = "cb05594b-4bf0-43e5-a5d4-43a376d6354d",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Lab2.Views.OrderDetail", b =>
                {
                    b.HasOne("Lab2.Views.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Lab2.Views.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Lab2.Views.Product", b =>
                {
                    b.HasOne("Lab2.Views.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Lab2.Views.Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Lab2.Models.Domain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Lab2.Models.Domain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Lab2.Models.Domain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Lab2.Models.Domain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
