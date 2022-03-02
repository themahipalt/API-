using Microsoft.EntityFrameworkCore.Migrations;

namespace HandsOnAPIWithEFCore_CodeFirst_Demo2.Migrations
{
    public partial class new_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectCode = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false),
                    ProjectName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    TeamSize = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectCode);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    ProjectCode = table.Column<string>(type: "char(5)", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Projects_ProjectCode",
                        column: x => x.ProjectCode,
                        principalTable: "Projects",
                        principalColumn: "ProjectCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ProjectCode",
                table: "Employees",
                column: "ProjectCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
