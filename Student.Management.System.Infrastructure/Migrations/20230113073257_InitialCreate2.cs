using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student.Management.System.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Subject_FavouriteSubjectId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_FavouriteSubjectId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "FavouriteSubjectId",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Subject",
                newName: "Subjects");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Subjects",
                newName: "SubjectId");

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SubjectId",
                table: "Students",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Subjects_SubjectId",
                table: "Students",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Subjects_SubjectId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_SubjectId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Subject",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "FavouriteSubjectId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                table: "Subject",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_FavouriteSubjectId",
                table: "Students",
                column: "FavouriteSubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Subject_FavouriteSubjectId",
                table: "Students",
                column: "FavouriteSubjectId",
                principalTable: "Subject",
                principalColumn: "Id");
        }
    }
}
