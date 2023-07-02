using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pawpals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Breed = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Photo = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Owner = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pawpals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PawbondPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false),
                    WantedPartnerBreed = table.Column<string>(type: "TEXT", nullable: false),
                    WantedPartnerAge = table.Column<int>(type: "INTEGER", nullable: false),
                    WanterPartnerDescription = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PawbondPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PawbondPosts_Pawpals_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Pawpals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pawbonds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false),
                    PartnerId = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pawbonds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pawbonds_Pawpals_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Pawpals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pawbonds_Pawpals_PartnerId",
                        column: x => x.PartnerId,
                        principalTable: "Pawpals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PawbondPosts_AuthorId",
                table: "PawbondPosts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pawbonds_AuthorId",
                table: "Pawbonds",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pawbonds_PartnerId",
                table: "Pawbonds",
                column: "PartnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PawbondPosts");

            migrationBuilder.DropTable(
                name: "Pawbonds");

            migrationBuilder.DropTable(
                name: "Pawpals");
        }
    }
}
