using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HardwareStore.Infrastructure.Migrations
{
    public partial class AddedFullTextIndexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE FULLTEXT INDEX ON Products(Name, Description, Model) 
            KEY INDEX PK_Products
            ON product_catalog;
            ", true);

            migrationBuilder.Sql(@"
            CREATE FULLTEXT INDEX ON Characteristics(Value) 
            KEY INDEX PK_Characteristics
            ON product_catalog;
            ", true);

            migrationBuilder.Sql(@"
            CREATE FULLTEXT INDEX ON Manufacturers(Name) 
            KEY INDEX PK_Manufacturers
            ON product_catalog;
            ", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FULLTEXT INDEX PK_Products ON Products;", true);
            migrationBuilder.Sql("DROP FULLTEXT INDEX PK_Characteristics ON Characteristics;", true);
            migrationBuilder.Sql("DROP FULLTEXT INDEX PK_Manufacturers ON Manufacturers;", true);
        }
    }
}
