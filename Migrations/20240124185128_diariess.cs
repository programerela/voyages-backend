using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Voyages.Migrations
{
    /// <inheritdoc />
    public partial class diariess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diary_AspNetUsers_UserId",
                table: "Diary");

            migrationBuilder.DropForeignKey(
                name: "FK_LikedDiary_AspNetUsers_UserId",
                table: "LikedDiary");

            migrationBuilder.DropForeignKey(
                name: "FK_LikedDiary_Diary_DiaryId",
                table: "LikedDiary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LikedDiary",
                table: "LikedDiary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diary",
                table: "Diary");

            migrationBuilder.RenameTable(
                name: "LikedDiary",
                newName: "LikedDiaries");

            migrationBuilder.RenameTable(
                name: "Diary",
                newName: "Diaries");

            migrationBuilder.RenameIndex(
                name: "IX_LikedDiary_UserId",
                table: "LikedDiaries",
                newName: "IX_LikedDiaries_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_LikedDiary_DiaryId",
                table: "LikedDiaries",
                newName: "IX_LikedDiaries_DiaryId");

            migrationBuilder.RenameIndex(
                name: "IX_Diary_UserId",
                table: "Diaries",
                newName: "IX_Diaries_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LikedDiaries",
                table: "LikedDiaries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diaries",
                table: "Diaries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Diaries_AspNetUsers_UserId",
                table: "Diaries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikedDiaries_AspNetUsers_UserId",
                table: "LikedDiaries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikedDiaries_Diaries_DiaryId",
                table: "LikedDiaries",
                column: "DiaryId",
                principalTable: "Diaries",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diaries_AspNetUsers_UserId",
                table: "Diaries");

            migrationBuilder.DropForeignKey(
                name: "FK_LikedDiaries_AspNetUsers_UserId",
                table: "LikedDiaries");

            migrationBuilder.DropForeignKey(
                name: "FK_LikedDiaries_Diaries_DiaryId",
                table: "LikedDiaries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LikedDiaries",
                table: "LikedDiaries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diaries",
                table: "Diaries");

            migrationBuilder.RenameTable(
                name: "LikedDiaries",
                newName: "LikedDiary");

            migrationBuilder.RenameTable(
                name: "Diaries",
                newName: "Diary");

            migrationBuilder.RenameIndex(
                name: "IX_LikedDiaries_UserId",
                table: "LikedDiary",
                newName: "IX_LikedDiary_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_LikedDiaries_DiaryId",
                table: "LikedDiary",
                newName: "IX_LikedDiary_DiaryId");

            migrationBuilder.RenameIndex(
                name: "IX_Diaries_UserId",
                table: "Diary",
                newName: "IX_Diary_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LikedDiary",
                table: "LikedDiary",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diary",
                table: "Diary",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Diary_AspNetUsers_UserId",
                table: "Diary",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikedDiary_AspNetUsers_UserId",
                table: "LikedDiary",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikedDiary_Diary_DiaryId",
                table: "LikedDiary",
                column: "DiaryId",
                principalTable: "Diary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
