﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MorePlants_PlantsAPI.Data;

#nullable disable

namespace MorePlants_PlantsAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MorePlants_PlantsAPI.Models.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Plants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 10, 4, 17, 49, 1, 360, DateTimeKind.Local).AddTicks(9925),
                            Details = "여인초는 마다가스카르 원산지로 플랜테리어 실내조경 인테리어 식물로 꾸준히 많은 사랑을 받고 있습니다.",
                            ImageUrl = "https://shop-phinf.pstatic.net/20231110_61/1699592764107jn9o8_JPEG/23118954104082569_1998215622.jpg?type=m510",
                            Name = "여인초",
                            Occupancy = 4,
                            Rate = 200.0,
                            Size = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 10, 4, 17, 49, 1, 360, DateTimeKind.Local).AddTicks(9943),
                            Details = "실내에서도 튼튼하고 싱그러운 잎이 매력적인 '뱅갈고무나무'는 열대성 관상수로 다양한 카페 매장이나 사무실 등의 플랜테리어 식물로 많은 사랑을 받고 있습니다.",
                            ImageUrl = "https://shop-phinf.pstatic.net/20231109_39/1699514252955SFGey_JPEG/51586640329505362_16946473.jpg?type=m510",
                            Name = "뱅갈고무나무",
                            Occupancy = 4,
                            Rate = 300.0,
                            Size = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 10, 4, 17, 49, 1, 360, DateTimeKind.Local).AddTicks(9945),
                            Details = "휘커스움베르타는 무화과나무속 아프리카 원산지로 플랜테리어 실내조경 인테리어 식물로 꾸준히 많은 사랑을 받고 있습니다.",
                            ImageUrl = "https://shop-phinf.pstatic.net/20240202_296/1706848835240pVrYo_JPEG/34151519097359293_895289601.jpg?type=m510",
                            Name = "휘커스움베르타",
                            Occupancy = 4,
                            Rate = 400.0,
                            Size = 450,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 10, 4, 17, 49, 1, 360, DateTimeKind.Local).AddTicks(9947),
                            Details = "아레카 야자는 마다가스카르 원산지로 카페 매장이나 사무실 등에 배치하면 좋으며 플랜테리어 인테리어 식물로 꾸준히 많은 사랑을 받고 있습니다.",
                            ImageUrl = "https://shop-phinf.pstatic.net/20240131_46/1706676785751F0ecb_JPEG/107812684413121543_403150541.jpg?type=m510",
                            Name = "아레카야자",
                            Occupancy = 4,
                            Rate = 550.0,
                            Size = 600,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 10, 4, 17, 49, 1, 360, DateTimeKind.Local).AddTicks(9949),
                            Details = "크로톤은 화려하고 다채로운 색상의 건강한 잎을 지니고 있어 실내 인테리어 환경과 잘 어울리며, 관상용으로 뛰어나 승진이나 개업선물용으로 사랑받는 식물입니다.",
                            ImageUrl = "https://shop-phinf.pstatic.net/20231013_237/1697184041025Ioq5O_PNG/44331539823884559_499226285.png?type=m510",
                            Name = "크로톤",
                            Occupancy = 4,
                            Rate = 600.0,
                            Size = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
