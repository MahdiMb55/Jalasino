﻿// <auto-generated />
using System;
using Jalasino;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jalasino.Migrations
{
    [DbContext(typeof(DataContex))]
    partial class DataContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Jalasino.Models.Approval", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Actioner")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Approvals");
                });

            modelBuilder.Entity("Jalasino.Models.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Meetings", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2024, 10, 30, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Initial meeting to discuss the project kickoff.",
                            Subject = "Project Kickoff"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2024, 11, 6, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Weekly sync-up to discuss project progress.",
                            Subject = "Weekly Sync"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2024, 11, 13, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Review the budget allocation for the next quarter.",
                            Subject = "Budget Review"
                        });
                });

            modelBuilder.Entity("Jalasino.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MeetingId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MeetingId");

                    b.ToTable("People", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Alice"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bob"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Charlie"
                        },
                        new
                        {
                            Id = 4,
                            Name = "David"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Eve"
                        });
                });

            modelBuilder.Entity("Jalasino.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Jalasino.Models.Person", b =>
                {
                    b.HasOne("Jalasino.Models.Meeting", null)
                        .WithMany("People")
                        .HasForeignKey("MeetingId");
                });

            modelBuilder.Entity("Jalasino.Models.Meeting", b =>
                {
                    b.Navigation("People");
                });
#pragma warning restore 612, 618
        }
    }
}
