using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiPageWebApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "Name", "Note", "Phone" },
                values: new object[] { 1, "MAD Magazine, PO Box 8537, Big Sandy, TX 75755 - 853", "Alfred E Neuman", "Work", "800-462-3624" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "Name", "Note", "Phone" },
                values: new object[] { 2, "BBC London, 2nd Floor, Peel Wing, BBC Broadcasting House, Portland Place, London, W1A 1AA", "Dwayne Dibbley", "Personal", "020 8743 8000" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "Name", "Note", "Phone" },
                values: new object[] { 3, "1900 Broadway, (One Lincoln Plaza), New York, NY 10023", "Bert and Ernie", "Work", "212-595-3456" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
