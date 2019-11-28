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
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ColorCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
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
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ColorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActivityMember",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityMember_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityMember_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shift",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    ClientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shift_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActivitiesRelationship",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    ShiftId = table.Column<int>(nullable: true)
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
                table: "Color",
                columns: new[] { "Id", "ColorCode", "Name" },
                values: new object[,]
                {
                    { 12, "#FFA230", "Jaune foncé" },
                    { 11, "#A4202B", "Rose foncé" },
                    { 9, "#4D8602", "Vert foncé" },
                    { 8, "#005295", "Bleu foncé" },
                    { 7, "#454644", "Gris" },
                    { 10, "#562888", "Violet foncé" },
                    { 5, "#E15E6F", "Rose" },
                    { 4, "#8D7EF3", "Violet" },
                    { 3, "#8EBB0E", "Vert" },
                    { 2, "#017CE6", "Bleu" },
                    { 1, "#240058", "Infeeny" },
                    { 6, "#FFBA00", "Jaune" }
                });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "Id", "Email", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { 8, "lecarpentier@infeeny.com", "Le Carpentier Antoine", "" },
                    { 1, "console@infeeny.com", "Pauline Console", "" },
                    { 2, "muroni@infeeny.com", "Muroni Brice", "" },
                    { 3, "dao@infeeny.com", "Dao David", "" },
                    { 4, "neyrand@infeeny.com", "Neyrand Aurélien", "" },
                    { 5, "fruhinsholz@infeeny.com", "Fruhinsholz Fiona", "" },
                    { 6, "grange@infeeny.com", "Grange Sylvain", "" },
                    { 7, "fernandez@infeeny.com", "Fernandez Gaelle", "" },
                    { 9, "florez@infeeny.com", "Florez Angela", "" }
                });

            migrationBuilder.InsertData(
                table: "ActivitiesRelationship",
                columns: new[] { "Id", "ActivityId", "MemberId", "ShiftId" },
                values: new object[,]
                {
                    { 3, 1, 3, null },
                    { 7, 1, 7, null },
                    { 6, 1, 6, null },
                    { 14, 2, 5, null },
                    { 5, 1, 5, null },
                    { 13, 2, 4, null },
                    { 4, 1, 4, null },
                    { 12, 2, 3, null },
                    { 9, 1, 9, null },
                    { 11, 2, 2, null },
                    { 2, 1, 2, null },
                    { 10, 2, 1, null },
                    { 1, 1, 1, null },
                    { 8, 1, 8, null }
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "ColorId", "Name" },
                values: new object[,]
                {
                    { 4, 6, "Cegid" },
                    { 3, 5, "Sicam" },
                    { 2, 2, "Michelin" },
                    { 1, 1, "GEM" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesRelationship_ActivityId",
                table: "ActivitiesRelationship",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesRelationship_MemberId",
                table: "ActivitiesRelationship",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesRelationship_ShiftId",
                table: "ActivitiesRelationship",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityMember_ActivityId",
                table: "ActivityMember",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityMember_MemberId",
                table: "ActivityMember",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ColorId",
                table: "Client",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Shift_ClientId",
                table: "Shift",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivitiesRelationship");

            migrationBuilder.DropTable(
                name: "ActivityMember");

            migrationBuilder.DropTable(
                name: "Shift");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Color");
        }
    }
}
