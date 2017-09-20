﻿// <auto-generated />
using BirdieBook.Data;
using BirdieBook.Models;
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
    partial class BirdieBookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime?>("BirthDate");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int>("Gender");

                    b.Property<decimal>("Hcp");

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
                    b.Property<string>("GolfCourseId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("Name");

                    b.HasKey("GolfCourseId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("GolfCourse");
                });

            modelBuilder.Entity("BirdieBook.Models.Hole", b =>
                {
                    b.Property<string>("HoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HcpIndex");

                    b.Property<int>("HoleNumber");

                    b.Property<int>("Length");

                    b.Property<int>("Par");

                    b.Property<string>("TeeBoxId");

                    b.HasKey("HoleId");

                    b.HasIndex("TeeBoxId");

                    b.ToTable("Hole");
                });

            modelBuilder.Entity("BirdieBook.Models.Tag", b =>
                {
                    b.Property<string>("TagId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.Property<int>("TagType");

                    b.Property<string>("UserScoreId");

                    b.HasKey("TagId");

                    b.HasIndex("UserScoreId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("BirdieBook.Models.TagMap", b =>
                {
                    b.Property<string>("TagId");

                    b.Property<string>("Thing");

                    b.HasKey("TagId", "Thing");

                    b.ToTable("TagMap");
                });

            modelBuilder.Entity("BirdieBook.Models.TeeBox", b =>
                {
                    b.Property<string>("TeeBoxId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GolfCourseId");

                    b.Property<int?>("MensCourseRating");

                    b.Property<int?>("MensSlope");

                    b.Property<string>("Name");

                    b.Property<int>("UnitOfMeasure");

                    b.Property<int?>("WomensCourseRating");

                    b.Property<int?>("WomensSlope");

                    b.HasKey("TeeBoxId");

                    b.HasIndex("GolfCourseId");

                    b.ToTable("TeeBox");
                });

            modelBuilder.Entity("BirdieBook.Models.UserRound", b =>
                {
                    b.Property<string>("UserRoundId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DailyScratchRating");

                    b.Property<int>("Game");

                    b.Property<int>("GivenShots");

                    b.Property<decimal>("NewUserHcp");

                    b.Property<bool>("RegulateHandicap");

                    b.Property<string>("TeeBoxId");

                    b.Property<DateTime>("TeeTime");

                    b.Property<bool>("Tournament");

                    b.Property<decimal>("UserHcp");

                    b.Property<string>("UserId");

                    b.Property<int>("Visibility");

                    b.Property<string>("WeatherCondition");

                    b.HasKey("UserRoundId");

                    b.ToTable("UserRound");
                });

            modelBuilder.Entity("BirdieBook.Models.UserScore", b =>
                {
                    b.Property<string>("UserScoreId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Bunker");

                    b.Property<int>("BunkershotCount");

                    b.Property<int>("ChipCount");

                    b.Property<bool>("FairwayHit");

                    b.Property<string>("HoleId");

                    b.Property<int>("HoleNumber");

                    b.Property<bool>("LostBall");

                    b.Property<bool>("OutOfBounds");

                    b.Property<int>("PenaltyCount");

                    b.Property<bool>("PickedUp");

                    b.Property<int>("Points");

                    b.Property<int>("PuttCount");

                    b.Property<int>("Score");

                    b.Property<string>("UserRoundId");

                    b.Property<bool>("Water");

                    b.HasKey("UserScoreId");

                    b.HasIndex("UserRoundId");

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

            modelBuilder.Entity("BirdieBook.Models.GolfCourse", b =>
                {
                    b.HasOne("BirdieBook.Models.ApplicationUser")
                        .WithMany("FavCourses")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("BirdieBook.Models.Hole", b =>
                {
                    b.HasOne("BirdieBook.Models.TeeBox")
                        .WithMany("Holes")
                        .HasForeignKey("TeeBoxId");
                });

            modelBuilder.Entity("BirdieBook.Models.Tag", b =>
                {
                    b.HasOne("BirdieBook.Models.UserScore")
                        .WithMany("Tags")
                        .HasForeignKey("UserScoreId");
                });

            modelBuilder.Entity("BirdieBook.Models.TagMap", b =>
                {
                    b.HasOne("BirdieBook.Models.Tag")
                        .WithMany("TagMaps")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BirdieBook.Models.TeeBox", b =>
                {
                    b.HasOne("BirdieBook.Models.GolfCourse")
                        .WithMany("TeeBox")
                        .HasForeignKey("GolfCourseId");
                });

            modelBuilder.Entity("BirdieBook.Models.UserScore", b =>
                {
                    b.HasOne("BirdieBook.Models.UserRound")
                        .WithMany("Score")
                        .HasForeignKey("UserRoundId");
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
