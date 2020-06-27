using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAdminWebVersion.Migrations
{
    public partial class dbup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GetUsersDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fullname = table.Column<string>(type: "varchar(200)", nullable: false),
                    nic = table.Column<string>(type: "varchar(200)", nullable: false),
                    email = table.Column<string>(type: "varchar(200)", nullable: false),
                    phone = table.Column<string>(type: "varchar(200)", nullable: false),
                    role = table.Column<string>(type: "varchar(200)", nullable: false),
                    status = table.Column<string>(type: "varchar(200)", nullable: false),
                    username = table.Column<string>(type: "varchar(200)", nullable: false),
                    password = table.Column<string>(type: "varchar(200)", nullable: false),
                    log = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetUsersDetails", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SchoolDetails",
                columns: table => new
                {
                    schid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    schoolname = table.Column<string>(type: "varchar(200)", nullable: false),
                    log = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolDetails", x => x.schid);
                });

            migrationBuilder.CreateTable(
                name: "SubjectDetails",
                columns: table => new
                {
                    subid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    subject = table.Column<string>(type: "varchar(200)", nullable: false),
                    teacher = table.Column<string>(type: "varchar(200)", nullable: false),
                    log = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectDetails", x => x.subid);
                });

            migrationBuilder.CreateTable(
                name: "UniversityDetails",
                columns: table => new
                {
                    uniid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    uniname = table.Column<string>(type: "varchar(200)", nullable: false),
                    log = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityDetails", x => x.uniid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GetUsersDetails");

            migrationBuilder.DropTable(
                name: "SchoolDetails");

            migrationBuilder.DropTable(
                name: "SubjectDetails");

            migrationBuilder.DropTable(
                name: "UniversityDetails");
        }
    }
}
