using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_Riwi.Migrations
{
    /// <inheritdoc />
    public partial class createOfModelsAndSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    entry_time = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    departure_time = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    role = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "patient",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    role = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patient", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    appointment_time = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    appointment_day = table.Column<DateOnly>(type: "date", nullable: false),
                    patient_id = table.Column<int>(type: "int", nullable: false),
                    doctor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_doctor_id",
                        column: x => x.doctor_id,
                        principalTable: "Doctors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_patient_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patient",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "id", "departure_time", "entry_time", "name", "password", "role" },
                values: new object[,]
                {
                    { 1, new TimeOnly(16, 0, 0), new TimeOnly(8, 0, 0), "john smith", "$2a$11$gtp5M/xBM4qU0MPMMxZ2v.IIncP4iQib0fAa/0.XyqmxWBPUDKZuW", "doctor" },
                    { 2, new TimeOnly(17, 0, 0), new TimeOnly(9, 0, 0), "emily davis", "$2a$11$D.r8CRY591IHzt9.cPO7Oefi4Xn9nLXyWdXvbZqgHTGbSFwRjWpcO", "doctor" },
                    { 3, new TimeOnly(15, 30, 0), new TimeOnly(7, 30, 0), "michael johnson", "$2a$11$D128DCuQSv9Ou2j0F8TfKOMgUctIyLGXBQo9x/GPtWYtNwgtY3yii", "doctor" },
                    { 4, new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0), "sophia brown", "$2a$11$1w1kOm5xxWf16rMtbYLTzOcWNnLf5rC2vlhakl/RdLt7ZAd2NLLNW", "doctor" },
                    { 5, new TimeOnly(14, 0, 0), new TimeOnly(6, 0, 0), "james williams", "$2a$11$2PYe7J49UAINbu7yQUqinuNAAIU4.eH1T1gcvFfr22hnsDnS1e8TK", "doctor" },
                    { 6, new TimeOnly(21, 0, 0), new TimeOnly(13, 0, 0), "olivia martinez", "$2a$11$gLYSCejTumnuhfu00FWOL.OifF7FcW96yh9DmWnZyOkK/zBkkjsr6", "doctor" },
                    { 7, new TimeOnly(20, 0, 0), new TimeOnly(12, 0, 0), "benjamin wilson", "$2a$11$sNsoP3xPn89Z6iENcTR1keA4EWeVhJEbNM775OTa77oHylWFlphqO", "doctor" },
                    { 8, new TimeOnly(19, 0, 0), new TimeOnly(11, 0, 0), "isabella miller", "$2a$11$uWbJgjZY1Z9JXG4rQQjsFedy.Wnj.0GVI/UBuIKqacIDqwbdkcDqi", "doctor" },
                    { 9, new TimeOnly(22, 0, 0), new TimeOnly(14, 0, 0), "elijah garcia", "$2a$11$/Nkk3M7QTh7h2f/p14dc1uspiIV3fNVRYqz8Lm11eg4Y6hIEbcKPa", "doctor" },
                    { 10, new TimeOnly(13, 30, 0), new TimeOnly(5, 30, 0), "amelia clark", "$2a$11$7BVZp9aqHNDyCuCVdK.TFe9gXqQJe19Y.R6S3iR8iFIMDWJKnbNYu", "doctor" }
                });

            migrationBuilder.InsertData(
                table: "patient",
                columns: new[] { "id", "address", "name", "password", "role" },
                values: new object[,]
                {
                    { 1, "alice.green@example.com", "alice green", "$2a$11$qI80t3i0tqFB50BWusapX.ABz788mLYyFO94bXilc6qCavfbuxfKy", "Patient" },
                    { 2, "bob.brown@example.com", "bob brown", "$2a$11$JIlfei2Tail/mr0X67hfge77dfAA/nP3kDiY5xzhJwq9BFAuT26B2", "Patient" },
                    { 3, "charlie.white@example.com", "charlie white", "$2a$11$mdzciIud8Gxxy4LRlIcCNOPkqhvQt2w3FpqMVeHkMsBYIck3Lg6sC", "Patient" },
                    { 4, "diana.black@example.com", "diana black", "$2a$11$am.l4A13KgZnicTM.L6lXOZyXWfTg.L012wPv/UW4pVn/5A.z7lgC", "Patient" },
                    { 5, "edward.harris@example.com", "edward harris", "$2a$11$IB3/qmsz4JqYVLhuZ/MFe.U52S/nbzQnfcgg5RL44MrPWxlQ8X4D6", "Patient" },
                    { 6, "fiona.scott@example.com", "fiona scott", "$2a$11$sIBPAWCdtfBh6uomIUP8MuQ7aPMqjfEcWMvcx9dvX35KvKVKN5FYC", "Patient" },
                    { 7, "george.clark@example.com", "george clark", "$2a$11$ELAdM.oZy84EkIQ2mc.w0u1c2WAGpC2.pxygq7P.uRyf0jtmxyNwu", "Patient" },
                    { 8, "hannah.king@example.com", "hannah king", "$2a$11$N8zgSBvFCJ3HJnYUvVpDfePqxo4cey24yCXpSc0ZlrNsEj0.rgILK", "Patient" },
                    { 9, "ian.wilson@example.com", "ian wilson", "$2a$11$vvXQahB/ZARnXfTV6yhtHO59HWk5.8wZvPCon0DHEAzsHHeiDnz1q", "Patient" },
                    { 10, "julia.turner@example.com", "julia turner", "$2a$11$yqVrn52GxcOdJ5P/2UDJkO68IYqZcif6x/7sC9QamIWJSMHsOK7Ee", "Patient" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "id", "appointment_day", "appointment_time", "doctor_id", "patient_id", "status" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 11, 18), new TimeOnly(9, 30, 0), 2, 1, "scheduled" },
                    { 2, new DateOnly(2024, 11, 20), new TimeOnly(14, 15, 0), 6, 2, "scheduled" },
                    { 3, new DateOnly(2024, 11, 14), new TimeOnly(8, 45, 0), 1, 3, "completed" },
                    { 4, new DateOnly(2024, 11, 22), new TimeOnly(11, 0, 0), 8, 4, "canceled" },
                    { 5, new DateOnly(2024, 11, 25), new TimeOnly(15, 0, 0), 9, 5, "scheduled" },
                    { 6, new DateOnly(2024, 11, 30), new TimeOnly(12, 30, 0), 5, 6, "rescheduled" },
                    { 7, new DateOnly(2024, 11, 27), new TimeOnly(7, 45, 0), 3, 7, "scheduled" },
                    { 8, new DateOnly(2024, 11, 10), new TimeOnly(13, 45, 0), 7, 8, "completed" },
                    { 9, new DateOnly(2024, 11, 23), new TimeOnly(10, 30, 0), 4, 9, "scheduled" },
                    { 10, new DateOnly(2024, 11, 17), new TimeOnly(6, 15, 0), 5, 10, "scheduled" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_doctor_id",
                table: "Appointments",
                column: "doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_patient_id",
                table: "Appointments",
                column: "patient_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "patient");
        }
    }
}
