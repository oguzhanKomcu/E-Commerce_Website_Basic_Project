// <auto-generated />
using System;
using EWBP.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EWBP.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EWBP.Domain.Models.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("EWBP.Domain.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2022, 5, 19, 13, 38, 40, 797, DateTimeKind.Local).AddTicks(4205),
                            Name = "Teknology",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2022, 5, 19, 13, 38, 40, 797, DateTimeKind.Local).AddTicks(4216),
                            Name = "Vacuum Flasks & Mugs",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2022, 5, 19, 13, 38, 40, 797, DateTimeKind.Local).AddTicks(4218),
                            Name = "Sneakers",
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2022, 5, 19, 13, 38, 40, 797, DateTimeKind.Local).AddTicks(4219),
                            Name = "Cordless Drills",
                            Status = 1
                        });
                });

            modelBuilder.Entity("EWBP.Domain.Models.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Order_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shipping_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("User_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EWBP.Domain.Models.Entities.Order_Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Order_Id")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 5)
                        .HasColumnType("decimal(18,5)");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Order_Id");

                    b.HasIndex("Product_Id");

                    b.ToTable("Order_Details");
                });

            modelBuilder.Entity("EWBP.Domain.Models.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Category_Id")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 5)
                        .HasColumnType("decimal(18,5)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Category_Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category_Id = 1,
                            Color = "Black",
                            CreateDate = new DateTime(2022, 5, 19, 13, 38, 40, 797, DateTimeKind.Local).AddTicks(4435),
                            Description = "As part of our efforts to achieve our environmental goals, the iPhone 12 and iPhone 12 are not offered with a mini power adapter or EarPods. The box contains a USB-C - Lightning cable that supports fast charging, compatible with USB-C power adapters and computer ports.",
                            ImagePath = "",
                            Name = "iPhone 12",
                            Price = 1100m,
                            Size = "146.7 x 71.5 x 7.4",
                            Status = 1,
                            Stock = 300
                        },
                        new
                        {
                            Id = 2,
                            Category_Id = 1,
                            Color = "Black",
                            CreateDate = new DateTime(2022, 5, 19, 13, 38, 40, 797, DateTimeKind.Local).AddTicks(4438),
                            Description = "A11SCX-223TR Intel Core i7 1185G7 8GB 512GB SSD GTX1650 Windows 10 Home 15.6 FHD Laptop",
                            ImagePath = "",
                            Name = "MSI Prestige 15",
                            Price = 2000m,
                            Size = "15,6 inç",
                            Status = 1,
                            Stock = 150
                        },
                        new
                        {
                            Id = 3,
                            Category_Id = 1,
                            Color = "Black",
                            CreateDate = new DateTime(2022, 5, 19, 13, 38, 40, 797, DateTimeKind.Local).AddTicks(4440),
                            Description = "As part of our efforts to achieve our environmental goals, the iPhone 12 and iPhone 12 are not offered with a mini power adapter or EarPods. The box contains a USB-C - Lightning cable that supports fast charging, compatible with USB-C power adapters and computer ports.",
                            ImagePath = "",
                            Name = "iPhone 12",
                            Price = 1100m,
                            Size = "146.7 x 71.5 x 7.4",
                            Status = 1,
                            Stock = 300
                        },
                        new
                        {
                            Id = 4,
                            Category_Id = 2,
                            Color = "Green",
                            CreateDate = new DateTime(2022, 5, 19, 13, 38, 40, 797, DateTimeKind.Local).AddTicks(4442),
                            Description = "Boasting stainless steel vacuum insulation, this double walled Classic 750ml vacuum flask from Stanley is perfect for keeping hot drinks hot and cold drinks cold for up to 20 hours (04 days for ice).",
                            ImagePath = "",
                            Name = "New STANLEY Classic Vacuum Insulated 750ml Bottle Thermos Flask",
                            Price = 50m,
                            Size = "8.50cm Diameter - 30 cm Height",
                            Status = 1,
                            Stock = 250
                        },
                        new
                        {
                            Id = 5,
                            Category_Id = 3,
                            Color = "Black and White",
                            CreateDate = new DateTime(2022, 5, 19, 13, 38, 40, 797, DateTimeKind.Local).AddTicks(4444),
                            Description = "New with box: A brand - new,unused,and unworn item(including handmade items) in the original packaging(such as the original box or bag) and / or with the original tags attached.",
                            ImagePath = "",
                            Name = "[New Balance] Retro 530 Silber SG Paar Laufschuhe Sportschuhe",
                            Price = 104m,
                            Size = "us5-us10",
                            Status = 1,
                            Stock = 80
                        },
                        new
                        {
                            Id = 6,
                            Category_Id = 4,
                            Color = "Green",
                            CreateDate = new DateTime(2022, 5, 19, 13, 38, 40, 797, DateTimeKind.Local).AddTicks(4446),
                            Description = "Higher impact power and high performance in hard material with pneumatic mechanism",
                            ImagePath = "",
                            Name = "Bosch UniversalDrill ",
                            Price = 110m,
                            Size = "30,3 x 22,8 x 9,1 cm",
                            Status = 1,
                            Stock = 50
                        });
                });

            modelBuilder.Entity("EWBP.Domain.Models.Entities.Product_Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Product_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Product_Comments");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EWBP.Domain.Models.Entities.Order", b =>
                {
                    b.HasOne("EWBP.Domain.Models.Entities.AppUser", "AppUser")
                        .WithMany("Orders")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("EWBP.Domain.Models.Entities.Order_Detail", b =>
                {
                    b.HasOne("EWBP.Domain.Models.Entities.Order", "Order")
                        .WithMany("Order_Details")
                        .HasForeignKey("Order_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EWBP.Domain.Models.Entities.Product", "Product")
                        .WithMany("Order_Details")
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EWBP.Domain.Models.Entities.Product", b =>
                {
                    b.HasOne("EWBP.Domain.Models.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EWBP.Domain.Models.Entities.Product_Comment", b =>
                {
                    b.HasOne("EWBP.Domain.Models.Entities.Product", "Product")
                        .WithMany("Product_Comments")
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EWBP.Domain.Models.Entities.AppUser", "User")
                        .WithMany("Product_Comments")
                        .HasForeignKey("User_Id");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EWBP.Domain.Models.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EWBP.Domain.Models.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EWBP.Domain.Models.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EWBP.Domain.Models.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EWBP.Domain.Models.Entities.AppUser", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Product_Comments");
                });

            modelBuilder.Entity("EWBP.Domain.Models.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EWBP.Domain.Models.Entities.Order", b =>
                {
                    b.Navigation("Order_Details");
                });

            modelBuilder.Entity("EWBP.Domain.Models.Entities.Product", b =>
                {
                    b.Navigation("Order_Details");

                    b.Navigation("Product_Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
