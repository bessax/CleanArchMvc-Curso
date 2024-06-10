using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchMvc.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) VALUES ('Caderno espiral', 'Caderno espiral 100 folhas', 7.45, 50, 'caderno1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) VALUES ('Estojo escolar', 'Estojo escolar cinza', 5.65, 75, 'estojo1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) VALUES ('Mochila escolar', 'Mochila escolar juvenil', 15.99, 30, 'mochila1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) VALUES ('Caneta esferográfica', 'Caneta esferográfica azul', 1.75, 100, 'caneta1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) VALUES ('Borracha branca', 'Borracha branca pequena', 2.45, 150, 'borracha1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) VALUES ('Apontador', 'Apontador com depósito', 1.25, 200, 'apontador1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) VALUES ('Régua 30cm', 'Régua 30cm transparente', 3.75, 100, 'regua1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) VALUES ('Pasta catálogo', 'Pasta catálogo A4', 4.25, 50, 'pasta1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) VALUES ('Grampeador', 'Grampeador pequeno', 12.45, 25, 'grampeador1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) VALUES ('Clips', 'Clips para papel', 0.75, 500, 'clips1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) VALUES ('Calculadora', 'Calculadora de bolso', 15.75, 50, 'calculadora1.jpg', 2)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
