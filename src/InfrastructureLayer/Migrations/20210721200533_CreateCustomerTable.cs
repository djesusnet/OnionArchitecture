using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InfrastructureLayer.Migrations
{
    public partial class CreateCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CUSTOMER_NAME = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    PURCHASED_PRODUCT = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    PAYMENT_TYPE = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    MODIFIED_DATE = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IS_ACTIVE = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMER_ID", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
