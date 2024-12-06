using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jalasino.Migrations
{
    /// <inheritdoc />
    public partial class ApprovalRelateMeeting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Actioner",
                table: "Approvals");

            migrationBuilder.AddColumn<int>(
                name: "ApprovalId",
                table: "People",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Approvals",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "MeetingId",
                table: "Approvals",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_People_ApprovalId",
                table: "People",
                column: "ApprovalId");

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_MeetingId",
                table: "Approvals",
                column: "MeetingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Approvals_Meetings_MeetingId",
                table: "Approvals",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Approvals_ApprovalId",
                table: "People",
                column: "ApprovalId",
                principalTable: "Approvals",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Approvals_Meetings_MeetingId",
                table: "Approvals");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Approvals_ApprovalId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_ApprovalId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_Approvals_MeetingId",
                table: "Approvals");

            migrationBuilder.DropColumn(
                name: "ApprovalId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "MeetingId",
                table: "Approvals");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Approvals",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Actioner",
                table: "Approvals",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Date", "Description", "Subject" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "Initial meeting to discuss the project kickoff.", "Project Kickoff" },
                    { 2, new DateTime(2024, 11, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), "Weekly sync-up to discuss project progress.", "Weekly Sync" },
                    { 3, new DateTime(2024, 11, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), "Review the budget allocation for the next quarter.", "Budget Review" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "MeetingId", "Name" },
                values: new object[,]
                {
                    { 1, null, "Alice" },
                    { 2, null, "Bob" },
                    { 3, null, "Charlie" },
                    { 4, null, "David" },
                    { 5, null, "Eve" }
                });
        }
    }
}
