using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmptyFridge.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeasureUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Unit = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmountMeasure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    MeasureUnitId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmountMeasure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AmountMeasure_MeasureUnits_MeasureUnitId",
                        column: x => x.MeasureUnitId,
                        principalTable: "MeasureUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    FoodGroupId = table.Column<int>(type: "INTEGER", nullable: true),
                    AmountMeasureId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_AmountMeasure_AmountMeasureId",
                        column: x => x.AmountMeasureId,
                        principalTable: "AmountMeasure",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ingredients_FoodGroups_FoodGroupId",
                        column: x => x.FoodGroupId,
                        principalTable: "FoodGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmountMeasure_MeasureUnitId",
                table: "AmountMeasure",
                column: "MeasureUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_AmountMeasureId",
                table: "Ingredients",
                column: "AmountMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_FoodGroupId",
                table: "Ingredients",
                column: "FoodGroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "AmountMeasure");

            migrationBuilder.DropTable(
                name: "FoodGroups");

            migrationBuilder.DropTable(
                name: "MeasureUnits");
        }
    }
}
