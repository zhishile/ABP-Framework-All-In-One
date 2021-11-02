using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AbpClub.Migrations
{
    public partial class Docs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocsDocuments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Version = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Format = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    EditLink = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    RootUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    RawRootUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    LocalDirectory = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastSignificantUpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastCachedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocsDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocsProjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultDocumentName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NavigationDocumentName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ParametersDocumentName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    MinimumVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentStoreType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainWebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LatestVersionBranchName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocsProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocsDocumentContributors",
                columns: table => new
                {
                    DocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CommitCount = table.Column<int>(type: "int", nullable: false),
                    UserProfileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocsDocumentContributors", x => new { x.DocumentId, x.Username });
                    table.ForeignKey(
                        name: "FK_DocsDocumentContributors_DocsDocuments_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "DocsDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocsDocumentContributors");

            migrationBuilder.DropTable(
                name: "DocsProjects");

            migrationBuilder.DropTable(
                name: "DocsDocuments");
        }
    }
}
