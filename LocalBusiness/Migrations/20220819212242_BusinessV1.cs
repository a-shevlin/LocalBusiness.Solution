using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBusiness.Migrations
{
    public partial class BusinessV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1,
                column: "Description",
                value: "Fried Chicken Food Cart devoted to Korean and American Southern Flavors");

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Description", "Genre", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 2, "2046 NE Martin Luther King Jr Blvd, Portland, OR 97212", "A LGBTQ owned plant store specializing in rare plants.", "Plant Nursery", "Arium Botanicals", 3, "Shop" },
                    { 3, "2137 E Burnside St, Portland, OR 97214", "A compact family owned mexican restaurant.", "Mexican", "Ole Ole", 1, "Restaurant" },
                    { 4, "2031 NE Martin Luther King Jr Blvd, Portland, OR 97212", "Coffee shop serving fair trade locally roasted coffee beans.", "Cafe", "Tinys Coffee", 1, "Coffee Shop" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1,
                column: "Description",
                value: "Fried chicken with Korean or classic Southern flavors");
        }
    }
}
