using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bibliothek_EF.Migrations
{
    /// <inheritdoc />
    public partial class initCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Persons_ID",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_BOOK_LOANS_Customers_CustomerId",
                table: "BOOK_LOANS");

            migrationBuilder.DropForeignKey(
                name: "FK_BOOK_LOANS_Librarians_LibrarianId",
                table: "BOOK_LOANS");

            migrationBuilder.DropForeignKey(
                name: "FK_BOOK_LOANS_Librarians_ReturnLibrarianId",
                table: "BOOK_LOANS");

            migrationBuilder.DropForeignKey(
                name: "FK_BOOKS_Authors_AuthorId",
                table: "BOOKS");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Persons_ID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Librarians_Persons_ID",
                table: "Librarians");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Librarians",
                table: "Librarians");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "PERSONS");

            migrationBuilder.RenameTable(
                name: "Librarians",
                newName: "LIBRARIANS");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "CUSTOMERS");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "AUTHORS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PERSONS",
                table: "PERSONS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LIBRARIANS",
                table: "LIBRARIANS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CUSTOMERS",
                table: "CUSTOMERS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AUTHORS",
                table: "AUTHORS",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AUTHORS_PERSONS_ID",
                table: "AUTHORS",
                column: "ID",
                principalTable: "PERSONS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BOOK_LOANS_CUSTOMERS_CustomerId",
                table: "BOOK_LOANS",
                column: "CustomerId",
                principalTable: "CUSTOMERS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BOOK_LOANS_LIBRARIANS_LibrarianId",
                table: "BOOK_LOANS",
                column: "LibrarianId",
                principalTable: "LIBRARIANS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BOOK_LOANS_LIBRARIANS_ReturnLibrarianId",
                table: "BOOK_LOANS",
                column: "ReturnLibrarianId",
                principalTable: "LIBRARIANS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BOOKS_AUTHORS_AuthorId",
                table: "BOOKS",
                column: "AuthorId",
                principalTable: "AUTHORS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CUSTOMERS_PERSONS_ID",
                table: "CUSTOMERS",
                column: "ID",
                principalTable: "PERSONS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LIBRARIANS_PERSONS_ID",
                table: "LIBRARIANS",
                column: "ID",
                principalTable: "PERSONS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AUTHORS_PERSONS_ID",
                table: "AUTHORS");

            migrationBuilder.DropForeignKey(
                name: "FK_BOOK_LOANS_CUSTOMERS_CustomerId",
                table: "BOOK_LOANS");

            migrationBuilder.DropForeignKey(
                name: "FK_BOOK_LOANS_LIBRARIANS_LibrarianId",
                table: "BOOK_LOANS");

            migrationBuilder.DropForeignKey(
                name: "FK_BOOK_LOANS_LIBRARIANS_ReturnLibrarianId",
                table: "BOOK_LOANS");

            migrationBuilder.DropForeignKey(
                name: "FK_BOOKS_AUTHORS_AuthorId",
                table: "BOOKS");

            migrationBuilder.DropForeignKey(
                name: "FK_CUSTOMERS_PERSONS_ID",
                table: "CUSTOMERS");

            migrationBuilder.DropForeignKey(
                name: "FK_LIBRARIANS_PERSONS_ID",
                table: "LIBRARIANS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PERSONS",
                table: "PERSONS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LIBRARIANS",
                table: "LIBRARIANS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CUSTOMERS",
                table: "CUSTOMERS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AUTHORS",
                table: "AUTHORS");

            migrationBuilder.RenameTable(
                name: "PERSONS",
                newName: "Persons");

            migrationBuilder.RenameTable(
                name: "LIBRARIANS",
                newName: "Librarians");

            migrationBuilder.RenameTable(
                name: "CUSTOMERS",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "AUTHORS",
                newName: "Authors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Librarians",
                table: "Librarians",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Persons_ID",
                table: "Authors",
                column: "ID",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BOOK_LOANS_Customers_CustomerId",
                table: "BOOK_LOANS",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BOOK_LOANS_Librarians_LibrarianId",
                table: "BOOK_LOANS",
                column: "LibrarianId",
                principalTable: "Librarians",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BOOK_LOANS_Librarians_ReturnLibrarianId",
                table: "BOOK_LOANS",
                column: "ReturnLibrarianId",
                principalTable: "Librarians",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BOOKS_Authors_AuthorId",
                table: "BOOKS",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Persons_ID",
                table: "Customers",
                column: "ID",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Librarians_Persons_ID",
                table: "Librarians",
                column: "ID",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
