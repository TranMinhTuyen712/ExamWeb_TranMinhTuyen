using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_TranMinhTuyen.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Phim",
                columns: new[] { "Id", "DienVien", "GiaVe", "ThoiLuong", "TrongNuoc", "TuaDe" },
                values: new object[,]
                {
                    { 1, null, 150.0, 110, true, "Chúng ta của 8 năm sau" },
                    { 2, null, 150.0, 110, true, "Avatar" },
                    { 3, null, 150.0, 110, true, "Gặp em ngày nắng" },
                    { 4, null, 150.0, 110, true, "Không ngại cười" },
                    { 5, null, 150.0, 110, true, "Gia đình đại chiến" },
                    { 6, null, 150.0, 110, true, "Kẻ huỷ diệt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phim",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Phim",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Phim",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Phim",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Phim",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Phim",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
