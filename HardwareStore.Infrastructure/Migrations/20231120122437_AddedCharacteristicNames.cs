using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HardwareStore.Infrastructure.Migrations
{
    public partial class AddedCharacteristicNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CharacteristicsNames",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Form Factor" },
                    { 2, "Format" },
                    { 3, "Fans included" },
                    { 4, "Front panel" },
                    { 5, "Color" },
                    { 6, "Length" },
                    { 7, "Width" },
                    { 8, "Height" },
                    { 9, "Maximum height of air cooler" },
                    { 10, "Maximum video card length" },
                    { 11, "Front supported fans" },
                    { 12, "Rear fans supported" },
                    { 13, "Supported fans on top" },
                    { 14, "Supported water coolers in the front" },
                    { 15, "Rear water coolers supported" },
                    { 16, "Supported water coolers on top" },
                    { 17, "Mesh front panel" },
                    { 18, "Supported side fans" },
                    { 19, "Supported water coolers on the side" },
                    { 20, "Supported fans below" },
                    { 21, "Supported water coolers below" },
                    { 22, "Type" },
                    { 23, "Socket" },
                    { 24, "Fan speed" },
                    { 25, "Noise level" },
                    { 26, "Fan size" },
                    { 27, "Connector" },
                    { 28, "Backlight" },
                    { 29, "Air flow" },
                    { 30, "TDP" },
                    { 31, "Form" },
                    { 32, "Interface" },
                    { 33, "Microphone" },
                    { 34, "Frequency range" },
                    { 35, "Resistance" },
                    { 36, "Waterproof" },
                    { 37, "Soundproofing" },
                    { 38, "Sensitivity" },
                    { 39, "Compatibility" },
                    { 40, "Cable length" },
                    { 41, "Size of speakers" },
                    { 42, "Capacity" }
                });

            migrationBuilder.InsertData(
                table: "CharacteristicsNames",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 43, "Reading speed" },
                    { 44, "Writing speed" },
                    { 45, "Random Read IOPS" },
                    { 46, "Random Write IOPS" },
                    { 47, "Connectivity" },
                    { 48, "Cyrillicization" },
                    { 49, "Type of buttons" },
                    { 50, "Macro buttons" },
                    { 51, "Layout" },
                    { 52, "Hot-swappable" },
                    { 53, "Multi media buttons" },
                    { 54, "Switch" },
                    { 55, "Screen size" },
                    { 56, "Resolution" },
                    { 57, "Matrix" },
                    { 58, "Refresh rate" },
                    { 59, "Reaction time" },
                    { 60, "Ports" },
                    { 61, "Stand adjustment" },
                    { 62, "Touch screen" },
                    { 63, "VESA" },
                    { 64, "Brightness" },
                    { 65, "Technology" },
                    { 66, "Chipset" },
                    { 67, "Number of memory slots" },
                    { 68, "RAM capacity" },
                    { 69, "Memory frequency" },
                    { 70, "Supported memory" },
                    { 71, "Built-in Wi-Fi" },
                    { 72, "Thickness" },
                    { 73, "Surface" },
                    { 74, "Cover" },
                    { 75, "Sensor" },
                    { 76, "Programmable buttons" },
                    { 77, "Number of buttons" },
                    { 78, "Power" },
                    { 79, "Certificate" },
                    { 80, "Efficiency" },
                    { 81, "PCIe Gen5" },
                    { 82, "Physical cores" },
                    { 83, "Threads" },
                    { 84, "Base frequency" }
                });

            migrationBuilder.InsertData(
                table: "CharacteristicsNames",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 85, "Boost frequency" },
                    { 86, "Cache memory" },
                    { 87, "Box cooler" },
                    { 88, "Series" },
                    { 89, "Generation" },
                    { 90, "Frequency" },
                    { 91, "Timing" },
                    { 92, "Purpose" },
                    { 93, "Heatsink" },
                    { 94, "Kit" },
                    { 95, "Memory" },
                    { 96, "Cores" },
                    { 97, "Sheena" },
                    { 98, "Outputs" },
                    { 99, "Memory type" },
                    { 100, "Weight" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "CharacteristicsNames",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
