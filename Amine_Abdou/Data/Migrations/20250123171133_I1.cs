using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amine_Abdou.Data.Migrations
{
    /// <inheritdoc />
    public partial class I1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Maladies_MaladieId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_medecins_MedecinId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_MaladieId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_MedecinId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "MaladieId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "MedecinId",
                table: "Patients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaladieId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MedecinId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_MaladieId",
                table: "Patients",
                column: "MaladieId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_MedecinId",
                table: "Patients",
                column: "MedecinId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Maladies_MaladieId",
                table: "Patients",
                column: "MaladieId",
                principalTable: "Maladies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_medecins_MedecinId",
                table: "Patients",
                column: "MedecinId",
                principalTable: "medecins",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
