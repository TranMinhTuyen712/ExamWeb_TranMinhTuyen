using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_TranMinhTuyen.Migrations
{
    public partial class InitSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TuaDe = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DienVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrongNuoc = table.Column<bool>(type: "bit", nullable: false),
                    GiaVe = table.Column<double>(type: "float", nullable: false),
                    ThoiLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phim", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phim");
        }
    }
}
