using Microsoft.EntityFrameworkCore.Migrations;

namespace Notissimus_Test.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryIDs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryIDs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OfferHalls",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    plan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferHalls", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Offer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BID = table.Column<int>(type: "int", nullable: false),
                    CBID = table.Column<int>(type: "int", nullable: false),
                    Avalible = table.Column<bool>(type: "bit", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    artist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    binding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoryIdID = table.Column<int>(type: "int", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country_of_origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    currencyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataTour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    days = table.Column<int>(type: "int", nullable: false),
                    delivery = table.Column<bool>(type: "bit", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    downloadable = table.Column<bool>(type: "bit", nullable: false),
                    format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hallID = table.Column<int>(type: "int", nullable: true),
                    hall_part = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hotel_stars = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    included = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_kids = table.Column<int>(type: "int", nullable: false),
                    is_premiere = table.Column<int>(type: "int", nullable: false),
                    language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    local_delivery_cost = table.Column<double>(type: "float", nullable: false),
                    manufacturer_warranty = table.Column<bool>(type: "bit", nullable: false),
                    meal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    media = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    originalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    page_extent = table.Column<int>(type: "int", nullable: false),
                    part = table.Column<int>(type: "int", nullable: false),
                    performance_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    performed_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false),
                    publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    recording_length = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    room = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    series = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    starring = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    storage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typePrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vendor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vendorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    volume = table.Column<int>(type: "int", nullable: false),
                    worldRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Offer_CategoryIDs_categoryIdID",
                        column: x => x.categoryIdID,
                        principalTable: "CategoryIDs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Offer_OfferHalls_hallID",
                        column: x => x.hallID,
                        principalTable: "OfferHalls",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Offer_categoryIdID",
                table: "Offer",
                column: "categoryIdID");

            migrationBuilder.CreateIndex(
                name: "IX_Offer_hallID",
                table: "Offer",
                column: "hallID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offer");

            migrationBuilder.DropTable(
                name: "CategoryIDs");

            migrationBuilder.DropTable(
                name: "OfferHalls");
        }
    }
}
