﻿// <auto-generated />
using System;
using BookstoreCafe.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookstoreCafe.Data.Migrations
{
    [DbContext(typeof(BookCafeDbContext))]
    [Migration("20240605082439_FixIngredientsColumn")]
    partial class FixIngredientsColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookstoreCafe.Data.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfPages")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(12,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("TypeOfCover")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("YearOfRelease")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "zeppazariel",
                            Description = "There's never enough time. They had ten years, and still, that wasn't enough...\n \nRegulus Black was fifteen the first time his name was called at a reaping. He's twenty-five when it happens to him again. A lot has changed in that time, and one of them is that he's ready to do whatever it takes to make it home. Nothing or no one will stop him, not even James Potter.\r\n\r\nJames Potter has no plans to stop Regulus Black from making it home. In fact, his plans revolve around the opposite. He has his reasons, but he's made his choice to get Regulus out of the arena, even knowing it'll be the last thing he ever does.\r\n\r\nSirius Black was sixteen when he volunteered to take his little brother's place in the arena. At twenty-six, without the option to do it again, he has no choice but to be a mentor to his brother and best friend, knowing that only one of them can make it back out.\r\n\r\nTwo names called, a mentor on the verge of falling apart, and more secrets and grief between all of them than they know how to handle. None of them are prepared for what comes next, or how far they'll go to make it through.",
                            GenreId = 1,
                            ImageUrl = "https://gcdnb.pbrd.co/images/UsjakXzwxKbS.png?o=1",
                            NumberOfPages = 743,
                            Price = 18.99m,
                            Title = "Crimson Rivers Book 1",
                            TypeOfCover = "Hard",
                            YearOfRelease = 2023
                        },
                        new
                        {
                            Id = 2,
                            Author = "zeppazariel",
                            Description = "It's devastating that a tear shed in heartbreak is the only thing that they get to have for themselves. But this is what they are. A great, big tragedy...\n \nRegulus Black was fifteen the first time his name was called at a reaping. He's twenty-five when it happens to him again. A lot has changed in that time, and one of them is that he's ready to do whatever it takes to make it home. Nothing or no one will stop him, not even James Potter.\r\n\r\nJames Potter has no plans to stop Regulus Black from making it home. In fact, his plans revolve around the opposite. He has his reasons, but he's made his choice to get Regulus out of the arena, even knowing it'll be the last thing he ever does.\r\n\r\nSirius Black was sixteen when he volunteered to take his little brother's place in the arena. At twenty-six, without the option to do it again, he has no choice but to be a mentor to his brother and best friend, knowing that only one of them can make it back out.\r\n\r\nTwo names called, a mentor on the verge of falling apart, and more secrets and grief between all of them than they know how to handle. None of them are prepared for what comes next, or how far they'll go to make it through.",
                            GenreId = 1,
                            ImageUrl = "https://gcdnb.pbrd.co/images/QKZPVkKBERJl.png?o=1",
                            NumberOfPages = 694,
                            Price = 18.99m,
                            Title = "Crimson Rivers Book 2",
                            TypeOfCover = "Hard",
                            YearOfRelease = 2023
                        },
                        new
                        {
                            Id = 3,
                            Author = "zeppazariel",
                            Description = "Hurting together. Mourning together. Terrified together. Never one without the other, evein in pain. One day at a time, together, all of them.\n \nRegulus Black was fifteen the first time his name was called at a reaping. He's twenty-five when it happens to him again. A lot has changed in that time, and one of them is that he's ready to do whatever it takes to make it home. Nothing or no one will stop him, not even James Potter.\r\n\r\nJames Potter has no plans to stop Regulus Black from making it home. In fact, his plans revolve around the opposite. He has his reasons, but he's made his choice to get Regulus out of the arena, even knowing it'll be the last thing he ever does.\r\n\r\nSirius Black was sixteen when he volunteered to take his little brother's place in the arena. At twenty-six, without the option to do it again, he has no choice but to be a mentor to his brother and best friend, knowing that only one of them can make it back out.\r\n\r\nTwo names called, a mentor on the verge of falling apart, and more secrets and grief between all of them than they know how to handle. None of them are prepared for what comes next, or how far they'll go to make it through.",
                            GenreId = 1,
                            ImageUrl = "https://gcdnb.pbrd.co/images/YyL1yTBQMKNd.png?o=1",
                            NumberOfPages = 757,
                            Price = 18.99m,
                            Title = "Crimson Rivers Book 3",
                            TypeOfCover = "Hard",
                            YearOfRelease = 2023
                        });
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MenuCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Beverages"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pastries"
                        });
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Young Adult"
                        });
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            ImageUrl = "https://gcdnb.pbrd.co/images/3EpytMWSVnJJ.jpg?o=1",
                            Ingredients = "MILK, BREWED ESPRESSO",
                            Name = "Cappuccino",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            ImageUrl = "https://gcdnb.pbrd.co/images/A6obyfAlzZbf.jpg?o=1",
                            Ingredients = "MILK, BREWED ESPRESSO, MOCHA SAUCE [WATER, SUGAR, COCOA PROCESSED WITH ALKALI, NATURAL FLAVOR], WHIPPED CREAM [CREAM (CREAM, MONO AND DIGLYCERIDES, CARAGEENAN), VANILLA SYRUP (SUGAR, WATER, NATURAL FLAVORS, POTASSIUM SORBATE, CITRIC ACID)]",
                            Name = "Caffè Mocha",
                            Price = 6.99m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            ImageUrl = "https://gcdnb.pbrd.co/images/PkcXbeAeqOxS.jpg?o=1",
                            Ingredients = "Sugar, Enriched Wheat Flour [Wheat Flour, Niacin, Reduced Iron, Thiamine Mononitrate, Riboflavin, Folic Acid], Blueberries, Plain Yogurt [Milk, Skim Milk, Skim Milk Powder, Whey, Bacterial Culture], Soybean And / Or Canola Oil, Eggs, Honey, Baking Powder [Sodium Acid Pyrophosphate, Cornstarch, Sodium Bicarbonate, Monocalcium Phosphate], Lemon Zest [Lemon Peel, Sugar, Lemon Oil], Natural Flavor, Sea Salt, Whey [Milk], Soy Lecithin",
                            Name = "Blueberry Muffin",
                            Price = 6.99m
                        });
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryPostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
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

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
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

                    b.HasData(
                        new
                        {
                            Id = "1297764b-dd30-4c4a-be10-a188dde20808",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3cbe184e-32a4-48f7-9b78-3ce9b780f09e",
                            Email = "guest@mail.com",
                            EmailConfirmed = false,
                            FirstName = "John",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            NormalizedEmail = "GUEST@MAIL.COM",
                            NormalizedUserName = "GUEST@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAED7pAIswAPV0PtOxm1MdN65xPFZW1Fqrc4NSuGBfnLtnYftqrijzT4xdnOvl0sZl5A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fb7f2446-aaaf-46f7-8003-da6df113dacf",
                            TwoFactorEnabled = false,
                            UserName = "guest@mail.com"
                        },
                        new
                        {
                            Id = "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "60a6b29c-a295-491d-9cad-7d38caeb4629",
                            Email = "admin@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Bate",
                            LastName = "Shefa",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMPvUbCsEmLmYJhzPLGgrfQdkjwso5/Lx/KhMtrMYx1yhVIubkFxWVL7lmkvJJP0UA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dd5d0bc8-784a-4903-83ec-7a5c043716ba",
                            TwoFactorEnabled = false,
                            UserName = "admin@mail.com"
                        });
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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.Book", b =>
                {
                    b.HasOne("BookstoreCafe.Data.Entities.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.MenuItem", b =>
                {
                    b.HasOne("BookstoreCafe.Data.Entities.Category", "Category")
                        .WithMany("MenuItems")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.Order", b =>
                {
                    b.HasOne("BookstoreCafe.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.OrderDetail", b =>
                {
                    b.HasOne("BookstoreCafe.Data.Entities.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookstoreCafe.Data.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.ShoppingCartItem", b =>
                {
                    b.HasOne("BookstoreCafe.Data.Entities.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookstoreCafe.Data.Entities.ShoppingCart", "ShoppingCart")
                        .WithMany("Items")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("ShoppingCart");
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
                    b.HasOne("BookstoreCafe.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BookstoreCafe.Data.Entities.User", null)
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

                    b.HasOne("BookstoreCafe.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BookstoreCafe.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.Category", b =>
                {
                    b.Navigation("MenuItems");
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BookstoreCafe.Data.Entities.ShoppingCart", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
