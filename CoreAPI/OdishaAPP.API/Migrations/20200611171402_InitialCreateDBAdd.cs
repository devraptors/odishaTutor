using Microsoft.EntityFrameworkCore.Migrations;

namespace OdishaAPP.API.Migrations
{
    public partial class InitialCreateDBAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductBands_ProductBandId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductBandId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductBandId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "PictureUrl",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                maxLength: 180,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductBrandId",
                table: "Products",
                column: "ProductBrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductBands_ProductBrandId",
                table: "Products",
                column: "ProductBrandId",
                principalTable: "ProductBands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductBands_ProductBrandId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductBrandId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "PictureUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 180);

            migrationBuilder.AddColumn<int>(
                name: "ProductBandId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductBandId",
                table: "Products",
                column: "ProductBandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductBands_ProductBandId",
                table: "Products",
                column: "ProductBandId",
                principalTable: "ProductBands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
