using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sso.Migrations
{
    /// <inheritdoc />
    public partial class alldata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sessionInfos",
                columns: table => new
                {
                    session = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sessionId = table.Column<int>(type: "int", nullable: false),
                    token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isactive = table.Column<bool>(type: "bit", nullable: false),
                    sessionDates = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sessionInfos", x => x.session);
                });

            migrationBuilder.CreateTable(
                name: "userCreds",
                columns: table => new
                {
                    userName = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userCreds", x => x.userName);
                });

            migrationBuilder.CreateTable(
                name: "userDatas",
                columns: table => new
                {
                    email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telephone = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authDomin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userName = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userDatas", x => x.email);
                    table.ForeignKey(
                        name: "FK_userDatas_userCreds_userName",
                        column: x => x.userName,
                        principalTable: "userCreds",
                        principalColumn: "userName");
                });

            migrationBuilder.CreateIndex(
                name: "IX_userDatas_userName",
                table: "userDatas",
                column: "userName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sessionInfos");

            migrationBuilder.DropTable(
                name: "userDatas");

            migrationBuilder.DropTable(
                name: "userCreds");
        }
    }
}
