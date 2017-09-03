﻿// <auto-generated />
using BirdieBook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BirdieBook.Migrations
{
    [DbContext(typeof(BirdieBookContext))]
    [Migration("20170830003937_UserRoundDateTime")]
    partial class UserRoundDateTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BirdieBook.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

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

            modelBuilder.Entity("BirdieBook.Models.GolfCourse", b =>
                {
                    b.Property<string>("GolfCourseID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("GolfCourseID");

                    b.ToTable("GolfCourse");
                });

            modelBuilder.Entity("BirdieBook.Models.Hole", b =>
                {
                    b.Property<int>("HoleID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HCPIndex");

                    b.Property<int?>("HoleID1");

                    b.Property<int>("HoleNumber");

                    b.Property<int>("Length");

                    b.Property<int>("Par");

                    b.Property<string>("TeeBoxID");

                    b.HasKey("HoleID");

                    b.HasIndex("HoleID1");

                    b.HasIndex("TeeBoxID");

                    b.ToTable("Hole");
                });

            modelBuilder.Entity("BirdieBook.Models.TeeBox", b =>
                {
                    b.Property<string>("TeeBoxID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GolfCourseID");

                    b.Property<int>("MensCourseRating");

                    b.Property<int>("MensSlope");

                    b.Property<string>("Name");

                    b.Property<int>("WomensCourseRating");

                    b.Property<int>("WomensSlope");

                    b.HasKey("TeeBoxID");

                    b.HasIndex("GolfCourseID");

                    b.ToTable("TeeBox");
                });

            modelBuilder.Entity("BirdieBook.Models.UserRound", b =>
                {
                    b.Property<string>("UserRoundID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DailyScratchRating");

                    b.Property<string>("TeeBoxID");

                    b.Property<DateTime>("TeeTime");

                    b.Property<decimal>("UserHCP");

                    b.Property<string>("UserID");

                    b.Property<string>("WeatherCondition");

                    b.HasKey("UserRoundID");

                    b.ToTable("UserRound");
                });

            modelBuilder.Entity("BirdieBook.Models.UserScore", b =>
                {
                    b.Property<string>("UserScoreID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("FairwayHit");

                    b.Property<string>("HoleID");

                    b.Property<int>("PuttCount");

                    b.Property<int>("Score");

                    b.Property<string>("UserRoundID");

                    b.HasKey("UserScoreID");

                    b.HasIndex("UserRoundID");

                    b.ToTable("UserScore");
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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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
                        .ValueGeneratedOnAdd();

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

            modelBuilder.Entity("BirdieBook.Models.Hole", b =>
                {
                    b.HasOne("BirdieBook.Models.Hole", "hole")
                        .WithMany()
                        .HasForeignKey("HoleID1");

                    b.HasOne("BirdieBook.Models.TeeBox")
                        .WithMany("holes")
                        .HasForeignKey("TeeBoxID");
                });

            modelBuilder.Entity("BirdieBook.Models.TeeBox", b =>
                {
                    b.HasOne("BirdieBook.Models.GolfCourse")
                        .WithMany("teeBox")
                        .HasForeignKey("GolfCourseID");
                });

            modelBuilder.Entity("BirdieBook.Models.UserScore", b =>
                {
                    b.HasOne("BirdieBook.Models.UserRound")
                        .WithMany("Score")
                        .HasForeignKey("UserRoundID");
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
                    b.HasOne("BirdieBook.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BirdieBook.Models.ApplicationUser")
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

                    b.HasOne("BirdieBook.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BirdieBook.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
