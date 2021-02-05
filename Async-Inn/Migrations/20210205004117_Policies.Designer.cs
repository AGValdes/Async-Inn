﻿// <auto-generated />
using System;
using Async_Inn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Async_Inn.Migrations
{
    [DbContext(typeof(AsyncInnDbContext))]
    [Migration("20210205004117_Policies")]
    partial class Policies
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Async_Inn.Models.Amenity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mini Bar"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kitchenette"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Desk Work Space"
                        });
                });

            modelBuilder.Entity("Async_Inn.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
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

            modelBuilder.Entity("Async_Inn.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Ruston",
                            Country = "United States",
                            Name = "Neutral Milk Hotel",
                            State = "Louisianna",
                            StreetAddress = "123 Avery Island St., Ruston, LA 12345"
                        },
                        new
                        {
                            Id = 2,
                            City = "Somewhere",
                            Country = "United States",
                            Name = "Grand Budapest Hotel",
                            State = "Ohklahoma",
                            StreetAddress = "123 West Anderson Dr, Somewhere, OK 23456"
                        },
                        new
                        {
                            Id = 3,
                            City = "Los Angeles",
                            Country = "United States",
                            Name = "Hotel California",
                            State = "California",
                            StreetAddress = "123 Such A Lovely Pl., Los Angeles, CA 90212"
                        });
                });

            modelBuilder.Entity("Async_Inn.Models.HotelRoom", b =>
                {
                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<bool>("PetFriendly")
                        .HasColumnType("bit");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.HasKey("RoomId", "HotelId");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelRooms");

                    b.HasData(
                        new
                        {
                            RoomId = 3,
                            HotelId = 1,
                            PetFriendly = true,
                            Rate = 39.99m,
                            RoomNumber = 69
                        },
                        new
                        {
                            RoomId = 2,
                            HotelId = 2,
                            PetFriendly = false,
                            Rate = 199.99m,
                            RoomNumber = 42
                        },
                        new
                        {
                            RoomId = 1,
                            HotelId = 3,
                            PetFriendly = false,
                            Rate = 299.99m,
                            RoomNumber = 401
                        });
                });

            modelBuilder.Entity("Async_Inn.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Layout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Layout = "Two Bedroom",
                            Name = "Executive Suite"
                        },
                        new
                        {
                            Id = 2,
                            Layout = "One Bedroom",
                            Name = "Honeymoon Suite"
                        },
                        new
                        {
                            Id = 3,
                            Layout = "Studio",
                            Name = "Economy Plus"
                        });
                });

            modelBuilder.Entity("Async_Inn.Models.RoomAmenity", b =>
                {
                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("AmenityId")
                        .HasColumnType("int");

                    b.HasKey("RoomId", "AmenityId");

                    b.HasIndex("AmenityId");

                    b.ToTable("RoomAmenities");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
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
                            Id = "district manager",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "District Manager",
                            NormalizedName = "DISTRICT MANAGER"
                        },
                        new
                        {
                            Id = "propertymanager",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "PropertyManager",
                            NormalizedName = "PROPERTYMANAGER"
                        },
                        new
                        {
                            Id = "agent",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Agent",
                            NormalizedName = "AGENT"
                        },
                        new
                        {
                            Id = "anonymous",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Anonymous",
                            NormalizedName = "ANONYMOUS"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "permissions",
                            ClaimValue = "Create Hotel",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "permissions",
                            ClaimValue = "See Hotels",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "permissions",
                            ClaimValue = "Update Hotel",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "permissions",
                            ClaimValue = "Delete Hotel",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "permissions",
                            ClaimValue = "Create HotelRoom",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "permissions",
                            ClaimValue = "See HotelRooms",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 7,
                            ClaimType = "permissions",
                            ClaimValue = "Update HotelRooms",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 8,
                            ClaimType = "permissions",
                            ClaimValue = "Delete HotelRooms",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 9,
                            ClaimType = "permissions",
                            ClaimValue = "Create Rooms",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 10,
                            ClaimType = "permissions",
                            ClaimValue = "See Rooms",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 11,
                            ClaimType = "permissions",
                            ClaimValue = "Update Rooms",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 12,
                            ClaimType = "permissions",
                            ClaimValue = "Delete Rooms",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 13,
                            ClaimType = "permissions",
                            ClaimValue = "Create Amenity",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 14,
                            ClaimType = "permissions",
                            ClaimValue = "See Amenities",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 15,
                            ClaimType = "permissions",
                            ClaimValue = "Add Amenity to Room",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 16,
                            ClaimType = "permissions",
                            ClaimValue = "Delete Amenity From Room",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 17,
                            ClaimType = "permissions",
                            ClaimValue = "Update Amenity",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 18,
                            ClaimType = "permissions",
                            ClaimValue = "Delete Amenity",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 19,
                            ClaimType = "permissions",
                            ClaimValue = "Create Account for District Manager",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 20,
                            ClaimType = "permissions",
                            ClaimValue = "Create Account for Agent",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 21,
                            ClaimType = "permissions",
                            ClaimValue = "Create Account for Property Manager",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 22,
                            ClaimType = "permissions",
                            ClaimValue = "Create account for Anonymous User",
                            RoleId = "district manager"
                        },
                        new
                        {
                            Id = 23,
                            ClaimType = "permissions",
                            ClaimValue = "See Hotels",
                            RoleId = "propertymanager"
                        },
                        new
                        {
                            Id = 24,
                            ClaimType = "permissions",
                            ClaimValue = "Create HotelRoom",
                            RoleId = "propertymanager"
                        },
                        new
                        {
                            Id = 25,
                            ClaimType = "permissions",
                            ClaimValue = "See HotelRooms",
                            RoleId = "propertymanager"
                        },
                        new
                        {
                            Id = 26,
                            ClaimType = "permissions",
                            ClaimValue = "Update HotelRooms",
                            RoleId = "propertymanager"
                        },
                        new
                        {
                            Id = 27,
                            ClaimType = "permissions",
                            ClaimValue = "See Rooms",
                            RoleId = "propertymanager"
                        },
                        new
                        {
                            Id = 28,
                            ClaimType = "permissions",
                            ClaimValue = "See Amenities",
                            RoleId = "propertymanager"
                        },
                        new
                        {
                            Id = 29,
                            ClaimType = "permissions",
                            ClaimValue = "Add Amenity to Room",
                            RoleId = "propertymanager"
                        },
                        new
                        {
                            Id = 30,
                            ClaimType = "permissions",
                            ClaimValue = "Delete Amenity From Room",
                            RoleId = "propertymanager"
                        },
                        new
                        {
                            Id = 31,
                            ClaimType = "permissions",
                            ClaimValue = "Update Amenity",
                            RoleId = "propertymanager"
                        },
                        new
                        {
                            Id = 32,
                            ClaimType = "permissions",
                            ClaimValue = "See HotelRooms",
                            RoleId = "agent"
                        },
                        new
                        {
                            Id = 33,
                            ClaimType = "permissions",
                            ClaimValue = "Update HotelRooms",
                            RoleId = "agent"
                        },
                        new
                        {
                            Id = 34,
                            ClaimType = "permissions",
                            ClaimValue = "See Amenities",
                            RoleId = "agent"
                        },
                        new
                        {
                            Id = 35,
                            ClaimType = "permissions",
                            ClaimValue = "Add Amenity to Room",
                            RoleId = "agent"
                        },
                        new
                        {
                            Id = 36,
                            ClaimType = "permissions",
                            ClaimValue = "Delete Amenity From Room",
                            RoleId = "agent"
                        },
                        new
                        {
                            Id = 37,
                            ClaimType = "permissions",
                            ClaimValue = "See Hotels",
                            RoleId = "anonymous"
                        },
                        new
                        {
                            Id = 38,
                            ClaimType = "permissions",
                            ClaimValue = "See HotelRooms",
                            RoleId = "anonymous"
                        },
                        new
                        {
                            Id = 39,
                            ClaimType = "permissions",
                            ClaimValue = "See Rooms",
                            RoleId = "anonymous"
                        },
                        new
                        {
                            Id = 40,
                            ClaimType = "permissions",
                            ClaimValue = "See Amenities",
                            RoleId = "anonymous"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Async_Inn.Models.HotelRoom", b =>
                {
                    b.HasOne("Async_Inn.Models.Hotel", "Hotel")
                        .WithMany("HotelRooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Async_Inn.Models.Room", "Room")
                        .WithMany("HotelRooms")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Async_Inn.Models.RoomAmenity", b =>
                {
                    b.HasOne("Async_Inn.Models.Amenity", "Amenity")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("AmenityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Async_Inn.Models.Room", "Room")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("Async_Inn.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Async_Inn.Models.ApplicationUser", null)
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

                    b.HasOne("Async_Inn.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Async_Inn.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
