using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "e280570d-ef47-4ebe-9c67-89e59cf82f77", "Gaseosas" },
                    { "c5c600c9-0bdd-424c-aafe-4484d9d48e98", "Almacen" },
                    { "ced7cb99-4b4e-46ef-9dd6-351a5160dd05", "Golosinas" },
                    { "8900a0ef-058e-4c54-9156-2277d42fb059", "Aguas Saborisadas" },
                    { "0ff456ff-00c2-490f-8654-3770c8e32367", "Jugos" },
                    { "edd4dd70-9fee-4f8e-b4c6-163794e05df8", "Vinos" }
                });

            migrationBuilder.InsertData(
                table: "WereHouses",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { "d22e20fb-369c-4e7c-8fee-30db14dbfb90", "Cordoba 880", "Casa Central" },
                    { "42f366c8-0acf-44e5-8c59-b28ce34d8c8f", "Catamarca 1290", "Centro" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "0ff456ff-00c2-490f-8654-3770c8e32367");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "8900a0ef-058e-4c54-9156-2277d42fb059");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c5c600c9-0bdd-424c-aafe-4484d9d48e98");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "ced7cb99-4b4e-46ef-9dd6-351a5160dd05");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "e280570d-ef47-4ebe-9c67-89e59cf82f77");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "edd4dd70-9fee-4f8e-b4c6-163794e05df8");

            migrationBuilder.DeleteData(
                table: "WereHouses",
                keyColumn: "Id",
                keyValue: "42f366c8-0acf-44e5-8c59-b28ce34d8c8f");

            migrationBuilder.DeleteData(
                table: "WereHouses",
                keyColumn: "Id",
                keyValue: "d22e20fb-369c-4e7c-8fee-30db14dbfb90");
        }
    }
}
