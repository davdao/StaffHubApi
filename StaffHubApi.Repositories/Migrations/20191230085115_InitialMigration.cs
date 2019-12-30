using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StaffHubApi.Repositories.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    TenantId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PictureUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shift",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shift", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityMemberRelationship",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityMemberRelationship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityMemberRelationship_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityMemberRelationship_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivitiesRelationship",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    ShiftId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitiesRelationship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivitiesRelationship_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivitiesRelationship_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivitiesRelationship_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivitiesRelationship_Shift_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shift",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "Name", "TenantId" },
                values: new object[,]
                {
                    { 1, "Modern Workplace", new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, "Cloud Apps Data", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Color", "Name" },
                values: new object[,]
                {
                    { 1, "#8D7EF3", "GEM" },
                    { 2, "#A4202B", "Michelin" },
                    { 3, "#4D8602", "Sicam" },
                    { 4, "#454644", "Cegid" }
                });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "Id", "Email", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { 1, "console@infeeny.com", "Pauline Console", "" },
                    { 2, "muroni@infeeny.com", "Muroni Brice", "" },
                    { 3, "dao@infeeny.com", "Dao David", "" },
                    { 4, "neyrand@infeeny.com", "Neyrand Aurélien", "" },
                    { 5, "fruhinsholz@infeeny.com", "Fruhinsholz Fiona", "" },
                    { 6, "grange@infeeny.com", "Grange Sylvain", "" },
                    { 7, "fernandez@infeeny.com", "Fernandez Gaelle", "" },
                    { 8, "lecarpentier@infeeny.com", "Le Carpentier Antoine", "" },
                    { 9, "florez@infeeny.com", "Florez Angela", "" }
                });

            migrationBuilder.InsertData(
                table: "Shift",
                columns: new[] { "Id", "EndDate", "StartDate", "Title" },
                values: new object[] { 1, new DateTime(2019, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "bonjour" });

            migrationBuilder.InsertData(
                table: "ActivitiesRelationship",
                columns: new[] { "Id", "ActivityId", "CategoryId", "MemberId", "ShiftId" },
                values: new object[] { 1, 1, 1, 5, 1 });

            migrationBuilder.InsertData(
                table: "ActivityMemberRelationship",
                columns: new[] { "Id", "ActivityId", "MemberId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 7, 1, 7 },
                    { 8, 1, 8 },
                    { 9, 1, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesRelationship_ActivityId",
                table: "ActivitiesRelationship",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesRelationship_CategoryId",
                table: "ActivitiesRelationship",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesRelationship_MemberId",
                table: "ActivitiesRelationship",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesRelationship_ShiftId",
                table: "ActivitiesRelationship",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityMemberRelationship_ActivityId",
                table: "ActivityMemberRelationship",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityMemberRelationship_MemberId",
                table: "ActivityMemberRelationship",
                column: "MemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivitiesRelationship");

            migrationBuilder.DropTable(
                name: "ActivityMemberRelationship");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Shift");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Member");
        }
    }
}
