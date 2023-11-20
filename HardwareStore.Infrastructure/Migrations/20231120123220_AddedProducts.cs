using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HardwareStore.Infrastructure.Migrations
{
    public partial class AddedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AddDate", "CategoryId", "Description", "ManufacturerId", "Model", "Name", "Price", "Quantity", "ReferenceNumber", "Warranty" },
                values: new object[,]
                {
                    { new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c"), new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7296), 6, "Processor Intel Alder Lake Core i5-12600KF, 10 Cores, 16 Threads (3.7GHz Up to 4.9GHz, 20MB, LGA1700), BOX", 37, "Core I5-12600KF", "INTEL CORE I5-12600KF", 522.10m, 10, "INTEL-CORE-I5-12600KF", 36 },
                    { new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1"), new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9858), 1, "Lightweight wired gaming mouse with 16,000 dpi sensor, six programmable buttons, ultralight Air Shell, IPX6 water resistance, ASUS Antibacterial Guard, TUF Gaming Paracord and PTFE feet.", 1, "TUF GAMING M4 AIR", "ASUS TUF GAMING M4 AIR", 93.56m, 10, "ASUS-TUF-GAMING-M4-AIR-BLACK", 24 },
                    { new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d"), new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5785), 4, "Built for your victory, the Logitech G440 is a hard pad suitable for anyone using a high-sensitivity mouse. Compatible with optical and laser sensors", 12, "G440", "LOGITECH G440", 58.99m, 10, "LOGITECH-G440-BLACK", 24 },
                    { new Guid("0608c462-e7bf-4120-bdcd-091352064849"), new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9469), 2, "Featuring HyperX's signature radiant light bar, and smooth, dynamic RGB lighting effects, the HyperX Alloy Core RGB is ideal for gamers looking to enhance their keyboard's style and performance without breaking the bank. With six different lighting effects and three brightness levels, it balances both brilliance and budget. Crafted with a durable, reinforced plastic frame, the Alloy Core RGB was constructed for stability and reliability for gamers who want a keyboard that will last.", 11, "Alloy Core RGB", "HYPERX ALLOY CORE RGB", 118.99m, 10, "HYPERX-ALLOY-CORE-RGB-BLACK", 24 },
                    { new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6"), new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7355), 6, "Processor AMD Ryzen Threadripper PRO 5965WX, 24 Cores / 48 Threads 3.8GHz (up to 4.5Ghz), Socket WRX8, 280W, 7nm", 37, "Ryzen Threadripper PRO 5965WX", "AMD RYZEN THREADRIPPER PRO 5965WX", 5818.57m, 10, "AMD-RYZEN-THREADRIPPER-PRO-5965WX", 36 },
                    { new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a"), new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7305), 6, "Processor AMD RYZEN 5 7600 6-Core 3.8 GHz (5.1 GHz Turbo) 32MB/65W/AM5/BOX", 38, "Ryzen 5 7600", "AMD RYZEN 5 7600", 543.05m, 10, "AMD-RYZEN-5-7600", 36 },
                    { new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2"), new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9842), 1, "The Logitech G502 X is an amazing gaming mouse that helps you crush your opponents on the virtual battlefield. It features the most innovative gaming functionalities, including the first-of-its-kind LIGHTFORCE hybrid optical-mechanical switches. This mouse guarantees you incredible speed and reliability, and its ultra-light weight of 89 grams guarantees you optimal comfort, even during prolonged use.", 12, "G502X", "LOGITECH G502X", 178.99m, 10, "LOGITECH-G502X-BLACK", 24 },
                    { new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082"), new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9482), 2, "Bloody S98 Naraka keyboard", 8, "S98 Naraka", "BLOODY S98 NARAKA", 148.99m, 10, "A4TECH-S98-NARAKA-BLACK", 24 },
                    { new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b"), new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2723), 13, "Corsair iCUE H100i Elite Capellix 240 White RGB AMD/INTEL CPU Cooler", 5, "iCUE H100i Elite Capellix 240", "CORSAIR ICUE H100I ELITE CAPELLIX", 371.56m, 10, "CORSAIR-ICUE-H100I-ELITE-CAPELLIX", 60 },
                    { new Guid("0ec80d70-22db-4952-bf93-99105299ca78"), new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(8840), 11, "Memory Corsair Vengeance RS RGB Black 32GB(2x16GB) DDR4 PC4-25600 3200MHz CL16 CMG32GX4M2E3200C16", 5, "Vengeance RS RGB Black 32GB(2x16GB) DDR4", "CORSAIR VENGEANCE RS RGB BLACK 32GB (2X16GB) 3200MHZ", 187.50m, 10, "CORSAIR-VEMGEANCE-32-3200", 99 },
                    { new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a"), new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5545), 4, "Meet the soft, smooth and anti-slip mouse pad that takes your workplace to new heights. Made of high-quality materials, the Logitech mouse pad gives you the glide and comfort you need for your favorite Logitech mouse.", 12, "MOUSE PAD STUDIO SERIES", "LOGITECH MOUSE PAD STUDIO SERIES", 15.00m, 10, "LOGITECH-MOUSE-PAD-STUDIO-SERIES-BLUE", 24 },
                    { new Guid("11c9e125-f0a0-485c-a12f-c47938729085"), new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9526), 8, "Solid State Drive (SSD) Silicon Power UD80 M.2-2280 PCIe Gen 3x4 NVMe 500GB", 16, "UD80 500GB", "SILICON POWER UD80 500GB", 59.86m, 10, "SILICON-POWER-UD80-500GB", 60 },
                    { new Guid("1208439d-df39-4445-9bdb-cce86277842b"), new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9826), 1, "The icon in racing gaming - Sensei Ten, improved with a new sensor and keeping the legendary shape. One of the most preferred shapes equipped with TrueMove Pro, a new high-quality polymer coating and improved switches to give you clarity with every click.", 14, "Sensei Ten", "STEELSERIES SENSEI TEN", 159.00m, 10, "STEELSERIES-SENSEI-TEN-BLACK", 24 },
                    { new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03"), new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7076), 6, "Processor Intel Pentium Gold G5600F, 3.9GHz, 4MB, 54W, LGA1151, BOX", 37, "Pentium Gold G5600F", "INTEL PENTIUM GOLD G5600F", 182.05m, 10, "INTEL-PENTIUM-GOLD-G5600F", 36 },
                    { new Guid("125d9fda-502a-4214-85ac-f746276bbb12"), new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7313), 6, "Processor AMD RYZEN 9 5900X 12-Core 3.7 GHz (4.8 GHz Turbo) 70MB/105W/AM4", 38, "Ryzen 9 5900X", "AMD RYZEN 9 5900X", 703.30m, 10, "AMD-RYZEN-9-5900X", 10 },
                    { new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"), new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5096), 12, "ROG Strix Helios is a premium mid-tower gaming case with three tempered-glass panels, refined aluminum frame and integrated front-panel RGB lighting. Built-in cable management, including a multifunction cover with GPU braces, keeps the interior sharp and tidy. Engineered for expandability and performance, it's ready for an up to EATX motherboard and serious water-cooling setups – making it the perfect choice for a classic ROG showcase build.", 1, "ROG STRIX HELIOS", "ASUS ROG STRIX HELIOS", 638.65m, 10, "ASUS-ROG-STRIX-HELIOS", 24 },
                    { new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0"), new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9695), 1, "Get the best out of your game with the G102 gaming mouse! It includes LIGHTSYNC technology, an optical sensor (intended for gaming) and a classic design with 6 buttons.", 12, "G102 LIGHTSYNC", "LOGITECH G102 LIGHTSYNC", 58.99m, 10, "LOGITECH-G102-LS-BK", 24 },
                    { new Guid("176d8c2e-8942-4732-a677-29c670c0c091"), new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9955), 1, "The PRO Wireless is designed to be the ultimate mouse for professional esports players! For 2 years, Logitech has partnered with more than 50 professional gamers to find the perfect shape, weight and feel, which is combined with wireless LIGHTSPEED technology and their HERO sensor. The result is a gaming mouse with unmatched performance and precision to give you the confidence you need to win.", 12, "G PRO", "LOGITECH G PRO", 259.00m, 10, "LOGITECH-G-PRO-BLACK", 24 },
                    { new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035"), new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9727), 2, "Геймърска механична клавиатура Ducky One 3 Pure White Mini 60% Hotswap Cherry MX Silver, RGB, PBT Keycaps", 21, "One 3 Mini DayBreak", "DUCKY ONE 3 MINI DAYBREAK", 309.80m, 10, "DUCKY-ONE-3-MINI-DAYBREAK-BLUE", 24 },
                    { new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f"), new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6527), 5, "The new generation of the XL series is already a fact! DyAc technology can now be with you at a much more affordable price, and in addition - an improved stand, smoother movements and software for easier control of monitor settings.", 25, "XL2411K", "ZOWIE XL2411K", 491.30m, 10, "ZOWIE-XL2411K", 36 },
                    { new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5"), new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(8867), 11, "Memory Kingston FURY Beast Black 32GB(4x8GB) DDR4 PC4-28800 3600MHz CL17 KF436C17BBK4/32", 18, "FURY Beast Black 32GB(4x8GB) DDR4", "KINGSTON FURY BEAST BLACK 32GB (4X8GB) 3600MHZ", 199.09m, 10, "KINGSTON-FURY-BEAST-BLACK-32-3600", 99 },
                    { new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831"), new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(8858), 11, "Memory ADATA XPG Lancer Black RGB 16GB DDR5 PC5-41600 5200MHz CL38 AX5U5200C3816G-CLABK", 39, "XPG Lancer Black RGB 16GB DDR5", "ADATA XPG LANCER BLACK RGB 16GB 5200MHZ", 114.00m, 10, "ADATA-XPG-LANCER-BLACK-16-5200", 99 },
                    { new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0"), new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9293), 8, "Solid State Drive (SSD) Gigabyte 256GB, 7mm", 15, "SSD 256GB", "GIGABYTE SSD 256GB", 33.65m, 10, "GIGABYTE-256GB", 36 },
                    { new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f"), new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2575), 13, "Arctic Freezer 34 eSports DUO Red processor cooler", 6, "Freezer 34 eSports DUO Red", "ARCTIC FREEZER 34 ESPORTS DUO", 90.76m, 10, "ARCTIC-FREEZER-34-ESPORTS-DUO-RED", 120 },
                    { new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44"), new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6451), 10, "Video card ASROCK AMD RADEON RX 7600 Steel Legend OC 8GB GDDR6", 26, "RADEON RX 7600 Steel Legend OC 8GB GDDR6", "ASROCK AMD RADEON RX 7600 STEEL LEGEND 8GB OC", 690.14m, 10, "ASROCK-RADEON-RX7600-STEEL-LEGEND", 36 },
                    { new Guid("20138228-3cb1-4a00-899e-ed40343018f9"), new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9457), 2, "Apex 3 TKL is the first waterproof TKL keyboard for e-sports, thanks to its advanced features, including optimized compact design without a number pad, silent gaming switches with low friction for over 20 million presses, anti-ghosting gaming technology, thanks to which you do not miss not a single attack, and gorgeous PrismSync RGB backlighting. The Apex 3 TKL is designed for everyday use and offers features sought after by gamers, including IP32 certification for water and dust resistance to protect against accidental spills, dedicated multimedia controllers and a three-way cable routing system.", 14, "Apex 3 TKL", "STEELSERIES APEX 3 TKL", 109.00m, 10, "STEELSERIES-APEX-3-TKL-BLACK", 24 },
                    { new Guid("208f2a40-db59-4499-b40d-368db5b3a634"), new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6556), 3, "Gaming headset HyperX Cloud Stinger Core (PC) 3.5mm jack with Microphone, Black", 11, "Cloud Stinger Core", "HYPERX CLOUD STINGER CORE", 79.00m, 10, "HYPERX-CLOUD-STRINGER-CORE-BLACK", 24 },
                    { new Guid("221245d9-e8d1-4d83-b950-889ac825d869"), new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2612), 13, "CPU Cooler ASUS ROG STRIX LC II 280 ARGB, AIO", 1, "ROG STRIX LC II 280 ARGB", "ASUS ROG STRIX LC II 280 ARGB", 379.00m, 10, "1", 72 },
                    { new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7"), new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5624), 4, "HyperX Fury - the textile addition to the HyperX pad portfolio. Fury will provide you with a smooth texture allowing you to move your mouse feet perfectly.", 11, "Fury S Speed M", "HYPERX FURY S SPEED M", 29.89m, 10, "HYPERX-FURY-S-SPEED-M-RED", 24 },
                    { new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4"), new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5600), 4, "The Bloody BP-50L gaming pad combines both types of speed/control surface, providing exceptional accuracy and comfort. The precise, consistent surface senses every mouse movement so you can hold every action yourself!", 8, "Bloody BP-50L", "BLOODY BP-50L", 18.00m, 10, "A4TECH-BLOODY-BP-50L-BLACK", 24 },
                    { new Guid("2403dada-744b-4347-b72a-6df00591f237"), new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9031), 11, "Memory T-Force Vulcan TUF 16GB (2x8GB) 1.35V", 41, "T-Force Vulcan TUF 16GB", "T-FORCE VULCAN TUF 16GB (2X8GB) 3200 MHZ", 86.24m, 10, "TEAM-GROUP-T-FORCE-VULCAN-TUF-16-3200", 99 },
                    { new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad"), new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6529), 10, "Video card GIGABYTE GTX 1660 SUPER 6GB GDDR6 192 Bit", 15, "GTX 1660 SUPER 6GB GDDR6 192 Bit", "GIGABYTE GEFORCE GTX 1660 SUPER D6 6G", 559.19m, 10, "GIGABYTE-GTX-1660-SUPER", 36 },
                    { new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6"), new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5617), 4, "Meet the soft, smooth and anti-slip mouse pad that takes your workplace to new heights. Made of high-quality materials, the Logitech mouse pad gives you the glide and comfort you need for your favorite Logitech mouse.", 12, "Desk Mat Studio Series", "LOGITECH DESK MAT STUDIO SERIES", 29.00m, 10, "LOGITECH-DESK-MAT-STUDIO-SERIES-PURPLE", 24 },
                    { new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac"), new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5801), 4, "World of WarCraft Shadowlands Gaming Pad - Bolvar, XL", 31, "World of WarCraft Shadowlands - Bolvar, XL", "WORLD OF WARCRAFT SHADOWLANDS - BOLVAR MOUSEPAD, XL", 59.00m, 10, "BLIZZARD-WORLD-OF-WARCRAFT-SHADOWLANDS-BOLVAR", 24 },
                    { new Guid("26f18072-6741-4ece-a5bc-977994a5268b"), new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9320), 8, "Solid State Drive (SSD) KINGSTON A400", 18, "A400 480GB", "KINGSTON A400 480GB", 51.61m, 10, "KINGSTON-A400-480GB", 36 },
                    { new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9"), new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5505), 7, "ASROCK B450M-HDV R4.0 motherboard", 26, "B450M-HDV R4.0", "ASROCK B450M-HDV R4.0", 124.36m, 10, "ASROCK-B450M-HDV-R4.0", 36 },
                    { new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6"), new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2749), 13, "CPU Cooler Corsair iCUE H170i Elite CAPELLIX XT 420mm Black RGB AMD/INTEL, CW-9060071-WW", 4, "iCUE H170i Elite CAPELLIX XT 420mm Black RGB", "CORSAIR ICUE H170I ELITE CAPELLIX XT LIQUID CPU COOLER", 644.32m, 10, "CORSAIR-ICUE-H170I-ELITE-CAPELLIX-XT", 60 },
                    { new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"), new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5894), 12, "Case Lian Li PC-O11 Dynamic Razer Edition Mid-Tower, Tempered Glass, Black", 3, "PC-O11 Dynamic Razer Edition", "LIAN LI PC-O11 DYNAMIC RAZER EDITION", 339.00m, 10, "LIAN-LI-PC-O11-DYNAMIC-RAZER-EDITION", 24 },
                    { new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0"), new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5635), 7, "Motherboard GIGABYTE H510M-K V2, socket 1200, Micro ATX", 15, "H510M-K V2", "GIGABYTE H510M K", 138.96m, 10, "GIGABYTE-H510M-K-V2", 36 },
                    { new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3"), new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5831), 4, "Brilliant 2-zone RGB dynamic lighting Easy and intuitive lighting notification setup during gameplay", 14, "Qck Prism Cloth XL", "STEELSERIES QCK PRISM CLOTH XL", 119.00m, 10, "STEELSERIES-QCK-PRISM-CLOTH-XL-BLACK", 24 },
                    { new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c"), new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7347), 6, "Processor Intel Raptor Lake i9-13900KF 24 Cores 4.3 GHz (Up to 5.8GHz) 36MB, 125W, LGA1700, BOX, No Graphics", 37, "Core I9-13900KF", "INTEL CORE I9-13900KF", 1274.40m, 10, "INTEL-CORE-I9-13900KF", 36 },
                    { new Guid("32987f00-ee05-40bf-aecd-e13297d74532"), new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5911), 12, "Kolink Observatory Lite Mesh RGB Mid-Tower Box, White", 2, "Observatory Lite Mesh RGB", "KOLINK OBSERVATORY LITE MESH ARGB WHITE", 178.99m, 10, "KOLING-OBSERVATORY-LITE-MESH-RGB", 24 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AddDate", "CategoryId", "Description", "ManufacturerId", "Model", "Name", "Price", "Quantity", "ReferenceNumber", "Warranty" },
                values: new object[,]
                {
                    { new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567"), new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9508), 8, "Solid State Drive (SSD) SILICON POWER A55", 16, "A55 256GB", "SILICON POWER A55 256GB", 29.42m, 10, "SILICON-POWER-A55-256GB", 60 },
                    { new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981"), new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9810), 1, "The Logitech G502 HERO is a gaming mouse that features an advanced optical sensor for maximum tracking accuracy, customizable RGB lighting, custom game profiles, from 200 to 16,000 DPI, and additional weights that can be configured to your feel and comfort.", 12, "G502 HERO", "LOGITECH G502 HERO", 138.00m, 10, "LOGITECH-G502-HERO-BLACK", 24 },
                    { new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d"), new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4815), 9, "Power supply FSP Group Hydro K PRO 600W 80+ Bronze", 33, "Group Hydro K PRO 750", "FSP HYDRO K PRO 750W", 158.60m, 10, "FS0-FROUP-HYPERK-PRO-750", 120 },
                    { new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"), new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5208), 12, "Cooler Master HAF 500 case", 4, "HAF 500", "COOLER MASTER HAF 500", 289.00m, 10, "COOLER-MASTER-HAF-500", 24 },
                    { new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070"), new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9777), 1, "HyperX Pulsefire Haste is a gaming optical mouse that is the company's first model in the super light segment. It comes equipped with a powerful Pixart PAW3335 optical sensor with a maximum DPI value of 16,000 and a speed of 450 IPS tracking. The shape is symmetrical, but the mouse is designed for right-handed use. Holes help reduce of weight, but also for better airflow and theoretically reduces palm sweating. Haste has an RGB underlay in 16.8 million colors, which you can adjust from the company's software, but unfortunately it is only in one area, when scrolling. Below the main two buttons are mechanical switches with a life of at least 60 million presses.", 11, "Pulsefire Haste", "HYPERX PULSEFIRE HASTE", 118.99m, 17, "HYPERX-PULSEFIRE-HASTE", 24 },
                    { new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6"), new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4780), 9, "Power supply Kolink Core 600W 80 PLUS", 2, "Core 600W 80 PLUS", "KOLINK CORE 600W", 88.57m, 10, "KOLINK-CORE-600", 24 },
                    { new Guid("39bc4103-3f11-481b-a859-f2eb720649ba"), new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6598), 5, "Monitor EIZO FlexScan EV2460, IPS, 23.8\" inch, Wide, Full HD, D-Sub, DVI, HDMI, DisplayPort, USB Hub, Black", 24, "FlexScan EV2460", "EIZO FLEXSCAN EV2460", 841.37m, 10, "EIZO-FLEXSCAN-EV2460", 36 },
                    { new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe"), new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4850), 9, "Power supply Thermaltake Thoughpower GF2 ARGB 750W (230V) 80+ Gold", 34, "Thoughpower GF2 ARGB 750W (230V) 80+ Gold", "THERMALTAKE THOUGHPOWER GF2 ARGB 750W", 273.90m, 10, "THERMALTAKE-THOUGHPOWER-GF2-GOLD-750", 60 },
                    { new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456"), new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5793), 4, "Blizzard Diablo Gaming Pad - Lilith", 31, "Diablo - Lilith", "BLIZZARD DIABLO - LILITH MOUSEPAD", 59.00m, 10, "BLIZZARD-DIABLO-LILITH", 24 },
                    { new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c"), new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7154), 6, "Processor AMD Ryzen 5 5600G, 3.9GHz(Up to 4.4GHz), 65W, AM4", 38, "Ryzen 5 5600G", "AMD RYZEN 5 5600G", 273.54m, 10, "AMD-RYZEN-5-5600G", 36 },
                    { new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7"), new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4965), 9, "System Power 10 750W has been built with price-conscious users in mind that do not want to dispense on reliability and quietness. Elaborated features such as a temperature-controlled fan and a remarkably low stand-by-drain underline the value System Power 10 750W offers even at entry-level. ", 36, "System Power 10 750W", "BE QUIET SYSTEM POWER 10 750W", 165.00m, 10, "BE-QUIET-SYSTEM-POWER-10-750", 60 },
                    { new Guid("4556d753-6a08-4457-b2a8-d772c054499e"), new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9500), 8, "Solid State Drive (SSD) SAMSUNG 990 PRO с Heatsink, 1TB, M.2 Type 2280, MZ-V9P1T0CW", 17, "990 PRO", "SAMSUNG 990 PRO W/ HEATSINK 1TB", 278.40m, 10, "SAMSUNG-990-PRO-1TB", 60 },
                    { new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702"), new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2740), 13, "CPU Cooler Corsair iCUE H150i Elite Capellix XT 360 White RGB AMD/INTEL, CW-9060073-WW", 5, "iCUE H150i Elite Capellix XT 360 White RGB", "CORSAIR ICUE H150I ELITE CAPELLIX XT", 565.90m, 10, "CORSAIR-ICUE-H150I-ELITE-CAPELLIX-XT", 60 },
                    { new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7"), new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6577), 5, "Monitor HyperX ARMADA 25 240Hz, IPS, 24.5 inch, Wide, Full HD, HDMI, DP, Black", 11, "ARMADA 25\"", "HYPERX ARMADA 25\"", 779.02m, 10, "HYPERX-ARMADA-25", 36 },
                    { new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd"), new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9850), 1, "The G703 LIGHTSPEED takes precision to another level. Get ready for unique tracking and precision from our latest sensor, which is 10 times more battery-efficient than the previous model. Add POWERPLAY and you'll never think about the battery again.", 12, "G703", "LOGITECH G703", 189.00m, 10, "LOGITECH-G703-BLACK", 24 },
                    { new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"), new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5199), 12, "With the MasterBox MB511 ARGB ATX PC case, systems built for high demand gaming can breathe easily through the Fine Mesh front panel. Along with the aggressive intakes in front, there is also ventilation on the top panel for added thermal support.", 4, "MasterBox MB511 ARGB", "COOLER MASTER MASTERBOX MB511 ARGB", 199.00m, 10, "COOLER-MASTER-MASTERBOX-MB511-ARGB", 24 },
                    { new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6"), new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9358), 8, "Solid State Drive (SSD) SAMSUNG 970 EVO Plus", 17, "970 EVO PLUS 250GB", "SAMSUNG 970 EVO PLUS 250GB", 64.82m, 10, "SAMSUNG-970-EVO-250GB", 60 },
                    { new Guid("50c72822-3c58-4689-bb12-171629bfce1a"), new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6529), 3, "Made of high-quality materials for maximum comfort even after hours of computer adventures. Even the most demanding gamers will be impressed by the elegant design. The large earcups cover the entire ear, eliminate all noise and provide comfort even during long hours of listening. Omni-Directional microphone to suppress background noise LED lighting in 7 colors emphasize the atmosphere of the game", 8, "Bllody G521", "BLOODY G521", 43.76m, 10, "A4TECH-BLOODY-G521-BLACK", 24 },
                    { new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"), new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5225), 12, "Box Corsair iCUE 220T RGB Smart Mid Tower, Tempered Glass, Black", 5, "iCUE 220T RGB", "CORSAIR ICUE 220T RGB TG", 297.78m, 10, "CORSAIR-ICUE-220T-RGB", 24 },
                    { new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7"), new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9213), 8, "Solid State Drive (SSD) Gigabyte M.2 Nvme PCIe SSD", 15, "NVME SSD 256GB", "GIGABYTE NVME SSD 256GB", 37.68m, 10, "GIGABYTE-NVME-256GB", 60 },
                    { new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"), new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5877), 12, "Lian-Li LANCOOL 216 RGB Mid-Tower Box, Tempered Glass, White", 3, "LANCOOL 216 RGB", "LIAN LI LANCOOL 216 RGB", 229.00m, 10, "LIAN-LI-LANCOOL-216-RGB", 24 },
                    { new Guid("57815913-af9e-4ad4-bc57-b22706866cd2"), new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9311), 8, "Solid State Drive (SSD) Gigabyte AORUS NVMe Gen4", 15, "AORUS NVMe Gen4", "GIGABYTE AORUS NVME GEN4 2TB", 265.86m, 10, "GIGABYTE-AORUS-NVME-GEN4-2TB", 60 },
                    { new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7"), new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5787), 7, "Motherboard ASUS ROG STRIX B660-A GAMING WIFI D4, LGA 1700 ATX, 4x DDR4, WiFi 6, 3x M.2, Aura Sync RGB", 1, "ROG STRIX B660-A GAMING WIFI D4", "ASUS ROG STRIX B660-A GAMING WIFI D4", 439.00m, 10, "ASUS-ROG-STRIX-B660-A-GAMING-WIFI-D4", 36 },
                    { new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943"), new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6620), 5, "Monitor ASUS ZenScreen MQ16AH – 15.6\", FHD (1920 x 1080) OLED, 1ms, USB-C, Mini HDMI, HDR-10", 1, "ZENSCREEN OLED MQ16AH", "ASUS ZENSCREEN OLED MQ16AH", 1039.00m, 10, "ASUS-ZENSCREEN-OLED-MQ16AH", 36 },
                    { new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1"), new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4868), 9, "Pure Power 11 FM 650W is certified 80 PLUS Gold with an efficiency rating of up to 93.3% – a truly outstanding level for this class of PSU. The most compelling benefit: lower power consumption and consequently lower costs, and cooler, quieter operation.", 36, "Pure Power 12", "BE QUIET PURE POWER 12 650W", 236.00m, 10, "BE-QUIET-PURE-POWER-650", 60 },
                    { new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a"), new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4859), 9, "Power supply NZXT C650, 650W 80+ Bronze Semi Modular", 35, "C650", "NZXT C650 BRONZE", 181.15m, 10, "NZXT-C650-650", 120 },
                    { new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e"), new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4842), 9, "Power supply ASUS TUF Gaming 850W, 80+ Gold PCIe 5.0, Fully Modular", 1, "TUF Gaming 850W", "ASUS TUF GAMING 850W GOLD", 323.29m, 10, "ASUS-TUF-GAMING-GOLD-850", 120 },
                    { new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c"), new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2637), 13, "The legendary Hyper air cooler is back and better than ever. The Hyper 212 Black Edition offers better installation and great performance, easily one of the best air cooling solutions out there. The aluminum top cover and nickel-plated black fins give the Hyper 212 Black Edition a premium aesthetic appeal. The sleek jet black not only makes it look great, but also boosts cooling efficiency.", 4, "Hyper 212 Black Edition", "COOLER MASTER HYPER 212 BLACK EDITION LGA1700", 88.99m, 10, "COOLER-MASTER-HYPER-212-BLACK-EDITION", 24 },
                    { new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470"), new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4797), 9, "Power supply Cooler Master Elite Nex 600W 230V, 80+ White", 4, "Elite Nex 600W 230V", "COOLER MASTER ELITE NEX WHITE 600W", 124.99m, 10, "COOLER-MASTER-ELITE-NEX-WHITE-600", 36 },
                    { new Guid("5fa226cc-43f9-4f16-8849-7331be60090d"), new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9658), 2, "The CK351 full-size gaming keyboard delivers responsive controls in reliable hardware that's rated to outlast your most intense nights. IP58 dustproof and waterproof with state-of-the-art optical switches rated for over 100 million keystrokes - and a bounce time that's practically instantaneous. Add to that fully customizable RGB lighting, media controls and Cooler Master's signature On-the-Fly control system and you have a solid, rugged workhorse that gets the job done.", 4, "CK351", "COOLER MASTER CK351", 199.00m, 10, "COOLER-MASTER-CK351-SILVER", 24 },
                    { new Guid("5fe0b265-d074-4864-9526-966405759eff"), new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9692), 2, "Logitech G Pro League of Legends GX Brown Tactile RGB Gaming Mechanical Keyboard", 12, "G PRO League of legends", "LOGITECH G PRO LEAGUE OF LEGENDS", 238.80m, 10, "LOGITECH-G-PRO-LEAGUE-OF-LEGENDS-BLUE", 24 },
                    { new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"), new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5886), 12, "Box Lian Li PC-O11 Dynamic Mid-Tower, Tempered Glass, White", 3, "PC-O11 Dynamic", "LIAN LI PC-O11 DYNAMIC", 319.00m, 10, "LIAN-LI-PC-O11-DYNAMIC", 24 },
                    { new Guid("637d8089-3235-4896-a213-2b85771393c5"), new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9750), 1, "The Rival 3 uses mechanical switches to sense every click and is built from the most durable materials. The improved TrueMove Core optical sensor is optimized and uses Steelseries true 1-to-1 tracking technology. The new Rival has 3-zone backlighting and a choice of 16.8 million colors.", 14, "Rival 3", "STEELSERIES RIVAL 3", 78.96m, 12, "STEELSERIES-RIVAL-3", 24 },
                    { new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"), new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6630), 3, "Logitech PRO X 2 LIGHTSPEED wireless gaming headset", 12, "PRO X 2 Lightspeed", "LOGITECH PRO X 2 LIGHTSPEED", 499.00m, 10, "LOGITECH-PRO-X-2-LIGHTSPEED-WHITE", 24 },
                    { new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"), new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5188), 12, "Cooler Master MasterBox TD300 Mesh box", 4, "MasterBox TD300 Mesh", "COOLER MASTER MASTERBOX TD300 MESH", 169.00m, 10, "COOLER-MASTER-MASTERBOX-TD300-MESH", 24 },
                    { new Guid("65386f80-3659-4dc5-873b-572afdd12461"), new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6589), 3, "Logitech PRO X Gaming Headset", 12, "G PRO X", "LOGITECH G PRO X", 208.99m, 10, "LOGITECH-G-PRO-X-BLACK", 24 },
                    { new Guid("661acb6b-83fb-4039-bb91-098f97aa394a"), new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6540), 5, "Gaming Monitor Gigabyte M27F-A SS IPS, 1920 x 1080 (FHD), KVM, 165hz, 1ms", 15, "M27F A", "GIGABYTE M27F A", 562.50m, 10, "GIGABYTE-M27F-A", 36 },
                    { new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"), new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6613), 3, "Go beyond the mundane to Almighty Audio - a superior combination of hardware and software. The Nova Acoustic system features custom audio drivers, immersive 360° audio surround, and 10-band parametric EQ from Sonar software. Listen to two audio streams simultaneously with 2.4GHz and Bluetooth, easily switching between PC, Mac, PlayStation and Switch with USB-C. Stay powered up with a 38-hour battery and a quick charge feature that delivers 6 hours of use in just 15 minutes. Enjoy noise-free communications as AI algorithms guide the 2nd generation ClearCast microphone to clear incoming and outgoing team chat audio. The ComfortMax system offers 4 adjustment points and breathable AirWeave memory foam cushions.", 14, "Arctis Nova 7", "STEELSERIES ARCTIS NOVA 7", 388.99m, 10, "STEELSERIES-ARCTIS-NOVA-7-BLACK", 24 },
                    { new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4"), new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5812), 7, "Motherboard ASROCK Z790 TAICHI Wi-Fi 6E, LGA 1700, DDR5, PCIe 5.0", 26, "Z790 TAICHI Wi-Fi 6E", "ASROCK Z790 TAICHI", 1070.64m, 10, "ASROCK-Z790-TAICHI", 36 },
                    { new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49"), new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9802), 1, "Tested and developed by a team of passionate gamers who accept nothing short of perfection, we present you the Model D, which aims to elevate your gaming experience to new heights. Designed to offer incredible speed, control and comfort, all wrapped up in an ultra-light and premium mouse to take you to the highest level of E-sport gaming!", 30, "Model D (Matte White)", "GLORIOUS MODEL D (MATTE WHITE)", 129.00m, 10, "GLORIOUS-MODEL-D-MATTE-WHITE", 24 },
                    { new Guid("684eb60e-08df-4c0c-a30a-6c1294673988"), new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5779), 7, "Motherboard ASUS PRIME H670-PLUS D4, LGA 1700 ATX, 4x DDR4, 3x M.2, Aura Sync RGB", 1, "PRIME H670-PLUS D4", "ASUS PRIME H670-PLUS D4", 372.01m, 10, "ASUS-PRIME-H670-PLUS-D4", 36 },
                    { new Guid("689b3a84-261c-4512-904c-c7fed46365be"), new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4806), 9, "Power supply Corsair CV650, 80+ BRONZE 650W", 5, "CV650", "CORSAIR CV650W", 155.41m, 10, "CORSAIR-CV650W-650", 36 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AddDate", "CategoryId", "Description", "ManufacturerId", "Model", "Name", "Price", "Quantity", "ReferenceNumber", "Warranty" },
                values: new object[,]
                {
                    { new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e"), new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4788), 9, "The new HYPER K PRO PSUs fully comply with ATX12 v2.52 standard and latest safety 62368 regulation as well, and features with all black and high-grade ribbon cables, will give your PC a polished look. The HYPER K PRO series is characterized by a powerful single +12V rail design that continuously delivers maximum performance for the most demanding components, while FSP's custom DC-DC design provides safety and power efficiency.", 33, "Group Hyper K PRO 500", "FSP GROUP HYPER K PRO 500W", 109.48m, 10, "FSP-GROUP-HYPER-K-PRO-500", 60 },
                    { new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5"), new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6502), 5, "Monitor 24\" Samsung 24AG320 Odyssey - LS24AG320NUXEN", 17, "24AG320 ODYSSEY G3", "SAMSUNG 24AG320 ODYSSEY G3", 388.99m, 10, "SAMSING-24AG320-ODYSSEY-G3", 36 },
                    { new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5"), new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5804), 7, "Motherboard ASROCK Z790 PRO RS, LGA 1700, DDR5, PCIe 5.0", 26, "Z790 PRO RS", "ASROCK Z790 PRO RS", 457.32m, 10, "ASROCK-Z790-PRO-RS", 36 },
                    { new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d"), new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5823), 4, "Control for precision shooting or speed? Rocket Jump Ninja's specially selected materials are a good mix between the two extremes and strike the right balance.", 19, "GPZ1", "XTRFY GPZ1", 79.00m, 10, "XTRFY-GPZ1-BLACK", 24 },
                    { new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536"), new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4824), 9, "Power supply Seasonic SSR-650FX, 650W, 80+ GOLD", 32, "SSR-650FX", "SEASONIC FOCUS PLUS 650 GOLD 650W", 225.16m, 10, "SEASONIC-FOCUS-PLUS-650-GOLD-650W", 120 },
                    { new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be"), new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7322), 6, "Processor AMD RYZEN 7 7700 8-Core 3.8 GHz (5.3 GHz Turbo) 32MB/65W/AM5/BOX", 38, "Ryzen 7 7700", "AMD RYZEN 7 7700", 784.92m, 10, "AMD-RYZEN-7-7700", 36 },
                    { new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6"), new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9760), 1, "Lightweight construction. Modern components. Unique shape for right hand. The Xtrfy M4 takes the performance, feel and durability of lightweight gaming mice to the next level.", 19, "M4 RGB Street", "XTRFY M4 RGB STREET", 88.99m, 9, "XTRFY-M4-RGB-STREET", 24 },
                    { new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134"), new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9367), 8, "Solid State Drive (SSD) SAMSUNG 870 EVO SATA 2.5”, 500GB, SATA 6 Gb/s, MZ-77E500B/EU", 17, "870 EVO 500GB", "SAMSUNG 870 EVO 500GB", 82.61m, 10, "SAMSUNG-870-EVO-500GB", 36 },
                    { new Guid("711b7764-c49d-4d92-9c03-2385ed109930"), new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6539), 3, "Boost your productivity with the Plantronics RIG 300 PC headset. SoundGuard technology protects you from audio distortion, and the ventilated earcups and lightweight frame provide a comfortable, ultra-stable shape.", 9, "RIG 300", "PLANTRONICS RIG 300", 49.99m, 10, "PLANTRONICS-RIG-300-BLACK", 24 },
                    { new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b"), new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7128), 6, "Processor AMD Ryzen 5 5500, AM4 Socket, 6 Cores, 12 Threads, 3.6GHz(Up to 4.2GHz), 19MB Cache, 65W, BOX", 38, "Ryzen 5 5500", "AMD RYZEN 5 5500", 215.20m, 10, "AMD-RYZEN-5-5500", 36 },
                    { new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad"), new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9768), 1, "Pro gamers know that if they don't improve their skills sooner or later someone will beat them, and the same goes for peripherals. Take your mini to the next level with the HyperX Pulsefire FPS Pro RGB Add RGB style and dish out headshots to anyone who has the imprudence to come near you. Pulsefire FPS Pro uses a high-end Pixart 3389 sensor that will give you up to 16,000 DPI without hardware acceleration to have speed and accuracy far superior to your enemies.", 11, "Pulsefire FPS PRO", "HYPERX PULSEFIRE FPS PRO", 99.00m, 6, "HYPERX-PULSEFIRE-FPS-PRO", 24 },
                    { new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2"), new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9127), 11, "Memory Corsair Dominator Platinum RGB Black 16GB(2x8GB) DDR4 PC4-28800 3600MHz CL18 CMT16GX4M2C3600C18", 5, "Dominator Platinum RGB Black 16GB(2x8GB) DDR4", "CORSAIR DOMINATOR PLATINUM RGB BLACK 16GB (2X8GB) 3600MHZ", 312.04m, 10, "CORSAIR-DOMINATOR-PLATINUM-16-3600", 99 },
                    { new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b"), new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5591), 7, "ASUS Prime series is expertly engineered to unleash the full potential of the 3rd Generation AMD Ryzen platform. Boasting a robust power design, comprehensive cooling solutions and intelligent tuning options, Prime B550 series motherboards provide daily users and DIY PC builders a range of performance tuning options via intuitive software and firmware features.", 1, "PRIME B550-PLUS", "ASUS PRIME B550-PLUS", 355.20m, 10, "ASUS-PRIME-B550-PLUS", 36 },
                    { new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07"), new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6375), 5, "With 1ms GTG response time, 75Hz refresh rate, dynamic ratio and HDMI connectivity, BenQ's GL2480 LED gaming monitor brings you every detail of the image with the best viewing quality.", 22, "GL2480", "BENQ GL2480", 259.85m, 10, "BENQ-GL2480", 36 },
                    { new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66"), new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9643), 2, "HyperX Alloy Origins Core tenkeyless keyboard featuring custom HyperX mechanical switches designed to give gamers the best combination of style, performance and reliability. The keyboard has an open design for stunning RGB lighting. The Alloy Origins Core is built with an all-aluminum body. It has legs that allow you to choose from three different levels of incline. Sleek and compact design frees up space for mouse movement.", 11, "Alloy Origins Core", "HYPERX ALLOY ORIGINS CORE", 199.00m, 10, "HYPERX-ALLOY-ORIGINS-CORE-BLACK", 24 },
                    { new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a"), new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2707), 13, "Cooler Master MasterLiquid ML240 Illusion processor cooler", 4, "MasterLiquid ML240 Illusion", "COOLER MASTER MASTERLIQUID ML240 ILLUSION", 199.00m, 10, "COOLER-MASTER-MASTERLIQUID-ML240-ILLUSION", 36 },
                    { new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6"), new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9534), 8, "Solid State Drive (SSD) Silicon Power A60 M.2-2280 PCIe Gen 3x4 NVMe 1ТB", 16, "P34A60 1TB", "SILICON POWER P34A60 1TB", 112.88m, 10, "SILICON-POWER-P34A60-1TB", 60 },
                    { new Guid("796faaca-ca93-4081-9a23-b90191c6c28c"), new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6490), 5, "Minimalist design for maximum concentration. The frameless display on 3 sides gives a modern and uncluttered aesthetic touch to any work environment.", 17, "S31C", "SAMSUNG S31C 27\"", 319.00m, 10, "SAMSUNG-S31C-27", 36 },
                    { new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf"), new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4833), 9, "Power supply Seasonic SSR-850FX, 850W, 80+ GOLD", 32, "SSR-850FX", "SEASONIC FOCUS PLUS 850W GOLD", 343.62m, 10, "SEASONIC-FOCUS-PLUS-GOLD-850", 120 },
                    { new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558"), new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5627), 7, "Motherboard GIGABYTE H410M S2H 1.0, Socket 1200 (400 Series), 2 x DDR4", 15, "H410M S2H 1.0", "GIGABYTE H410M S2H", 133.56m, 10, "GIGABYTE-H410M-S2H-1.0", 36 },
                    { new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"), new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5161), 12, "Box ASUS TUF Gaming GT502, Mid-Tower, Aura Sync RGB", 1, "TUF GAMING GT502", "ASUS TUF GAMING GT502", 349.00m, 10, "ASUS-TUF-GAMING-GT5O2", 24 },
                    { new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"), new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5171), 12, "Box ASUS TUF Gaming GT301 ARGB, Mid-Tower", 1, "TUF GAMING GT301", "ASUS TUF GAMING GT301", 219.00m, 10, "ASUS-TUF-GAMING-GT301", 24 },
                    { new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383"), new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(8986), 11, "Memory Kingston Fury Renegade Black RGB 32GB DDR5 PC5-48000 6000MHz CL32 KF560C32RSA-32", 18, "Fury Renegade Black RGB 32GB DDR5", "KINGSTON FURY RENEGADE SILVER RGB 32GB 6000MHZ", 278.44m, 10, "KINGSTON-FURY-RENEGADE-SILVER-RGB-32-6000", 99 },
                    { new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f"), new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2530), 13, "CPU Cooler ARCTIC Freezer i35 Black/White", 6, "Freezer i35", "ARCTIC FREEZER I35", 55.12m, 10, "ARCTIC-FREEZER-I35", 120 },
                    { new Guid("7e0cdafa-a356-4245-9b25-a8864857109b"), new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6478), 10, "Video card ASUS DUAL GeForce RTX 4060 OC 8GB GDDR6", 1, "DUAL GeForce RTX 4060 OC 8GB GDDR6", "ASUS DUAL GEFORCE RTX 4060 OC EDITION 8G", 750.42m, 10, "ASUS-DUAL-RTX-4060-OC", 36 },
                    { new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0"), new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6792), 5, "Monitor ASUS ROG Swift OLED PG27AQDM - 27 inch WQHD (2560 x 1440), OLED, 240Hz, 0.3ms, HDR10, G-SYNC Compatible", 1, "ROG Swift OLED PG27AQDM", "ASUS ROG SWIFT OLED PG27AQDM", 2349.00m, 10, "ASUS-ROG-SWIFT-OLED-PG27AQDM", 36 },
                    { new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"), new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6572), 3, "HyperX Cloud Core Gaming Headset", 11, "Cloud Code", "HYPERX CLOUD CORE", 159.00m, 10, "HYPERX-CLOUD-CORE-BLACK", 24 },
                    { new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546"), new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9494), 2, "The K6 has included keycaps for both Windows and Mac operating systems. Hot-swappable version comes with Gateron switch pre-installed.", 20, "K6", "KEYCHRON K6", 169.00m, 10, "KEYCHRON-K6-BLACK", 24 },
                    { new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60"), new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2715), 13, "Cooler Master builds on the classic MasterLiquid L series to present a redesigned and improved edition of the MasterLiquid 360L Core ARGB White. With new design elements that bring a classic minimalist look to the series, the MasterLiquid 360L Core ARGB White represents Cooler Master's continued innovative spirit.", 4, "MasterLiquid 360L Core ARGB White Edition", "COOLER MASTER MASTERLIQUID 360L CORE ARGB WHITE", 268.99m, 10, "COOLER-MASTER-MASTERLIQUID-360L-CORE-ARGB-WHITE-EDITION", 24 },
                    { new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed"), new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7145), 6, "Processor Intel Rocket Lake Core i5-11400F, 6 Cores, 2.60Ghz (Up to 4.40Ghz), 12MB, 65W, LGA1200, BOX", 37, "Core I5-11400F", "INTEL CORE I5-11400F", 289.84m, 10, "INTEL-CORE-I5-11400F", 36 },
                    { new Guid("87139a76-a325-4046-a973-e5dc072dc258"), new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7137), 6, "Processor Intel Raptor Lake Core i3-13100F, 4 Cores, 8 Threads (3.4GHz Up to 4.6Ghz, 12MB, LGA1700), 60W, BOX", 37, "Core I3-13100F", "INTEL CORE I3-13100F", 250.97m, 10, "INTEL-CORE-I3-13100F", 36 },
                    { new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"), new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5919), 12, "Box Kolink Void Rift RGB TG Midi-Tower Black Window ATX", 2, "Void Rift RGB", "KOLINK VOID RIFT", 199.00m, 10, "KOLING-OBSERVATORY-LITE-MESH-RGB", 24 },
                    { new Guid("89e3e4de-4748-4c4a-b018-89946185aecd"), new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5583), 7, "ASRock B550 PRO4 motherboard", 26, "B550 PRO4", "ASROCK B550 PRO4", 260.95m, 10, "ASROCK-B550-PRO4", 36 },
                    { new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d"), new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6487), 10, "Video card ASUS TUF Gaming GeForce RTX 3060 V2 OC Edition 12GB GDDR6", 1, "TUF Gaming GeForce RTX 3060 V2 OC Edition 12GB GDDR6", "ASUS TUF GAMING GEFORCE RTX 3060 V2 OC EDITION 12G", 899.00m, 10, "ASUS-TUF-GAMING-GEFORCE-RTX-3060-OC", 36 },
                    { new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044"), new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5610), 7, "Motherboard ASROCK B650E Steel Legend WiFi, Socket AM5, ATX, 4xDDR5", 26, "B650E Steel Legend WiFi", "ASROCK B650E STEEL LEGEND WIFI", 590.80m, 10, "ASROCK-B650E-STEEL-SERIES-WIFI", 36 },
                    { new Guid("8d4089ec-9f65-450b-9f74-337390c86144"), new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6609), 5, "NEC MultiSync EA271F monitor", 27, "EA271F", "NEC EA271F", 955.20m, 10, "NEC-EA271F", 36 },
                    { new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9"), new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9517), 8, "Solid State Drive (SSD) Silicon Power UD85, M.2-2280, PCIe Gen 4x4, NVMe, 250GB, SP250GBP44UD8505", 16, "UD85 250GB", "SILICON POWER UD85 250GB", 48.18m, 10, "SILICON-POWER-UD85-250GB", 60 },
                    { new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"), new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5902), 12, "Box Kolink Void Midi-Tower black Window ATX", 2, "Void", "KOLINK VOID", 139.00m, 10, "KOLING-VOID", 24 },
                    { new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02"), new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9818), 1, "Ergonomic design, fully intended for right-handed users. Offers users room for wrist movements. The right side of the mouse has a well-rounded shape. This allows the user's fingers to hold/cover the mouse and provides smooth movement. And now with Paracord cable and reduced weight.", 25, "EC3-C", "ZOWIE EC3-C", 149.00m, 10, "ZOWEI-EC3-C-BLACK", 24 },
                    { new Guid("91661960-9390-47c3-ab98-9b9e19269b02"), new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6645), 3, "The new TUF Gaming H3 gaming headset is designed to provide incredible comfort and durability to gamers who play or stream for extended periods of time. With its lightweight construction, fast-cooling ASUS ear cushions, stainless steel headband, 50mm ASUS Essence drivers and sealed chamber design, the TUF Gaming H3 headset enhances your in-game audio experience with rich and immersive sound.", 1, "Gaming headphones ASUS TUF Gaming H3 Blue, 7.1 Virtual Surround Sound", "ASUS TUF GAMING H3", 88.80m, 10, "ASUS-TUF-GAMING-H3-BLACK-BLUE", 24 },
                    { new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2"), new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5639), 4, "Our mouse pads are used by both professionals and enthusiasts around the world. The special surface provides a unique combination of speed and control, making the pads ideal for any situation. All of our mouse pads also feature stitched edges that prevent wear and tear, greatly increasing aesthetics and lifespan. Thanks to our high-quality workmanship, these pads are also washable.", 30, "L White", "GLORIOUS L WHITE", 37.09m, 10, "GLORIOUS-L-WHITE", 24 },
                    { new Guid("92089877-a384-404f-b813-f02236406a7e"), new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7330), 6, "Processor Intel Raptor Lake i7-13700F 8P+8E Cores 2.10 GHz (Up to 5.2GHz) 30MB, 65W, LGA1700, BOX, No Graphics", 37, "Core I7-13700F", "INTEL CORE I7-13700F", 856.63m, 10, "INTEL-CORE-I7-13700F", 36 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AddDate", "CategoryId", "Description", "ManufacturerId", "Model", "Name", "Price", "Quantity", "ReferenceNumber", "Warranty" },
                values: new object[,]
                {
                    { new Guid("938085a4-745e-4e76-851b-dada0ed1a06f"), new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9704), 2, "Ducky One 2 Mini V2 White RGB has an updated frame design and PBT plastic keys, which ensure durability and beauty whether you will use it in the office, at home or for gaming. Ducky features Cherry MX switches that have a durability of over 50 million keystrokes. Each Ducky One 2 keyboard can change its height for maximum comfort while working or playing. The keyboard also features a USB-C output on the chassis, which minimizes lag when pressing keys and receiving a signal from your PC.", 21, "One 2 Mini Pure White V2", "DUCKY ONE 2 MINI PURE WHITE V2", 259.00m, 10, "DUCKY-ONE-2-MINI-PURE-V2-WHITE", 24 },
                    { new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18"), new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6470), 10, "Video card ASROCK AMD RADEON RX 7900 XTX Taichi White OC 24GB GDDR6, RX7900XTX TCW 24GO", 26, "RADEON RX 7900 XTX Taichi", "ASROCK RADEON RX 7900 XTX TAICHI WHITE 24GB OC", 2437.45m, 10, "ASROCK-RADEON-RX7900XTX-TAICHI", 36 },
                    { new Guid("98322a27-9cbc-4666-8392-0f245afb62aa"), new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9793), 1, "Designed and developed by a team of passionate gamers who accept nothing short of perfection, we present the Model O, which aims to elevate your gaming experience to new heights. Designed to offer incredible speed, control and comfort, all wrapped up in an ultra-light and premium mouse to take you to the highest level of E-sport gaming!", 30, "Model O (Glossy Black)", "GLORIOUS MODEL O (GLOSSY BLACK)", 129.00m, 10, "GLORIOUS-MODEL-O-GLOSSY-BLACK", 24 },
                    { new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19"), new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6381), 10, "Video card ASRock AMD Radeon RX 6600 Challenger D 8G", 26, "Radeon RX 6600 Challenger D 8G", "ASROCK AMD RADEON RX 6600 CHALLENGER D 8G", 278.44m, 10, "ASROCK-RADEON-RX6600-CHALLENGER", 24 },
                    { new Guid("9c847a36-b5be-465e-993e-472f1135de58"), new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5216), 12, "Corsair 4000D Mid Tower Case, Tempered Glass, White", 5, "4000D", "CORSAIR 4000D TG", 237.64m, 10, "CORSAIR-4000D", 24 },
                    { new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539"), new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5778), 4, "The MP511 mouse pad is an upgrade in every sense of the word, featuring the legendary CORDURA® fabric for enhanced durability, impeccable splash resistance and smooth performance for generations of battles to come.", 4, "MP511 XL", "COOLER MASTER MP511 XL", 49.00m, 10, "COOLER-MASTER-MP511-XL", 24 },
                    { new Guid("9d1fc184-5111-405f-bc08-686cf2086357"), new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6475), 5, "Monitor ASUS TUF GAMING VG246H1A 23.8\" IPS Full HD 1920 x 1080, Frameless, 0.5 ms MPRT, 100Hz FreeSync, ELMB", 1, "TUF GAMING VG246H1A", "ASUS TUF GAMING VG246H1A", 309.00m, 10, "ASUS-TUF-GAMING-VG246H1A", 36 },
                    { new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233"), new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6566), 5, "Gaming monitor ROG Strix XG249CM – 23.8\" inches Full HD (1920 x 1080), 270Hz, 1ms GTG, Extreme Low Motion Blur Sync, 105% sRGB, FreeSync Premium, HDR", 1, "ROG Strix XG249CM", "ASUS ROG STRIX XG249CM", 769.00m, 10, "ASUS-ROG-STRIX-XG249CM", 36 },
                    { new Guid("9df7c2cd-486d-481a-b047-6d55e9ffafa8"), new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9303), 8, "Solid State Drive (SSD) Gigabyte AORUS 5000E 500GB, NVMe, PCIe Gen4, AG450E500G-G", 15, "AORUS 5000E 500GB", "GIGABYTE AORUS GEN4 5000E SSD 500GB", 85.34m, 10, "GIGABYTE-AORUS-5000E-500GB", 60 },
                    { new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7"), new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(8997), 11, "Memory G.SKILL Trident Z RGB 16GB(2x8GB) DDR4 PC4-25600 3200MHz CL16 F4-3200C16D-16GTZR", 40, "Trident Z RGB 16GB(2x8GB) DDR4", "G.SKILL TRIDENT Z RGB 16GB (2X8GB) 3200MHZ", 137.18m, 10, "GKILL-TRIDENT-Z-RGB-16-3200", 99 },
                    { new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab"), new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6496), 10, "Video card ASUS Dual GeForce RTX 3060 TI OC Edition White 8GB GDDR6X", 1, "Dual GeForce RTX 3060 TI OC Edition White 8GB GDDR6X", "ASUS DUAL GEFORCE RTX 3060 TI WHITE OC EDITION 8GB", 949.00m, 10, "ASUS-DUAL-GEFORCE-RTX-3060TI-OC", 36 },
                    { new Guid("a17622b2-2710-4c88-83a2-477d1292400c"), new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2696), 13, "CPU Cooler Cooler Master Hyper 212 HALO Black Edition, AMD/INTEL", 4, "Hyper 212 HALO Black Edition", "COOLER MASTER HYPER 212 HALO BLACK", 99.00m, 10, "COOLER-MASTER-HYPER-212-HALO-BLACK-EDITION", 24 },
                    { new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1"), new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2732), 13, "Corsair iCUE H115i Elite Capellix 280 Black RGB AMD/INTEL Processor Cooler", 5, "iCUE H115i Elite Capellix 280 Black RGB", "CORSAIR ICUE H115I ELITE CAPELLIX LIQUID CPU COOLER", 431.65m, 10, "CORSAIR-ICUE-H115I-ELITE-CAPELLIX", 60 },
                    { new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9"), new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9349), 8, "Solid State Drive (SSD) Kingston FURY Renegade PCIe 4.0 NVMe M.2 SSD 500GB", 18, "FURY Renegade PCIe 4.0 NVMe M.2 SSD 500GB", "KINGSTON FURY RENEGADE 500GB NVME", 122.44m, 10, "KINGSTON-FURY-RENEGATE-500GB", 60 },
                    { new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3"), new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5808), 4, "World of WarCraft Classic Gaming Pad - Ragnaros, XL", 31, "World of WarCraft Classic - Ragnaros, XL", "WORLD OF WARCRAFT CLASSIC - RAGNAROS MOUSEPAD, XL", 59.00m, 10, "BLIZZARD-WORLD-OF-WARCRAFT-CLASSIC-RAGNAROS", 24 },
                    { new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372"), new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4976), 9, "Power supply Cooler Master V850 Gold - V2 (White Edition), Full Modular", 4, "V850 Gold - V2 (White Edition)", "COOLER MASTER V850 GOLD - V2 (WHITE EDITION) 850W", 319.00m, 10, "COOLER-MASTER-V850-WHITE-GOLD-850", 120 },
                    { new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb"), new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2594), 13, "CPU cooler Arctic Freezer II A-RGB (240mm), water cooling, ACFRE00093A AMD/Intel", 6, "Freezer II A-RGB (240mm)", "ARCTIC LIQUID FREEZER II - 240 A-RGB", 237.24m, 10, "ARCTIC-LIQUID-FREEZER-II-240-ARGB", 72 },
                    { new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf"), new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5632), 4, "Spartan Gear Ares RGB Gaming Pad", 29, "Ares RGB", "SPARTAN GEAR ARES RGB", 34.99m, 10, "SPARTAN-GEAR-ARES-RGB-BLACK", 24 },
                    { new Guid("a6a172e1-aec3-475d-af84-754e32ddd378"), new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9005), 11, "Memory G.SKILL Trident Z Royal 16GB(2x8GB) DDR4 PC4-32000 4000MHz CL16 F4-4000C16D-16GTRGA", 40, "Trident Z Royal 16GB(2x8GB) DDR4", "G.SKILL TRIDENT Z ROYAL 16GB (2X8GB) 4000MHZ", 321.58m, 10, "GSKILL-TRIDENT-Z-ROYAL-16-4000", 99 },
                    { new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05"), new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9716), 2, "Take the first step with the incredibly fast Apex 9 Mini gaming keyboard. Thanks to the replaceable optical OptiPoint buttons, which actuate 33% faster compared to the leading products on the market, adjust the force of pressing the buttons between 1 mm for games and 1.5 mm for typing. Play like the pros with a 60% form factor gaming keyboard that gives you more room to move your mouse and the ability to optimize settings. The aircraft grade aluminum upper is just what you need for your next winning streak and will give you unmatched durability. Unlock the potential of this keyboard and customize it with ease in the SteelSeries Engine.", 21, "Apex 9 Mini", "STEELSERIES APEX 9 MINI", 279.00m, 10, "STEELSERIES-APEX-9-MINI-BLACK", 24 },
                    { new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f"), new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2620), 13, "ROG Ryujin is the flagship of All-in-one water coolers, which aims to provide the best cooling in extreme configurations. It relies on 3 x 120mm Noctua iPPC industrial fans for excellent and quiet cooling, + a built-in fan in the pump housing to further cool the VRM and M.2 drive, all of which ensure your machine will perform at its highest level.", 1, "ROG RYUJIN 360 Aura Sync", "ASUS ROG RYUJIN 360", 425.60m, 10, "ASUS-ROG-RYUJIN-360", 36 },
                    { new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4"), new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6538), 10, "Video card GIGABYTE GeForce RTX 4070 WINDFORCE OC 12GB GDDR6X, DLSS 3", 15, "GeForce RTX 4070 WINDFORCE OC 12GB GDDR6X, DLSS 3", "GIGABYTE GEFORCE RTX 4070 WINDFORCE OC 12G", 1437.94m, 10, "GIGABYTE-GEFORCE-RTX-4070-WINDFORCE-OC", 36 },
                    { new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75"), new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9047), 11, "Memory Silicon Power XPOWER Zenith 8GB DDR4 PC4-25600 UDIMM 3200MHz CL16 SP008GXLZU320BSC", 16, "XPOWER Zenith 8GB DDR4", "SILICON POWER XPOWER ZENITH 8GB 3200MHZ", 38.86m, 10, "SILICON-POWER-XPOWER-ZENITH-8-3200", 99 },
                    { new Guid("b1261055-dac3-4233-9f36-b85208472b24"), new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9490), 8, "Solid State Drive (SSD) SAMSUNG 980 PRO, 1TB, M.2 Type 2280, MZ-V8P1T0BW", 17, "980 PRO 1TB", "SAMSUNG 980 PRO 1TB", 167.32m, 10, "SAMSUNG-980-PRO-1TB", 60 },
                    { new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3"), new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5770), 7, "Motherboard GIGABYTE B760M GAMING, socket 1700, ATX 2xDDR4, PCIe 4.0", 15, "B760M GAMING", "GIGABYTE B760M GAMING DDR4", 222.84m, 10, "GIGABYTE-B760M-GAMING", 36 },
                    { new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8"), new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(8849), 11, "Memory ADATA Black 8GB DDR5 PC5-38400 4800MHz CL40 AD5U48008G-S", 39, "Black 8GB DDR5", "ADATA BLACK 8GB 4800MHZ", 81.60m, 10, "ADATA-BLACK-8-4800", 99 },
                    { new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9"), new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9118), 11, "Memory G.SKILL Trident Z Royal Elite 32GB(2x16GB) DDR4 PC4-32000 4000MHz CL16 F4-4000C16D-32GTES", 40, "Trident Z Royal Elite 32GB(2x16GB) DDR4", "G.SKILL TRIDENT Z ROYAL ELITE 32GB (2X16GB) 4000MHZ", 660.14m, 10, "GSKILL-TRIDENT-Z-ROYAL-ELITE-32-4000", 99 },
                    { new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38"), new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(7422), 10, "Video card Powercolor AMD RADEON RX 7900 XTX Red Devil OC 24GB GDDR6 - RX 7900 XTX 24G-E/OC", 42, "RADEON RX 7900 XTX Red Devil OC 24GB GDDR6 - RX 7900 XTX 24G-E/OC", "POWERCOLOR RED DEVIL AMD RADEON RX 7900 XTX 24G", 2495.49m, 10, "POWERCOLOR-RADEON-RX7900XTX-RED-DEVIL", 36 },
                    { new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867"), new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5566), 7, "Motherboard GIGABYTE A520M K V2, Socket AM4, mATX, 2xDDR4, M.2 NVMe", 15, "A520M K V2", "GIGABYTE A520M K V2", 128.46m, 10, "GIGABYTE-A520M-K-V2", 36 },
                    { new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524"), new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4762), 9, "Power supply Gigabyte AORUS P1200W 80+ Platinum", 15, "AORUS P1200W 80+ Platinum", "GIGABYTE AORUS P1200W 80+ PLATINUM", 739.18m, 10, "GIGABYTE-P1200-PLATINUM", 60 },
                    { new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1"), new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6597), 3, "CREATIVE SXFI Gamer Headphones, Black", 13, "SXFI Gamer", "CREATIVE SXFI GAMER", 248.50m, 10, "CREATIVE-SFXI-GAMER-BLACK", 24 },
                    { new Guid("b98a0d2b-36ea-441f-a191-733ead645f18"), new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9785), 1, "The Logitech G305 LIGHTSPEED is a wireless gaming mouse designed to provide excellent performance and the latest technology at an affordable price.", 12, "G305", "LOGITECH G305 WH", 119.00m, 10, "LOGITECH-G305-WHITE", 24 },
                    { new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe"), new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7118), 6, "Processor Intel Comet Lake-S Core I3-10100F 4 cores 3.6Ghz (Up to 4.30Ghz) 6MB, 65W LGA1200 BOX", 37, "Core I3-10100F", "INTEL CORE I3-10100F", 177.19m, 10, "INTEL-CORE-I3-10100F", 36 },
                    { new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a"), new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6587), 5, "Monitor ASUS ProArt PA278QV Professional 27\" IPS, WQHD (2560 x 1440), 100% sRGB, 100% Rec. 709, Color Accuracy ΔE < 2, Calman Verified, ProArt Preset, ProArt Palette", 1, "ProArt PA278QV", "ASUS PROART DISPLAY PA278QV", 789.00m, 10, "ASUS-PROART-PA278QV", 36 },
                    { new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434"), new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2603), 13, "ASUS ROG STRIX LC II 240 CPU Cooler", 1, "ROG STRIX LC II 240", "ASUS ROG STRIX LC II 240", 329.00m, 10, "ASUS-ROG-STRIX-LCII-240", 72 },
                    { new Guid("c092adb2-47c6-4360-9d70-1411e0278747"), new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9681), 2, "The first 60% keyboard from HyperX is already a fact. Aluminum chassis, HyperX designed mechanical switches, PBT plastic keys and of course stylish RGB backlighting.", 11, "Alloy Origins 60", "HYPERX ALLOY ORIGINS 60", 229.00m, 10, "HYPERX-ALLOY-ORIGINS-60-BLACK", 24 },
                    { new Guid("c096f9aa-448f-42ec-894a-875688f16264"), new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6461), 10, "Video card Asrock AMD Radeon RX 6950 XT Phantom Gaming 16G OC", 26, "Radeon RX 6950 XT Phantom Gaming 16G OC", "ASROCK RADEON RX 6950 XT PHANTOM GAMING 16GB OC", 1357.03m, 10, "ASROCK-RADEON-RX6950XT-PHANTOM-GAMING", 36 },
                    { new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"), new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6622), 3, "The Quantum 910 Wireless Gaming Headset offers high-resolution dual surround audio. Low-latency wireless means zero lag when talking to the team. Active noise cancellation - you can play even in the noisiest places without distraction. A built-in battery offers up to 39 hours of life and can even be charged while playing. A built-in head movement sensor will also be at your disposal.", 10, "Quantum 910", "JBL QUANTUM 910 WIRELESS", 459.00m, 10, "JBL-QUANTUM-910-WIRELESS-BLACK", 24 },
                    { new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2"), new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9738), 2, "LIGHTSPEED wireless technology provides professional performance with flexibility and freedom from cables. Lasts 30 hours on a full charge.", 12, "G915", "LOGITECH G915", 446.27m, 10, "LOGITECH-G915-BLACK", 24 },
                    { new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9"), new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6521), 10, "Video card GIGABYTE GeForce RTX 4060 GAMING OC 8GB GDDR6 DLSS 3", 15, "GeForce RTX 4060 GAMING OC 8GB GDDR6 DLSS 3", "GIGABYTE GEFORCE RTX 4060 GAMING OC 8GB GDDR6", 777.28m, 10, "GIGABYTE-GEFORCE-RTX-4060-GAMING-OC", 36 },
                    { new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc"), new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6546), 10, "Video card PowerColor Fighter Radeon RX 6600 8GB GDDR6 AXRX 6600 8GBD6-3DH", 42, " Fighter Radeon RX 6600 8GB GDDR6 AXRX 6600 8GBD6-3DH", "POWERCOLOR FIGHTER RADEON RX 6600 8G", 417.29m, 10, "POWERCOLOR-FIGHTER-RADEON-RX6600", 36 },
                    { new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f"), new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(7405), 10, "Video card Powercolor AMD RADEON HELLHOUND RX 7900 XT 20GB GDDR6", 42, "RADEON HELLHOUND RX 7900 XT 20GB GDDR6", "POWERCOLOR AMD RADEON HELLHOUND RX 7900 XT 20G", 2202.61m, 10, "POWERCOLOR-RADEON-HELLHOUND-RX7900XT", 36 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AddDate", "CategoryId", "Description", "ManufacturerId", "Model", "Name", "Price", "Quantity", "ReferenceNumber", "Warranty" },
                values: new object[,]
                {
                    { new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d"), new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(8799), 11, "Memory Corsair Vengeance LPX White 16GB(2x8GB) DDR4 PC4-25600 3200MHz CL16 CMK16GX4M2B3200C16W", 5, "Vengeance LPX White 16GB(2x8GB) DDR4", "CORSAIR VENGEANCE LPX 16GB (2X8GB) 3200MHZ", 100.24m, 10, "CORSAIR-VENGEANCE-16-3200", 99 },
                    { new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0"), new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4771), 9, "Power supply ASUS ROG STRIX 850W White Edition 80+ Gold Fully Modular", 1, "ROG STRIX 850W White Edition 80+ Gold", "ASUS ROG-STRIX-850G-WHITE", 421.08m, 10, "ASUS-ROG-STRIX-850G-WHITE", 120 },
                    { new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"), new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6547), 3, "From the quietest footstep to the loudest explosion, JBL QuantumSound makes every scene more epic and every gamer more competitive. Thanks to the comfortable memory foam and lightweight design, you will be able to enjoy even longer gaming sessions.", 10, "Quantum 100", "JBL QUANTUM 100", 68.46m, 10, "JBL-QUANTUM-100-WHITE", 24 },
                    { new Guid("cd520645-7cc4-42de-98f9-79c109829bbb"), new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6605), 3, "Finally, headphones as expressive as you! The G733 are wireless and designed to be comfortable and lightweight. At your disposal are surround, filters for the microphone and of course RGB backlighting.", 12, "G733 Lightspeed Wireless RGB", "LOGITECH G733 LIGHTSPEED WIRELESS RGB", 289.00m, 10, "LOGITECH-G733-LIGHTSPEED-WIRELESS-RGB-WHITE", 24 },
                    { new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c"), new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6632), 5, "Monitor ZOWIE XL2746K 240Hz DyAc+™, TN, 27 inch, Wide, Full HD, DP, DVI-DL, HDMI, Black", 25, "XL2746K", "ZOWIE XL2746K", 1239.70m, 10, "ZOWIE-XL2746K", 36 },
                    { new Guid("cdf75419-d5f9-4119-beba-9765a822918d"), new DateTime(2023, 11, 20, 14, 32, 19, 101, DateTimeKind.Local).AddTicks(4721), 9, "Power Supply Seasonic PRIME TX-1600, 1600W, 80+ Titanium PCIe Gen 5, Full Modular", 32, "PRIME TX-1600", "SEASONIC PRIME TX-1600 1600W", 1024.78m, 10, "SEASONIC-PRIME-TX-1600", 144 },
                    { new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba"), new DateTime(2023, 11, 20, 14, 32, 19, 99, DateTimeKind.Local).AddTicks(9834), 1, "The MM730 retains Cooler Master's innovative spirit while retaining the familiar aesthetics of classic gaming mice. Every professional feature is designed to give you light-speed responsiveness in the blink of an eye: genuine PTFE feet for unmatched glide, an adjustable 16,000 DPI optical sensor, and optical micro switches for superior durability and input. All housed in a super light, revolutionary new ergonomic housing design that reduces weight to 48g, the MM730 truly is less than the sum of its parts.", 4, "MM730", "COOLER MASTER MM730", 88.99m, 10, "COOLER-MASTER-MM730-BLACK", 24 },
                    { new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b"), new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9108), 11, "Memory Silicon Power 16GB(2x8GB) DDR4 PC4-25600 3200MHz CL22 SP016GBLFU320B22", 16, "16GB(2x8GB) DDR4", "SILICON POWER 16GB(2X8GB) 3200MHZ", 120.44m, 10, "SILICON-POWER-16-3200", 99 },
                    { new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b"), new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9445), 2, "The XTRFY K3 combines many of the high-end features with membrane construction to make it more affordable. The K3 features well-proven components in an extremely durable construction, 1000 Hz Polling Rate and a special 19-Key Rollover that allows up to 19 keys to be pressed simultaneously. The K3 also has an adjustable RGB backlight, the settings of which are made using the keys, without the need for software.", 19, "K3 RGB", "XTRFY K3 RGB", 98.08m, 10, "A4TECH-S510R-BLACK", 24 },
                    { new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"), new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6638), 3, "Arctis Nova Pro delivers legendary sound quality with the Nova Pro speaker system and premium speakers of the highest quality. Every detail surrounds you, as the 360° audio space will transport you to a different world with the second-generation Sonar GameDAC software that powers the sound with High-Res audio, ESS Saber quad-DAC and amplifier. The Arctit Nova Pro also functions as a base station for quick switching between multiple systems (Xbox, PC, PlayStation, Nintendo Switch). AI noise-isolating microphone keeps communication crystal clear. Easily get the most comfortable fit with the ComfortMAX system. Try Almighty Audio to hear sound like never before.", 14, "Arctis Nova Pro", "STEELSERIES ARCTIS NOVA PRO", 549.00m, 10, "STEELSERIES-ARCTIS-NOVA-PRO-BLACK", 24 },
                    { new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6"), new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9341), 8, "Solid State Drive (SSD) KINGSTON KC3000 M.2-2280 PCIe 4.0 NVMe 4096GB", 18, "KC3000 M.2-2280 PCIe 4.0 NVMe 4096GB", "KINGSTON KC3000 4TB", 767.42m, 10, "KINGSTON-KC3000-4TB", 60 },
                    { new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899"), new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9022), 11, "Memory Gigabyte AORUS RGB 16GB DDR4 (2x8GB) 3600MHz CL18-19-19-39 1.35v", 15, "AORUS RGB 16GB DDR4 (2x8GB) 3600MHz", "AORUS RGB MEMORY 16GB 3600 MHZ", 250.00m, 10, "GIGABYTE-AORUS-DDR4-16-3600", 99 },
                    { new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e"), new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9014), 11, "Memory Gigabyte AORUS RGB 16GB DDR4 (2x8GB) 3733MHz CL18-19-19-39 1.4v with Demo Kit", 15, "AORUS RGB 16GB DDR4 (2x8GB) 3733MHz", "AORUS RGB MEMORY DDR4 16GB (2X8GB) 3733MHZ", 119.32m, 10, "GIGABYTE-AORUS-DDR4-16-3733", 99 },
                    { new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d"), new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5619), 7, "Motherboard ASUS Prime X570-Pro socket AM4, 4xDDR4, Aura Sync, PCIe 4.0", 1, "Prime X570-Pro", "ASUS PRIME X570-PRO", 639.00m, 10, "ASUS-PRIME-X570-PRO", 36 },
                    { new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9"), new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6553), 5, "Gaming Monitor ASRock PG32QF2B 32\" QHD (2560X1440) Flat VA, 165Hz, 1ms , 92% DCI-P3 , 2xHDMI, 1xDP, WiFi Antena, Freesync Premium", 26, "PG32QF2B", "ASROCK PG32QF2B", 748.99m, 10, "ASROCK-PG32QF2B", 36 },
                    { new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d"), new DateTime(2023, 11, 20, 14, 32, 19, 103, DateTimeKind.Local).AddTicks(9039), 11, "Memory Team Group T-Force XTREEM WHITE, ARGB, DDR4 32GB (2x16GB), 3600MHz, CL18", 41, "T-Force XTREEM WHITE", "T-FORCE XTREEM ARGB WHITE 32GB (2X16GB) 3600MHZ", 250.01m, 10, "TEAM-GROUP-T-FORCE-XTREEM-ARGB-WHITE-32-3600", 99 },
                    { new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c"), new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9669), 2, "Utilizing the revolutionary Anti-Ghosting Matrix key-switch design, AORUS K1 provides Anti-Ghosting across all areas of the keyboard. (N-Key Rollover) Dominate the competition with the advantage and versatility of being able to input multiple keystrokes at once. *supports 64 simultaneous key presses via USB connection.", 15, "Aorus K1", "AORUS K1", 207.30m, 10, "GIGABYTE-AORUS-K1-BLACK", 24 },
                    { new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976"), new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5601), 7, "Motherboard GIGABYTE B650M GAMING X AX WiFi 6E socket AM5, 4xDDR5", 15, "B650M GAMING X AX WiFi", "GIGABYTE B650M GAMING X AX", 406.07m, 10, "GIGABYTE-B650M-GAMING-X-AX", 36 },
                    { new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4"), new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6484), 3, "Hama Gaming Headset, For PlayStation 5, Microphone, 3.5mm Jack, White/Black", 7, null, "HAMA GAMING HEADSET FOR PLAYSTATION 5", 34.69m, 10, "HAMA-PLAYSTATION5-WHITE", 24 },
                    { new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1"), new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7286), 6, "Processor AMD Ryzen 7 5700G, 3.8GHz(Up to 4.6GHz), 65W, AM4", 38, "Ryzen 7 5700G", "AMD RYZEN 7 5700G", 451.19m, 10, "AMD RYZEN 7 5700G", 36 },
                    { new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b"), new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6581), 3, "All-day wireless comfort, zero lag and Windows Sonic surround sound to ensure you're never vulnerable on the battlefield. Victory has never been sweeter.", 9, "RIG 700HS", "PLANTRONICS RIG 700HS", 173.83m, 10, "PLANTRONICS-RIG-700HS-CAMOUFLAGE", 24 },
                    { new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625"), new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5816), 4, "Place your keyboard in many more positions without having to consider the mouse pad or mouse. At 900x400mm, the G840 provides the area to bring together the aesthetics of a gaming desktop while adding additional options for comfort and configuration.", 12, "G840 XL K/DA", "LOGITECH G840 XL K/DA", 79.00m, 10, "LOGITECH-G840-XL-K/DA", 24 },
                    { new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac"), new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5574), 7, "ASROCK B450 Steel Legend motherboard", 26, "B450 Steel Legend", "ASROCK B450 STEEL LEGEND", 202.02m, 10, "ASROCK-B450-STEEL-LEGEND", 36 },
                    { new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b"), new DateTime(2023, 11, 20, 14, 32, 19, 89, DateTimeKind.Local).AddTicks(9332), 8, "Solid State Drive (SSD) Kingston KC600", 18, "KC600 512GB", "KINGSTON KC600 512GB", 111.85m, 10, "KINGSTON-KC600-512GB", 60 },
                    { new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d"), new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6554), 10, "Video card PowerColor Fighter AMD Radeon RX 6700 XT 12GB GDDR6, AXRX 6700 XT 12GBD6-3DH", 42, "Fighter AMD Radeon RX 6700 XT 12GB GDDR6, AXRX 6700 XT 12GBD6-3DH", "POWERCOLOR FIGHTER AMD RADEON RX 6700 XT 12G", 699.08m, 10, "POWERCOLOR-FIGHTER-RADEON-RX6700XT", 36 },
                    { new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104"), new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6512), 10, "Video card GIGABYTE GeForce RTX 3050 EAGLE 8GB GDDR6", 15, "GeForce RTX 3050 EAGLE 8GB GDDR6", "GIGABYTE GEFORCE RTX 3050 EAGLE 8G", 608.84m, 10, "GIGABYTE-GEFORCE-RTX-3050-EAGLE", 36 },
                    { new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761"), new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7339), 6, "Processor Intel Alder Lake Core i9-12900K, 16 Cores, 24 Threads (3.20 GHz Up to 5.20 GHz, 30MB, LGA1700), 125W, Intel UHD Graphics 770, BOX", 37, "Core I9-12900K", "INTEL CORE I9-12900K", 981.20m, 10, "INTEL-CORE-I9-12900K", 36 },
                    { new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6"), new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5769), 4, "The SR is for gamers who love the comfort of a fabric pad on a soft rubber base. The base is 100% flat which provides comfort and maintains a consistent glide to ensure the best performance.", 25, "P-SR", "ZOWIE P-SR", 39.00m, 10, "ZOWIE-P-SR-BLACK", 24 },
                    { new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"), new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5859), 12, "Corsair 5000D Airflow Mid Tower Case, Tempered Glass, Black", 5, "5000D Airflow", "CORSAIR 5000D AIRFLOW TG", 345.00m, 10, "CORSAIR-5000D-AIRFLOW", 24 },
                    { new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260"), new DateTime(2023, 11, 20, 14, 32, 19, 96, DateTimeKind.Local).AddTicks(5796), 7, "Motherboard MSI Z590 PRO, 4xDDR4, Socket 1200", 28, "Z590 PRO", "MSI Z590 PRO", 411.86m, 10, "MSI-Z590-PRO", 36 },
                    { new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4"), new DateTime(2023, 11, 20, 14, 32, 19, 94, DateTimeKind.Local).AddTicks(6516), 5, "Monitor 32\" LG 32MP60G-B", 23, "32MP60G-B", "LG 32MP60G-B", 469.00m, 10, "LG-32MP60G-B", 36 },
                    { new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"), new DateTime(2023, 11, 20, 14, 32, 19, 85, DateTimeKind.Local).AddTicks(5180), 12, "Cooler Master CMP 320 Mesh Black ARGB box", 4, "CMP320", "COOLER MASTER CMP320", 148.99m, 10, "COOLER-MASTER-CMP320", 24 },
                    { new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2"), new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9352), 2, "The uRage Exodus 220 TKL is a compact gaming keyboard with fast response designed for gaming. The keyboard also has RGB lighting with 8 different modes - . Exodus 450 is made of high quality components and metal.", 7, "URAGE EXODUS 220 TKL", "URAGE EXODUS 220 TKL", 39.00m, 10, "HAMA-URAGE-EXODUS-220-TKL-BLACK", 24 },
                    { new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70"), new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2629), 13, "CPU Cooler ASUS ROG RYUJIN III 360, 3.5 Full Color LCD Display, Noctua NF-F12 IndustrialPPC Fans", 1, "ROG RYUJIN III 360", "ASUS ROG RYUJIN III 360", 849.00m, 10, "ASUS-ROG-RYUJIN-III-360", 72 },
                    { new Guid("f9fadd8c-666a-40da-8058-3461e7580906"), new DateTime(2023, 11, 20, 14, 32, 19, 88, DateTimeKind.Local).AddTicks(6564), 3, "Lightweight and cool. G335 is where color and comfort combine. Featuring a suspension headband design with adjustable strap so you can choose your most comfortable fit. Easy plug-and-play and built-in controls let you quickly connect and jump into the game. Just pick your favorite color to match your awesome style. The suspension headband design distributes weight and relieves pressure points. Soft, breathable memory ear cups and sports mesh material surround the ear and provide just the right amount of force to stay firmly in place. At only 240 grams, G335 is a smaller and lighter version of the award-winning G733 LIGHTSPEED wireless headset. Easily get into the game using a simple 3.5 mm audio jack. G335 works with Xbox®, PlayStation®, Nintendo Switch™ as well as most PCs, laptops, or mobile devices. The soft elastic headband conforms to your head and can be adjusted for the perfect fit. Slide the ear cups up and down to make them feel just right. Use the volume roller on the ear cup to turn up your game or music. Flip up the mic to instantly mute and move it out of the way.", 12, "G335", "LOGITECH G335", 139.00m, 10, "LOGITECH-G335-BLACK", 24 },
                    { new Guid("fab242ac-113e-42ca-9363-d362efbcb394"), new DateTime(2023, 11, 20, 14, 32, 19, 102, DateTimeKind.Local).AddTicks(7162), 6, "Processor Intel Alder Lake Core i5-12400F, 6 Cores, 12 Threads (2.50 GHz Up to 4.40 GHz, 18MB, LGA1700), 65W, BOX", 37, "Core I5-12400F", "INTEL CORE I5-12400F", 333.82m, 10, "INTEL-CORE-I5-12400F", 36 },
                    { new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a"), new DateTime(2023, 11, 20, 14, 32, 19, 91, DateTimeKind.Local).AddTicks(9432), 2, "Bloody S510R keyboard", 8, "S510R", "BLOODY S510R", 79.00m, 10, "A4TECH-S510R-WHITE", 24 },
                    { new Guid("fb36b717-5bf3-4648-8839-e66018ec1523"), new DateTime(2023, 11, 20, 14, 32, 19, 87, DateTimeKind.Local).AddTicks(2585), 13, "Arctic Freezer II CPU Cooler (240mm), Water Cooling, ACFRE00046A AMD/Intel", 6, "Freezer II (240mm)", "ARCTIC LIQUID FREEZER II 240", 195.28m, 10, "ARCTIC-LIQUID-FREEZER-II-240", 72 },
                    { new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5"), new DateTime(2023, 11, 20, 14, 32, 19, 98, DateTimeKind.Local).AddTicks(5609), 4, "Made from high-quality fabric and a rubber base, the SteelSeries QcK mini is the perfect mouse pad for any gamer who likes textile pads.", 14, "Qck S", "STEELSERIES QCK S", 19.99m, 10, "STEELSERIES-QCK-S-BLACK", 24 },
                    { new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0"), new DateTime(2023, 11, 20, 14, 32, 19, 105, DateTimeKind.Local).AddTicks(6504), 10, "Video card ASUS ROG STRIX GeForce RTX 4070 TI OC 12GB GDDR6X, DLSS 3.0", 1, "ROG STRIX GeForce RTX 4070 TI OC 12GB GDDR6X", "ASUS ROG STRIX GEFORCE RTX 4070TI 12GB GDDR6X OC EDITION", 2399.00m, 10, "ASUS-ROG-STRIX-RTX-4070TI-OC", 36 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01ed6ef9-2722-4172-aeb5-8e997a11643c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02c200a6-74ae-4aba-baa2-2b77f2d7b6f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0384abf9-33a2-42c6-9621-d17db2e1f23d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0608c462-e7bf-4120-bdcd-091352064849"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06c3cb01-b579-4d74-85e5-5e40297702f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06d80050-9408-43cb-8d3e-8760ddb4613a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07087f6f-31ed-462a-aa44-63d515cfbbb2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09766e9a-ae47-4ba6-b7f3-882300c08082"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d741fb7-9163-4eb1-a898-75316c2dd01b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ec80d70-22db-4952-bf93-99105299ca78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("107c6981-c785-4eaa-a77f-fad669d5e58a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11c9e125-f0a0-485c-a12f-c47938729085"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1208439d-df39-4445-9bdb-cce86277842b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("120c1ebd-bdf6-4da8-8399-69026daa9d03"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("125d9fda-502a-4214-85ac-f746276bbb12"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15bdecb1-2c5c-463a-96a8-2d64277596ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15ec5003-6f40-4c31-97df-5ef24cd7b3a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("176d8c2e-8942-4732-a677-29c670c0c091"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("177bcff9-a521-48c9-9ff1-bf11b3e89035"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("190bfc58-58f2-4aa4-bfb2-56610eb70a6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a65a65b-9ad3-4a5d-8ddb-01fbe008d4a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b052fb7-93b8-435e-9a4a-bc2aee57b831"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1baaa99d-510e-4fd7-b4d5-176a456d6ff0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1dba4642-7292-4b4a-aca2-0927966cbc6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f1e3a25-1d54-4bca-8da5-226dea269d44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20138228-3cb1-4a00-899e-ed40343018f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("208f2a40-db59-4499-b40d-368db5b3a634"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("221245d9-e8d1-4d83-b950-889ac825d869"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("223d4ad5-af03-4ebf-88f6-a2515df284d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23b6fca6-c7ac-41e6-b3d0-54153a7783d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2403dada-744b-4347-b72a-6df00591f237"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24c16ce4-ba6f-4662-a6e9-a7d4c26cadad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25ac0de5-8071-4d5a-9119-a6110ae90dd6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("265e805c-664e-470d-93fc-b89ed1fbfbac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26f18072-6741-4ece-a5bc-977994a5268b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2906c72c-f9fa-43e2-ae10-92e83f70a3f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2be6399b-9a9a-4f94-a0eb-edd72f07e2f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f5ec2d2-fae1-4d21-8c9a-30bbd87d6a40"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("308f0b3d-c8a7-4883-80b1-18efe8075ec0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30d0b9ae-fcc7-401f-af91-84fd84585ce3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3163767e-f433-4fa4-b5f5-ced4fbf7e96c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32987f00-ee05-40bf-aecd-e13297d74532"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("333df926-a3ab-4f31-9cc0-2705a73a3567"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3405e1e6-53c7-411b-8c88-c9ffcfd45981"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34226a99-4efb-49f0-9bdd-2d2b4630c36d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35e09c36-6065-433e-bf7c-3e218aa306fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36581cdd-c605-40c1-8e23-78cd02fb5070"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("395d8881-b8b4-489e-9604-2bf814cfa6d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39bc4103-3f11-481b-a859-f2eb720649ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b75374e-3205-40aa-b951-2ae6ced3fcbe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d3e4282-32cf-4674-b081-80cdb8cba456"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4330fb51-f627-405a-8f6c-10aa5f65a99c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44952150-1557-40cd-b81d-0601ce3eb1c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4556d753-6a08-4457-b2a8-d772c054499e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47ae397f-8a33-49dc-bd02-ff78941f7702"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47b4250a-85b5-4b6e-b56f-a4ba36edcab7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4911caa3-a307-4f59-baba-0dd6616ef6dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d36d3d0-ca56-48e5-a20a-a216e518922a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d433585-5485-4d14-8cc2-e2e73640aca6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50c72822-3c58-4689-bb12-171629bfce1a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50c92a0d-9e08-4834-8d08-11d443a115ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5481e50e-f8a4-48c8-a94b-5ba1225dd9d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("562d56a7-3b3d-4573-8dd6-c66f041f8dc5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57815913-af9e-4ad4-bc57-b22706866cd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5983b17f-d4e6-494c-9761-3745c0756cf7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59a0140a-ca95-40d1-9e51-ea6e491b3943"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59d0b2df-20ff-4c14-94db-dec1c2c8dfd1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a6c197e-b93c-428c-85dc-b90e5980d91a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bfc84bb-26cc-4f50-97b6-d0bab38e189e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c3f04e7-4504-40f5-a510-ff81490bd11c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e3767b6-1a2e-4629-be24-c20cdf356470"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fa226cc-43f9-4f16-8849-7331be60090d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fe0b265-d074-4864-9526-966405759eff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61b407d1-483b-4958-8d5d-0f01b2da56c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("637d8089-3235-4896-a213-2b85771393c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("642d5692-050a-4cf2-befd-b7ce353d0e5c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6493cdac-f50f-45ae-a0ee-15b0c9851916"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65386f80-3659-4dc5-873b-572afdd12461"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("661acb6b-83fb-4039-bb91-098f97aa394a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("667d3dfb-7d7f-4a3e-a1af-249c52c2e893"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66c9c7e1-00f6-4b8b-b68d-958f68b215d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67fd9e91-b4bc-42d5-8b7d-43eee2c97a49"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("684eb60e-08df-4c0c-a30a-6c1294673988"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("689b3a84-261c-4512-904c-c7fed46365be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68e4ea47-65f9-46a4-8b96-ee14917c480e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a5dec5e-c220-4ea9-9e0e-1b74b1afd2e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6bf2eeae-330f-4fb3-b40a-8853e7afc5e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6debfaa8-a45f-476d-9ff8-444092581c8d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e2fdae2-ee0c-407d-8660-ae5d8a81c536"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ec72ed3-5a7f-4f86-a486-dc98f46b20be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f05799c-c64f-4bbd-870a-682feea0a5d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("703b1f7f-b293-42b2-a9be-a17af6d8a134"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("711b7764-c49d-4d92-9c03-2385ed109930"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71835245-ee6b-477c-9f7f-a4552f497e5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71fd642b-51bf-412c-b383-c49fc3e948ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72dd678e-f4ec-45ac-8dac-ed4e197fe1a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72fc4faa-21c9-4bbb-8fee-24607062767b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("730dd1ab-67ce-4901-9e23-c0bbb4890e07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76826cff-ba78-4615-8650-9dca6fe3bd66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77016fe5-8c13-4c30-b972-227c232cbe2a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77edaa89-bf57-4a44-943b-e32e0f9c6ce6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("796faaca-ca93-4081-9a23-b90191c6c28c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a04d99f-54cb-4dcb-8dd7-1671a3066fdf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bb0b10b-594b-4f07-8e61-11c0dd0b3558"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bc68af5-7508-4f78-8be7-902c5bdfaf96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7cfe7936-6644-4912-b846-9c5860a35b44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d12cc41-4444-4b4b-be2c-a14e1f7ca383"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d6be4cd-f068-424f-a1e6-b730ee95ad9f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e0cdafa-a356-4245-9b25-a8864857109b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e546395-0e5b-4bbf-a083-be5505a56ee0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ec24e8f-1ca3-4779-8c4f-404b287a9cfb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7fd001cd-d2d6-4666-afd0-af3d7507d546"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("834cb7ed-d351-4bed-a458-1e1f49e6aa60"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84efb0de-b1df-42d3-b9ae-e64a7db810ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87139a76-a325-4046-a973-e5dc072dc258"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89b6221e-d046-4e6e-a4a0-c4076c8852f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89e3e4de-4748-4c4a-b018-89946185aecd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a1ff4a9-d713-49fa-b0b1-233512fa364d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a5ae781-9cb1-4338-9dd4-b4b8db9e0044"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d4089ec-9f65-450b-9f74-337390c86144"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8eb18a3b-3d49-433c-be92-2d6357f0f0b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f9bc461-f386-4aa1-9b06-243da34f831f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9025ef3b-286f-4880-83f1-6abb8ce9eb02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91661960-9390-47c3-ab98-9b9e19269b02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91aa1a0b-6a57-413b-acb8-68207fc919a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92089877-a384-404f-b813-f02236406a7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("938085a4-745e-4e76-851b-dada0ed1a06f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94205a90-d5e5-4f5b-96a7-5bd080f7cd18"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98322a27-9cbc-4666-8392-0f245afb62aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a1a04b5-f16a-4645-9c8e-a0bd0766ad19"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c847a36-b5be-465e-993e-472f1135de58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ccfcbea-ce7f-4eff-b489-863cf18ad539"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d1fc184-5111-405f-bc08-686cf2086357"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9dbc4281-e1c3-4e2a-a1fa-2fb4c4e00233"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9df7c2cd-486d-481a-b047-6d55e9ffafa8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e564d00-7c09-4f84-9ca9-988725d9f3e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a08cae7c-b4a7-4398-b830-5ead830ceeab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a17622b2-2710-4c88-83a2-477d1292400c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2e48daa-85f0-4bce-be53-2120c8c587c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3737e42-5d07-495d-a0e6-4c55c179e3a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a419e6f9-50f6-4407-9225-43fbc75dfbf3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a625e07c-1465-4218-a6cd-aeeab4fd7372"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a63730e3-657f-4615-a181-ddf28a4f7ccb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6569dfe-6133-4573-86b7-603e0dfffbaf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6a172e1-aec3-475d-af84-754e32ddd378"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7eb6fee-9fc2-4e45-96b5-6d401ce08a05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab49d775-a5e5-4722-b998-7c84f552bc1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af2f52a6-5363-4763-aee4-32c7ccbb79b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b02518aa-82d1-408d-9358-bbb4c9ff0d75"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1261055-dac3-4233-9f36-b85208472b24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b230d33c-c6b5-41d7-8c12-95195add32b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3cce4d5-2714-4d4d-95a5-29a1b51122e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b40407d5-8b5e-435d-9c0b-f423ff2d6de9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b762e7a3-c6f3-4577-b108-0adbbcaadc38"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7bc74b7-e735-4d4c-91cf-da9e4fa15867"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b95b0c3d-fb4f-4ff8-b6db-15318e844524"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b984f412-d26c-422f-bdbe-7f6d2f8feab1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b98a0d2b-36ea-441f-a191-733ead645f18"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba51dae1-3cec-41d8-b34f-efb6ef2dd2fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc21439d-7c9d-4183-812f-bc3ac468c20a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfdd573d-93a7-467c-9da0-cc0b8a369434"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c092adb2-47c6-4360-9d70-1411e0278747"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c096f9aa-448f-42ec-894a-875688f16264"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a69d0c-4a68-4b59-ace7-818063027ac6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0ed1cb0-92a7-4eef-927b-9a74ec7f08e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2ed628e-08ff-4c88-a481-7f295305cbd9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3abc6f7-3ac0-4f85-b60a-b2e6b6ce59bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb23639e-6a7a-42d9-9d89-4ea66534a11f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb959e58-aa9d-4fec-bbc2-44f6ed71966d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbf96c4e-fd3f-44fb-9534-ab0490ba8be0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc76c44b-f261-43d2-a2d9-8e6f3736bc26"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd520645-7cc4-42de-98f9-79c109829bbb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd979606-d482-40f8-a2e2-a81c1dfcce5c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cdf75419-d5f9-4119-beba-9765a822918d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf2d9535-fdb8-4819-ab61-d58a60603cba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf8abdbd-1402-4821-b8cd-b24802e20b5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d007de1b-8e13-422e-8f7a-1f27179f327b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d03b396d-085e-4e7c-a984-fc7216d663d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3b16f38-b6f5-4107-9b8a-e6ad58321aa6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d422037a-9e86-4a44-bb7c-46b4d3d06899"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d473ea9e-6f6b-4e3a-ade5-8af43ef1e53e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5465209-b9c5-4b28-94e2-1c59a1c1985d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d74f185f-fa18-4945-a84f-aaab038ba2b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7602e8a-a62b-4d94-a173-f86c0536938d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9d23801-0269-4a1c-a94e-f458531e1e8c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc6170c8-5a2b-4ce2-b24c-6ef20f69b976"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de4b950a-48e4-451c-ba03-b97cfa4aead4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dff4da58-9f47-483b-91b8-efaac5c609a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e139c82e-38b6-444c-aa74-f1eb917f096b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3eb50d0-b7f2-4c83-920f-d8c497a2f625"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e538ad42-85be-4fcd-9bd1-eca22cb55fac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5ff1668-146a-4cc9-9e1b-f55a5c76978b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e60add18-4edd-42b4-82ed-cf5c90e2793d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e65a3775-78fa-40f0-b7a8-54fc261c2104"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e76539b9-89a9-4e5b-a60e-a7429323f761"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb94ca5e-f7e2-41f0-9027-26f6f5d618e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee9e8c36-58e3-43cb-8733-23fade554f76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef3d8554-abee-474b-82a2-5be8f9a32260"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("effc1fb1-a282-4562-b209-9a29f8d94fb4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f29decd2-89a8-44ad-8440-2bd6637ad0dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6e8983e-a734-4088-a585-ed0b4b2af7a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f82aa81c-4c7f-4ae8-9376-db83866aff70"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9fadd8c-666a-40da-8058-3461e7580906"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fab242ac-113e-42ca-9363-d362efbcb394"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fae6e269-6eb6-4f26-bd96-f77188e2a48a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb36b717-5bf3-4648-8839-e66018ec1523"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd0efca2-99f8-45ed-833d-e7cd83b1c6c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff53e49d-ae66-4917-8e6d-627b9923d4a0"));
        }
    }
}
