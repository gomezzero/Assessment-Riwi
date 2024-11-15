using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_Riwi.Migrations
{
    /// <inheritdoc />
    public partial class fixDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "doctors",
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
                    role = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctors", x => x.id);
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
                name: "appointments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    appointment_time = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    appointment_day = table.Column<DateOnly>(type: "date", nullable: false),
                    patient_id = table.Column<int>(type: "int", nullable: false),
                    doctor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointments", x => x.id);
                    table.ForeignKey(
                        name: "FK_appointments_doctors_doctor_id",
                        column: x => x.doctor_id,
                        principalTable: "doctors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_appointments_patient_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patient",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "doctors",
                columns: new[] { "id", "departure_time", "entry_time", "name", "password", "role" },
                values: new object[,]
                {
                    { 1, new TimeOnly(16, 0, 0), new TimeOnly(8, 0, 0), "john smith", "$2a$11$Rqf/r2dysNFHc3q9OkYczu87i85nlLTOgqgeXg1j5eOSAYqO4F2fS", "doctor" },
                    { 2, new TimeOnly(17, 0, 0), new TimeOnly(9, 0, 0), "emily davis", "$2a$11$s0Ws.QlzhPbKjLpqEKv5fOnzT9ySk5sxOdsTgYEiiAqArKEt8CWpa", "doctor" },
                    { 3, new TimeOnly(15, 30, 0), new TimeOnly(7, 30, 0), "michael johnson", "$2a$11$kDUqrf3D3cW0GlQq6xy3ce9O3FMuB7TMJLpXUd041R9Wolk2Gx.qG", "doctor" },
                    { 4, new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0), "sophia brown", "$2a$11$J26ujo7qyuVoj//GN2NprOmLVZMyXi1QeeVJfspp59NTBM3j9Ao8O", "doctor" },
                    { 5, new TimeOnly(14, 0, 0), new TimeOnly(6, 0, 0), "james williams", "$2a$11$6GNF.XTIU1YurQUKv/kqr.JvII0sCKeX/ue8EFGIG2Bw/elNTy.qq", "doctor" },
                    { 6, new TimeOnly(21, 0, 0), new TimeOnly(13, 0, 0), "olivia martinez", "$2a$11$CKvAZI9Ic0yu6AkqqeI7xe0hEulXLhZNoQnuCeaDu4zAuHv9koXuq", "doctor" },
                    { 7, new TimeOnly(20, 0, 0), new TimeOnly(12, 0, 0), "benjamin wilson", "$2a$11$W4thB1nCaMBTVj10tm8ilefTppjipGBY9LO8c6a9smeLy5mYcQ1sy", "doctor" },
                    { 8, new TimeOnly(19, 0, 0), new TimeOnly(11, 0, 0), "isabella miller", "$2a$11$ulrU4/oiwSeVkGSHhEzbRewrLslwRwTfBptMuWrXkwp1jhsCzxXTO", "doctor" },
                    { 9, new TimeOnly(22, 0, 0), new TimeOnly(14, 0, 0), "elijah garcia", "$2a$11$CJBlP.PNlu5nT5eLOk811uBYZENcRk3uy3kAbC0Ewj96jIBqmlFZa", "doctor" },
                    { 10, new TimeOnly(13, 30, 0), new TimeOnly(5, 30, 0), "amelia clark", "$2a$11$NczxXe8a1.w.52fTft9QyukUWMUrJuvecjiKI1d9WNT4KrqWGU/Ie", "doctor" }
                });

            migrationBuilder.InsertData(
                table: "patient",
                columns: new[] { "id", "address", "name", "password", "role" },
                values: new object[,]
                {
                    { 1, "alice.green@example.com", "alice green", "$2a$11$NW028I4bGiUkEnTIKP4sa.bIbwZVkcdg9/uDUHwYNL78tuU7xhHZG", "patient" },
                    { 2, "bob.brown@example.com", "bob brown", "$2a$11$ATBvBmcGxyT8RkoFHvm2SeqUINk98sFwxcMTxq8vLYAOCWUWM3dMC", "patient" },
                    { 3, "charlie.white@example.com", "charlie white", "$2a$11$q1J4lFtBHft1rhlsp3GPxepymSsQiSAaykCwwlGIc1dbubsxZHhym", "patient" },
                    { 4, "diana.black@example.com", "diana black", "$2a$11$fGN.ivwEIuzOetoxZMB8red026LOCnNoSf1/Wuz0IP3BsSGaxLSA6", "patient" },
                    { 5, "edward.harris@example.com", "edward harris", "$2a$11$/OBKKOzAHZxYApboXZNEneoPRId6pGbrz5SaPlMP612iXUM3eypoS", "patient" },
                    { 6, "fiona.scott@example.com", "fiona scott", "$2a$11$Est.vxJXXJ1woQiBAHRNseZyd5GvjtG/iNW7gXydGbXgNMnGbjzSW", "patient" },
                    { 7, "george.clark@example.com", "george clark", "$2a$11$YVuOOlV9ZPL047zBRwbkjesWdz8vN1bGny3em60ZY6aT111/u5yFy", "patient" },
                    { 8, "hannah.king@example.com", "hannah king", "$2a$11$Cv3xDyWxydmHQLqeVBFpceFl23jqG8gG9GeA9enGNty.JN8HiOl7C", "patient" },
                    { 9, "ian.wilson@example.com", "ian wilson", "$2a$11$ZPQ5GFaSByvU3h6h.fxc9ecSkZdRC14z9802HiyDkpBh1QqsNsSW.", "patient" },
                    { 10, "julia.turner@example.com", "julia turner", "$2a$11$YS9kKNFEiex/ZwNLgPBNAOP8V7sAkuX.Cm0F/yrcTDKuohYeDGAWW", "patient" }
                });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "id", "appointment_day", "appointment_time", "description", "doctor_id", "patient_id", "status" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 11, 18), new TimeOnly(9, 30, 0), "check-up with dr. martinez", 2, 1, "scheduled" },
                    { 2, new DateOnly(2024, 11, 20), new TimeOnly(14, 15, 0), "follow-up consultation", 6, 2, "scheduled" },
                    { 3, new DateOnly(2024, 11, 14), new TimeOnly(8, 45, 0), "routine physical exam", 1, 3, "completed" },
                    { 4, new DateOnly(2024, 11, 22), new TimeOnly(11, 0, 0), "dental check-up", 8, 4, "canceled" },
                    { 5, new DateOnly(2024, 11, 25), new TimeOnly(15, 0, 0), "general health assessment", 9, 5, "scheduled" },
                    { 6, new DateOnly(2024, 11, 30), new TimeOnly(12, 30, 0), "eye examination", 5, 6, "rescheduled" },
                    { 7, new DateOnly(2024, 11, 27), new TimeOnly(7, 45, 0), "annual check-up", 3, 7, "scheduled" },
                    { 8, new DateOnly(2024, 11, 10), new TimeOnly(13, 45, 0), "post-surgery follow-up", 7, 8, "completed" },
                    { 9, new DateOnly(2024, 11, 23), new TimeOnly(10, 30, 0), "consultation on chronic pain", 4, 9, "scheduled" },
                    { 10, new DateOnly(2024, 11, 17), new TimeOnly(6, 15, 0), "vaccination", 5, 10, "scheduled" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_appointments_doctor_id",
                table: "appointments",
                column: "doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_appointments_patient_id",
                table: "appointments",
                column: "patient_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appointments");

            migrationBuilder.DropTable(
                name: "doctors");

            migrationBuilder.DropTable(
                name: "patient");
        }
    }
}
