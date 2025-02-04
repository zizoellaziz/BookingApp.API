﻿// <auto-generated />
using System;
using BookingApp.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookingApp.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220210232823_initiate-db")]
    partial class initiatedb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookingApp.Core.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookedQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("datetime2");

                    b.Property<int>("ResourceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ResourceId")
                        .IsUnique();

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookedQuantity = 0,
                            DateFrom = new DateTime(2022, 2, 11, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(322),
                            DateTo = new DateTime(2022, 2, 11, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7348),
                            ResourceId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookedQuantity = 0,
                            DateFrom = new DateTime(2022, 2, 11, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7684),
                            DateTo = new DateTime(2022, 2, 12, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7688),
                            ResourceId = 2
                        },
                        new
                        {
                            Id = 3,
                            BookedQuantity = 0,
                            DateFrom = new DateTime(2022, 2, 11, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7693),
                            DateTo = new DateTime(2022, 2, 13, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7694),
                            ResourceId = 3
                        },
                        new
                        {
                            Id = 4,
                            BookedQuantity = 0,
                            DateFrom = new DateTime(2022, 2, 11, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7695),
                            DateTo = new DateTime(2022, 2, 14, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7696),
                            ResourceId = 4
                        },
                        new
                        {
                            Id = 5,
                            BookedQuantity = 0,
                            DateFrom = new DateTime(2022, 2, 11, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7697),
                            DateTo = new DateTime(2022, 2, 15, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7698),
                            ResourceId = 5
                        },
                        new
                        {
                            Id = 6,
                            BookedQuantity = 0,
                            DateFrom = new DateTime(2022, 2, 11, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7699),
                            DateTo = new DateTime(2022, 2, 16, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7699),
                            ResourceId = 6
                        },
                        new
                        {
                            Id = 7,
                            BookedQuantity = 0,
                            DateFrom = new DateTime(2022, 2, 11, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7700),
                            DateTo = new DateTime(2022, 2, 17, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7701),
                            ResourceId = 7
                        },
                        new
                        {
                            Id = 8,
                            BookedQuantity = 0,
                            DateFrom = new DateTime(2022, 2, 11, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7702),
                            DateTo = new DateTime(2022, 2, 18, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7703),
                            ResourceId = 8
                        },
                        new
                        {
                            Id = 9,
                            BookedQuantity = 0,
                            DateFrom = new DateTime(2022, 2, 11, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7704),
                            DateTo = new DateTime(2022, 2, 19, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7704),
                            ResourceId = 9
                        },
                        new
                        {
                            Id = 10,
                            BookedQuantity = 0,
                            DateFrom = new DateTime(2022, 2, 11, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7705),
                            DateTo = new DateTime(2022, 2, 20, 1, 28, 23, 186, DateTimeKind.Local).AddTicks(7706),
                            ResourceId = 10
                        });
                });

            modelBuilder.Entity("BookingApp.Core.Entities.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "resource_0",
                            Quantity = 10
                        },
                        new
                        {
                            Id = 2,
                            Name = "resource_1",
                            Quantity = 10
                        },
                        new
                        {
                            Id = 3,
                            Name = "resource_2",
                            Quantity = 10
                        },
                        new
                        {
                            Id = 4,
                            Name = "resource_3",
                            Quantity = 10
                        },
                        new
                        {
                            Id = 5,
                            Name = "resource_4",
                            Quantity = 10
                        },
                        new
                        {
                            Id = 6,
                            Name = "resource_5",
                            Quantity = 10
                        },
                        new
                        {
                            Id = 7,
                            Name = "resource_6",
                            Quantity = 10
                        },
                        new
                        {
                            Id = 8,
                            Name = "resource_7",
                            Quantity = 10
                        },
                        new
                        {
                            Id = 9,
                            Name = "resource_8",
                            Quantity = 10
                        },
                        new
                        {
                            Id = 10,
                            Name = "resource_9",
                            Quantity = 10
                        });
                });

            modelBuilder.Entity("BookingApp.Core.Entities.Booking", b =>
                {
                    b.HasOne("BookingApp.Core.Entities.Resource", "Resource")
                        .WithOne("Booking")
                        .HasForeignKey("BookingApp.Core.Entities.Booking", "ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("BookingApp.Core.Entities.Resource", b =>
                {
                    b.Navigation("Booking");
                });
#pragma warning restore 612, 618
        }
    }
}
