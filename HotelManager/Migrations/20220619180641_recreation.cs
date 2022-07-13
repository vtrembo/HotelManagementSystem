using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManager.Migrations
{
    public partial class recreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apartment",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfBeds = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ApartmentTypes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AmountOfDrinks = table.Column<int>(type: "int", nullable: true),
                    NumberOfChildenBeds = table.Column<int>(type: "int", nullable: true),
                    HasRoofZone = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment", x => x.Number);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    IdIngredient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsVegeterian = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.IdIngredient);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    IdPerson = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.IdPerson);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    IdRestaurant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.IdRestaurant);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    IdRoom = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ApartmentNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.IdRoom);
                    table.ForeignKey(
                        name: "FK_Room_Apartment_ApartmentNumber",
                        column: x => x.ApartmentNumber,
                        principalTable: "Apartment",
                        principalColumn: "Number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    IdPerson = table.Column<int>(type: "int", nullable: false),
                    IdClient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.IdPerson);
                    table.ForeignKey(
                        name: "FK_Client_Person_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "Person",
                        principalColumn: "IdPerson");
                });

            migrationBuilder.CreateTable(
                name: "Maiden",
                columns: table => new
                {
                    IdPerson = table.Column<int>(type: "int", nullable: false),
                    IdMaiden = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinimalAmountOfApartmentsCleaned = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    SpecializedApartmentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdEmployee = table.Column<int>(type: "int", nullable: false),
                    PESEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HiringDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeavingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Workemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maiden", x => x.IdPerson);
                    table.ForeignKey(
                        name: "FK_Maiden_Person_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "Person",
                        principalColumn: "IdPerson");
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    IdPerson = table.Column<int>(type: "int", nullable: false),
                    IdManager = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfSubordinates = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    IdEmployee = table.Column<int>(type: "int", nullable: false),
                    PESEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HiringDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeavingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Workemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.IdPerson);
                    table.ForeignKey(
                        name: "FK_Manager_Person_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "Person",
                        principalColumn: "IdPerson");
                });

            migrationBuilder.CreateTable(
                name: "Porter",
                columns: table => new
                {
                    IdPerson = table.Column<int>(type: "int", nullable: false),
                    IdPorter = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishLevel = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IdEmployee = table.Column<int>(type: "int", nullable: false),
                    PESEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HiringDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeavingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Workemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porter", x => x.IdPerson);
                    table.ForeignKey(
                        name: "FK_Porter_Person_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "Person",
                        principalColumn: "IdPerson");
                });

            migrationBuilder.CreateTable(
                name: "Chef",
                columns: table => new
                {
                    IdPerson = table.Column<int>(type: "int", nullable: false),
                    IdChef = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecifiedCuisine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdRestaurant = table.Column<int>(type: "int", nullable: false),
                    IdEmployee = table.Column<int>(type: "int", nullable: false),
                    PESEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HiringDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeavingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Workemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chef", x => x.IdPerson);
                    table.ForeignKey(
                        name: "FK_Chef_Person_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "Person",
                        principalColumn: "IdPerson");
                    table.ForeignKey(
                        name: "FK_Chef_Restaurant_IdRestaurant",
                        column: x => x.IdRestaurant,
                        principalTable: "Restaurant",
                        principalColumn: "IdRestaurant",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    IdRestaurant = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.IdRestaurant);
                    table.ForeignKey(
                        name: "FK_Menu_Restaurant_IdRestaurant",
                        column: x => x.IdRestaurant,
                        principalTable: "Restaurant",
                        principalColumn: "IdRestaurant",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Table",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: false),
                    IsIndoor = table.Column<bool>(type: "bit", nullable: false),
                    IsInSmokingAre = table.Column<bool>(type: "bit", nullable: false),
                    IsOutdoor = table.Column<bool>(type: "bit", nullable: false),
                    HasUmbrella = table.Column<bool>(type: "bit", nullable: false),
                    IdRestaurant = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.Number);
                    table.ForeignKey(
                        name: "FK_Table_Restaurant_IdRestaurant",
                        column: x => x.IdRestaurant,
                        principalTable: "Restaurant",
                        principalColumn: "IdRestaurant",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Facility",
                columns: table => new
                {
                    IdFacility = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdRoom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.IdFacility);
                    table.ForeignKey(
                        name: "FK_Facility_Room_IdRoom",
                        column: x => x.IdRoom,
                        principalTable: "Room",
                        principalColumn: "IdRoom",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rent",
                columns: table => new
                {
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    ApartmentNumber = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rent", x => new { x.IdClient, x.ApartmentNumber });
                    table.ForeignKey(
                        name: "FK_Rent_Apartment_ApartmentNumber",
                        column: x => x.ApartmentNumber,
                        principalTable: "Apartment",
                        principalColumn: "Number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rent_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "IdPerson",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dish",
                columns: table => new
                {
                    IdDish = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Cuisine = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsVegeterian = table.Column<bool>(type: "bit", nullable: false),
                    IdMenu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dish", x => x.IdDish);
                    table.ForeignKey(
                        name: "FK_Dish_Menu_IdMenu",
                        column: x => x.IdMenu,
                        principalTable: "Menu",
                        principalColumn: "IdRestaurant",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    IdPorter = table.Column<int>(type: "int", nullable: false),
                    TableNumber = table.Column<int>(type: "int", nullable: false),
                    DateOfReservation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfReservationCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => new { x.IdPorter, x.TableNumber });
                    table.ForeignKey(
                        name: "FK_Reservation_Porter_IdPorter",
                        column: x => x.IdPorter,
                        principalTable: "Porter",
                        principalColumn: "IdPerson",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservation_Table_TableNumber",
                        column: x => x.TableNumber,
                        principalTable: "Table",
                        principalColumn: "Number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DamageReport",
                columns: table => new
                {
                    IdDamageReport = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IdFacility = table.Column<int>(type: "int", nullable: false),
                    IdPorter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageReport", x => x.IdDamageReport);
                    table.ForeignKey(
                        name: "FK_DamageReport_Facility_IdFacility",
                        column: x => x.IdFacility,
                        principalTable: "Facility",
                        principalColumn: "IdFacility",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DamageReport_Porter_IdPorter",
                        column: x => x.IdPorter,
                        principalTable: "Porter",
                        principalColumn: "IdPerson",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IngredientDish",
                columns: table => new
                {
                    IdDish = table.Column<int>(type: "int", nullable: false),
                    IdIngredient = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientDish", x => new { x.IdDish, x.IdIngredient });
                    table.ForeignKey(
                        name: "FK_IngredientDish_Dish_IdDish",
                        column: x => x.IdDish,
                        principalTable: "Dish",
                        principalColumn: "IdDish",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IngredientDish_Ingredient_IdIngredient",
                        column: x => x.IdIngredient,
                        principalTable: "Ingredient",
                        principalColumn: "IdIngredient",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FacilityChangeRequest",
                columns: table => new
                {
                    IdFacilityChangeRequest = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfDecision = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IdMaiden = table.Column<int>(type: "int", nullable: false),
                    IdDamageReport = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityChangeRequest", x => x.IdFacilityChangeRequest);
                    table.ForeignKey(
                        name: "FK_FacilityChangeRequest_DamageReport_IdDamageReport",
                        column: x => x.IdDamageReport,
                        principalTable: "DamageReport",
                        principalColumn: "IdDamageReport",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilityChangeRequest_Maiden_IdMaiden",
                        column: x => x.IdMaiden,
                        principalTable: "Maiden",
                        principalColumn: "IdPerson",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Apartment",
                columns: new[] { "Number", "AmountOfDrinks", "ApartmentTypes", "Area", "Description", "HasRoofZone", "NumberOfBeds", "NumberOfChildenBeds" },
                values: new object[,]
                {
                    { 1, null, "Regular", 19.5f, "Description is here.", null, 2, null },
                    { 2, null, "Penthouse", 19.5f, "Description is here.", true, 3, null },
                    { 3, null, "Family", 19.5f, "Description is here.", null, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "IdPerson", "BirthDate", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1, new DateTime(2022, 6, 19, 20, 6, 41, 299, DateTimeKind.Local).AddTicks(5876), "Valerii", "Trembovetsky", "888888888" });

            migrationBuilder.InsertData(
                table: "Porter",
                columns: new[] { "IdPerson", "EnglishLevel", "HiringDate", "IdEmployee", "IdPorter", "LeavingDate", "PESEL", "Password", "Workemail" },
                values: new object[] { 1, "intermediate", new DateTime(2022, 6, 19, 20, 6, 41, 299, DateTimeKind.Local).AddTicks(5911), 1, 1, null, "12312332111", "password", "vtrembovetsky@hotel.com" });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "IdRoom", "ApartmentNumber", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Quite modern bedroom bla bla", "Bedroom" },
                    { 2, 2, "Quite modern bedroom bla bla", "Bedroom" },
                    { 3, 1, "Quite modern kitchen bla bla", "Kitchen" },
                    { 4, 3, "Quite modern bedroom bla bla", "Bedroom" },
                    { 5, 3, "Just after repairs bla bla", "Kids Room" },
                    { 6, 2, "Huge zone for something chillll", "Hall" }
                });

            migrationBuilder.InsertData(
                table: "Facility",
                columns: new[] { "IdFacility", "IdRoom", "Manufacturer", "Name", "Price", "SerialNumber", "Weight" },
                values: new object[,]
                {
                    { 1, 1, "China", "Fride", 140.4f, "SR2312312", 48.4f },
                    { 2, 2, "Samsung", "TV", 249.4f, "SR23123122", 50.4f },
                    { 3, 3, "Ukraine", "Carpet", 16.9f, "SR32312312", 9.4f },
                    { 4, 4, "Poland SR", "Table", 16.9f, null, 9.4f },
                    { 5, 6, "Poland SR", "Sofa", 99.9f, null, 49.4f },
                    { 6, 1, "Finland Corp", "Mirror", 99.9f, null, 10.4f },
                    { 7, 2, "Finland Corp", "Mirror", 99.9f, null, 10.4f },
                    { 8, 3, "Polska", "Stove", 99.9f, null, 10.4f },
                    { 9, 4, "Polska", "TV", 99.9f, null, 10.4f },
                    { 10, 5, "Polska", "Stove", 99.9f, null, 10.4f },
                    { 11, 6, "Polska", "Dishwasher", 99.9f, null, 10.4f },
                    { 12, 5, "Poland SR", "Table", 16.9f, null, 9.4f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chef_IdRestaurant",
                table: "Chef",
                column: "IdRestaurant");

            migrationBuilder.CreateIndex(
                name: "IX_DamageReport_IdFacility",
                table: "DamageReport",
                column: "IdFacility");

            migrationBuilder.CreateIndex(
                name: "IX_DamageReport_IdPorter",
                table: "DamageReport",
                column: "IdPorter");

            migrationBuilder.CreateIndex(
                name: "IX_Dish_IdMenu",
                table: "Dish",
                column: "IdMenu");

            migrationBuilder.CreateIndex(
                name: "IX_Facility_IdRoom",
                table: "Facility",
                column: "IdRoom");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityChangeRequest_IdDamageReport",
                table: "FacilityChangeRequest",
                column: "IdDamageReport",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FacilityChangeRequest_IdMaiden",
                table: "FacilityChangeRequest",
                column: "IdMaiden");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientDish_IdIngredient",
                table: "IngredientDish",
                column: "IdIngredient");

            migrationBuilder.CreateIndex(
                name: "IX_Rent_ApartmentNumber",
                table: "Rent",
                column: "ApartmentNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_TableNumber",
                table: "Reservation",
                column: "TableNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Room_ApartmentNumber",
                table: "Room",
                column: "ApartmentNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Table_IdRestaurant",
                table: "Table",
                column: "IdRestaurant");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chef");

            migrationBuilder.DropTable(
                name: "FacilityChangeRequest");

            migrationBuilder.DropTable(
                name: "IngredientDish");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "Rent");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "DamageReport");

            migrationBuilder.DropTable(
                name: "Maiden");

            migrationBuilder.DropTable(
                name: "Dish");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Table");

            migrationBuilder.DropTable(
                name: "Facility");

            migrationBuilder.DropTable(
                name: "Porter");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropTable(
                name: "Apartment");
        }
    }
}
