using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAdminWebVersion.Migrations
{
    public partial class InitCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentDetails",
                columns: table => new
                {
                    Sid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RegId = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(200)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(200)", nullable: false),
                    Nic = table.Column<string>(type: "varchar(200)", nullable: false),
                    Dob = table.Column<string>(type: "varchar(200)", nullable: false),
                    HomeAdress = table.Column<string>(type: "varchar(200)", nullable: false),
                    HomeTell = table.Column<string>(type: "varchar(200)", nullable: false),
                    StayAddress = table.Column<string>(type: "varchar(200)", nullable: true),
                    StayHomeTell = table.Column<string>(type: "varchar(200)", nullable: true),
                    FatherName = table.Column<string>(type: "varchar(200)", nullable: false),
                    ParentsTell = table.Column<string>(type: "varchar(200)", nullable: false),
                    OlSchool = table.Column<string>(type: "varchar(200)", nullable: false),
                    AlSchool = table.Column<string>(type: "varchar(200)", nullable: true),
                    OlResult = table.Column<string>(type: "varchar(200)", nullable: false),
                    JoinedDate = table.Column<string>(type: "varchar(200)", nullable: false),
                    Batch = table.Column<string>(type: "varchar(200)", nullable: false),
                    Scholership = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetails", x => x.Sid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentDetails");
        }
    }
}
