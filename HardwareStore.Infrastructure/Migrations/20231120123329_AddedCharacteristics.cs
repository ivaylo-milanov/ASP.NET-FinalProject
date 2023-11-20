using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HardwareStore.Infrastructure.Migrations
{
    public partial class AddedCharacteristics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 23, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c"), "LGA1700" },
                    { 82, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c"), "10" },
                    { 83, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c"), "16" },
                    { 84, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c"), "3.7 GHz" },
                    { 85, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c"), "4.9 GHz" },
                    { 86, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c"), "20 MB" },
                    { 87, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c"), "No" },
                    { 88, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c"), "Intel Core i5" },
                    { 89, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c"), "Intel 12th Gen" },
                    { 5, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1"), "Black" },
                    { 28, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1"), "No" },
                    { 38, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1"), "16000 DPI" },
                    { 47, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1"), "USB" },
                    { 59, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1"), "1 ms" },
                    { 75, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1"), "Optical" },
                    { 76, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1"), "No" },
                    { 77, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1"), "6" },
                    { 100, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1"), "47 g" },
                    { 5, new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d"), "Black" },
                    { 6, new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d"), "280 mm" },
                    { 7, new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d"), "340 mm" },
                    { 28, new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d"), "No" },
                    { 72, new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d"), "3 mm" },
                    { 73, new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d"), "Hard" },
                    { 74, new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d"), "No" },
                    { 5, new Guid("0608c462-e7bf-4120-bdcd-091352064849"), "Black" },
                    { 22, new Guid("0608c462-e7bf-4120-bdcd-091352064849"), "Membrane" },
                    { 31, new Guid("0608c462-e7bf-4120-bdcd-091352064849"), "Full Size" },
                    { 47, new Guid("0608c462-e7bf-4120-bdcd-091352064849"), "USB" },
                    { 48, new Guid("0608c462-e7bf-4120-bdcd-091352064849"), "No" },
                    { 49, new Guid("0608c462-e7bf-4120-bdcd-091352064849"), "High profile" },
                    { 50, new Guid("0608c462-e7bf-4120-bdcd-091352064849"), "No" },
                    { 51, new Guid("0608c462-e7bf-4120-bdcd-091352064849"), "US" },
                    { 52, new Guid("0608c462-e7bf-4120-bdcd-091352064849"), "No" },
                    { 53, new Guid("0608c462-e7bf-4120-bdcd-091352064849"), "Yes" },
                    { 23, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6"), "sWRX8" },
                    { 82, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6"), "24" },
                    { 83, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6"), "48" },
                    { 84, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6"), "3.8 GHz" },
                    { 85, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6"), "4.5 GHz" },
                    { 86, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6"), "140 MB" },
                    { 87, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6"), "No" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 88, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6"), "AMD Ryzen Threadripper" },
                    { 89, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6"), "AMD 5th Gen" },
                    { 23, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a"), "АМ5" },
                    { 82, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a"), "6" },
                    { 83, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a"), "12" },
                    { 84, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a"), "3.8 GHz" },
                    { 85, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a"), "5.1 GHz" },
                    { 86, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a"), "32 MB" },
                    { 87, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a"), "Yes" },
                    { 88, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a"), "AMD Ryzen 5" },
                    { 89, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a"), "AMD 7th Gen" },
                    { 5, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2"), "Black" },
                    { 28, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2"), "No" },
                    { 38, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2"), "25600 DPI" },
                    { 40, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2"), "2 m" },
                    { 47, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2"), "USB" },
                    { 59, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2"), "1 ms" },
                    { 75, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2"), "Hero, Optical" },
                    { 76, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2"), "Yes" },
                    { 77, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2"), "13" },
                    { 100, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2"), "89 g" },
                    { 5, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082"), "Black" },
                    { 22, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082"), "Mechanical" },
                    { 28, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082"), "RGB" },
                    { 31, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082"), "96%" },
                    { 47, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082"), "USB" },
                    { 48, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082"), "No" },
                    { 49, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082"), "High profile" },
                    { 50, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082"), "No" },
                    { 51, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082"), "US" },
                    { 52, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082"), "Yes" },
                    { 53, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082"), "Yes" },
                    { 54, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082"), "BLMS Red" },
                    { 22, new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b"), "Watery" },
                    { 23, new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b"), "1150, 1151, 1155, 1156, 1366, 2011, 2066, AM2, AM3, FM2, AM4, 1200, 1700" },
                    { 24, new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b"), "2400 RPM" },
                    { 25, new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b"), "37 dBA" },
                    { 26, new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b"), "120 x 25 mm x2" },
                    { 27, new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b"), "4-pin, 3-pin, SATA Power" },
                    { 28, new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b"), "RGB" },
                    { 29, new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b"), "75 CFM" },
                    { 5, new Guid("0ec80d70-22db-4952-bf93-99105299ca78"), "Black" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 22, new Guid("0ec80d70-22db-4952-bf93-99105299ca78"), "DDR4" },
                    { 28, new Guid("0ec80d70-22db-4952-bf93-99105299ca78"), "Yes" },
                    { 42, new Guid("0ec80d70-22db-4952-bf93-99105299ca78"), "32 GB" },
                    { 90, new Guid("0ec80d70-22db-4952-bf93-99105299ca78"), "3200 MHz" },
                    { 91, new Guid("0ec80d70-22db-4952-bf93-99105299ca78"), "CL 16" },
                    { 92, new Guid("0ec80d70-22db-4952-bf93-99105299ca78"), "Desktop" },
                    { 93, new Guid("0ec80d70-22db-4952-bf93-99105299ca78"), "Yes" },
                    { 94, new Guid("0ec80d70-22db-4952-bf93-99105299ca78"), "from 2 memories" },
                    { 5, new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a"), "Blue" },
                    { 6, new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a"), "200 mm" },
                    { 7, new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a"), "230 mm" },
                    { 28, new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a"), "No" },
                    { 72, new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a"), "2 mm" },
                    { 73, new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a"), "Textile" },
                    { 74, new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a"), "Yes" },
                    { 1, new Guid("11c9e125-f0a0-485c-a12f-c47938729085"), "M.2 2280" },
                    { 22, new Guid("11c9e125-f0a0-485c-a12f-c47938729085"), "NVMe" },
                    { 28, new Guid("11c9e125-f0a0-485c-a12f-c47938729085"), "No" },
                    { 32, new Guid("11c9e125-f0a0-485c-a12f-c47938729085"), "PCIe Gen 3.0" },
                    { 42, new Guid("11c9e125-f0a0-485c-a12f-c47938729085"), "500 GB" },
                    { 43, new Guid("11c9e125-f0a0-485c-a12f-c47938729085"), "3400 MB/s" },
                    { 44, new Guid("11c9e125-f0a0-485c-a12f-c47938729085"), "2300 MB/s" },
                    { 5, new Guid("1208439d-df39-4445-9bdb-cce86277842b"), "Black" },
                    { 28, new Guid("1208439d-df39-4445-9bdb-cce86277842b"), "RGB" },
                    { 38, new Guid("1208439d-df39-4445-9bdb-cce86277842b"), "18000 DPI" },
                    { 40, new Guid("1208439d-df39-4445-9bdb-cce86277842b"), "2 m" },
                    { 47, new Guid("1208439d-df39-4445-9bdb-cce86277842b"), "USB" },
                    { 59, new Guid("1208439d-df39-4445-9bdb-cce86277842b"), "1 ms" },
                    { 75, new Guid("1208439d-df39-4445-9bdb-cce86277842b"), "Optical, TrueMove Pro" },
                    { 76, new Guid("1208439d-df39-4445-9bdb-cce86277842b"), "Yes" },
                    { 77, new Guid("1208439d-df39-4445-9bdb-cce86277842b"), "8" },
                    { 100, new Guid("1208439d-df39-4445-9bdb-cce86277842b"), "92 g" },
                    { 23, new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03"), "LGA1151" },
                    { 82, new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03"), "2" },
                    { 83, new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03"), "4" },
                    { 84, new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03"), "3.9 GHz" },
                    { 86, new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03"), "4 MB" },
                    { 87, new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03"), "Yes" },
                    { 88, new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03"), "Intel Pentium" },
                    { 89, new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03"), "Intel 8th Gen" },
                    { 23, new Guid("125d9fda-502a-4214-85ac-f746276bbb12"), "AM4" },
                    { 82, new Guid("125d9fda-502a-4214-85ac-f746276bbb12"), "12" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 83, new Guid("125d9fda-502a-4214-85ac-f746276bbb12"), "24" },
                    { 84, new Guid("125d9fda-502a-4214-85ac-f746276bbb12"), "3.7 GHz" },
                    { 85, new Guid("125d9fda-502a-4214-85ac-f746276bbb12"), "4.8 GHz" },
                    { 86, new Guid("125d9fda-502a-4214-85ac-f746276bbb12"), "70 MB" },
                    { 87, new Guid("125d9fda-502a-4214-85ac-f746276bbb12"), "No" },
                    { 88, new Guid("125d9fda-502a-4214-85ac-f746276bbb12"), "AMD Ryzen 9" },
                    { 89, new Guid("125d9fda-502a-4214-85ac-f746276bbb12"), "AMD 5th Gen" },
                    { 1, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "Mid Tower" },
                    { 2, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "ATX, Micro ATX, Mini ITX, EATX" },
                    { 3, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "4x 140mm" },
                    { 4, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "Audio In & Out, USB 3.1 Gen1, USB 3.1 Gen 2 (Type-C)" },
                    { 5, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "Black" },
                    { 6, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "565 mm" },
                    { 7, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "250 mm" },
                    { 8, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "591 mm" },
                    { 9, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "190 mm" },
                    { 10, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "450 mm" },
                    { 11, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "3x 120mm, 3x 140mm" },
                    { 12, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "1x 120mm, 1x 140mm" },
                    { 13, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "2x 140mm, 3x 120mm" },
                    { 14, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "1x 280mm, 1x 120mm, 1x 240mm, 1x 360mm, 1x 140mm, 1x 420mm" },
                    { 15, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "1x 120mm, 1x 140mm" },
                    { 16, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "1x 240mm, 1x 120mm, 1x 140mm, 1x 280mm, 1x 360mm" },
                    { 17, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), "No" },
                    { 5, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0"), "Black" },
                    { 28, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0"), "RGB" },
                    { 38, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0"), "8000 DPI" },
                    { 40, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0"), "2.1 m" },
                    { 47, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0"), "USB" },
                    { 59, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0"), "1 ms" },
                    { 75, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0"), "Mercury, Optical" },
                    { 76, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0"), "Yes" },
                    { 77, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0"), "6" },
                    { 100, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0"), "85 g" },
                    { 5, new Guid("176d8c2e-8942-4732-a677-29c670c0c091"), "Black" },
                    { 28, new Guid("176d8c2e-8942-4732-a677-29c670c0c091"), "RGB" },
                    { 38, new Guid("176d8c2e-8942-4732-a677-29c670c0c091"), "16000 DPI" },
                    { 47, new Guid("176d8c2e-8942-4732-a677-29c670c0c091"), "USB, Wireless" },
                    { 59, new Guid("176d8c2e-8942-4732-a677-29c670c0c091"), "1 ms" },
                    { 75, new Guid("176d8c2e-8942-4732-a677-29c670c0c091"), "Hero, Optical" },
                    { 76, new Guid("176d8c2e-8942-4732-a677-29c670c0c091"), "Yes" },
                    { 77, new Guid("176d8c2e-8942-4732-a677-29c670c0c091"), "8" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 100, new Guid("176d8c2e-8942-4732-a677-29c670c0c091"), "85 g" },
                    { 5, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035"), "Blue" },
                    { 22, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035"), "Mechanical" },
                    { 28, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035"), "RGB" },
                    { 31, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035"), "60%" },
                    { 47, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035"), "USB" },
                    { 48, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035"), "No" },
                    { 49, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035"), "High profile" },
                    { 50, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035"), "No" },
                    { 51, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035"), "US" },
                    { 52, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035"), "Yes" },
                    { 53, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035"), "Yes" },
                    { 54, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035"), "Cherry MX Silver" },
                    { 5, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f"), "Black" },
                    { 55, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f"), "24 inch" },
                    { 56, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f"), "1920 x 1080" },
                    { 57, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f"), "TN" },
                    { 58, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f"), "144 Hz" },
                    { 59, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f"), "1 ms" },
                    { 60, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f"), "3.5mm Audio jack, HDMI, Display Port" },
                    { 61, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f"), "Yes" },
                    { 62, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f"), "No" },
                    { 63, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f"), "Yes" },
                    { 64, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f"), "320 cd/㎡" },
                    { 5, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5"), "Black" },
                    { 22, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5"), "DDR4" },
                    { 28, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5"), "No" },
                    { 42, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5"), "32 GB" },
                    { 90, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5"), "3600 MHz" },
                    { 91, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5"), "CL 17" },
                    { 92, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5"), "Desktop" },
                    { 93, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5"), "Yes" },
                    { 94, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5"), "from 4 memories" },
                    { 5, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831"), "Black" },
                    { 22, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831"), "DDR5" },
                    { 28, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831"), "Yes" },
                    { 42, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831"), "16 GB" },
                    { 90, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831"), "5200 MHz" },
                    { 91, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831"), "CL 38" },
                    { 92, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831"), "Desktop" },
                    { 93, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831"), "Yes" },
                    { 94, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831"), "No" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 1, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0"), "2.5\"" },
                    { 22, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0"), "SSD" },
                    { 28, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0"), "No" },
                    { 32, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0"), "SATA III" },
                    { 42, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0"), "256 GB" },
                    { 43, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0"), "520 MB/s" },
                    { 44, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0"), "500 MB/s" },
                    { 45, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0"), "80 k" },
                    { 46, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0"), "85 k" },
                    { 8, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f"), "157 mm" },
                    { 22, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f"), "Aerial" },
                    { 23, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f"), "1150, 1151, 1155, 1156, 2066, AM4, 2011-3, 1200, 1700" },
                    { 24, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f"), "2100 RPM" },
                    { 25, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f"), "28 dBA" },
                    { 26, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f"), "120 x 25 mm x2" },
                    { 27, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f"), "4-pin PWM" },
                    { 28, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f"), "No" },
                    { 29, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f"), "135.12 CFM" },
                    { 30, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f"), "210 W" },
                    { 88, new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44"), "RX 7000 Series" },
                    { 90, new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44"), "2320 MHz" },
                    { 95, new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44"), "8 GB" },
                    { 96, new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44"), "2048 Stream" },
                    { 97, new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44"), "128 bit" },
                    { 98, new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44"), "HDMI, DisplayPort" },
                    { 99, new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44"), "GDDR6" },
                    { 5, new Guid("20138228-3cb1-4a00-899e-ed40343018f9"), "Black" },
                    { 22, new Guid("20138228-3cb1-4a00-899e-ed40343018f9"), "Membrane" },
                    { 28, new Guid("20138228-3cb1-4a00-899e-ed40343018f9"), "RGB" },
                    { 31, new Guid("20138228-3cb1-4a00-899e-ed40343018f9"), "TKL" },
                    { 47, new Guid("20138228-3cb1-4a00-899e-ed40343018f9"), "USB" },
                    { 48, new Guid("20138228-3cb1-4a00-899e-ed40343018f9"), "No" },
                    { 49, new Guid("20138228-3cb1-4a00-899e-ed40343018f9"), "High profile" },
                    { 50, new Guid("20138228-3cb1-4a00-899e-ed40343018f9"), "Yes" },
                    { 51, new Guid("20138228-3cb1-4a00-899e-ed40343018f9"), "US" },
                    { 52, new Guid("20138228-3cb1-4a00-899e-ed40343018f9"), "No" },
                    { 53, new Guid("20138228-3cb1-4a00-899e-ed40343018f9"), "Yes" },
                    { 5, new Guid("208f2a40-db59-4499-b40d-368db5b3a634"), "Black" },
                    { 22, new Guid("208f2a40-db59-4499-b40d-368db5b3a634"), "Stereo" },
                    { 31, new Guid("208f2a40-db59-4499-b40d-368db5b3a634"), "Over-ear" },
                    { 32, new Guid("208f2a40-db59-4499-b40d-368db5b3a634"), "3.5mm Audio jack, 2x3.5mm Audio jack" },
                    { 33, new Guid("208f2a40-db59-4499-b40d-368db5b3a634"), "Yes" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 34, new Guid("208f2a40-db59-4499-b40d-368db5b3a634"), "20 Hz - 20 kHz" },
                    { 35, new Guid("208f2a40-db59-4499-b40d-368db5b3a634"), "99 Ω" },
                    { 36, new Guid("208f2a40-db59-4499-b40d-368db5b3a634"), "No" },
                    { 37, new Guid("208f2a40-db59-4499-b40d-368db5b3a634"), "No" },
                    { 38, new Guid("208f2a40-db59-4499-b40d-368db5b3a634"), "16 dB" },
                    { 39, new Guid("208f2a40-db59-4499-b40d-368db5b3a634"), "PC" },
                    { 40, new Guid("208f2a40-db59-4499-b40d-368db5b3a634"), "3 m" },
                    { 41, new Guid("208f2a40-db59-4499-b40d-368db5b3a634"), "40 mm" },
                    { 22, new Guid("221245d9-e8d1-4d83-b950-889ac825d869"), "Watery" },
                    { 23, new Guid("221245d9-e8d1-4d83-b950-889ac825d869"), "1150, 1151, 1155, 1156, 1200, 1700" },
                    { 24, new Guid("221245d9-e8d1-4d83-b950-889ac825d869"), "2100 RPM" },
                    { 25, new Guid("221245d9-e8d1-4d83-b950-889ac825d869"), "35.7 dBA" },
                    { 26, new Guid("221245d9-e8d1-4d83-b950-889ac825d869"), "140 x 25 mm x2" },
                    { 27, new Guid("221245d9-e8d1-4d83-b950-889ac825d869"), "4-pin, USB Header, 3-pin, 3-pin 5V ARGB" },
                    { 28, new Guid("221245d9-e8d1-4d83-b950-889ac825d869"), "ARGB" },
                    { 29, new Guid("221245d9-e8d1-4d83-b950-889ac825d869"), "102.3 CFM" },
                    { 5, new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7"), "Red" },
                    { 6, new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7"), "300 mm" },
                    { 7, new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7"), "360 mm" },
                    { 28, new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7"), "No" },
                    { 72, new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7"), "3.5 mm" },
                    { 73, new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7"), "Textile" },
                    { 74, new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7"), "Yes" },
                    { 5, new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4"), "Black" },
                    { 6, new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4"), "300 mm" },
                    { 7, new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4"), "750 mm" },
                    { 28, new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4"), "No" },
                    { 72, new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4"), "3 mm" },
                    { 73, new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4"), "Textile" },
                    { 74, new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4"), "Tes" },
                    { 5, new Guid("2403dada-744b-4347-b72a-6df00591f237"), "Black, Yellow" },
                    { 22, new Guid("2403dada-744b-4347-b72a-6df00591f237"), "DDR4" },
                    { 28, new Guid("2403dada-744b-4347-b72a-6df00591f237"), "No" },
                    { 42, new Guid("2403dada-744b-4347-b72a-6df00591f237"), "16 GB" },
                    { 90, new Guid("2403dada-744b-4347-b72a-6df00591f237"), "3200 MHz" },
                    { 91, new Guid("2403dada-744b-4347-b72a-6df00591f237"), "CL 16" },
                    { 92, new Guid("2403dada-744b-4347-b72a-6df00591f237"), "Desktop" },
                    { 93, new Guid("2403dada-744b-4347-b72a-6df00591f237"), "Yes" },
                    { 94, new Guid("2403dada-744b-4347-b72a-6df00591f237"), "from 2 memories" },
                    { 88, new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad"), "GTX 1000 Series" },
                    { 90, new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad"), "1785 MHz" },
                    { 95, new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad"), "6 GB" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 96, new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad"), "1408 CUDA" },
                    { 97, new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad"), "192 bit" },
                    { 98, new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad"), "HDMI, DisplayPort" },
                    { 99, new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad"), "GDDR6" },
                    { 5, new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6"), "Purple" },
                    { 6, new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6"), "300 mm" },
                    { 7, new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6"), "700 mm" },
                    { 28, new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6"), "No" },
                    { 72, new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6"), "2 mm" },
                    { 73, new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6"), "Textile" },
                    { 74, new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6"), "Yes" },
                    { 5, new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac"), "WarCraft" },
                    { 6, new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac"), "420 mm" },
                    { 7, new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac"), "900 mm" },
                    { 28, new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac"), "No" },
                    { 72, new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac"), "4 mm" },
                    { 73, new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac"), "Textile" },
                    { 74, new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac"), "Yes" },
                    { 1, new Guid("26f18072-6741-4ece-a5bc-977994a5268b"), "2.5\"" },
                    { 22, new Guid("26f18072-6741-4ece-a5bc-977994a5268b"), "SSD" },
                    { 28, new Guid("26f18072-6741-4ece-a5bc-977994a5268b"), "No" },
                    { 32, new Guid("26f18072-6741-4ece-a5bc-977994a5268b"), "SATA III" },
                    { 42, new Guid("26f18072-6741-4ece-a5bc-977994a5268b"), "480 GB" },
                    { 43, new Guid("26f18072-6741-4ece-a5bc-977994a5268b"), "500 MB/s" },
                    { 44, new Guid("26f18072-6741-4ece-a5bc-977994a5268b"), "450 MB/s" },
                    { 1, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9"), "Micro ATX" },
                    { 23, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9"), "AMD AM4" },
                    { 28, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9"), "No" },
                    { 66, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9"), "AMD B450" },
                    { 67, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9"), "2" },
                    { 68, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9"), "64 GB" },
                    { 69, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9"), "3200 MHz" },
                    { 70, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9"), "DDR4" },
                    { 71, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9"), "Yes" },
                    { 22, new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6"), "Watery" },
                    { 23, new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6"), "1150, 1151, 1155, 1156, 2011, 2066, AM4, sTRX4, 1200, 1700, sTR4" },
                    { 24, new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6"), "1700 RPM" },
                    { 25, new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6"), "33.8 dBA" },
                    { 26, new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6"), "140 x 25 mm x3" },
                    { 27, new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6"), "USB Header, 3-pin, 3-pin 5V ARGB, SATA Power" },
                    { 28, new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6"), "ARGB" },
                    { 29, new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6"), "89 CFM" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 1, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "Mid Tower" },
                    { 2, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "ATX, Micro ATX, EATX" },
                    { 3, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "No" },
                    { 4, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "USB 3.0, Audio In & Out, USB 3.1 Gen 2 (Type-C)" },
                    { 5, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "White" },
                    { 6, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "446 mm" },
                    { 7, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "274 mm" },
                    { 8, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "449 mm" },
                    { 9, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "155 mm" },
                    { 10, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "420 mm" },
                    { 13, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "2x 140mm, 3x 120mm" },
                    { 16, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "1x 240mm, 1x 280mm, 1x 360mm" },
                    { 17, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "No" },
                    { 18, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "3x 120mm" },
                    { 19, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "1x 240mm, 1x 280mm, 1x 360mm" },
                    { 20, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "3x 120mm" },
                    { 21, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), "1x 240mm, 1x 280mm, 1x 360mm" },
                    { 1, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0"), "Micro ATX" },
                    { 23, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0"), "Intel 1200" },
                    { 28, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0"), "No" },
                    { 66, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0"), "Intel H510" },
                    { 67, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0"), "2" },
                    { 68, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0"), "64 GB" },
                    { 69, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0"), "3200 MHz" },
                    { 70, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0"), "DDR4" },
                    { 71, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0"), "No" },
                    { 5, new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3"), "Black" },
                    { 6, new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3"), "300 mm" },
                    { 7, new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3"), "900 mm" },
                    { 28, new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3"), "Yes" },
                    { 72, new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3"), "4 mm" },
                    { 73, new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3"), "Textile" },
                    { 74, new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3"), "Yes" },
                    { 23, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c"), "LGA1700" },
                    { 82, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c"), "24" },
                    { 83, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c"), "32" },
                    { 84, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c"), "3 GHz" },
                    { 85, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c"), "5.8 GHz" },
                    { 86, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c"), "36 MB" },
                    { 87, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c"), "No" },
                    { 88, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c"), "Intel Core i9" },
                    { 89, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c"), "Intel 13th Gen" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 1, new Guid("32987f00-ee05-40bf-aecd-e13297d74532"), "Mid Tower" },
                    { 2, new Guid("32987f00-ee05-40bf-aecd-e13297d74532"), "ATX, Micro ATX, Mini ITX" },
                    { 3, new Guid("32987f00-ee05-40bf-aecd-e13297d74532"), "4x 120mm" },
                    { 4, new Guid("32987f00-ee05-40bf-aecd-e13297d74532"), "USB 3.0, USB 2.0, Audio In & Out" },
                    { 5, new Guid("32987f00-ee05-40bf-aecd-e13297d74532"), "White" },
                    { 6, new Guid("32987f00-ee05-40bf-aecd-e13297d74532"), "400 mm" },
                    { 7, new Guid("32987f00-ee05-40bf-aecd-e13297d74532"), "190 mm" },
                    { 8, new Guid("32987f00-ee05-40bf-aecd-e13297d74532"), "440 mm" },
                    { 9, new Guid("32987f00-ee05-40bf-aecd-e13297d74532"), "160 mm" },
                    { 10, new Guid("32987f00-ee05-40bf-aecd-e13297d74532"), "335 mm" },
                    { 11, new Guid("32987f00-ee05-40bf-aecd-e13297d74532"), "3x 120mm, 2x 140mm" },
                    { 12, new Guid("32987f00-ee05-40bf-aecd-e13297d74532"), "1x 120mm" },
                    { 13, new Guid("32987f00-ee05-40bf-aecd-e13297d74532"), "2x 120mm, 2x 140mm" },
                    { 14, new Guid("32987f00-ee05-40bf-aecd-e13297d74532"), "1x 280mm" },
                    { 17, new Guid("32987f00-ee05-40bf-aecd-e13297d74532"), "Yes" },
                    { 1, new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567"), "2.5\"" },
                    { 22, new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567"), "SSD" },
                    { 28, new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567"), "No" },
                    { 32, new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567"), "SATA III" },
                    { 42, new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567"), "256 GB" },
                    { 43, new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567"), "550 MB/s" },
                    { 44, new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567"), "450 MB/s" },
                    { 5, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981"), "Black" },
                    { 28, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981"), "RGB" },
                    { 38, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981"), "16000 DPI" },
                    { 40, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981"), "2.1 m" },
                    { 47, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981"), "USB" },
                    { 59, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981"), "1 ms" },
                    { 75, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981"), "Hero, Optical" },
                    { 76, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981"), "Yes" },
                    { 77, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981"), "11" },
                    { 100, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981"), "120 g" },
                    { 1, new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d"), "ATX" },
                    { 5, new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d"), "Black" },
                    { 22, new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d"), "Non-modular" },
                    { 28, new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d"), "No" },
                    { 78, new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d"), "750W" },
                    { 79, new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d"), "80+ Bronze" },
                    { 80, new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d"), "85 %" },
                    { 81, new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d"), "No" },
                    { 1, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "Mid Tower" },
                    { 2, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "ATX, Micro ATX, Mini ITX, EATX" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 3, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "2x 120mm, 2x 200mm" },
                    { 4, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "Audio In & Out, USB 3.2 Gen1, ARGB Controller, USB 3.2 (Gen 2) Type-C" },
                    { 5, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "Black" },
                    { 6, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "516 mm" },
                    { 7, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "224 mm" },
                    { 8, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "510 mm" },
                    { 9, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "167 mm" },
                    { 10, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "410 mm" },
                    { 11, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "3x 120mm, 2x 140mm, 2x 200mm" },
                    { 12, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "1x 120mm" },
                    { 13, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "2x 140mm, 3x 120mm, 2x 200mm" },
                    { 14, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "1x 280mm, 1x 120mm, 1x 240mm, 1x 360mm, 1x 140mm" },
                    { 15, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "1x 120mm" },
                    { 16, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "1x 240mm, 1x 120mm, 1x 140mm, 1x 280mm, 1x 360mm" },
                    { 17, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), "Yes" },
                    { 5, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070"), "White" },
                    { 28, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070"), "RGB" },
                    { 38, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070"), "16000 DPI" },
                    { 40, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070"), "1.8 m" },
                    { 47, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070"), "USB" },
                    { 59, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070"), "1 ms" },
                    { 75, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070"), "Optical, PixArt 3335" },
                    { 76, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070"), "Yes" },
                    { 77, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070"), "6" },
                    { 100, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070"), "59 g" },
                    { 1, new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6"), "ATX" },
                    { 5, new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6"), "Black" },
                    { 22, new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6"), "Non-modular" },
                    { 28, new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6"), "No" },
                    { 78, new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6"), "600W" },
                    { 79, new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6"), "80+" },
                    { 80, new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6"), "82 %" },
                    { 81, new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6"), "No" },
                    { 5, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba"), "Black" },
                    { 55, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba"), "23.8 inch" },
                    { 56, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba"), "1920 x 1080" },
                    { 57, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba"), "IPS" },
                    { 58, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba"), "60 Hz" },
                    { 59, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba"), "5 ms" },
                    { 60, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba"), "3.5mm Audio jack, DVI, HDMI, Display Port, USB-A" },
                    { 61, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba"), "Yes" },
                    { 62, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba"), "No" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 63, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba"), "Yes" },
                    { 64, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba"), "250 cd/㎡" },
                    { 1, new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe"), "ATX" },
                    { 5, new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe"), "Black" },
                    { 22, new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe"), "Modular" },
                    { 28, new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe"), "Yes" },
                    { 78, new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe"), "750W" },
                    { 79, new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe"), "80+ Gold" },
                    { 80, new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe"), "90 %" },
                    { 81, new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe"), "No" },
                    { 5, new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456"), "Diablo" },
                    { 6, new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456"), "420 mm" },
                    { 7, new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456"), "900 mm" },
                    { 28, new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456"), "No" },
                    { 72, new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456"), "3 mm" },
                    { 73, new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456"), "Textile" },
                    { 74, new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456"), "Yes" },
                    { 23, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c"), "AM4" },
                    { 82, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c"), "6" },
                    { 83, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c"), "12" },
                    { 84, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c"), "3.9 GHz" },
                    { 85, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c"), "4.4 GHz" },
                    { 86, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c"), "19 MB" },
                    { 87, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c"), "Yes" },
                    { 88, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c"), "AMD Ryzen 5" },
                    { 89, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c"), "AMD 5th Gen" },
                    { 1, new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7"), "ATX" },
                    { 5, new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7"), "Black" },
                    { 22, new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7"), "Semi-modular" },
                    { 28, new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7"), "No" },
                    { 78, new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7"), "750W" },
                    { 79, new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7"), "80+ Bronze" },
                    { 80, new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7"), "89 %" },
                    { 81, new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7"), "No" },
                    { 1, new Guid("4556d753-6a08-4457-b2a8-d772c054499e"), "M.2 2280" },
                    { 22, new Guid("4556d753-6a08-4457-b2a8-d772c054499e"), "NVMe" },
                    { 32, new Guid("4556d753-6a08-4457-b2a8-d772c054499e"), "PCIe Gen 4.0" },
                    { 42, new Guid("4556d753-6a08-4457-b2a8-d772c054499e"), "1000 GB" },
                    { 43, new Guid("4556d753-6a08-4457-b2a8-d772c054499e"), "7450 MB/s" },
                    { 44, new Guid("4556d753-6a08-4457-b2a8-d772c054499e"), "6900 MB/s" },
                    { 45, new Guid("4556d753-6a08-4457-b2a8-d772c054499e"), "1200 k" },
                    { 46, new Guid("4556d753-6a08-4457-b2a8-d772c054499e"), "1550 k" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 22, new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702"), "Watery" },
                    { 23, new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702"), "1150, 1151, 1155, 1156, 2011, 2066, AM4, sTRX4, 1200, 1700, sTR4" },
                    { 24, new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702"), "2100 RPM" },
                    { 25, new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702"), "34.1 dBA" },
                    { 26, new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702"), "120 x 25 mm x3" },
                    { 27, new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702"), "USB Header, 3-pin, 4-pin PWM, SATA Power" },
                    { 28, new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702"), "ARGB" },
                    { 29, new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702"), "65.57 CFM" },
                    { 5, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7"), "Black" },
                    { 55, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7"), "24.5 inch" },
                    { 56, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7"), "1920 x 1080" },
                    { 57, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7"), "IPS" },
                    { 58, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7"), "240 Hz" },
                    { 59, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7"), "1 ms" },
                    { 60, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7"), "HDMI, Display Port" },
                    { 61, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7"), "Yes" },
                    { 62, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7"), "No" },
                    { 63, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7"), "Yes" },
                    { 64, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7"), "400 cd/㎡" },
                    { 65, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7"), "G-Sync" },
                    { 5, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd"), "Black" },
                    { 28, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd"), "RGB" },
                    { 38, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd"), "16000 DPI" },
                    { 47, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd"), "USB, Wireless" },
                    { 59, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd"), "1 ms" },
                    { 75, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd"), "Hero, Optical" },
                    { 76, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd"), "Yes" },
                    { 77, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd"), "6" },
                    { 100, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd"), "95 g" },
                    { 1, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), "Mid Tower" },
                    { 2, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), "ATX, Micro ATX, Mini ITX, EATX" },
                    { 3, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), "3x 120mm" },
                    { 4, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), "Audio In & Out, USB 3.2 Gen1" },
                    { 5, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), "Black" },
                    { 6, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), "496 mm" },
                    { 7, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), "217 mm" },
                    { 8, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), "469 mm" },
                    { 9, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), "165 mm" },
                    { 10, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), "410 mm" },
                    { 11, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), "3x 120mm, 2x 140mm" },
                    { 12, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), "1x 120mm" },
                    { 13, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), "2x 140mm, 3x 120mm" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 14, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), "1x 280mm, 1x 120mm, 1x 240mm, 1x 360mm, 1x 140mm" },
                    { 16, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), "1x 240mm, 1x 120mm, 1x 360mm" },
                    { 17, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), "Yes" },
                    { 1, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6"), "M.2 2280" },
                    { 22, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6"), "NVMe" },
                    { 28, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6"), "No" },
                    { 32, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6"), "PCIe Gen 3.0" },
                    { 42, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6"), "250 GB" },
                    { 43, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6"), "3500 MB/s" },
                    { 44, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6"), "2300 MB/s" },
                    { 45, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6"), "250 k" },
                    { 46, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6"), "550 k" },
                    { 5, new Guid("50c72822-3c58-4689-bb12-171629bfce1a"), "Black" },
                    { 22, new Guid("50c72822-3c58-4689-bb12-171629bfce1a"), "Stereo" },
                    { 31, new Guid("50c72822-3c58-4689-bb12-171629bfce1a"), "Over-ear" },
                    { 32, new Guid("50c72822-3c58-4689-bb12-171629bfce1a"), "USB" },
                    { 33, new Guid("50c72822-3c58-4689-bb12-171629bfce1a"), "Yes" },
                    { 34, new Guid("50c72822-3c58-4689-bb12-171629bfce1a"), "20 Hz - 20 kHz" },
                    { 35, new Guid("50c72822-3c58-4689-bb12-171629bfce1a"), "16 Ω" },
                    { 36, new Guid("50c72822-3c58-4689-bb12-171629bfce1a"), "No" },
                    { 37, new Guid("50c72822-3c58-4689-bb12-171629bfce1a"), "No" },
                    { 38, new Guid("50c72822-3c58-4689-bb12-171629bfce1a"), "105 dB" },
                    { 39, new Guid("50c72822-3c58-4689-bb12-171629bfce1a"), "PC" },
                    { 40, new Guid("50c72822-3c58-4689-bb12-171629bfce1a"), "2 m" },
                    { 41, new Guid("50c72822-3c58-4689-bb12-171629bfce1a"), "50 mm" },
                    { 1, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "Mid Tower" },
                    { 2, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "ATX, Micro ATX, Mini ITX" },
                    { 3, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "3x 120mm" },
                    { 4, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "USB 3.0, Audio In & Out" },
                    { 5, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "Black" },
                    { 6, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "395 mm" },
                    { 7, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "210 mm" },
                    { 8, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "450 mm" },
                    { 9, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "160 mm" },
                    { 10, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "300 mm" },
                    { 11, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "3x 120mm, 2x 140mm" },
                    { 12, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "1x 120mm" },
                    { 13, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "2x 120mm, 2x 140mm" },
                    { 14, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "1x 280mm, 1x 360mm" },
                    { 15, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "1x 120mm" },
                    { 16, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "1x 240mm" },
                    { 17, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), "Yes" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 1, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7"), "M.2 2280" },
                    { 22, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7"), "NVMe" },
                    { 28, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7"), "No" },
                    { 32, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7"), "PCIe Gen 3.0" },
                    { 42, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7"), "256 GB" },
                    { 43, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7"), "1700 MB/s" },
                    { 44, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7"), "1100 MB/s" },
                    { 45, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7"), "180 k" },
                    { 46, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7"), "250 k" },
                    { 1, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "Mid Tower" },
                    { 2, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "ATX, Micro ATX, Mini ITX, EATX" },
                    { 3, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "1x 140mm, 2x 160mm" },
                    { 4, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "USB 3.0, Audio In & Out, Type-C, ARGB Controller" },
                    { 5, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "White" },
                    { 6, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "480.9 mm" },
                    { 7, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "235 mm" },
                    { 8, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "491.7 mm" },
                    { 9, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "180.5 mm" },
                    { 10, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "392 mm" },
                    { 11, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "3x 120mm, 2x 140mm, 2x 160mm" },
                    { 12, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "1x 120mm, 1x 140mm" },
                    { 13, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "2x 140mm, 3x 120mm" },
                    { 14, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "1x 280mm, 1x 360mm" },
                    { 16, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "1x 280mm, 1x 360mm" },
                    { 17, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "Yes" },
                    { 20, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "2x 120mm, 2x 140mm" },
                    { 21, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), "1x 240mm" },
                    { 1, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2"), "M.2 2280" },
                    { 22, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2"), "NVMe" },
                    { 28, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2"), "No" },
                    { 32, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2"), "PCIe Gen 4.0" },
                    { 42, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2"), "2000 GB" },
                    { 43, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2"), "5000 MB/s" },
                    { 44, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2"), "4400 MB/s" },
                    { 45, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2"), "750 k" },
                    { 46, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2"), "700 k" },
                    { 1, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7"), "ATX" },
                    { 23, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7"), "Intel 1700" },
                    { 28, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7"), "Yes" },
                    { 66, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7"), "Intel B660" },
                    { 67, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7"), "4" },
                    { 68, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7"), "128 GB" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 69, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7"), "5333 MHz" },
                    { 70, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7"), "DDR4" },
                    { 71, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7"), "Yes" },
                    { 5, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943"), "Grey" },
                    { 55, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943"), "15.6 inch" },
                    { 56, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943"), "1920 x 1080" },
                    { 57, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943"), "OLED" },
                    { 58, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943"), "60 Hz" },
                    { 59, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943"), "1 ms" },
                    { 60, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943"), "USB-C, Mini HDMI" },
                    { 61, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943"), "No" },
                    { 62, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943"), "No" },
                    { 63, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943"), "No" },
                    { 64, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943"), "360 cd/㎡" },
                    { 1, new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1"), "ATX" },
                    { 5, new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1"), "Black" },
                    { 22, new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1"), "Modular" },
                    { 28, new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1"), "No" },
                    { 78, new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1"), "650W" },
                    { 79, new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1"), "80+ Gold" },
                    { 80, new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1"), "92.7 %" },
                    { 81, new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1"), "No" },
                    { 1, new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a"), "ATX" },
                    { 5, new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a"), "Black" },
                    { 22, new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a"), "Semi-modular" },
                    { 28, new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a"), "No" },
                    { 78, new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a"), "650W" },
                    { 79, new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a"), "80+ Bronze" },
                    { 80, new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a"), "87 %" },
                    { 81, new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a"), "No" },
                    { 1, new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e"), "ATX" },
                    { 5, new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e"), "Black" },
                    { 22, new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e"), "Modular" },
                    { 28, new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e"), "No" },
                    { 78, new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e"), "850W" },
                    { 79, new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e"), "80+ Gold" },
                    { 80, new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e"), "92 %" },
                    { 81, new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e"), "Yes" },
                    { 8, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c"), "159 mm" },
                    { 22, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c"), "Aerial" },
                    { 23, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c"), "1150, 1151, 1155, 1156, 1366, AM2, AM2+, AM3, AM3+, FM1, FM2, FM2+, AM4, 1200, 1700" },
                    { 24, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c"), "2000 RPM" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 25, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c"), "26 dBA" },
                    { 26, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c"), "120 x 25 mm" },
                    { 27, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c"), "4-pin PWM" },
                    { 28, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c"), "No" },
                    { 29, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c"), "42 CFM" },
                    { 1, new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470"), "ATX" },
                    { 5, new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470"), "Black" },
                    { 22, new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470"), "Non-modular" },
                    { 28, new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470"), "No" },
                    { 78, new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470"), "600W" },
                    { 79, new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470"), "80+" },
                    { 80, new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470"), "82 %" },
                    { 81, new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470"), "No" },
                    { 5, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d"), "Silver" },
                    { 22, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d"), "Mechanical" },
                    { 28, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d"), "RGB" },
                    { 31, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d"), "Full Size" },
                    { 47, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d"), "USB" },
                    { 48, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d"), "No" },
                    { 49, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d"), "High profile" },
                    { 50, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d"), "Yes" },
                    { 51, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d"), "US" },
                    { 52, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d"), "Yes" },
                    { 53, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d"), "Yes" },
                    { 54, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d"), "Cooler Master Optical Brown" },
                    { 5, new Guid("5fe0b265-d074-4864-9526-966405759eff"), "Blue" },
                    { 22, new Guid("5fe0b265-d074-4864-9526-966405759eff"), "Mechanical" },
                    { 28, new Guid("5fe0b265-d074-4864-9526-966405759eff"), "RGB" },
                    { 31, new Guid("5fe0b265-d074-4864-9526-966405759eff"), "TKL" },
                    { 47, new Guid("5fe0b265-d074-4864-9526-966405759eff"), "USB" },
                    { 48, new Guid("5fe0b265-d074-4864-9526-966405759eff"), "No" },
                    { 49, new Guid("5fe0b265-d074-4864-9526-966405759eff"), "High profile" },
                    { 50, new Guid("5fe0b265-d074-4864-9526-966405759eff"), "Yes" },
                    { 51, new Guid("5fe0b265-d074-4864-9526-966405759eff"), "US" },
                    { 52, new Guid("5fe0b265-d074-4864-9526-966405759eff"), "No" },
                    { 53, new Guid("5fe0b265-d074-4864-9526-966405759eff"), "Yes" },
                    { 54, new Guid("5fe0b265-d074-4864-9526-966405759eff"), "GX Brown (Tactile)" },
                    { 1, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "Mid Tower" },
                    { 2, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "ATX, Micro ATX, Mini ITX, EATX" },
                    { 3, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "No" },
                    { 4, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "USB 3.0, Audio In & Out, USB 3.1 Gen 2 (Type-C)" },
                    { 5, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "White" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 6, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "445 mm" },
                    { 7, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "272 mm" },
                    { 8, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "446 mm" },
                    { 9, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "155 mm" },
                    { 10, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "420 mm" },
                    { 13, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "2x 140mm, 3x 120mm" },
                    { 16, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "1x 240mm, 1x 280mm, 1x 360mm" },
                    { 17, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "No" },
                    { 18, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "3x 120mm" },
                    { 19, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "1x 240mm, 1x 280mm, 1x 360mm" },
                    { 20, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "3x 120mm" },
                    { 21, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), "1x 240mm, 1x 280mm, 1x 360mm" },
                    { 5, new Guid("637d8089-3235-4896-a213-2b85771393c5"), "Black" },
                    { 28, new Guid("637d8089-3235-4896-a213-2b85771393c5"), "RGB" },
                    { 38, new Guid("637d8089-3235-4896-a213-2b85771393c5"), "8500 DPI" },
                    { 40, new Guid("637d8089-3235-4896-a213-2b85771393c5"), "1.8 m" },
                    { 47, new Guid("637d8089-3235-4896-a213-2b85771393c5"), "USB" },
                    { 59, new Guid("637d8089-3235-4896-a213-2b85771393c5"), "1 ms" },
                    { 75, new Guid("637d8089-3235-4896-a213-2b85771393c5"), "Optical, TrueMove Core" },
                    { 76, new Guid("637d8089-3235-4896-a213-2b85771393c5"), "Yes" },
                    { 77, new Guid("637d8089-3235-4896-a213-2b85771393c5"), "6" },
                    { 100, new Guid("637d8089-3235-4896-a213-2b85771393c5"), "77 g" },
                    { 5, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"), "White" },
                    { 22, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"), "7.1 Virtual surround" },
                    { 31, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"), "Over-ear" },
                    { 32, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"), "3.5mm Audio jack, Bluetooth, USB, Wireless" },
                    { 33, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"), "Yes" },
                    { 34, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"), "20 Hz - 20 kHz" },
                    { 35, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"), "38 Ω" },
                    { 36, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"), "No" },
                    { 37, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"), "No" },
                    { 38, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"), "87.8 dB" },
                    { 39, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"), "PC/Mac, Mobile, Nintendo Switch, PlayStation 4, PlayStation 5, Xbox Series S/X" },
                    { 40, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"), "1.8 m" },
                    { 41, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"), "50 mm" },
                    { 1, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "Mini Tower" },
                    { 2, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "Micro ATX, Mini ITX" },
                    { 3, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "2x 120mm" },
                    { 4, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "Audio In & Out, USB 3.2 Gen1, ARGB Controller" },
                    { 5, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "Black" },
                    { 6, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "433 mm" },
                    { 7, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "210 mm" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 8, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "421 mm" },
                    { 9, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "166 mm" },
                    { 10, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "344 mm" },
                    { 11, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "3x 120mm, 2x 140mm" },
                    { 12, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "1x 120mm" },
                    { 13, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "2x 120mm, 2x 140mm" },
                    { 14, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "1x 280mm, 1x 120mm, 1x 240mm, 1x 140mm" },
                    { 15, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "1x 120mm" },
                    { 16, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "1x 240mm, 1x 120mm, 1x 140mm, 1x 280mm" },
                    { 17, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), "Yes" },
                    { 5, new Guid("65386f80-3659-4dc5-873b-572afdd12461"), "Black" },
                    { 22, new Guid("65386f80-3659-4dc5-873b-572afdd12461"), "7.1 Virtual surround" },
                    { 31, new Guid("65386f80-3659-4dc5-873b-572afdd12461"), "Over-ear" },
                    { 32, new Guid("65386f80-3659-4dc5-873b-572afdd12461"), "3.5mm Audio jack, USB, 2x3.5mm Audio jack" },
                    { 33, new Guid("65386f80-3659-4dc5-873b-572afdd12461"), "Yes" },
                    { 34, new Guid("65386f80-3659-4dc5-873b-572afdd12461"), "20 Hz - 20 kHz" },
                    { 35, new Guid("65386f80-3659-4dc5-873b-572afdd12461"), "35 Ω" },
                    { 36, new Guid("65386f80-3659-4dc5-873b-572afdd12461"), "No" },
                    { 37, new Guid("65386f80-3659-4dc5-873b-572afdd12461"), "No" },
                    { 38, new Guid("65386f80-3659-4dc5-873b-572afdd12461"), "91.7 dB" },
                    { 39, new Guid("65386f80-3659-4dc5-873b-572afdd12461"), "Xbox, PC/Mac, PlayStation, Mobile, Nintendo Switch" },
                    { 40, new Guid("65386f80-3659-4dc5-873b-572afdd12461"), "2 m" },
                    { 41, new Guid("65386f80-3659-4dc5-873b-572afdd12461"), "50 mm" },
                    { 5, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a"), "Black" },
                    { 55, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a"), "27 inch" },
                    { 56, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a"), "1920 x 1080" },
                    { 57, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a"), "IPS" },
                    { 58, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a"), "165 Hz" },
                    { 59, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a"), "1 ms" },
                    { 60, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a"), "3.5mm Audio jack, HDMI, Display Port, USB-A, USB-C" },
                    { 61, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a"), "No" },
                    { 62, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a"), "No" },
                    { 63, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a"), "Yes" },
                    { 64, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a"), "400 cd/㎡" },
                    { 5, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"), "Black" },
                    { 22, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"), "3D Audio" },
                    { 31, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"), "Over-ear" },
                    { 32, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"), "Bluetooth, USB, Wireless, USB-C" },
                    { 33, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"), "Yes" },
                    { 34, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"), "20 Hz - 22 kHz" },
                    { 35, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"), "36 Ω" },
                    { 36, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"), "No" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 37, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"), "No" },
                    { 38, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"), "93 dB" },
                    { 39, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"), "PC/Mac, Mobile, Nintendo Switch, PlayStation 4, PlayStation 5, Oculus Quest 2" },
                    { 40, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"), "1.2 m" },
                    { 41, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"), "40 mm" },
                    { 1, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4"), "Extended ATX" },
                    { 23, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4"), "Intel 1700" },
                    { 28, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4"), "Yes" },
                    { 66, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4"), "Intel Z790" },
                    { 67, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4"), "4" },
                    { 68, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4"), "128 GB" },
                    { 69, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4"), "7000 MHz" },
                    { 70, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4"), "DDR5" },
                    { 71, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4"), "Yes" },
                    { 5, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49"), "White" },
                    { 28, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49"), "RGB" },
                    { 38, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49"), "12000 DPI" },
                    { 40, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49"), "2 m" },
                    { 47, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49"), "USB" },
                    { 59, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49"), "1 ms" },
                    { 75, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49"), "PixArt PMW3360" },
                    { 76, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49"), "Yes" },
                    { 77, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49"), "6" },
                    { 100, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49"), "68 g" },
                    { 1, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988"), "ATX" },
                    { 23, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988"), "Intel 1700" },
                    { 28, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988"), "No" },
                    { 66, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988"), "Intel H670" },
                    { 67, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988"), "4" },
                    { 68, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988"), "128 GB" },
                    { 69, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988"), "5066 MHz" },
                    { 70, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988"), "DDR4" },
                    { 71, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988"), "No" },
                    { 1, new Guid("689b3a84-261c-4512-904c-c7fed46365be"), "ATX" },
                    { 5, new Guid("689b3a84-261c-4512-904c-c7fed46365be"), "Black" },
                    { 22, new Guid("689b3a84-261c-4512-904c-c7fed46365be"), "Non-modular" },
                    { 28, new Guid("689b3a84-261c-4512-904c-c7fed46365be"), "No" },
                    { 78, new Guid("689b3a84-261c-4512-904c-c7fed46365be"), "650W" },
                    { 79, new Guid("689b3a84-261c-4512-904c-c7fed46365be"), "80+ Bronze" },
                    { 80, new Guid("689b3a84-261c-4512-904c-c7fed46365be"), "85 %" },
                    { 81, new Guid("689b3a84-261c-4512-904c-c7fed46365be"), "No" },
                    { 1, new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e"), "ATX" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 5, new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e"), "Black" },
                    { 22, new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e"), "Non-modular" },
                    { 28, new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e"), "No" },
                    { 78, new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e"), "500W" },
                    { 79, new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e"), "80+" },
                    { 80, new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e"), "85 %" },
                    { 81, new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e"), "No" },
                    { 5, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5"), "Black" },
                    { 55, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5"), "24 inch" },
                    { 56, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5"), "1920 x 1080" },
                    { 57, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5"), "VA" },
                    { 58, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5"), "165 Hz" },
                    { 59, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5"), "1 ms" },
                    { 60, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5"), "3.5mm Audio jack, HDMI, Display Port" },
                    { 61, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5"), "Yes" },
                    { 62, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5"), "No" },
                    { 63, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5"), "Yes" },
                    { 64, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5"), "250 cd/㎡" },
                    { 65, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5"), "FreeSync" },
                    { 1, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5"), "ATX" },
                    { 23, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5"), "Intel 1700" },
                    { 28, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5"), "Yes" },
                    { 66, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5"), "Intel Z790" },
                    { 67, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5"), "4" },
                    { 68, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5"), "128 GB" },
                    { 69, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5"), "6800 MHz" },
                    { 70, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5"), "DDR5" },
                    { 71, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5"), "No" },
                    { 5, new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d"), "Black" },
                    { 6, new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d"), "400 mm" },
                    { 7, new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d"), "460 mm" },
                    { 28, new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d"), "No" },
                    { 72, new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d"), "4 mm" },
                    { 73, new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d"), "Textile" },
                    { 74, new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d"), "Yes" },
                    { 1, new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536"), "ATX" },
                    { 5, new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536"), "Black" },
                    { 22, new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536"), "Modular" },
                    { 28, new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536"), "No" },
                    { 78, new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536"), "650W" },
                    { 79, new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536"), "80+ Gold" },
                    { 80, new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536"), "90 %" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 81, new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536"), "No" },
                    { 23, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be"), "АМ5" },
                    { 82, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be"), "8" },
                    { 83, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be"), "16" },
                    { 84, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be"), "3.8 GHz" },
                    { 85, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be"), "5.3 GHz" },
                    { 86, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be"), "32 MB" },
                    { 87, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be"), "Yes" },
                    { 88, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be"), "AMD Ryzen 7" },
                    { 89, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be"), "AMD 7th Gen" },
                    { 5, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6"), "Black" },
                    { 28, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6"), "RGB" },
                    { 38, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6"), "16000 DPI" },
                    { 40, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6"), "1.8 m" },
                    { 47, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6"), "USB" },
                    { 59, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6"), "1 ms" },
                    { 75, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6"), "PixArt 3389, Optical" },
                    { 76, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6"), "No" },
                    { 77, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6"), "6" },
                    { 100, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6"), "69 g" },
                    { 1, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134"), "2.5\"" },
                    { 22, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134"), "SSD" },
                    { 28, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134"), "No" },
                    { 32, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134"), "SATA III" },
                    { 42, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134"), "500 GB" },
                    { 43, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134"), "560 MB/s" },
                    { 44, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134"), "530 MB/s" },
                    { 45, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134"), "98 k" },
                    { 46, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134"), "88 k" },
                    { 5, new Guid("711b7764-c49d-4d92-9c03-2385ed109930"), "Black" },
                    { 22, new Guid("711b7764-c49d-4d92-9c03-2385ed109930"), "Stereo" },
                    { 31, new Guid("711b7764-c49d-4d92-9c03-2385ed109930"), "Over-ear" },
                    { 32, new Guid("711b7764-c49d-4d92-9c03-2385ed109930"), "3.5mm Audio jack" },
                    { 33, new Guid("711b7764-c49d-4d92-9c03-2385ed109930"), "Yes" },
                    { 34, new Guid("711b7764-c49d-4d92-9c03-2385ed109930"), "20 Hz - 20 kHz" },
                    { 35, new Guid("711b7764-c49d-4d92-9c03-2385ed109930"), "32 Ω" },
                    { 36, new Guid("711b7764-c49d-4d92-9c03-2385ed109930"), "No" },
                    { 37, new Guid("711b7764-c49d-4d92-9c03-2385ed109930"), "No" },
                    { 38, new Guid("711b7764-c49d-4d92-9c03-2385ed109930"), "111 dB" },
                    { 39, new Guid("711b7764-c49d-4d92-9c03-2385ed109930"), "Xbox, PC/Mac, PlayStation, Mobile, Nintendo Switch" },
                    { 41, new Guid("711b7764-c49d-4d92-9c03-2385ed109930"), "40 mm" },
                    { 23, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b"), "AM4" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 82, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b"), "6" },
                    { 83, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b"), "12" },
                    { 84, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b"), "3.6 GHz" },
                    { 85, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b"), "4.2 GHz" },
                    { 86, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b"), "19 MB" },
                    { 87, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b"), "Yes" },
                    { 88, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b"), "AMD Ryzen 5" },
                    { 89, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b"), "AMD 5th Gen" },
                    { 5, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad"), "Black" },
                    { 28, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad"), "RGB" },
                    { 38, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad"), "16000 DPI" },
                    { 40, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad"), "1.8 m" },
                    { 47, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad"), "USB" },
                    { 59, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad"), "1 ms" },
                    { 75, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad"), "PixArt 3389, Optical" },
                    { 76, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad"), "Yes" },
                    { 77, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad"), "6" },
                    { 100, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad"), "95 g" },
                    { 5, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2"), "Black" },
                    { 22, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2"), "DDR4" },
                    { 28, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2"), "Yes" },
                    { 42, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2"), "16 MHz" },
                    { 90, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2"), "3600 GB" },
                    { 91, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2"), "CL 18" },
                    { 92, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2"), "Desktop" },
                    { 93, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2"), "Yes" },
                    { 94, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2"), "from 2 memories" },
                    { 1, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b"), "ATX" },
                    { 23, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b"), "AMD AM4" },
                    { 28, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b"), "No" },
                    { 66, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b"), "AMD B550" },
                    { 67, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b"), "4" },
                    { 68, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b"), "128 GB" },
                    { 69, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b"), "4600 MHz" },
                    { 70, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b"), "DDR4" },
                    { 71, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b"), "No" },
                    { 5, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07"), "Black" },
                    { 55, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07"), "24 inch" },
                    { 56, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07"), "1920 x 1080" },
                    { 57, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07"), "TN" },
                    { 58, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07"), "75 Hz" },
                    { 59, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07"), "1 ms" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 60, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07"), "D-Sub (VGA), 3.5mm Audio jack, DVI, HDMI" },
                    { 61, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07"), "No" },
                    { 62, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07"), "No" },
                    { 63, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07"), "Yes" },
                    { 64, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07"), "250 cd/㎡" },
                    { 5, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66"), "Black" },
                    { 22, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66"), "Mechanical" },
                    { 28, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66"), "RGB" },
                    { 31, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66"), "TKL" },
                    { 47, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66"), "USB" },
                    { 48, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66"), "No" },
                    { 49, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66"), "High profile" },
                    { 50, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66"), "Yes" },
                    { 51, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66"), "US" },
                    { 52, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66"), "No" },
                    { 53, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66"), "Yes" },
                    { 54, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66"), "HyperX Blue" },
                    { 22, new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a"), "Watery" },
                    { 23, new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a"), "1150, 1151, 1155, 1156, 2011, 2066, AM2, AM2+, AM3, AM3+, FM1, FM2, FM2+, AM4, 2011-3, 1200" },
                    { 24, new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a"), "1800 RPM" },
                    { 25, new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a"), "30 dBA" },
                    { 26, new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a"), "120 x 25 mm x2" },
                    { 27, new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a"), "4-pin, 3-pin, 3-pin 5V ARGB" },
                    { 28, new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a"), "ARGB" },
                    { 29, new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a"), "47.2 CFM" },
                    { 1, new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6"), "M.2 2280" },
                    { 22, new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6"), "NVMe" },
                    { 28, new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6"), "No" },
                    { 32, new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6"), "PCIe Gen 3.0" },
                    { 42, new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6"), "1000 GB" },
                    { 43, new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6"), "2200 MB/s" },
                    { 44, new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6"), "1600 MB/s" },
                    { 5, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c"), "Black" },
                    { 55, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c"), "27 inch" },
                    { 56, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c"), "1920 x 1080" },
                    { 57, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c"), "IPS" },
                    { 58, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c"), "75 Hz" },
                    { 59, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c"), "5 ms" },
                    { 60, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c"), "D-Sub (VGA), HDMI" },
                    { 61, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c"), "No" },
                    { 62, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c"), "No" },
                    { 63, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c"), "Yes" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 64, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c"), "250 cd/㎡" },
                    { 65, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c"), "FreeSync" },
                    { 1, new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf"), "ATX" },
                    { 5, new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf"), "Black" },
                    { 22, new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf"), "Modular" },
                    { 28, new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf"), "No" },
                    { 78, new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf"), "850W" },
                    { 79, new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf"), "80+ Gold" },
                    { 80, new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf"), "87 %" },
                    { 81, new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf"), "No" },
                    { 1, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558"), "Micro ATX" },
                    { 23, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558"), "Intel 1200" },
                    { 28, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558"), "No" },
                    { 66, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558"), "Intel H410" },
                    { 67, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558"), "2" },
                    { 68, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558"), "64 GB" },
                    { 69, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558"), "2933 MHz" },
                    { 70, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558"), "DDR4" },
                    { 71, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558"), "No" },
                    { 1, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"), "Mid Tower" },
                    { 2, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"), "ATX, Micro ATX, Mini ITX" },
                    { 3, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"), "No" },
                    { 4, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"), "Audio In & Out, USB 3.2 Gen1, USB 3.2 (Gen 2) Type-C" },
                    { 5, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"), "Black" },
                    { 6, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"), "446 mm" },
                    { 7, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"), "285 mm" },
                    { 8, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"), "450 mm" },
                    { 9, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"), "163 mm" },
                    { 10, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"), "400 mm" },
                    { 12, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"), "1x 120mm" },
                    { 13, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"), "2x 140mm, 3x 120mm" },
                    { 15, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"), "1x 120mm" },
                    { 16, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"), "1x 240mm, 1x 120mm, 1x 140mm, 1x 280mm, 1x 360mm" },
                    { 17, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"), "No" },
                    { 1, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), "Mid Tower" },
                    { 2, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), "ATX, Micro ATX, Mini ITX" },
                    { 3, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), "4x 120mm" },
                    { 4, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), "Audio In & Out, USB 3.2 Gen1" },
                    { 5, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), "Black" },
                    { 6, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), "426 mm" },
                    { 7, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), "214 mm" },
                    { 8, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), "482 mm" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 9, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), "160 mm" },
                    { 10, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), "320 mm" },
                    { 11, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), "3x 120mm, 2x 140mm" },
                    { 12, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), "1x 120mm" },
                    { 13, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), "2x 120mm" },
                    { 14, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), "1x 280mm, 1x 120mm, 1x 240mm, 1x 360mm, 1x 140mm" },
                    { 15, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), "1x 120mm" },
                    { 17, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), "Yes" },
                    { 5, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383"), "Black, Grey" },
                    { 22, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383"), "DDR5" },
                    { 28, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383"), "Yes" },
                    { 42, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383"), "32 GB" },
                    { 90, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383"), "6000 MHz" },
                    { 91, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383"), "CL 32" },
                    { 92, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383"), "Desktop" },
                    { 93, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383"), "Yes" },
                    { 94, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383"), "No" },
                    { 8, new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f"), "158.5 mm" },
                    { 22, new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f"), "Aerial" },
                    { 23, new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f"), "1150, 1151, 1155, 1156, 1200, 1700" },
                    { 24, new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f"), "1800 RPM" },
                    { 25, new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f"), "23 dBA" },
                    { 26, new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f"), "120 x 25 mm" },
                    { 27, new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f"), "4-pin" },
                    { 28, new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f"), "No" },
                    { 88, new Guid("7e0cdafa-a356-4245-9b25-a8864857109b"), "RTX 4000 Series" },
                    { 90, new Guid("7e0cdafa-a356-4245-9b25-a8864857109b"), "2535 MHz" },
                    { 95, new Guid("7e0cdafa-a356-4245-9b25-a8864857109b"), "8 GB" },
                    { 96, new Guid("7e0cdafa-a356-4245-9b25-a8864857109b"), "3072 CUDA" },
                    { 97, new Guid("7e0cdafa-a356-4245-9b25-a8864857109b"), "128 bit" },
                    { 98, new Guid("7e0cdafa-a356-4245-9b25-a8864857109b"), "HDMI, DisplayPort" },
                    { 99, new Guid("7e0cdafa-a356-4245-9b25-a8864857109b"), "GDDR6" },
                    { 5, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0"), "Black" },
                    { 55, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0"), "26.5" },
                    { 56, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0"), "2560 x 1440" },
                    { 57, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0"), "OLED" },
                    { 58, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0"), "240 Hz" },
                    { 59, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0"), "0.03 ms" },
                    { 60, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0"), "3.5mm Audio jack, HDMI, Display Port, USB-A" },
                    { 61, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0"), "Yes" },
                    { 62, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0"), "No" },
                    { 63, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0"), "Yes" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 64, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0"), "450 cd/㎡" },
                    { 65, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0"), "G-Sync" },
                    { 5, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"), "Black" },
                    { 22, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"), "3D Audio" },
                    { 31, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"), "Over-ear" },
                    { 32, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"), "3.5mm Audio jack, USB" },
                    { 33, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"), "Yes" },
                    { 34, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"), "15 Hz - 25 kHz" },
                    { 35, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"), "60 Ω" },
                    { 36, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"), "No" },
                    { 37, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"), "No" },
                    { 38, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"), "98 dB" },
                    { 39, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"), "Xbox, PC/Mac, PlayStation, Mobile, Nintendo Switch" },
                    { 40, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"), "3 m" },
                    { 41, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"), "53 mm" },
                    { 5, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546"), "Black" },
                    { 22, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546"), "Mechanical" },
                    { 28, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546"), "RGB" },
                    { 31, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546"), "65%" },
                    { 47, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546"), "USB, Bluetooth" },
                    { 48, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546"), "No" },
                    { 49, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546"), "High profile" },
                    { 50, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546"), "Yes" },
                    { 51, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546"), "US" },
                    { 52, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546"), "No" },
                    { 53, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546"), "Yes" },
                    { 54, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546"), "Gateron G Pro Blue" },
                    { 22, new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60"), "Watery" },
                    { 23, new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60"), "1150, 1151, 1155, 1156, AM2, AM2+, AM3, AM3+, FM1, FM2, FM2+, AM4, 1200, 1700, AM5" },
                    { 24, new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60"), "1750 RPM" },
                    { 25, new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60"), "27.2 dBA" },
                    { 26, new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60"), "120 x 25mm x3" },
                    { 27, new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60"), "3-pin, 4-pin PWM, 3-pin 5V ARGB" },
                    { 28, new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60"), "ARGB" },
                    { 29, new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60"), "71.93 CFM" },
                    { 23, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed"), "LGA1200" },
                    { 82, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed"), "6" },
                    { 83, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed"), "12" },
                    { 84, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed"), "2.6 GHz" },
                    { 85, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed"), "4.4 GHz" },
                    { 86, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed"), "12 MB" },
                    { 87, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed"), "Yes" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 88, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed"), "Intel Core i5" },
                    { 89, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed"), "Intel 11th Gen" },
                    { 23, new Guid("87139a76-a325-4046-a973-e5dc072dc258"), "LGA1700" },
                    { 82, new Guid("87139a76-a325-4046-a973-e5dc072dc258"), "4" },
                    { 83, new Guid("87139a76-a325-4046-a973-e5dc072dc258"), "8" },
                    { 84, new Guid("87139a76-a325-4046-a973-e5dc072dc258"), "3.4 GHz" },
                    { 85, new Guid("87139a76-a325-4046-a973-e5dc072dc258"), "4.5 GHz" },
                    { 86, new Guid("87139a76-a325-4046-a973-e5dc072dc258"), "5 MB" },
                    { 87, new Guid("87139a76-a325-4046-a973-e5dc072dc258"), "Yes" },
                    { 88, new Guid("87139a76-a325-4046-a973-e5dc072dc258"), "Intel Core i3" },
                    { 89, new Guid("87139a76-a325-4046-a973-e5dc072dc258"), "Intel 13th Gen" },
                    { 1, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "Mid Tower" },
                    { 2, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "ATX, Micro ATX, Mini ITX" },
                    { 3, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "1x 120mm" },
                    { 4, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "USB 3.0, USB 2.0, Audio In & Out" },
                    { 5, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "Black" },
                    { 6, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "400 mm" },
                    { 7, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "200 mm" },
                    { 8, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "485 mm" },
                    { 9, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "165 mm" },
                    { 10, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "355 mm" },
                    { 11, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "3x 120mm, 3x 140mm" },
                    { 12, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "1x 120mm" },
                    { 13, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "2x 120mm, 2x 140mm" },
                    { 14, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "1x 280mm, 1x 360mm" },
                    { 15, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "1x 120mm" },
                    { 16, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "1x 240mm, 1x 280mm" },
                    { 17, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), "No" },
                    { 1, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd"), "ATX" },
                    { 23, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd"), "AMD AM4" },
                    { 28, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd"), "Yes" },
                    { 66, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd"), "AMD B550" },
                    { 67, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd"), "4" },
                    { 68, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd"), "128 GB" },
                    { 69, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd"), "4733 MHz" },
                    { 70, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd"), "DDR4" },
                    { 71, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd"), "No" },
                    { 88, new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d"), "RTX 3000 Series" },
                    { 90, new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d"), "1852 MHz" },
                    { 95, new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d"), "12 GB" },
                    { 96, new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d"), "3584 CUDA" },
                    { 97, new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d"), "192 bit" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 98, new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d"), "HDMI, DisplayPort" },
                    { 99, new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d"), "GDDR6" },
                    { 1, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044"), "ATX" },
                    { 23, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044"), "AMD AM5" },
                    { 28, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044"), "Yes" },
                    { 66, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044"), "AMD B650" },
                    { 67, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044"), "4" },
                    { 68, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044"), "128 GB" },
                    { 69, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044"), "6400 MHz" },
                    { 70, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044"), "DDR5" },
                    { 71, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044"), "Yes" },
                    { 5, new Guid("8d4089ec-9f65-450b-9f74-337390c86144"), "Black" },
                    { 55, new Guid("8d4089ec-9f65-450b-9f74-337390c86144"), "27 inch" },
                    { 56, new Guid("8d4089ec-9f65-450b-9f74-337390c86144"), "1920 x 1080" },
                    { 57, new Guid("8d4089ec-9f65-450b-9f74-337390c86144"), "IPS" },
                    { 58, new Guid("8d4089ec-9f65-450b-9f74-337390c86144"), "60 Hz" },
                    { 59, new Guid("8d4089ec-9f65-450b-9f74-337390c86144"), "6 ms" },
                    { 60, new Guid("8d4089ec-9f65-450b-9f74-337390c86144"), "D-Sub (VGA), 3.5mm Audio jack, DVI, HDMI, Display Port, USB-A" },
                    { 61, new Guid("8d4089ec-9f65-450b-9f74-337390c86144"), "Yes" },
                    { 62, new Guid("8d4089ec-9f65-450b-9f74-337390c86144"), "No" },
                    { 63, new Guid("8d4089ec-9f65-450b-9f74-337390c86144"), "Yes" },
                    { 64, new Guid("8d4089ec-9f65-450b-9f74-337390c86144"), "250 cd/㎡" },
                    { 1, new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9"), "M.2 2280" },
                    { 22, new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9"), "NVMe" },
                    { 28, new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9"), "No" },
                    { 32, new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9"), "PCIe Gen 4.0" },
                    { 42, new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9"), "250 GB" },
                    { 43, new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9"), "3300 MB/s" },
                    { 44, new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9"), "1300 MB/s" },
                    { 1, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"), "Mid Tower" },
                    { 2, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"), "ATX, Micro ATX, Mini ITX" },
                    { 3, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"), "1x 120mm" },
                    { 4, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"), "USB 3.0, USB 2.0, Audio In & Out" },
                    { 5, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"), "Black" },
                    { 6, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"), "400 mm" },
                    { 7, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"), "190 mm" },
                    { 8, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"), "430 mm" },
                    { 9, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"), "160 mm" },
                    { 10, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"), "310 mm" },
                    { 11, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"), "3x 120mm" },
                    { 12, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"), "1x 120mm" },
                    { 13, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"), "2x 120mm" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 14, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"), "1x 240mm" },
                    { 17, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"), "No" },
                    { 5, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02"), "Black" },
                    { 28, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02"), "No" },
                    { 38, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02"), "3200 DPI" },
                    { 40, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02"), "2 m" },
                    { 47, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02"), "USB" },
                    { 59, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02"), "1 ms" },
                    { 75, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02"), "PixArt PMW3360, Optical" },
                    { 76, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02"), "No" },
                    { 77, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02"), "5" },
                    { 100, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02"), "70 g" },
                    { 5, new Guid("91661960-9390-47c3-ab98-9b9e19269b02"), "Black, Blue" },
                    { 22, new Guid("91661960-9390-47c3-ab98-9b9e19269b02"), "7.1 Virtual surround" },
                    { 31, new Guid("91661960-9390-47c3-ab98-9b9e19269b02"), "Over-ear" },
                    { 32, new Guid("91661960-9390-47c3-ab98-9b9e19269b02"), "3.5mm Audio jack" },
                    { 33, new Guid("91661960-9390-47c3-ab98-9b9e19269b02"), "Yes" },
                    { 34, new Guid("91661960-9390-47c3-ab98-9b9e19269b02"), "20 Hz - 20 kHz" },
                    { 35, new Guid("91661960-9390-47c3-ab98-9b9e19269b02"), "32 Ω" },
                    { 36, new Guid("91661960-9390-47c3-ab98-9b9e19269b02"), "No" },
                    { 37, new Guid("91661960-9390-47c3-ab98-9b9e19269b02"), "No" },
                    { 39, new Guid("91661960-9390-47c3-ab98-9b9e19269b02"), "PC/Mac, Nintendo Switch, PlayStation 4, Xbox One, PlayStation 5, Xbox Series S/X" },
                    { 40, new Guid("91661960-9390-47c3-ab98-9b9e19269b02"), "1.3 m" },
                    { 41, new Guid("91661960-9390-47c3-ab98-9b9e19269b02"), "50 mm" },
                    { 5, new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2"), "White" },
                    { 6, new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2"), "280 mm" },
                    { 7, new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2"), "330 mm" },
                    { 28, new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2"), "No" },
                    { 72, new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2"), "2 mm" },
                    { 73, new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2"), "Textile" },
                    { 74, new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2"), "Yes" },
                    { 23, new Guid("92089877-a384-404f-b813-f02236406a7e"), "LGA1700" },
                    { 82, new Guid("92089877-a384-404f-b813-f02236406a7e"), "16" },
                    { 83, new Guid("92089877-a384-404f-b813-f02236406a7e"), "24" },
                    { 84, new Guid("92089877-a384-404f-b813-f02236406a7e"), "2.1 GHz" },
                    { 85, new Guid("92089877-a384-404f-b813-f02236406a7e"), "5.2 GHz" },
                    { 86, new Guid("92089877-a384-404f-b813-f02236406a7e"), "30 MB" },
                    { 87, new Guid("92089877-a384-404f-b813-f02236406a7e"), "Yes" },
                    { 88, new Guid("92089877-a384-404f-b813-f02236406a7e"), "Intel Core i7" },
                    { 89, new Guid("92089877-a384-404f-b813-f02236406a7e"), "Intel 13th Gen" },
                    { 5, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f"), "Blue" },
                    { 22, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f"), "Mechanical" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 28, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f"), "RGB" },
                    { 31, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f"), "60%" },
                    { 47, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f"), "USB" },
                    { 48, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f"), "No" },
                    { 49, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f"), "High profile" },
                    { 50, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f"), "No" },
                    { 51, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f"), "US" },
                    { 52, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f"), "No" },
                    { 53, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f"), "Yes" },
                    { 54, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f"), "Cherry MX Black" },
                    { 88, new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18"), "RX 7000 Series" },
                    { 90, new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18"), "2680 MHz" },
                    { 95, new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18"), "24 GB" },
                    { 96, new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18"), "6144 Stream" },
                    { 97, new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18"), "384 bit" },
                    { 98, new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18"), "HDMI, DisplayPort" },
                    { 99, new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18"), "GDDR6" },
                    { 5, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa"), "Black" },
                    { 28, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa"), "RGB" },
                    { 38, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa"), "12000 DPI" },
                    { 40, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa"), "2 m" },
                    { 47, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa"), "USB" },
                    { 59, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa"), "1 ms" },
                    { 75, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa"), "PixArt PMW3360, Optical" },
                    { 76, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa"), "Yes" },
                    { 77, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa"), "6" },
                    { 100, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa"), "68 g" },
                    { 88, new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19"), "RX 6000 Series" },
                    { 90, new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19"), "2044 MHz" },
                    { 95, new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19"), "8 GB" },
                    { 96, new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19"), "1792 Stream" },
                    { 97, new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19"), "128 bit" },
                    { 98, new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19"), "HDMI, DisplayPort" },
                    { 99, new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19"), "GDDR6" },
                    { 1, new Guid("9c847a36-b5be-465e-993e-472f1135de58"), "Mid Tower" },
                    { 2, new Guid("9c847a36-b5be-465e-993e-472f1135de58"), "ATX, Micro ATX, Mini ITX" },
                    { 3, new Guid("9c847a36-b5be-465e-993e-472f1135de58"), "2x 120mm" },
                    { 4, new Guid("9c847a36-b5be-465e-993e-472f1135de58"), "USB 3.0, Audio In & Out, USB 3.1 Gen 2 (Type-C)" },
                    { 5, new Guid("9c847a36-b5be-465e-993e-472f1135de58"), "White, Gray" },
                    { 6, new Guid("9c847a36-b5be-465e-993e-472f1135de58"), "453 mm" },
                    { 7, new Guid("9c847a36-b5be-465e-993e-472f1135de58"), "230 mm" },
                    { 8, new Guid("9c847a36-b5be-465e-993e-472f1135de58"), "466 mm" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 9, new Guid("9c847a36-b5be-465e-993e-472f1135de58"), "170 mm" },
                    { 10, new Guid("9c847a36-b5be-465e-993e-472f1135de58"), "360 mm" },
                    { 11, new Guid("9c847a36-b5be-465e-993e-472f1135de58"), "3x 120mm, 2x 140mm" },
                    { 12, new Guid("9c847a36-b5be-465e-993e-472f1135de58"), "1x 120mm" },
                    { 13, new Guid("9c847a36-b5be-465e-993e-472f1135de58"), "2x 120mm, 2x 140mm" },
                    { 14, new Guid("9c847a36-b5be-465e-993e-472f1135de58"), "1x 280mm, 1x 360mm" },
                    { 16, new Guid("9c847a36-b5be-465e-993e-472f1135de58"), "1x 240mm, 1x 280mm" },
                    { 17, new Guid("9c847a36-b5be-465e-993e-472f1135de58"), "Yes" },
                    { 5, new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539"), "Black" },
                    { 6, new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539"), "400 mm" },
                    { 7, new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539"), "900 mm" },
                    { 28, new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539"), "No" },
                    { 72, new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539"), "3 mm" },
                    { 73, new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539"), "Textile" },
                    { 74, new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539"), "Yes" },
                    { 5, new Guid("9d1fc184-5111-405f-bc08-686cf2086357"), "Black" },
                    { 55, new Guid("9d1fc184-5111-405f-bc08-686cf2086357"), "23.8 inch" },
                    { 56, new Guid("9d1fc184-5111-405f-bc08-686cf2086357"), "1920 x 1080" },
                    { 57, new Guid("9d1fc184-5111-405f-bc08-686cf2086357"), "IPS" },
                    { 58, new Guid("9d1fc184-5111-405f-bc08-686cf2086357"), "100 Hz" },
                    { 59, new Guid("9d1fc184-5111-405f-bc08-686cf2086357"), "1 ms" },
                    { 60, new Guid("9d1fc184-5111-405f-bc08-686cf2086357"), "3.5mm Audio jack, HDMI" },
                    { 61, new Guid("9d1fc184-5111-405f-bc08-686cf2086357"), "No" },
                    { 62, new Guid("9d1fc184-5111-405f-bc08-686cf2086357"), "No" },
                    { 63, new Guid("9d1fc184-5111-405f-bc08-686cf2086357"), "Yes" },
                    { 64, new Guid("9d1fc184-5111-405f-bc08-686cf2086357"), "300 cd/㎡" },
                    { 65, new Guid("9d1fc184-5111-405f-bc08-686cf2086357"), "FreeSync" },
                    { 5, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233"), "Black" },
                    { 55, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233"), "23.8 inch" },
                    { 56, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233"), "1920 x 1080" },
                    { 57, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233"), "IPS" },
                    { 58, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233"), "270 Hz" },
                    { 59, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233"), "1 ms" },
                    { 60, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233"), "3.5mm Audio jack, HDMI, Display Port, USB-A, USB-C" },
                    { 61, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233"), "Yes" },
                    { 62, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233"), "No" },
                    { 63, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233"), "Yes" },
                    { 64, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233"), "350 cd/㎡" },
                    { 1, new Guid("9df7c2cd-486d-481a-b047-6d55e9ffafa8"), "M.2 2280" },
                    { 22, new Guid("9df7c2cd-486d-481a-b047-6d55e9ffafa8"), "NVMe" },
                    { 32, new Guid("9df7c2cd-486d-481a-b047-6d55e9ffafa8"), "PCIe Gen 4.0" },
                    { 42, new Guid("9df7c2cd-486d-481a-b047-6d55e9ffafa8"), "500 GB" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 43, new Guid("9df7c2cd-486d-481a-b047-6d55e9ffafa8"), "5000 MB/s" },
                    { 44, new Guid("9df7c2cd-486d-481a-b047-6d55e9ffafa8"), "3800 MB/s" },
                    { 5, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7"), "Black" },
                    { 22, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7"), "DDR4" },
                    { 28, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7"), "Yes" },
                    { 42, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7"), "16 GB" },
                    { 90, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7"), "3200 MHz" },
                    { 91, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7"), "CL 16" },
                    { 92, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7"), "Desktop" },
                    { 93, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7"), "Yes" },
                    { 94, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7"), "from 2 memories" },
                    { 88, new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab"), "RTX 3000 Series" },
                    { 90, new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab"), "1710 MHz" },
                    { 95, new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab"), "8 GB" },
                    { 96, new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab"), "4864 CUDA" },
                    { 97, new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab"), "256 bit" },
                    { 98, new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab"), "HDMI, DisplayPort" },
                    { 99, new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab"), "GDDR6X" },
                    { 8, new Guid("a17622b2-2710-4c88-83a2-477d1292400c"), "154 mm" },
                    { 22, new Guid("a17622b2-2710-4c88-83a2-477d1292400c"), "Aerial" },
                    { 23, new Guid("a17622b2-2710-4c88-83a2-477d1292400c"), "1150, 1151, 1155, 1156, AM4, 1200, 1700, AM5" },
                    { 24, new Guid("a17622b2-2710-4c88-83a2-477d1292400c"), "2050 RPM" },
                    { 25, new Guid("a17622b2-2710-4c88-83a2-477d1292400c"), "27 dBA" },
                    { 26, new Guid("a17622b2-2710-4c88-83a2-477d1292400c"), "120 x 25 mm" },
                    { 27, new Guid("a17622b2-2710-4c88-83a2-477d1292400c"), "4-pin PWM, 3-pin 5V ARGB" },
                    { 28, new Guid("a17622b2-2710-4c88-83a2-477d1292400c"), "ARGB" },
                    { 29, new Guid("a17622b2-2710-4c88-83a2-477d1292400c"), "42 CFM" },
                    { 22, new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1"), "Watery" },
                    { 23, new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1"), "1150, 1151, 1155, 1156, 1366, 2011, 2066, AM2, AM3, AM4, sTRX4, 1200, 1700" },
                    { 24, new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1"), "2000 RPM" },
                    { 25, new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1"), "36 dBA" },
                    { 26, new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1"), "140 x 25 mm x2" },
                    { 27, new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1"), "3-pin, 4-pin PWM, SATA Power" },
                    { 28, new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1"), "RGB" },
                    { 29, new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1"), "97 CFM" },
                    { 1, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9"), "M.2 2280" },
                    { 22, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9"), "NVMe" },
                    { 28, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9"), "No" },
                    { 32, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9"), "PCIe Gen 4.0" },
                    { 42, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9"), "500 GB" },
                    { 43, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9"), "7300 MB/s" },
                    { 44, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9"), "3900 MB/s" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 45, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9"), "450 k" },
                    { 46, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9"), "900 k" },
                    { 5, new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3"), "WarCraft" },
                    { 6, new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3"), "420 mm" },
                    { 7, new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3"), "900 mm" },
                    { 28, new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3"), "No" },
                    { 72, new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3"), "4 mm" },
                    { 73, new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3"), "Textile" },
                    { 74, new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3"), "Yes" },
                    { 1, new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372"), "ATX" },
                    { 5, new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372"), "White" },
                    { 22, new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372"), "Modular" },
                    { 28, new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372"), "No" },
                    { 78, new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372"), "850W" },
                    { 79, new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372"), "80+ Gold" },
                    { 80, new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372"), "90 %" },
                    { 81, new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372"), "No" },
                    { 22, new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb"), "Watery" },
                    { 23, new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb"), "1150, 1151, 1155, 1156, 1366, 2011, 2066, AM4, 2011-3, 1200, 1700" },
                    { 24, new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb"), "1800 RPM" },
                    { 25, new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb"), "23 dBA" },
                    { 26, new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb"), "120 x 25 mm x2" },
                    { 27, new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb"), "4-pin PWM, 3-pin 5V ARGB" },
                    { 28, new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb"), "ARGB" },
                    { 29, new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb"), "48.8 CFM" },
                    { 5, new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf"), "Black" },
                    { 6, new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf"), "250 mm" },
                    { 7, new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf"), "350 mm" },
                    { 28, new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf"), "Yes" },
                    { 72, new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf"), "3 mm" },
                    { 73, new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf"), "Textile" },
                    { 74, new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf"), "No" },
                    { 5, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378"), "Gold" },
                    { 22, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378"), "DDR4" },
                    { 28, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378"), "Yes" },
                    { 42, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378"), "16 GB" },
                    { 90, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378"), "4000 MHz" },
                    { 91, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378"), "CL 16" },
                    { 92, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378"), "Desktop" },
                    { 93, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378"), "Yes" },
                    { 94, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378"), "from 2 memories" },
                    { 5, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05"), "Black" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 22, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05"), "Optical" },
                    { 28, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05"), "RGB" },
                    { 31, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05"), "60%" },
                    { 47, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05"), "USB" },
                    { 48, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05"), "No" },
                    { 49, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05"), "High profile" },
                    { 50, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05"), "No" },
                    { 51, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05"), "US" },
                    { 52, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05"), "No" },
                    { 53, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05"), "Yes" },
                    { 54, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05"), "SteelSeries Linear OptiPoint" },
                    { 22, new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f"), "Watery" },
                    { 23, new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f"), "1150, 1151, 1155, 1156, 1366, 2011, 2066, AM4, 2011-3, TR4, 1200" },
                    { 24, new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f"), "2000 RPM" },
                    { 25, new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f"), "29.7 dBA" },
                    { 26, new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f"), "120 x 25 mm x3" },
                    { 27, new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f"), "4-pin, USB Header, 4-pin PWM, SATA Power" },
                    { 28, new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f"), "No" },
                    { 29, new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f"), "71.6 CFM" },
                    { 88, new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4"), "RTX 4000 Series" },
                    { 90, new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4"), "2490 MHz" },
                    { 95, new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4"), "12 GB" },
                    { 96, new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4"), "5888 CUDA" },
                    { 97, new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4"), "192 bit" },
                    { 98, new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4"), "HDMI, DisplayPort" },
                    { 99, new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4"), "GDDR6X" },
                    { 5, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75"), "Grey" },
                    { 22, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75"), "DDR4" },
                    { 28, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75"), "No" },
                    { 42, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75"), "8 GB" },
                    { 90, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75"), "3200 MHz" },
                    { 91, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75"), "CL 16" },
                    { 92, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75"), "Desktop" },
                    { 93, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75"), "Yes" },
                    { 94, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75"), "No" },
                    { 1, new Guid("b1261055-dac3-4233-9f36-b85208472b24"), "M.2 2280" },
                    { 22, new Guid("b1261055-dac3-4233-9f36-b85208472b24"), "NVMe" },
                    { 28, new Guid("b1261055-dac3-4233-9f36-b85208472b24"), "No" },
                    { 32, new Guid("b1261055-dac3-4233-9f36-b85208472b24"), "PCIe Gen 4.0" },
                    { 42, new Guid("b1261055-dac3-4233-9f36-b85208472b24"), "1000 GB" },
                    { 43, new Guid("b1261055-dac3-4233-9f36-b85208472b24"), "7000 MB/s" },
                    { 44, new Guid("b1261055-dac3-4233-9f36-b85208472b24"), "5000 MB/s" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 45, new Guid("b1261055-dac3-4233-9f36-b85208472b24"), "690 k" },
                    { 46, new Guid("b1261055-dac3-4233-9f36-b85208472b24"), "660 k" },
                    { 1, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3"), "Micro ATX" },
                    { 23, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3"), "Intel 1700" },
                    { 28, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3"), "No" },
                    { 66, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3"), "Intel B760" },
                    { 67, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3"), "2" },
                    { 68, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3"), "64 GB" },
                    { 69, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3"), "5333 MHz" },
                    { 70, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3"), "DDR4" },
                    { 71, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3"), "No" },
                    { 5, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8"), "Black" },
                    { 22, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8"), "DDR5" },
                    { 28, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8"), "No" },
                    { 42, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8"), "8 GB" },
                    { 90, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8"), "4800 MHz" },
                    { 91, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8"), "CL 40" },
                    { 92, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8"), "Desktop" },
                    { 93, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8"), "No" },
                    { 94, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8"), "No" },
                    { 5, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9"), "Silver" },
                    { 22, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9"), "DDR4" },
                    { 28, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9"), "Yes" },
                    { 42, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9"), "32 GB" },
                    { 90, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9"), "4000 MHz" },
                    { 91, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9"), "CL 16" },
                    { 92, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9"), "Desktop" },
                    { 93, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9"), "Yes" },
                    { 94, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9"), "from 2 memories" },
                    { 88, new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38"), "RX 7000 Series" },
                    { 90, new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38"), "2395 MHz" },
                    { 95, new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38"), "24 GB" },
                    { 96, new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38"), "6144 Stream" },
                    { 97, new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38"), "384 bit" },
                    { 98, new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38"), "HDMI, DisplayPort" },
                    { 99, new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38"), "GDDR6" },
                    { 1, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867"), "Micro ATX" },
                    { 23, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867"), "AMD AM4" },
                    { 28, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867"), "No" },
                    { 66, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867"), "AMD A520" },
                    { 67, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867"), "2" },
                    { 68, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867"), "64 GB" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 69, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867"), "5100 MHz" },
                    { 70, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867"), "DDR4" },
                    { 71, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867"), "No" },
                    { 1, new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524"), "ATX" },
                    { 5, new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524"), "Black" },
                    { 22, new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524"), "Modular" },
                    { 28, new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524"), "No" },
                    { 78, new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524"), "1200W" },
                    { 79, new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524"), "80+ Platinum" },
                    { 80, new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524"), "92 %" },
                    { 81, new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524"), "No" },
                    { 5, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1"), "Black" },
                    { 22, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1"), "Stereo" },
                    { 31, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1"), "Over-ear" },
                    { 32, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1"), "3.5mm Audio jack, USB-C" },
                    { 33, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1"), "Yes" },
                    { 34, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1"), "20 Hz - 20 kHz" },
                    { 36, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1"), "No" },
                    { 37, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1"), "No" },
                    { 39, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1"), "PC" },
                    { 41, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1"), "50 mm" },
                    { 5, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18"), "White" },
                    { 28, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18"), "No" },
                    { 38, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18"), "12000 DPI" },
                    { 47, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18"), "Wireless" },
                    { 59, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18"), "1 ms" },
                    { 75, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18"), "Hero, Optical" },
                    { 76, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18"), "Yes" },
                    { 77, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18"), "6" },
                    { 100, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18"), "99 g" },
                    { 23, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe"), "LGA1200" },
                    { 82, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe"), "4" },
                    { 83, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe"), "8" },
                    { 84, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe"), "3.6 GHz" },
                    { 85, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe"), "4.3 GHz" },
                    { 86, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe"), "6 MB" },
                    { 87, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe"), "Yes" },
                    { 88, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe"), "Intel Core i3" },
                    { 89, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe"), "Intel 10th Gen" },
                    { 5, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a"), "Black" },
                    { 55, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a"), "27 inch" },
                    { 56, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a"), "2560 x 1440" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 57, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a"), "IPS" },
                    { 58, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a"), "60 Hz" },
                    { 59, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a"), "5 ms" },
                    { 60, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a"), "3.5mm Audio jack, DVI, HDMI, Display Port, USB-A, Mini Display Port" },
                    { 61, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a"), "Yes" },
                    { 62, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a"), "No" },
                    { 63, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a"), "Yes" },
                    { 64, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a"), "300 cd/㎡" },
                    { 22, new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434"), "Watery" },
                    { 23, new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434"), "1150, 1151, 1155, 1156, 2011, 2066, AM4, 2011-3, TR4, 1200, 1700" },
                    { 24, new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434"), "2500 RPM" },
                    { 25, new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434"), "29 dBA" },
                    { 26, new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434"), "120 x 25 mm x2" },
                    { 27, new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434"), "4-pin, 4-pin PWM, 3-pin 5V ARGB" },
                    { 28, new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434"), "ARGB" },
                    { 29, new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434"), "67 CFM" },
                    { 5, new Guid("c092adb2-47c6-4360-9d70-1411e0278747"), "Black" },
                    { 22, new Guid("c092adb2-47c6-4360-9d70-1411e0278747"), "Mechanical" },
                    { 28, new Guid("c092adb2-47c6-4360-9d70-1411e0278747"), "RGB" },
                    { 31, new Guid("c092adb2-47c6-4360-9d70-1411e0278747"), "60%" },
                    { 47, new Guid("c092adb2-47c6-4360-9d70-1411e0278747"), "USB" },
                    { 48, new Guid("c092adb2-47c6-4360-9d70-1411e0278747"), "No" },
                    { 49, new Guid("c092adb2-47c6-4360-9d70-1411e0278747"), "High profile" },
                    { 50, new Guid("c092adb2-47c6-4360-9d70-1411e0278747"), "No" },
                    { 51, new Guid("c092adb2-47c6-4360-9d70-1411e0278747"), "US" },
                    { 52, new Guid("c092adb2-47c6-4360-9d70-1411e0278747"), "No" },
                    { 53, new Guid("c092adb2-47c6-4360-9d70-1411e0278747"), "Yes" },
                    { 54, new Guid("c092adb2-47c6-4360-9d70-1411e0278747"), "HyperX Aqua" },
                    { 88, new Guid("c096f9aa-448f-42ec-894a-875688f16264"), "RX 6000 Series" },
                    { 90, new Guid("c096f9aa-448f-42ec-894a-875688f16264"), "2116 MHz" },
                    { 95, new Guid("c096f9aa-448f-42ec-894a-875688f16264"), "16 GB" },
                    { 96, new Guid("c096f9aa-448f-42ec-894a-875688f16264"), "5120 Stream" },
                    { 97, new Guid("c096f9aa-448f-42ec-894a-875688f16264"), "256 bit" },
                    { 98, new Guid("c096f9aa-448f-42ec-894a-875688f16264"), "HDMI, DisplayPort" },
                    { 99, new Guid("c096f9aa-448f-42ec-894a-875688f16264"), "GDDR6" },
                    { 5, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"), "Black" },
                    { 22, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"), "Stereo, 3D Audio" },
                    { 31, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"), "Over-ear" },
                    { 32, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"), "Bluetooth, Wireless" },
                    { 33, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"), "Yes" },
                    { 34, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"), "20 Hz - 20 kHz" },
                    { 35, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"), "32 Ω" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 36, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"), "No" },
                    { 37, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"), "Yes" },
                    { 38, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"), "111 dB" },
                    { 39, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"), "PC" },
                    { 40, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"), "1.2 m" },
                    { 41, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"), "50 mm" },
                    { 5, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2"), "Black" },
                    { 22, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2"), "Mechanical" },
                    { 28, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2"), "RGB" },
                    { 31, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2"), "Full Size" },
                    { 47, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2"), "USB" },
                    { 48, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2"), "No" },
                    { 49, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2"), "Low profile" },
                    { 50, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2"), "Yes" },
                    { 51, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2"), "US" },
                    { 52, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2"), "No" },
                    { 53, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2"), "Yes" },
                    { 54, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2"), "GL Clicky" },
                    { 88, new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9"), "RTX 4000 Series" },
                    { 90, new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9"), "2550 MHz" },
                    { 95, new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9"), "8 GB" },
                    { 96, new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9"), "3072 CUDA" },
                    { 97, new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9"), "128 bit" },
                    { 98, new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9"), "HDMI, DisplayPort" },
                    { 99, new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9"), "GDDR6" },
                    { 88, new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc"), "RX 6000 Series" },
                    { 90, new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc"), "2044 MHz" },
                    { 95, new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc"), "8 GB" },
                    { 96, new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc"), "1792 Stream" },
                    { 97, new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc"), "128 bit" },
                    { 98, new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc"), "HDMI, DisplayPort" },
                    { 99, new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc"), "GDDR6" },
                    { 88, new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f"), "RX 7000 Series" },
                    { 90, new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f"), "2130 MHz" },
                    { 95, new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f"), "20 GB" },
                    { 96, new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f"), "5376 Stream" },
                    { 97, new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f"), "320 bit" },
                    { 98, new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f"), "HDMI, DisplayPort" },
                    { 99, new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f"), "GDDR6" },
                    { 5, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d"), "White" },
                    { 22, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d"), "DDR4" },
                    { 28, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d"), "No" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 42, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d"), "16 GB" },
                    { 90, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d"), "3200 MHz" },
                    { 91, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d"), "CL 16" },
                    { 92, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d"), "Desktop" },
                    { 93, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d"), "Yes" },
                    { 94, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d"), "from 2 memories" },
                    { 1, new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0"), "ATX" },
                    { 5, new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0"), "White" },
                    { 22, new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0"), "Modular" },
                    { 28, new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0"), "No" },
                    { 78, new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0"), "850W" },
                    { 79, new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0"), "80+ Gold" },
                    { 80, new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0"), "85 %" },
                    { 81, new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0"), "No" },
                    { 5, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"), "White" },
                    { 22, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"), "Stereo" },
                    { 31, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"), "Over-ear" },
                    { 32, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"), "3.5mm Audio jack" },
                    { 33, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"), "Yes" },
                    { 34, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"), "20 Hz - 20 kHz" },
                    { 35, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"), "32 Ω" },
                    { 36, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"), "No" },
                    { 37, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"), "No" },
                    { 38, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"), "96 Db" },
                    { 39, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"), "Mobile, PC, PlayStation 4, Xbox One" },
                    { 40, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"), "1.2 m" },
                    { 41, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"), "40 mm" },
                    { 5, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb"), "White" },
                    { 22, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb"), "7.1 Virtual surround" },
                    { 31, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb"), "Over-ear" },
                    { 32, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb"), "Wireless" },
                    { 33, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb"), "Yes" },
                    { 34, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb"), "20 Hz - 20 kHz" },
                    { 35, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb"), "39 Ω" },
                    { 36, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb"), "No" },
                    { 37, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb"), "No" },
                    { 38, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb"), "87.5 dB" },
                    { 39, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb"), "PC, PlayStation 4" },
                    { 41, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb"), "40 mm" },
                    { 5, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c"), "Black" },
                    { 55, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c"), "27 inch" },
                    { 56, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c"), "1920 x 1080" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 57, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c"), "TN" },
                    { 58, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c"), "240 Hz" },
                    { 59, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c"), "0.5 ms" },
                    { 60, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c"), "3.5mm Audio jack, HDMI, Display Port" },
                    { 61, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c"), "Yes" },
                    { 62, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c"), "No" },
                    { 63, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c"), "Yes" },
                    { 64, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c"), "320 cd/㎡" },
                    { 1, new Guid("cdf75419-d5f9-4119-beba-9765a822918d"), "ATX" },
                    { 5, new Guid("cdf75419-d5f9-4119-beba-9765a822918d"), "Black" },
                    { 22, new Guid("cdf75419-d5f9-4119-beba-9765a822918d"), "Modular" },
                    { 28, new Guid("cdf75419-d5f9-4119-beba-9765a822918d"), "No" },
                    { 78, new Guid("cdf75419-d5f9-4119-beba-9765a822918d"), "1600W" },
                    { 79, new Guid("cdf75419-d5f9-4119-beba-9765a822918d"), "80+ Titanium" },
                    { 80, new Guid("cdf75419-d5f9-4119-beba-9765a822918d"), "94 %" },
                    { 81, new Guid("cdf75419-d5f9-4119-beba-9765a822918d"), "Ready (with adapter)" },
                    { 5, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba"), "Black" },
                    { 28, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba"), "RGB" },
                    { 38, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba"), "16000 DPI" },
                    { 40, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba"), "1.8 m" },
                    { 47, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba"), "USB" },
                    { 59, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba"), "1 ms" },
                    { 75, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba"), "Optical" },
                    { 76, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba"), "Yes" },
                    { 77, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba"), "6" },
                    { 100, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba"), "48 g" },
                    { 5, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b"), "Black" },
                    { 22, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b"), "DDR4" },
                    { 28, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b"), "No" },
                    { 42, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b"), "16 GB" },
                    { 90, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b"), "3200 MHz" },
                    { 91, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b"), "CL 22" },
                    { 92, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b"), "Desktop" },
                    { 93, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b"), "No" },
                    { 94, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b"), "from 2 memories" },
                    { 5, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b"), "Black" },
                    { 22, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b"), "Semimechanical" },
                    { 28, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b"), "RGB" },
                    { 31, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b"), "Full Size" },
                    { 47, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b"), "USB" },
                    { 48, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b"), "No" },
                    { 49, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b"), "High profile" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 50, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b"), "No" },
                    { 51, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b"), "UK" },
                    { 52, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b"), "No" },
                    { 53, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b"), "Yes" },
                    { 54, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b"), "Mem-chanical" },
                    { 5, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"), "Black" },
                    { 22, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"), "Stereo" },
                    { 31, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"), "Over-ear" },
                    { 32, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"), "3.5mm Audio jack, USB, USB-C" },
                    { 33, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"), "Yes" },
                    { 34, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"), "10 Hz - 40 kHz" },
                    { 35, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"), "38 Ω" },
                    { 36, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"), "No" },
                    { 37, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"), "No" },
                    { 38, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"), "93 dB" },
                    { 39, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"), "PC/Mac, Nintendo Switch, PlayStation 4, PlayStation 5" },
                    { 40, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"), "1.2 m" },
                    { 41, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"), "40 mm" },
                    { 1, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6"), "M.2 2280" },
                    { 22, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6"), "NVMe" },
                    { 28, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6"), "No" },
                    { 32, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6"), "PCIe Gen 4.0" },
                    { 42, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6"), "4096 GB" },
                    { 43, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6"), "7000 MB/s" },
                    { 44, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6"), "7000 MB/s" },
                    { 45, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6"), "1000 k" },
                    { 46, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6"), "1000 k" },
                    { 5, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899"), "Black" },
                    { 22, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899"), "DDR4" },
                    { 28, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899"), "Yes" },
                    { 42, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899"), "16 GB" },
                    { 90, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899"), "3600 MHz" },
                    { 91, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899"), "CL 18" },
                    { 92, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899"), "Desktop" },
                    { 93, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899"), "Yes" },
                    { 94, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899"), "No" },
                    { 5, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e"), "Black" },
                    { 22, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e"), "DDR4" },
                    { 28, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e"), "Yes" },
                    { 42, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e"), "16 GB" },
                    { 90, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e"), "3733 MHz" },
                    { 91, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e"), "CL 18" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 92, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e"), "Desktop" },
                    { 93, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e"), "Yes" },
                    { 94, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e"), "from 2 memories" },
                    { 1, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d"), "ATX" },
                    { 23, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d"), "AMD AM4" },
                    { 28, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d"), "Yes" },
                    { 66, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d"), "AMD X570" },
                    { 67, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d"), "4" },
                    { 68, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d"), "128 GB" },
                    { 69, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d"), "4400 MHz" },
                    { 70, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d"), "DDR4" },
                    { 71, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d"), "No" },
                    { 5, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9"), "Black" },
                    { 55, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9"), "31.5 inch" },
                    { 56, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9"), "2560 x 1440" },
                    { 57, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9"), "VA" },
                    { 58, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9"), "165 Hz" },
                    { 59, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9"), "1 ms" },
                    { 60, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9"), "3.5mm Audio jack, HDMI, Display Port" },
                    { 61, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9"), "Yes" },
                    { 62, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9"), "No" },
                    { 63, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9"), "Yes" },
                    { 64, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9"), "550 cd/㎡" },
                    { 65, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9"), "FreeSync" },
                    { 5, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d"), "White" },
                    { 22, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d"), "DDR4" },
                    { 28, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d"), "Yes" },
                    { 42, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d"), "32 GB" },
                    { 90, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d"), "3600 MHz" },
                    { 91, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d"), "CL 18" },
                    { 92, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d"), "Desktop" },
                    { 93, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d"), "Yes" },
                    { 94, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d"), "from 2 memories" },
                    { 5, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c"), "Black" },
                    { 22, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c"), "Mechanical" },
                    { 28, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c"), "RGB" },
                    { 31, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c"), "Full Size" },
                    { 47, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c"), "USB" },
                    { 48, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c"), "No" },
                    { 49, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c"), "High profile" },
                    { 50, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c"), "Yes" },
                    { 51, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c"), "US" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 52, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c"), "No" },
                    { 53, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c"), "Yes" },
                    { 54, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c"), "Cherry MX Red" },
                    { 1, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976"), "Micro ATX" },
                    { 23, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976"), "AMD AM5" },
                    { 28, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976"), "No" },
                    { 66, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976"), "AMD B650" },
                    { 67, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976"), "4" },
                    { 68, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976"), "128 GB" },
                    { 69, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976"), "6400 MHz" },
                    { 70, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976"), "DDR5" },
                    { 71, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976"), "No" },
                    { 5, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4"), "White" },
                    { 22, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4"), "Stereo" },
                    { 31, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4"), "Over-ear" },
                    { 32, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4"), "3.5mm Audio jack" },
                    { 33, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4"), "Yes" },
                    { 34, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4"), "20 Hz - 20 kHz" },
                    { 35, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4"), "32 Ω" },
                    { 36, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4"), "No" },
                    { 37, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4"), "No" },
                    { 39, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4"), "PlayStation 5" },
                    { 23, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1"), "AM4" },
                    { 82, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1"), "8" },
                    { 83, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1"), "16" },
                    { 84, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1"), "3.8 GHz" },
                    { 85, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1"), "4.6 GHz" },
                    { 86, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1"), "20 MB" },
                    { 87, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1"), "Yes" },
                    { 88, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1"), "AMD Ryzen 7" },
                    { 89, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1"), "AMD 5th Gen" },
                    { 5, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b"), "Camouflage" },
                    { 22, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b"), "Stereo" },
                    { 31, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b"), "Over-ear" },
                    { 32, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b"), "Wireless" },
                    { 33, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b"), "Yes" },
                    { 34, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b"), "20 Hz - 20 kHz" },
                    { 35, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b"), "32 Ω" },
                    { 36, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b"), "No" },
                    { 37, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b"), "No" },
                    { 38, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b"), "111 dB" },
                    { 39, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b"), "PlayStation 4" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 41, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b"), "40 mm" },
                    { 5, new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625"), "League of Legends" },
                    { 6, new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625"), "420 mm" },
                    { 7, new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625"), "900 mm" },
                    { 28, new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625"), "No" },
                    { 72, new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625"), "3 mm" },
                    { 73, new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625"), "Textile" },
                    { 74, new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625"), "Yes" },
                    { 1, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac"), "ATX" },
                    { 23, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac"), "AMD AM4" },
                    { 28, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac"), "Yes" },
                    { 66, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac"), "AMD B450" },
                    { 67, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac"), "4" },
                    { 68, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac"), "64 GB" },
                    { 69, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac"), "3533 MHz" },
                    { 70, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac"), "DDR4" },
                    { 71, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac"), "No" },
                    { 1, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b"), "2.5\"" },
                    { 22, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b"), "SSD" },
                    { 28, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b"), "No" },
                    { 32, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b"), "SATA III" },
                    { 42, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b"), "512 GB" },
                    { 43, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b"), "550 MB/s" },
                    { 44, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b"), "520 MB/s" },
                    { 45, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b"), "90 k" },
                    { 46, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b"), "80 k" },
                    { 88, new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d"), "RX 6000 Series" },
                    { 90, new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d"), "2424 MHz" },
                    { 95, new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d"), "12 GB" },
                    { 96, new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d"), "2560 Stream" },
                    { 97, new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d"), "192 bit" },
                    { 98, new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d"), "HDMI, DisplayPort" },
                    { 99, new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d"), "GDDR6" },
                    { 88, new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104"), "RTX 3000 Series" },
                    { 90, new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104"), "1777 MHz" },
                    { 95, new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104"), "8 GB" },
                    { 96, new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104"), "2560 CUDA" },
                    { 97, new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104"), "128 bit" },
                    { 98, new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104"), "HDMI, DisplayPort" },
                    { 99, new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104"), "GDDR6" },
                    { 23, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761"), "LGA1700" },
                    { 82, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761"), "16" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 83, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761"), "24" },
                    { 84, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761"), "3 GHz" },
                    { 85, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761"), "5.2 GHz" },
                    { 86, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761"), "30 MB" },
                    { 87, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761"), "No" },
                    { 88, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761"), "Intel Core i9" },
                    { 89, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761"), "Intel 12th Gen" },
                    { 5, new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6"), "Black" },
                    { 6, new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6"), "315 mm" },
                    { 7, new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6"), "355 mm" },
                    { 28, new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6"), "No" },
                    { 72, new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6"), "3.5 mm" },
                    { 73, new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6"), "Textile" },
                    { 74, new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6"), "Yes" },
                    { 1, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "Mid Tower" },
                    { 2, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "ATX, Micro ATX, Mini ITX" },
                    { 3, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "2x 120mm" },
                    { 4, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "SB 3.0, Audio In & Out, USB 3.1 Gen 2 (Type-C)" },
                    { 5, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "Black" },
                    { 6, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "520 mm" },
                    { 7, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "245 mm" },
                    { 8, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "520 mm" },
                    { 9, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "170 mm" },
                    { 10, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "400 mm" },
                    { 11, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "3x 120mm, 2x 140mm" },
                    { 12, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "1x 120mm" },
                    { 13, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "2x 140mm, 3x 120mm" },
                    { 14, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "1x 360mm" },
                    { 15, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "1x 120mm" },
                    { 16, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "1x 280mm, 1x 360mm" },
                    { 17, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "Yes" },
                    { 18, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "3x 120mm" },
                    { 19, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), "1x 280mm, 1x 360mm" },
                    { 1, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260"), "ATX" },
                    { 23, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260"), "Intel 1200" },
                    { 28, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260"), "No" },
                    { 66, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260"), "Intel Z590" },
                    { 67, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260"), "4" },
                    { 68, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260"), "128 GB" },
                    { 69, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260"), "5333 MHz" },
                    { 70, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260"), "DDR4" },
                    { 71, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260"), "No" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 5, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4"), "Black" },
                    { 55, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4"), "31.5 inch" },
                    { 56, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4"), "1920 x 1080" },
                    { 57, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4"), "IPS" },
                    { 58, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4"), "75 Hz" },
                    { 59, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4"), "5 ms" },
                    { 60, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4"), "D-Sub (VGA), 3.5mm Audio jack, HDMI, Display Port" },
                    { 61, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4"), "No" },
                    { 62, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4"), "No" },
                    { 63, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4"), "Yes" },
                    { 64, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4"), "300 cd/㎡" },
                    { 65, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4"), "FreeSync" },
                    { 1, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "Mini Tower" },
                    { 2, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "Micro ATX, Mini ITX" },
                    { 3, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "2x 120mm" },
                    { 4, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "USB 3.0, Audio In & Out, USB 3.2 Gen1, ARGB Controller" },
                    { 5, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "Black" },
                    { 6, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "446 mm" },
                    { 7, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "204 mm" },
                    { 8, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "425 mm" },
                    { 9, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "163.5 mm" },
                    { 10, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "365 mm" },
                    { 11, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "3x 120mm" },
                    { 12, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "1x 120mm" },
                    { 13, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "2x 120mm, 2x 140mm" },
                    { 14, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "1x 120mm, 1x 240mm" },
                    { 15, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "1x 120mm" },
                    { 16, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "1x 240mm, 1x 120mm, 1x 140mm, 1x 280mm" },
                    { 17, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), "Yes" },
                    { 5, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2"), "Black" },
                    { 22, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2"), "Membrane" },
                    { 28, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2"), "RGB" },
                    { 31, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2"), "TKL" },
                    { 47, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2"), "USB" },
                    { 48, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2"), "Yes" },
                    { 49, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2"), "High profile" },
                    { 50, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2"), "No" },
                    { 51, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2"), "US" },
                    { 52, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2"), "No" },
                    { 53, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2"), "Yes" },
                    { 22, new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70"), "Watery" },
                    { 23, new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70"), "1150, 1151, 1155, 1156, AM4, 1200, 1700, AM5" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 24, new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70"), "2000 RPM" },
                    { 25, new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70"), "29.7 dBA" },
                    { 26, new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70"), "120 x 25 mm x3" },
                    { 27, new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70"), "4-pin, USB Header, 3-pin 5V ARGB" },
                    { 28, new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70"), "No" },
                    { 29, new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70"), "71.6 CFM" },
                    { 5, new Guid("f9fadd8c-666a-40da-8058-3461e7580906"), "Black" },
                    { 22, new Guid("f9fadd8c-666a-40da-8058-3461e7580906"), "Stereo" },
                    { 31, new Guid("f9fadd8c-666a-40da-8058-3461e7580906"), "Over-ear" },
                    { 32, new Guid("f9fadd8c-666a-40da-8058-3461e7580906"), "3.5mm Audio jack, 2x3.5mm Audio jack" },
                    { 33, new Guid("f9fadd8c-666a-40da-8058-3461e7580906"), "Yes" },
                    { 34, new Guid("f9fadd8c-666a-40da-8058-3461e7580906"), "20 Hz - 20 kHz" },
                    { 35, new Guid("f9fadd8c-666a-40da-8058-3461e7580906"), "36 Ω" },
                    { 36, new Guid("f9fadd8c-666a-40da-8058-3461e7580906"), "No" },
                    { 37, new Guid("f9fadd8c-666a-40da-8058-3461e7580906"), "No" },
                    { 38, new Guid("f9fadd8c-666a-40da-8058-3461e7580906"), "87.5 dB" },
                    { 39, new Guid("f9fadd8c-666a-40da-8058-3461e7580906"), "Xbox, PlayStation, Mobile, Nintendo Switch, PC" },
                    { 40, new Guid("f9fadd8c-666a-40da-8058-3461e7580906"), "2 m" },
                    { 41, new Guid("f9fadd8c-666a-40da-8058-3461e7580906"), "40 mm" },
                    { 23, new Guid("fab242ac-113e-42ca-9363-d362efbcb394"), "LGA1700" },
                    { 82, new Guid("fab242ac-113e-42ca-9363-d362efbcb394"), "6" },
                    { 83, new Guid("fab242ac-113e-42ca-9363-d362efbcb394"), "12" },
                    { 84, new Guid("fab242ac-113e-42ca-9363-d362efbcb394"), "2.5 GHz" },
                    { 85, new Guid("fab242ac-113e-42ca-9363-d362efbcb394"), "4.4 GHz" },
                    { 86, new Guid("fab242ac-113e-42ca-9363-d362efbcb394"), "18 MB" },
                    { 87, new Guid("fab242ac-113e-42ca-9363-d362efbcb394"), "Yes" },
                    { 88, new Guid("fab242ac-113e-42ca-9363-d362efbcb394"), "Intel Core i5" },
                    { 89, new Guid("fab242ac-113e-42ca-9363-d362efbcb394"), "Intel 12th Gen" },
                    { 5, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a"), "White" },
                    { 22, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a"), "Mechanical" },
                    { 28, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a"), "RGB" },
                    { 31, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a"), "TKL" },
                    { 47, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a"), "USB" },
                    { 48, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a"), "Yes" },
                    { 49, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a"), "High profile" },
                    { 50, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a"), "No" },
                    { 51, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a"), "US" },
                    { 52, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a"), "No" },
                    { 53, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a"), "Yes" },
                    { 54, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a"), "BLMS Blue" },
                    { 22, new Guid("fb36b717-5bf3-4648-8839-e66018ec1523"), "Watery" },
                    { 23, new Guid("fb36b717-5bf3-4648-8839-e66018ec1523"), "1150, 1151, 1155, 1156, 2066, AM4, 2011-3, 1200, 1700" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "CharacteristicNameId", "ProductId", "Value" },
                values: new object[,]
                {
                    { 24, new Guid("fb36b717-5bf3-4648-8839-e66018ec1523"), "1800 RPM" },
                    { 25, new Guid("fb36b717-5bf3-4648-8839-e66018ec1523"), "23 dBA" },
                    { 26, new Guid("fb36b717-5bf3-4648-8839-e66018ec1523"), "120 x 25 mm x2" },
                    { 27, new Guid("fb36b717-5bf3-4648-8839-e66018ec1523"), "4-pin PWM" },
                    { 28, new Guid("fb36b717-5bf3-4648-8839-e66018ec1523"), "No" },
                    { 29, new Guid("fb36b717-5bf3-4648-8839-e66018ec1523"), "56.3 CFM" },
                    { 5, new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5"), "Black" },
                    { 6, new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5"), "210 mm" },
                    { 7, new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5"), "250 mm" },
                    { 28, new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5"), "No" },
                    { 72, new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5"), "2 mm" },
                    { 73, new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5"), "Textile" },
                    { 74, new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5"), "No" },
                    { 88, new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0"), "RTX 4000 Series" },
                    { 90, new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0"), "2790 MHz" },
                    { 95, new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0"), "12 GB" },
                    { 96, new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0"), "7680 CUDA" },
                    { 97, new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0"), "192 bit" },
                    { 98, new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0"), "HDMI, DisplayPort" },
                    { 99, new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0"), "GDDR6X" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 83, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 81, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 80, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0608c462-e7bf-4120-bdcd-091352064849"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 77, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 83, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 83, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 81, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 77, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 73, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ec80d70-22db-4952-bf93-99105299ca78"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 84, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 80, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11c9e125-f0a0-485c-a12f-c47938729085"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 76, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1208439d-df39-4445-9bdb-cce86277842b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 81, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 83, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("125d9fda-502a-4214-85ac-f746276bbb12"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 83, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 72, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 81, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("176d8c2e-8942-4732-a677-29c670c0c091"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 81, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 77, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 78, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 84, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 84, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 76, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 73, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 85, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20138228-3cb1-4a00-899e-ed40343018f9"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 77, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("208f2a40-db59-4499-b40d-368db5b3a634"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 75, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("221245d9-e8d1-4d83-b950-889ac825d869"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 73, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 80, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 80, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2403dada-744b-4347-b72a-6df00591f237"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 84, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 85, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 80, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 80, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26f18072-6741-4ece-a5bc-977994a5268b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 76, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 79, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 73, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 72, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 79, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 80, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 83, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32987f00-ee05-40bf-aecd-e13297d74532"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 72, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 76, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 81, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 82, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 72, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 81, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 82, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39bc4103-3f11-481b-a859-f2eb720649ba"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 78, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 82, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 80, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 83, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 82, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4556d753-6a08-4457-b2a8-d772c054499e"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 76, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 73, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 78, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 81, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 72, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 76, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50c72822-3c58-4689-bb12-171629bfce1a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 75, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 72, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 76, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 72, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57815913-af9e-4ad4-bc57-b22706866cd2"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 76, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 79, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 78, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 82, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 82, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 82, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 73, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 82, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fa226cc-43f9-4f16-8849-7331be60090d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 77, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fe0b265-d074-4864-9526-966405759eff"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 77, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 72, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("637d8089-3235-4896-a213-2b85771393c5"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 81, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 75, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 72, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65386f80-3659-4dc5-873b-572afdd12461"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 75, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("661acb6b-83fb-4039-bb91-098f97aa394a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 78, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 75, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 79, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 81, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("684eb60e-08df-4c0c-a30a-6c1294673988"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 79, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("689b3a84-261c-4512-904c-c7fed46365be"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 82, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 82, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 78, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 79, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 80, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 82, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 83, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 81, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 76, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("711b7764-c49d-4d92-9c03-2385ed109930"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 75, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 83, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 81, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 84, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 79, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 78, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 77, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 73, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 76, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("796faaca-ca93-4081-9a23-b90191c6c28c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 78, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 82, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 79, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 72, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 72, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 84, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 73, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e0cdafa-a356-4245-9b25-a8864857109b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 85, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 78, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 75, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 77, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 73, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 83, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87139a76-a325-4046-a973-e5dc072dc258"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 83, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 72, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89e3e4de-4748-4c4a-b018-89946185aecd"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 79, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 85, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 79, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d4089ec-9f65-450b-9f74-337390c86144"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 78, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 76, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 72, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 81, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91661960-9390-47c3-ab98-9b9e19269b02"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 75, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 80, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92089877-a384-404f-b813-f02236406a7e"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 83, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("938085a4-745e-4e76-851b-dada0ed1a06f"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 77, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 85, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98322a27-9cbc-4666-8392-0f245afb62aa"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 81, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 85, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c847a36-b5be-465e-993e-472f1135de58"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 72, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 80, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d1fc184-5111-405f-bc08-686cf2086357"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 78, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 78, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9df7c2cd-486d-481a-b047-6d55e9ffafa8"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 76, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 84, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 85, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a17622b2-2710-4c88-83a2-477d1292400c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 73, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 73, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 76, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 80, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 82, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 73, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 80, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6a172e1-aec3-475d-af84-754e32ddd378"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 84, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 77, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 73, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 85, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 84, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1261055-dac3-4233-9f36-b85208472b24"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 76, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 79, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 84, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 84, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 85, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 79, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 82, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 75, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b98a0d2b-36ea-441f-a191-733ead645f18"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 81, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 83, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 78, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 73, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c092adb2-47c6-4360-9d70-1411e0278747"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 77, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c096f9aa-448f-42ec-894a-875688f16264"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 85, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 75, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 77, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 85, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 85, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 85, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 84, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 82, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 75, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd520645-7cc4-42de-98f9-79c109829bbb"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 75, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 78, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cdf75419-d5f9-4119-beba-9765a822918d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 82, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 81, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 84, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 77, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 75, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 76, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 84, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 84, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 79, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 78, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 84, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 77, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 79, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 75, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 83, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 75, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 80, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 79, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 76, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 85, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 85, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 83, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 80, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 72, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 79, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 78, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 72, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 77, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 73, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9fadd8c-666a-40da-8058-3461e7580906"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 75, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fab242ac-113e-42ca-9363-d362efbcb394"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 83, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 77, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb36b717-5bf3-4648-8839-e66018ec1523"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 73, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 80, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 33, 28, 85, DateTimeKind.Local).AddTicks(5411));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 82, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 83, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 84, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 85, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 86, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 87, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 89, new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 75, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 76, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 77, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 100, new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 72, new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 73, new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 74, new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("0608c462-e7bf-4120-bdcd-091352064849") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("0608c462-e7bf-4120-bdcd-091352064849") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("0608c462-e7bf-4120-bdcd-091352064849") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("0608c462-e7bf-4120-bdcd-091352064849") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 48, new Guid("0608c462-e7bf-4120-bdcd-091352064849") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 49, new Guid("0608c462-e7bf-4120-bdcd-091352064849") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 50, new Guid("0608c462-e7bf-4120-bdcd-091352064849") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 51, new Guid("0608c462-e7bf-4120-bdcd-091352064849") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 52, new Guid("0608c462-e7bf-4120-bdcd-091352064849") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 53, new Guid("0608c462-e7bf-4120-bdcd-091352064849") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 82, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 83, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 84, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 85, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 86, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 87, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 89, new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 82, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 83, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 84, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 85, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 86, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 87, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 89, new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 75, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 76, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 77, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 100, new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 48, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 49, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 50, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 51, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 52, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 53, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 54, new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 24, new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 25, new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 26, new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 27, new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 29, new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("0ec80d70-22db-4952-bf93-99105299ca78") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("0ec80d70-22db-4952-bf93-99105299ca78") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("0ec80d70-22db-4952-bf93-99105299ca78") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("0ec80d70-22db-4952-bf93-99105299ca78") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("0ec80d70-22db-4952-bf93-99105299ca78") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 91, new Guid("0ec80d70-22db-4952-bf93-99105299ca78") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 92, new Guid("0ec80d70-22db-4952-bf93-99105299ca78") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 93, new Guid("0ec80d70-22db-4952-bf93-99105299ca78") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 94, new Guid("0ec80d70-22db-4952-bf93-99105299ca78") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 72, new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 73, new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 74, new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("11c9e125-f0a0-485c-a12f-c47938729085") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("11c9e125-f0a0-485c-a12f-c47938729085") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("11c9e125-f0a0-485c-a12f-c47938729085") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("11c9e125-f0a0-485c-a12f-c47938729085") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("11c9e125-f0a0-485c-a12f-c47938729085") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 43, new Guid("11c9e125-f0a0-485c-a12f-c47938729085") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 44, new Guid("11c9e125-f0a0-485c-a12f-c47938729085") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("1208439d-df39-4445-9bdb-cce86277842b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("1208439d-df39-4445-9bdb-cce86277842b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("1208439d-df39-4445-9bdb-cce86277842b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("1208439d-df39-4445-9bdb-cce86277842b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("1208439d-df39-4445-9bdb-cce86277842b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("1208439d-df39-4445-9bdb-cce86277842b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 75, new Guid("1208439d-df39-4445-9bdb-cce86277842b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 76, new Guid("1208439d-df39-4445-9bdb-cce86277842b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 77, new Guid("1208439d-df39-4445-9bdb-cce86277842b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 100, new Guid("1208439d-df39-4445-9bdb-cce86277842b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 82, new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 83, new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 84, new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 86, new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 87, new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 89, new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("125d9fda-502a-4214-85ac-f746276bbb12") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 82, new Guid("125d9fda-502a-4214-85ac-f746276bbb12") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 83, new Guid("125d9fda-502a-4214-85ac-f746276bbb12") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 84, new Guid("125d9fda-502a-4214-85ac-f746276bbb12") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 85, new Guid("125d9fda-502a-4214-85ac-f746276bbb12") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 86, new Guid("125d9fda-502a-4214-85ac-f746276bbb12") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 87, new Guid("125d9fda-502a-4214-85ac-f746276bbb12") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("125d9fda-502a-4214-85ac-f746276bbb12") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 89, new Guid("125d9fda-502a-4214-85ac-f746276bbb12") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 2, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 3, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 4, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 9, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 10, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 11, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 12, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 13, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 14, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 15, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 16, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 17, new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 75, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 76, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 77, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 100, new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("176d8c2e-8942-4732-a677-29c670c0c091") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("176d8c2e-8942-4732-a677-29c670c0c091") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("176d8c2e-8942-4732-a677-29c670c0c091") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("176d8c2e-8942-4732-a677-29c670c0c091") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("176d8c2e-8942-4732-a677-29c670c0c091") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 75, new Guid("176d8c2e-8942-4732-a677-29c670c0c091") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 76, new Guid("176d8c2e-8942-4732-a677-29c670c0c091") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 77, new Guid("176d8c2e-8942-4732-a677-29c670c0c091") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 100, new Guid("176d8c2e-8942-4732-a677-29c670c0c091") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 48, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 49, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 50, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 51, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 52, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 53, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 54, new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 55, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 56, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 57, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 58, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 60, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 61, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 62, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 63, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 64, new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 91, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 92, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 93, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 94, new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 91, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 92, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 93, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 94, new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 43, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 44, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 45, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 46, new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 24, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 25, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 26, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 27, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 29, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 30, new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 95, new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 96, new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 97, new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 98, new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 99, new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("20138228-3cb1-4a00-899e-ed40343018f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("20138228-3cb1-4a00-899e-ed40343018f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("20138228-3cb1-4a00-899e-ed40343018f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("20138228-3cb1-4a00-899e-ed40343018f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("20138228-3cb1-4a00-899e-ed40343018f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 48, new Guid("20138228-3cb1-4a00-899e-ed40343018f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 49, new Guid("20138228-3cb1-4a00-899e-ed40343018f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 50, new Guid("20138228-3cb1-4a00-899e-ed40343018f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 51, new Guid("20138228-3cb1-4a00-899e-ed40343018f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 52, new Guid("20138228-3cb1-4a00-899e-ed40343018f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 53, new Guid("20138228-3cb1-4a00-899e-ed40343018f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("208f2a40-db59-4499-b40d-368db5b3a634") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("208f2a40-db59-4499-b40d-368db5b3a634") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("208f2a40-db59-4499-b40d-368db5b3a634") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("208f2a40-db59-4499-b40d-368db5b3a634") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 33, new Guid("208f2a40-db59-4499-b40d-368db5b3a634") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 34, new Guid("208f2a40-db59-4499-b40d-368db5b3a634") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 35, new Guid("208f2a40-db59-4499-b40d-368db5b3a634") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 36, new Guid("208f2a40-db59-4499-b40d-368db5b3a634") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 37, new Guid("208f2a40-db59-4499-b40d-368db5b3a634") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("208f2a40-db59-4499-b40d-368db5b3a634") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 39, new Guid("208f2a40-db59-4499-b40d-368db5b3a634") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("208f2a40-db59-4499-b40d-368db5b3a634") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 41, new Guid("208f2a40-db59-4499-b40d-368db5b3a634") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("221245d9-e8d1-4d83-b950-889ac825d869") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("221245d9-e8d1-4d83-b950-889ac825d869") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 24, new Guid("221245d9-e8d1-4d83-b950-889ac825d869") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 25, new Guid("221245d9-e8d1-4d83-b950-889ac825d869") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 26, new Guid("221245d9-e8d1-4d83-b950-889ac825d869") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 27, new Guid("221245d9-e8d1-4d83-b950-889ac825d869") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("221245d9-e8d1-4d83-b950-889ac825d869") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 29, new Guid("221245d9-e8d1-4d83-b950-889ac825d869") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 72, new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 73, new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 74, new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 72, new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 73, new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 74, new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("2403dada-744b-4347-b72a-6df00591f237") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("2403dada-744b-4347-b72a-6df00591f237") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("2403dada-744b-4347-b72a-6df00591f237") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("2403dada-744b-4347-b72a-6df00591f237") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("2403dada-744b-4347-b72a-6df00591f237") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 91, new Guid("2403dada-744b-4347-b72a-6df00591f237") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 92, new Guid("2403dada-744b-4347-b72a-6df00591f237") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 93, new Guid("2403dada-744b-4347-b72a-6df00591f237") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 94, new Guid("2403dada-744b-4347-b72a-6df00591f237") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 95, new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 96, new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 97, new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 98, new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 99, new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 72, new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 73, new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 74, new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 72, new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 73, new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 74, new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("26f18072-6741-4ece-a5bc-977994a5268b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("26f18072-6741-4ece-a5bc-977994a5268b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("26f18072-6741-4ece-a5bc-977994a5268b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("26f18072-6741-4ece-a5bc-977994a5268b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("26f18072-6741-4ece-a5bc-977994a5268b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 43, new Guid("26f18072-6741-4ece-a5bc-977994a5268b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 44, new Guid("26f18072-6741-4ece-a5bc-977994a5268b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 66, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 67, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 68, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 69, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 70, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 71, new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 24, new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 25, new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 26, new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 27, new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 29, new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 2, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 3, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 4, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 9, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 10, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 13, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 16, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 17, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 18, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 19, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 20, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 21, new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 66, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 67, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 68, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 69, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 70, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 71, new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 72, new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 73, new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 74, new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 82, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 83, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 84, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 85, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 86, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 87, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 89, new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("32987f00-ee05-40bf-aecd-e13297d74532") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 2, new Guid("32987f00-ee05-40bf-aecd-e13297d74532") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 3, new Guid("32987f00-ee05-40bf-aecd-e13297d74532") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 4, new Guid("32987f00-ee05-40bf-aecd-e13297d74532") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("32987f00-ee05-40bf-aecd-e13297d74532") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("32987f00-ee05-40bf-aecd-e13297d74532") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("32987f00-ee05-40bf-aecd-e13297d74532") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("32987f00-ee05-40bf-aecd-e13297d74532") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 9, new Guid("32987f00-ee05-40bf-aecd-e13297d74532") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 10, new Guid("32987f00-ee05-40bf-aecd-e13297d74532") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 11, new Guid("32987f00-ee05-40bf-aecd-e13297d74532") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 12, new Guid("32987f00-ee05-40bf-aecd-e13297d74532") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 13, new Guid("32987f00-ee05-40bf-aecd-e13297d74532") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 14, new Guid("32987f00-ee05-40bf-aecd-e13297d74532") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 17, new Guid("32987f00-ee05-40bf-aecd-e13297d74532") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 43, new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 44, new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 75, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 76, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 77, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 100, new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 78, new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 79, new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 80, new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 81, new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 2, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 3, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 4, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 9, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 10, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 11, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 12, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 13, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 14, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 15, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 16, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 17, new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 75, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 76, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 77, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 100, new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 78, new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 79, new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 80, new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 81, new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 55, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 56, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 57, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 58, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 60, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 61, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 62, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 63, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 64, new Guid("39bc4103-3f11-481b-a859-f2eb720649ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 78, new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 79, new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 80, new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 81, new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 72, new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 73, new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 74, new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 82, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 83, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 84, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 85, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 86, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 87, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 89, new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 78, new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 79, new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 80, new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 81, new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("4556d753-6a08-4457-b2a8-d772c054499e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("4556d753-6a08-4457-b2a8-d772c054499e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("4556d753-6a08-4457-b2a8-d772c054499e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("4556d753-6a08-4457-b2a8-d772c054499e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 43, new Guid("4556d753-6a08-4457-b2a8-d772c054499e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 44, new Guid("4556d753-6a08-4457-b2a8-d772c054499e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 45, new Guid("4556d753-6a08-4457-b2a8-d772c054499e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 46, new Guid("4556d753-6a08-4457-b2a8-d772c054499e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 24, new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 25, new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 26, new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 27, new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 29, new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 55, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 56, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 57, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 58, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 60, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 61, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 62, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 63, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 64, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 65, new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 75, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 76, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 77, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 100, new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 2, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 3, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 4, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 9, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 10, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 11, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 12, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 13, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 14, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 16, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 17, new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 43, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 44, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 45, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 46, new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("50c72822-3c58-4689-bb12-171629bfce1a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("50c72822-3c58-4689-bb12-171629bfce1a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("50c72822-3c58-4689-bb12-171629bfce1a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("50c72822-3c58-4689-bb12-171629bfce1a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 33, new Guid("50c72822-3c58-4689-bb12-171629bfce1a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 34, new Guid("50c72822-3c58-4689-bb12-171629bfce1a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 35, new Guid("50c72822-3c58-4689-bb12-171629bfce1a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 36, new Guid("50c72822-3c58-4689-bb12-171629bfce1a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 37, new Guid("50c72822-3c58-4689-bb12-171629bfce1a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("50c72822-3c58-4689-bb12-171629bfce1a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 39, new Guid("50c72822-3c58-4689-bb12-171629bfce1a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("50c72822-3c58-4689-bb12-171629bfce1a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 41, new Guid("50c72822-3c58-4689-bb12-171629bfce1a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 2, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 3, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 4, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 9, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 10, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 11, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 12, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 13, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 14, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 15, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 16, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 17, new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 43, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 44, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 45, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 46, new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 2, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 3, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 4, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 9, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 10, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 11, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 12, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 13, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 14, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 16, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 17, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 20, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 21, new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 43, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 44, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 45, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 46, new Guid("57815913-af9e-4ad4-bc57-b22706866cd2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 66, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 67, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 68, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 69, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 70, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 71, new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 55, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 56, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 57, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 58, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 60, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 61, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 62, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 63, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 64, new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 78, new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 79, new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 80, new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 81, new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 78, new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 79, new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 80, new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 81, new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 78, new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 79, new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 80, new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 81, new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 24, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 25, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 26, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 27, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 29, new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 78, new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 79, new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 80, new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 81, new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 48, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 49, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 50, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 51, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 52, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 53, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 54, new Guid("5fa226cc-43f9-4f16-8849-7331be60090d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("5fe0b265-d074-4864-9526-966405759eff") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("5fe0b265-d074-4864-9526-966405759eff") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("5fe0b265-d074-4864-9526-966405759eff") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("5fe0b265-d074-4864-9526-966405759eff") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("5fe0b265-d074-4864-9526-966405759eff") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 48, new Guid("5fe0b265-d074-4864-9526-966405759eff") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 49, new Guid("5fe0b265-d074-4864-9526-966405759eff") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 50, new Guid("5fe0b265-d074-4864-9526-966405759eff") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 51, new Guid("5fe0b265-d074-4864-9526-966405759eff") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 52, new Guid("5fe0b265-d074-4864-9526-966405759eff") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 53, new Guid("5fe0b265-d074-4864-9526-966405759eff") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 54, new Guid("5fe0b265-d074-4864-9526-966405759eff") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 2, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 3, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 4, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 9, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 10, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 13, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 16, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 17, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 18, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 19, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 20, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 21, new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("637d8089-3235-4896-a213-2b85771393c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("637d8089-3235-4896-a213-2b85771393c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("637d8089-3235-4896-a213-2b85771393c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("637d8089-3235-4896-a213-2b85771393c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("637d8089-3235-4896-a213-2b85771393c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("637d8089-3235-4896-a213-2b85771393c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 75, new Guid("637d8089-3235-4896-a213-2b85771393c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 76, new Guid("637d8089-3235-4896-a213-2b85771393c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 77, new Guid("637d8089-3235-4896-a213-2b85771393c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 100, new Guid("637d8089-3235-4896-a213-2b85771393c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 33, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 34, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 35, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 36, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 37, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 39, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 41, new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 2, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 3, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 4, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 9, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 10, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 11, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 12, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 13, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 14, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 15, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 16, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 17, new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("65386f80-3659-4dc5-873b-572afdd12461") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("65386f80-3659-4dc5-873b-572afdd12461") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("65386f80-3659-4dc5-873b-572afdd12461") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("65386f80-3659-4dc5-873b-572afdd12461") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 33, new Guid("65386f80-3659-4dc5-873b-572afdd12461") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 34, new Guid("65386f80-3659-4dc5-873b-572afdd12461") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 35, new Guid("65386f80-3659-4dc5-873b-572afdd12461") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 36, new Guid("65386f80-3659-4dc5-873b-572afdd12461") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 37, new Guid("65386f80-3659-4dc5-873b-572afdd12461") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("65386f80-3659-4dc5-873b-572afdd12461") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 39, new Guid("65386f80-3659-4dc5-873b-572afdd12461") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("65386f80-3659-4dc5-873b-572afdd12461") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 41, new Guid("65386f80-3659-4dc5-873b-572afdd12461") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 55, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 56, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 57, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 58, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 60, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 61, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 62, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 63, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 64, new Guid("661acb6b-83fb-4039-bb91-098f97aa394a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 33, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 34, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 35, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 36, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 37, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 39, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 41, new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 66, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 67, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 68, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 69, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 70, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 71, new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 75, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 76, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 77, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 100, new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 66, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 67, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 68, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 69, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 70, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 71, new Guid("684eb60e-08df-4c0c-a30a-6c1294673988") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("689b3a84-261c-4512-904c-c7fed46365be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("689b3a84-261c-4512-904c-c7fed46365be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("689b3a84-261c-4512-904c-c7fed46365be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("689b3a84-261c-4512-904c-c7fed46365be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 78, new Guid("689b3a84-261c-4512-904c-c7fed46365be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 79, new Guid("689b3a84-261c-4512-904c-c7fed46365be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 80, new Guid("689b3a84-261c-4512-904c-c7fed46365be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 81, new Guid("689b3a84-261c-4512-904c-c7fed46365be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 78, new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 79, new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 80, new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 81, new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 55, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 56, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 57, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 58, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 60, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 61, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 62, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 63, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 64, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 65, new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 66, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 67, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 68, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 69, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 70, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 71, new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 72, new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 73, new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 74, new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 78, new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 79, new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 80, new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 81, new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 82, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 83, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 84, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 85, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 86, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 87, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 89, new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 75, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 76, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 77, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 100, new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 43, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 44, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 45, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 46, new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("711b7764-c49d-4d92-9c03-2385ed109930") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("711b7764-c49d-4d92-9c03-2385ed109930") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("711b7764-c49d-4d92-9c03-2385ed109930") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("711b7764-c49d-4d92-9c03-2385ed109930") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 33, new Guid("711b7764-c49d-4d92-9c03-2385ed109930") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 34, new Guid("711b7764-c49d-4d92-9c03-2385ed109930") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 35, new Guid("711b7764-c49d-4d92-9c03-2385ed109930") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 36, new Guid("711b7764-c49d-4d92-9c03-2385ed109930") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 37, new Guid("711b7764-c49d-4d92-9c03-2385ed109930") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("711b7764-c49d-4d92-9c03-2385ed109930") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 39, new Guid("711b7764-c49d-4d92-9c03-2385ed109930") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 41, new Guid("711b7764-c49d-4d92-9c03-2385ed109930") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 82, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 83, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 84, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 85, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 86, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 87, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 89, new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 75, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 76, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 77, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 100, new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 91, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 92, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 93, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 94, new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 66, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 67, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 68, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 69, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 70, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 71, new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 55, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 56, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 57, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 58, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 60, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 61, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 62, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 63, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 64, new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 48, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 49, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 50, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 51, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 52, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 53, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 54, new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 24, new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 25, new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 26, new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 27, new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 29, new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 43, new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 44, new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 55, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 56, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 57, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 58, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 60, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 61, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 62, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 63, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 64, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 65, new Guid("796faaca-ca93-4081-9a23-b90191c6c28c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 78, new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 79, new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 80, new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 81, new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 66, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 67, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 68, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 69, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 70, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 71, new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 2, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 3, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 4, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 9, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 10, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 12, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 13, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 15, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 16, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 17, new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 2, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 3, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 4, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 9, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 10, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 11, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 12, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 13, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 14, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 15, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 17, new Guid("7cfe7936-6644-4912-b846-9c5860a35b44") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 91, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 92, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 93, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 94, new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 24, new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 25, new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 26, new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 27, new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("7e0cdafa-a356-4245-9b25-a8864857109b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("7e0cdafa-a356-4245-9b25-a8864857109b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 95, new Guid("7e0cdafa-a356-4245-9b25-a8864857109b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 96, new Guid("7e0cdafa-a356-4245-9b25-a8864857109b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 97, new Guid("7e0cdafa-a356-4245-9b25-a8864857109b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 98, new Guid("7e0cdafa-a356-4245-9b25-a8864857109b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 99, new Guid("7e0cdafa-a356-4245-9b25-a8864857109b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 55, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 56, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 57, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 58, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 60, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 61, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 62, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 63, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 64, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 65, new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 33, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 34, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 35, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 36, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 37, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 39, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 41, new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 48, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 49, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 50, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 51, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 52, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 53, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 54, new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 24, new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 25, new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 26, new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 27, new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 29, new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 82, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 83, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 84, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 85, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 86, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 87, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 89, new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("87139a76-a325-4046-a973-e5dc072dc258") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 82, new Guid("87139a76-a325-4046-a973-e5dc072dc258") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 83, new Guid("87139a76-a325-4046-a973-e5dc072dc258") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 84, new Guid("87139a76-a325-4046-a973-e5dc072dc258") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 85, new Guid("87139a76-a325-4046-a973-e5dc072dc258") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 86, new Guid("87139a76-a325-4046-a973-e5dc072dc258") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 87, new Guid("87139a76-a325-4046-a973-e5dc072dc258") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("87139a76-a325-4046-a973-e5dc072dc258") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 89, new Guid("87139a76-a325-4046-a973-e5dc072dc258") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 2, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 3, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 4, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 9, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 10, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 11, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 12, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 13, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 14, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 15, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 16, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 17, new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 66, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 67, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 68, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 69, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 70, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 71, new Guid("89e3e4de-4748-4c4a-b018-89946185aecd") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 95, new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 96, new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 97, new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 98, new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 99, new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 66, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 67, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 68, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 69, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 70, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 71, new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("8d4089ec-9f65-450b-9f74-337390c86144") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 55, new Guid("8d4089ec-9f65-450b-9f74-337390c86144") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 56, new Guid("8d4089ec-9f65-450b-9f74-337390c86144") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 57, new Guid("8d4089ec-9f65-450b-9f74-337390c86144") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 58, new Guid("8d4089ec-9f65-450b-9f74-337390c86144") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("8d4089ec-9f65-450b-9f74-337390c86144") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 60, new Guid("8d4089ec-9f65-450b-9f74-337390c86144") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 61, new Guid("8d4089ec-9f65-450b-9f74-337390c86144") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 62, new Guid("8d4089ec-9f65-450b-9f74-337390c86144") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 63, new Guid("8d4089ec-9f65-450b-9f74-337390c86144") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 64, new Guid("8d4089ec-9f65-450b-9f74-337390c86144") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 43, new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 44, new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 2, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 3, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 4, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 9, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 10, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 11, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 12, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 13, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 14, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 17, new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 75, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 76, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 77, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 100, new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("91661960-9390-47c3-ab98-9b9e19269b02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("91661960-9390-47c3-ab98-9b9e19269b02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("91661960-9390-47c3-ab98-9b9e19269b02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("91661960-9390-47c3-ab98-9b9e19269b02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 33, new Guid("91661960-9390-47c3-ab98-9b9e19269b02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 34, new Guid("91661960-9390-47c3-ab98-9b9e19269b02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 35, new Guid("91661960-9390-47c3-ab98-9b9e19269b02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 36, new Guid("91661960-9390-47c3-ab98-9b9e19269b02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 37, new Guid("91661960-9390-47c3-ab98-9b9e19269b02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 39, new Guid("91661960-9390-47c3-ab98-9b9e19269b02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("91661960-9390-47c3-ab98-9b9e19269b02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 41, new Guid("91661960-9390-47c3-ab98-9b9e19269b02") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 72, new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 73, new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 74, new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("92089877-a384-404f-b813-f02236406a7e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 82, new Guid("92089877-a384-404f-b813-f02236406a7e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 83, new Guid("92089877-a384-404f-b813-f02236406a7e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 84, new Guid("92089877-a384-404f-b813-f02236406a7e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 85, new Guid("92089877-a384-404f-b813-f02236406a7e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 86, new Guid("92089877-a384-404f-b813-f02236406a7e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 87, new Guid("92089877-a384-404f-b813-f02236406a7e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("92089877-a384-404f-b813-f02236406a7e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 89, new Guid("92089877-a384-404f-b813-f02236406a7e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 48, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 49, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 50, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 51, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 52, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 53, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 54, new Guid("938085a4-745e-4e76-851b-dada0ed1a06f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 95, new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 96, new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 97, new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 98, new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 99, new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 75, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 76, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 77, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 100, new Guid("98322a27-9cbc-4666-8392-0f245afb62aa") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 95, new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 96, new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 97, new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 98, new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 99, new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("9c847a36-b5be-465e-993e-472f1135de58") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 2, new Guid("9c847a36-b5be-465e-993e-472f1135de58") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 3, new Guid("9c847a36-b5be-465e-993e-472f1135de58") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 4, new Guid("9c847a36-b5be-465e-993e-472f1135de58") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("9c847a36-b5be-465e-993e-472f1135de58") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("9c847a36-b5be-465e-993e-472f1135de58") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("9c847a36-b5be-465e-993e-472f1135de58") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("9c847a36-b5be-465e-993e-472f1135de58") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 9, new Guid("9c847a36-b5be-465e-993e-472f1135de58") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 10, new Guid("9c847a36-b5be-465e-993e-472f1135de58") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 11, new Guid("9c847a36-b5be-465e-993e-472f1135de58") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 12, new Guid("9c847a36-b5be-465e-993e-472f1135de58") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 13, new Guid("9c847a36-b5be-465e-993e-472f1135de58") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 14, new Guid("9c847a36-b5be-465e-993e-472f1135de58") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 16, new Guid("9c847a36-b5be-465e-993e-472f1135de58") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 17, new Guid("9c847a36-b5be-465e-993e-472f1135de58") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 72, new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 73, new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 74, new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("9d1fc184-5111-405f-bc08-686cf2086357") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 55, new Guid("9d1fc184-5111-405f-bc08-686cf2086357") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 56, new Guid("9d1fc184-5111-405f-bc08-686cf2086357") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 57, new Guid("9d1fc184-5111-405f-bc08-686cf2086357") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 58, new Guid("9d1fc184-5111-405f-bc08-686cf2086357") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("9d1fc184-5111-405f-bc08-686cf2086357") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 60, new Guid("9d1fc184-5111-405f-bc08-686cf2086357") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 61, new Guid("9d1fc184-5111-405f-bc08-686cf2086357") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 62, new Guid("9d1fc184-5111-405f-bc08-686cf2086357") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 63, new Guid("9d1fc184-5111-405f-bc08-686cf2086357") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 64, new Guid("9d1fc184-5111-405f-bc08-686cf2086357") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 65, new Guid("9d1fc184-5111-405f-bc08-686cf2086357") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 55, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 56, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 57, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 58, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 60, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 61, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 62, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 63, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 64, new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("9df7c2cd-486d-481a-b047-6d55e9ffafa8") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("9df7c2cd-486d-481a-b047-6d55e9ffafa8") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("9df7c2cd-486d-481a-b047-6d55e9ffafa8") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("9df7c2cd-486d-481a-b047-6d55e9ffafa8") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 43, new Guid("9df7c2cd-486d-481a-b047-6d55e9ffafa8") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 44, new Guid("9df7c2cd-486d-481a-b047-6d55e9ffafa8") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 91, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 92, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 93, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 94, new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 95, new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 96, new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 97, new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 98, new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 99, new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("a17622b2-2710-4c88-83a2-477d1292400c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("a17622b2-2710-4c88-83a2-477d1292400c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("a17622b2-2710-4c88-83a2-477d1292400c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 24, new Guid("a17622b2-2710-4c88-83a2-477d1292400c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 25, new Guid("a17622b2-2710-4c88-83a2-477d1292400c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 26, new Guid("a17622b2-2710-4c88-83a2-477d1292400c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 27, new Guid("a17622b2-2710-4c88-83a2-477d1292400c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("a17622b2-2710-4c88-83a2-477d1292400c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 29, new Guid("a17622b2-2710-4c88-83a2-477d1292400c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 24, new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 25, new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 26, new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 27, new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 29, new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 43, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 44, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 45, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 46, new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 72, new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 73, new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 74, new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 78, new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 79, new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 80, new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 81, new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 24, new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 25, new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 26, new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 27, new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 29, new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 72, new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 73, new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 74, new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 91, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 92, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 93, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 94, new Guid("a6a172e1-aec3-475d-af84-754e32ddd378") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 48, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 49, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 50, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 51, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 52, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 53, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 54, new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 24, new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 25, new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 26, new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 27, new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 29, new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 95, new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 96, new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 97, new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 98, new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 99, new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 91, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 92, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 93, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 94, new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("b1261055-dac3-4233-9f36-b85208472b24") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("b1261055-dac3-4233-9f36-b85208472b24") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("b1261055-dac3-4233-9f36-b85208472b24") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("b1261055-dac3-4233-9f36-b85208472b24") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("b1261055-dac3-4233-9f36-b85208472b24") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 43, new Guid("b1261055-dac3-4233-9f36-b85208472b24") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 44, new Guid("b1261055-dac3-4233-9f36-b85208472b24") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 45, new Guid("b1261055-dac3-4233-9f36-b85208472b24") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 46, new Guid("b1261055-dac3-4233-9f36-b85208472b24") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 66, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 67, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 68, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 69, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 70, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 71, new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 91, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 92, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 93, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 94, new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 91, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 92, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 93, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 94, new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 95, new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 96, new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 97, new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 98, new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 99, new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 66, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 67, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 68, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 69, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 70, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 71, new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 78, new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 79, new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 80, new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 81, new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 33, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 34, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 36, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 37, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 39, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 41, new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 75, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 76, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 77, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 100, new Guid("b98a0d2b-36ea-441f-a191-733ead645f18") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 82, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 83, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 84, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 85, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 86, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 87, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 89, new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 55, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 56, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 57, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 58, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 60, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 61, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 62, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 63, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 64, new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 24, new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 25, new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 26, new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 27, new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 29, new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("c092adb2-47c6-4360-9d70-1411e0278747") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("c092adb2-47c6-4360-9d70-1411e0278747") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("c092adb2-47c6-4360-9d70-1411e0278747") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("c092adb2-47c6-4360-9d70-1411e0278747") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("c092adb2-47c6-4360-9d70-1411e0278747") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 48, new Guid("c092adb2-47c6-4360-9d70-1411e0278747") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 49, new Guid("c092adb2-47c6-4360-9d70-1411e0278747") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 50, new Guid("c092adb2-47c6-4360-9d70-1411e0278747") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 51, new Guid("c092adb2-47c6-4360-9d70-1411e0278747") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 52, new Guid("c092adb2-47c6-4360-9d70-1411e0278747") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 53, new Guid("c092adb2-47c6-4360-9d70-1411e0278747") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 54, new Guid("c092adb2-47c6-4360-9d70-1411e0278747") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("c096f9aa-448f-42ec-894a-875688f16264") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("c096f9aa-448f-42ec-894a-875688f16264") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 95, new Guid("c096f9aa-448f-42ec-894a-875688f16264") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 96, new Guid("c096f9aa-448f-42ec-894a-875688f16264") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 97, new Guid("c096f9aa-448f-42ec-894a-875688f16264") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 98, new Guid("c096f9aa-448f-42ec-894a-875688f16264") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 99, new Guid("c096f9aa-448f-42ec-894a-875688f16264") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 33, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 34, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 35, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 36, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 37, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 39, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 41, new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 48, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 49, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 50, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 51, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 52, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 53, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 54, new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 95, new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 96, new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 97, new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 98, new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 99, new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 95, new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 96, new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 97, new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 98, new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 99, new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 95, new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 96, new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 97, new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 98, new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 99, new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 91, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 92, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 93, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 94, new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 78, new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 79, new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 80, new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 81, new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 33, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 34, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 35, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 36, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 37, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 39, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 41, new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 33, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 34, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 35, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 36, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 37, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 39, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 41, new Guid("cd520645-7cc4-42de-98f9-79c109829bbb") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 55, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 56, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 57, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 58, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 60, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 61, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 62, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 63, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 64, new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("cdf75419-d5f9-4119-beba-9765a822918d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("cdf75419-d5f9-4119-beba-9765a822918d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("cdf75419-d5f9-4119-beba-9765a822918d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("cdf75419-d5f9-4119-beba-9765a822918d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 78, new Guid("cdf75419-d5f9-4119-beba-9765a822918d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 79, new Guid("cdf75419-d5f9-4119-beba-9765a822918d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 80, new Guid("cdf75419-d5f9-4119-beba-9765a822918d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 81, new Guid("cdf75419-d5f9-4119-beba-9765a822918d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 75, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 76, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 77, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 100, new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 91, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 92, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 93, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 94, new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 48, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 49, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 50, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 51, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 52, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 53, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 54, new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 33, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 34, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 35, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 36, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 37, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 39, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 41, new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 43, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 44, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 45, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 46, new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 91, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 92, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 93, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 94, new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 91, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 92, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 93, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 94, new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 66, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 67, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 68, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 69, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 70, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 71, new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 55, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 56, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 57, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 58, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 60, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 61, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 62, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 63, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 64, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 65, new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 91, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 92, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 93, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 94, new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 48, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 49, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 50, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 51, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 52, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 53, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 54, new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 66, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 67, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 68, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 69, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 70, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 71, new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 33, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 34, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 35, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 36, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 37, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 39, new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 82, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 83, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 84, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 85, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 86, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 87, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 89, new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 33, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 34, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 35, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 36, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 37, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 39, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 41, new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 72, new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 73, new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 74, new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 66, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 67, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 68, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 69, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 70, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 71, new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 42, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 43, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 44, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 45, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 46, new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 95, new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 96, new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 97, new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 98, new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 99, new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 95, new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 96, new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 97, new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 98, new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 99, new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 82, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 83, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 84, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 85, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 86, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 87, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 89, new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 72, new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 73, new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 74, new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 2, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 3, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 4, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 9, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 10, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 11, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 12, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 13, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 14, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 15, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 16, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 17, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 18, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 19, new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 66, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 67, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 68, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 69, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 70, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 71, new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 55, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 56, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 57, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 58, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 59, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 60, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 61, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 62, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 63, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 64, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 65, new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 1, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 2, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 3, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 4, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 8, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 9, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 10, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 11, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 12, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 13, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 14, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 15, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 16, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 17, new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 48, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 49, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 50, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 51, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 52, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 53, new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 24, new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 25, new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 26, new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 27, new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 29, new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("f9fadd8c-666a-40da-8058-3461e7580906") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("f9fadd8c-666a-40da-8058-3461e7580906") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("f9fadd8c-666a-40da-8058-3461e7580906") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 32, new Guid("f9fadd8c-666a-40da-8058-3461e7580906") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 33, new Guid("f9fadd8c-666a-40da-8058-3461e7580906") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 34, new Guid("f9fadd8c-666a-40da-8058-3461e7580906") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 35, new Guid("f9fadd8c-666a-40da-8058-3461e7580906") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 36, new Guid("f9fadd8c-666a-40da-8058-3461e7580906") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 37, new Guid("f9fadd8c-666a-40da-8058-3461e7580906") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 38, new Guid("f9fadd8c-666a-40da-8058-3461e7580906") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 39, new Guid("f9fadd8c-666a-40da-8058-3461e7580906") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 40, new Guid("f9fadd8c-666a-40da-8058-3461e7580906") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 41, new Guid("f9fadd8c-666a-40da-8058-3461e7580906") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("fab242ac-113e-42ca-9363-d362efbcb394") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 82, new Guid("fab242ac-113e-42ca-9363-d362efbcb394") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 83, new Guid("fab242ac-113e-42ca-9363-d362efbcb394") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 84, new Guid("fab242ac-113e-42ca-9363-d362efbcb394") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 85, new Guid("fab242ac-113e-42ca-9363-d362efbcb394") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 86, new Guid("fab242ac-113e-42ca-9363-d362efbcb394") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 87, new Guid("fab242ac-113e-42ca-9363-d362efbcb394") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("fab242ac-113e-42ca-9363-d362efbcb394") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 89, new Guid("fab242ac-113e-42ca-9363-d362efbcb394") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 31, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 47, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 48, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 49, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 50, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 51, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 52, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 53, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 54, new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 22, new Guid("fb36b717-5bf3-4648-8839-e66018ec1523") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 23, new Guid("fb36b717-5bf3-4648-8839-e66018ec1523") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 24, new Guid("fb36b717-5bf3-4648-8839-e66018ec1523") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 25, new Guid("fb36b717-5bf3-4648-8839-e66018ec1523") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 26, new Guid("fb36b717-5bf3-4648-8839-e66018ec1523") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 27, new Guid("fb36b717-5bf3-4648-8839-e66018ec1523") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("fb36b717-5bf3-4648-8839-e66018ec1523") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 29, new Guid("fb36b717-5bf3-4648-8839-e66018ec1523") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 5, new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 6, new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 7, new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 28, new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 72, new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 73, new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 74, new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 88, new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 90, new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 95, new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 96, new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 97, new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 98, new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0") });

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumns: new[] { "CharacteristicNameId", "ProductId" },
                keyValues: new object[] { 99, new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0608c462-e7bf-4120-bdcd-091352064849"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ec80d70-22db-4952-bf93-99105299ca78"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11c9e125-f0a0-485c-a12f-c47938729085"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1208439d-df39-4445-9bdb-cce86277842b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("125d9fda-502a-4214-85ac-f746276bbb12"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("176d8c2e-8942-4732-a677-29c670c0c091"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20138228-3cb1-4a00-899e-ed40343018f9"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("208f2a40-db59-4499-b40d-368db5b3a634"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("221245d9-e8d1-4d83-b950-889ac825d869"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2403dada-744b-4347-b72a-6df00591f237"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26f18072-6741-4ece-a5bc-977994a5268b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32987f00-ee05-40bf-aecd-e13297d74532"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39bc4103-3f11-481b-a859-f2eb720649ba"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4556d753-6a08-4457-b2a8-d772c054499e"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50c72822-3c58-4689-bb12-171629bfce1a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57815913-af9e-4ad4-bc57-b22706866cd2"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fa226cc-43f9-4f16-8849-7331be60090d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fe0b265-d074-4864-9526-966405759eff"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("637d8089-3235-4896-a213-2b85771393c5"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65386f80-3659-4dc5-873b-572afdd12461"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("661acb6b-83fb-4039-bb91-098f97aa394a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("684eb60e-08df-4c0c-a30a-6c1294673988"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("689b3a84-261c-4512-904c-c7fed46365be"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("711b7764-c49d-4d92-9c03-2385ed109930"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("796faaca-ca93-4081-9a23-b90191c6c28c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e0cdafa-a356-4245-9b25-a8864857109b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87139a76-a325-4046-a973-e5dc072dc258"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89e3e4de-4748-4c4a-b018-89946185aecd"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d4089ec-9f65-450b-9f74-337390c86144"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91661960-9390-47c3-ab98-9b9e19269b02"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92089877-a384-404f-b813-f02236406a7e"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("938085a4-745e-4e76-851b-dada0ed1a06f"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98322a27-9cbc-4666-8392-0f245afb62aa"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c847a36-b5be-465e-993e-472f1135de58"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d1fc184-5111-405f-bc08-686cf2086357"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9df7c2cd-486d-481a-b047-6d55e9ffafa8"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a17622b2-2710-4c88-83a2-477d1292400c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6a172e1-aec3-475d-af84-754e32ddd378"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1261055-dac3-4233-9f36-b85208472b24"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b98a0d2b-36ea-441f-a191-733ead645f18"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c092adb2-47c6-4360-9d70-1411e0278747"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c096f9aa-448f-42ec-894a-875688f16264"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd520645-7cc4-42de-98f9-79c109829bbb"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cdf75419-d5f9-4119-beba-9765a822918d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9fadd8c-666a-40da-8058-3461e7580906"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fab242ac-113e-42ca-9363-d362efbcb394"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb36b717-5bf3-4648-8839-e66018ec1523"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0"),
                column: "AddDate",
                value: new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6504));
        }
    }
}
