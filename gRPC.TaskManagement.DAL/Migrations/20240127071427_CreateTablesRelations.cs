using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gRPC.TaskManagement.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreateTablesRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaskItemId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CategoryId",
                table: "Tasks",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ProjectId",
                table: "Tasks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TaskItemId",
                table: "Comments",
                column: "TaskItemId");

            migrationBuilder.AddForeignKey(
                name: "Fk_Task_Commnets",
                table: "Comments",
                column: "TaskItemId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "Fk_Category_Tasks",
                table: "Tasks",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "Fk_Project_Tasks",
                table: "Tasks",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Fk_Task_Commnets",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "Fk_Category_Tasks",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "Fk_Project_Tasks",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_CategoryId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ProjectId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Comments_TaskItemId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TaskItemId",
                table: "Comments");
        }
    }
}
