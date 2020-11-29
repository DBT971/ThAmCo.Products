using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Products.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Supply = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] {"Name", "Description", "Supply", "Price", "Available"},
                values: new object[,]
                {
                    {"Play Box 5", "Next Gen Playbox, 1 per Household", 200, 449.90, true},
                    {"Pear Phone XXII", "The Best, Brightest, and most Expensive Pear Phone", 200000, 20000.01, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ID",
                table: "Products",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
