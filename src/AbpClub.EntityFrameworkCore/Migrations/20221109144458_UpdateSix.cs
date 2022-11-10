using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbpClub.Migrations
{
    public partial class UpdateSix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CmsUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CmsUsers");
        }
    }
}
