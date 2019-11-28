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
    [Migration("20191127203353_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
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

            modelBuilder.Entity("StaffHubApi.Models.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ColorId = 1,
                            Name = "GEM"
                        },
                        new
                        {
                            Id = 2,
                            ColorId = 2,
                            Name = "Michelin"
                        },
                        new
                        {
                            Id = 3,
                            ColorId = 5,
                            Name = "Sicam"
                        },
                        new
                        {
                            Id = 4,
                            ColorId = 6,
                            Name = "Cegid"
                        });
                });

            modelBuilder.Entity("StaffHubApi.Models.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Color");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ColorCode = "#240058",
                            Name = "Infeeny"
                        },
                        new
                        {
                            Id = 2,
                            ColorCode = "#017CE6",
                            Name = "Bleu"
                        },
                        new
                        {
                            Id = 3,
                            ColorCode = "#8EBB0E",
                            Name = "Vert"
                        },
                        new
                        {
                            Id = 4,
                            ColorCode = "#8D7EF3",
                            Name = "Violet"
                        },
                        new
                        {
                            Id = 5,
                            ColorCode = "#E15E6F",
                            Name = "Rose"
                        },
                        new
                        {
                            Id = 6,
                            ColorCode = "#FFBA00",
                            Name = "Jaune"
                        },
                        new
                        {
                            Id = 7,
                            ColorCode = "#454644",
                            Name = "Gris"
                        },
                        new
                        {
                            Id = 8,
                            ColorCode = "#005295",
                            Name = "Bleu foncé"
                        },
                        new
                        {
                            Id = 9,
                            ColorCode = "#4D8602",
                            Name = "Vert foncé"
                        },
                        new
                        {
                            Id = 10,
                            ColorCode = "#562888",
                            Name = "Violet foncé"
                        },
                        new
                        {
                            Id = 11,
                            ColorCode = "#A4202B",
                            Name = "Rose foncé"
                        },
                        new
                        {
                            Id = 12,
                            ColorCode = "#FFA230",
                            Name = "Jaune foncé"
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

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Shift");
                });

            modelBuilder.Entity("StaffHubApi.Models.Relationship.ActivitiesRelationship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<int?>("ShiftId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("MemberId");

                    b.HasIndex("ShiftId");

                    b.ToTable("ActivitiesRelationship");

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
                        },
                        new
                        {
                            Id = 10,
                            ActivityId = 2,
                            MemberId = 1
                        },
                        new
                        {
                            Id = 11,
                            ActivityId = 2,
                            MemberId = 2
                        },
                        new
                        {
                            Id = 12,
                            ActivityId = 2,
                            MemberId = 3
                        },
                        new
                        {
                            Id = 13,
                            ActivityId = 2,
                            MemberId = 4
                        },
                        new
                        {
                            Id = 14,
                            ActivityId = 2,
                            MemberId = 5
                        });
                });

            modelBuilder.Entity("StaffHubApi.Models.Relationship.ActivityMember", b =>
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

                    b.ToTable("ActivityMember");
                });

            modelBuilder.Entity("StaffHubApi.Models.Entities.Client", b =>
                {
                    b.HasOne("StaffHubApi.Models.Entities.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");
                });

            modelBuilder.Entity("StaffHubApi.Models.Entities.Shift", b =>
                {
                    b.HasOne("StaffHubApi.Models.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("StaffHubApi.Models.Relationship.ActivitiesRelationship", b =>
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

                    b.HasOne("StaffHubApi.Models.Entities.Shift", "Shift")
                        .WithMany()
                        .HasForeignKey("ShiftId");
                });

            modelBuilder.Entity("StaffHubApi.Models.Relationship.ActivityMember", b =>
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
