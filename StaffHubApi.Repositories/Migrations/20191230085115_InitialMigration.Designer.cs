﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StaffHubApi.Repositories;

namespace StaffHubApi.Repositories.Migrations
{
    [DbContext(typeof(StaffHubContext))]
    [Migration("20191230085115_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StaffHubApi.Models.Entities.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Activity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Modern Workplace",
                            TenantId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cloud Apps Data",
                            TenantId = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("StaffHubApi.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "#8D7EF3",
                            Name = "GEM"
                        },
                        new
                        {
                            Id = 2,
                            Color = "#A4202B",
                            Name = "Michelin"
                        },
                        new
                        {
                            Id = 3,
                            Color = "#4D8602",
                            Name = "Sicam"
                        },
                        new
                        {
                            Id = 4,
                            Color = "#454644",
                            Name = "Cegid"
                        });
                });

            modelBuilder.Entity("StaffHubApi.Models.Entities.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Member");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "console@infeeny.com",
                            Name = "Pauline Console",
                            PictureUrl = ""
                        },
                        new
                        {
                            Id = 2,
                            Email = "muroni@infeeny.com",
                            Name = "Muroni Brice",
                            PictureUrl = ""
                        },
                        new
                        {
                            Id = 3,
                            Email = "dao@infeeny.com",
                            Name = "Dao David",
                            PictureUrl = ""
                        },
                        new
                        {
                            Id = 4,
                            Email = "neyrand@infeeny.com",
                            Name = "Neyrand Aurélien",
                            PictureUrl = ""
                        },
                        new
                        {
                            Id = 5,
                            Email = "fruhinsholz@infeeny.com",
                            Name = "Fruhinsholz Fiona",
                            PictureUrl = ""
                        },
                        new
                        {
                            Id = 6,
                            Email = "grange@infeeny.com",
                            Name = "Grange Sylvain",
                            PictureUrl = ""
                        },
                        new
                        {
                            Id = 7,
                            Email = "fernandez@infeeny.com",
                            Name = "Fernandez Gaelle",
                            PictureUrl = ""
                        },
                        new
                        {
                            Id = 8,
                            Email = "lecarpentier@infeeny.com",
                            Name = "Le Carpentier Antoine",
                            PictureUrl = ""
                        },
                        new
                        {
                            Id = 9,
                            Email = "florez@infeeny.com",
                            Name = "Florez Angela",
                            PictureUrl = ""
                        });
                });

            modelBuilder.Entity("StaffHubApi.Models.Entities.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shift");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndDate = new DateTime(2019, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "bonjour"
                        });
                });

            modelBuilder.Entity("StaffHubApi.Models.Relationship.ActivitiesRelationship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<int?>("ShiftId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MemberId");

                    b.HasIndex("ShiftId");

                    b.ToTable("ActivitiesRelationship");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActivityId = 1,
                            CategoryId = 1,
                            MemberId = 5,
                            ShiftId = 1
                        });
                });

            modelBuilder.Entity("StaffHubApi.Models.Relationship.ActivityMemberRelationship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("MemberId");

                    b.ToTable("ActivityMemberRelationship");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActivityId = 1,
                            MemberId = 1
                        },
                        new
                        {
                            Id = 2,
                            ActivityId = 1,
                            MemberId = 2
                        },
                        new
                        {
                            Id = 3,
                            ActivityId = 1,
                            MemberId = 3
                        },
                        new
                        {
                            Id = 4,
                            ActivityId = 1,
                            MemberId = 4
                        },
                        new
                        {
                            Id = 5,
                            ActivityId = 1,
                            MemberId = 5
                        },
                        new
                        {
                            Id = 6,
                            ActivityId = 1,
                            MemberId = 6
                        },
                        new
                        {
                            Id = 7,
                            ActivityId = 1,
                            MemberId = 7
                        },
                        new
                        {
                            Id = 8,
                            ActivityId = 1,
                            MemberId = 8
                        },
                        new
                        {
                            Id = 9,
                            ActivityId = 1,
                            MemberId = 9
                        });
                });

            modelBuilder.Entity("StaffHubApi.Models.Relationship.ActivitiesRelationship", b =>
                {
                    b.HasOne("StaffHubApi.Models.Entities.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StaffHubApi.Models.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StaffHubApi.Models.Entities.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StaffHubApi.Models.Entities.Shift", "Shift")
                        .WithMany()
                        .HasForeignKey("ShiftId");
                });

            modelBuilder.Entity("StaffHubApi.Models.Relationship.ActivityMemberRelationship", b =>
                {
                    b.HasOne("StaffHubApi.Models.Entities.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StaffHubApi.Models.Entities.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}