using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MorePlants_PlantsAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedPlantTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Size", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 4, 17, 49, 1, 360, DateTimeKind.Local).AddTicks(9925), "여인초는 마다가스카르 원산지로 플랜테리어 실내조경 인테리어 식물로 꾸준히 많은 사랑을 받고 있습니다.", "https://shop-phinf.pstatic.net/20231110_61/1699592764107jn9o8_JPEG/23118954104082569_1998215622.jpg?type=m510", "여인초", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 10, 4, 17, 49, 1, 360, DateTimeKind.Local).AddTicks(9943), "실내에서도 튼튼하고 싱그러운 잎이 매력적인 '뱅갈고무나무'는 열대성 관상수로 다양한 카페 매장이나 사무실 등의 플랜테리어 식물로 많은 사랑을 받고 있습니다.", "https://shop-phinf.pstatic.net/20231109_39/1699514252955SFGey_JPEG/51586640329505362_16946473.jpg?type=m510", "뱅갈고무나무", 4, 300.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 10, 4, 17, 49, 1, 360, DateTimeKind.Local).AddTicks(9945), "휘커스움베르타는 무화과나무속 아프리카 원산지로 플랜테리어 실내조경 인테리어 식물로 꾸준히 많은 사랑을 받고 있습니다.", "https://shop-phinf.pstatic.net/20240202_296/1706848835240pVrYo_JPEG/34151519097359293_895289601.jpg?type=m510", "휘커스움베르타", 4, 400.0, 450, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 10, 4, 17, 49, 1, 360, DateTimeKind.Local).AddTicks(9947), "아레카 야자는 마다가스카르 원산지로 카페 매장이나 사무실 등에 배치하면 좋으며 플랜테리어 인테리어 식물로 꾸준히 많은 사랑을 받고 있습니다.", "https://shop-phinf.pstatic.net/20240131_46/1706676785751F0ecb_JPEG/107812684413121543_403150541.jpg?type=m510", "아레카야자", 4, 550.0, 600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 10, 4, 17, 49, 1, 360, DateTimeKind.Local).AddTicks(9949), "크로톤은 화려하고 다채로운 색상의 건강한 잎을 지니고 있어 실내 인테리어 환경과 잘 어울리며, 관상용으로 뛰어나 승진이나 개업선물용으로 사랑받는 식물입니다.", "https://shop-phinf.pstatic.net/20231013_237/1697184041025Ioq5O_PNG/44331539823884559_499226285.png?type=m510", "크로톤", 4, 600.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
