using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assessment_Riwi.Migrations
{
    /// <inheritdoc />
    public partial class AddDoctorUniqueIdentifier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctors_doctor_id",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_patient_patient_id",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.RenameTable(
                name: "Doctors",
                newName: "doctors");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "appointments");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_patient_id",
                table: "appointments",
                newName: "IX_appointments_patient_id");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_doctor_id",
                table: "appointments",
                newName: "IX_appointments_doctor_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_doctors",
                table: "doctors",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointments",
                table: "appointments",
                column: "id");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$gVK80d/aq30DFbTCVhVkLOG0jp9FqsRpGegERiyc08Y7/poNcPQb6");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$n6iFAkXI7BOskqW0sGACzeUXJnZnYqJ7R6bVTfnaBV1p60fAY6Ple");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$uPFjG/rApiAsFCaasB1ygOs45xkNxWWPFRaUD7/mH4VNdy5Eqa1pK");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$Le6WcFjhypYOPdSXOgMMO.4MC7A34Me6JLIuNcSTrPXCs.D.A3FS2");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$QM0RYA7TMqRi6/y1KaztGOh/UZn.k2FYIpn6nu3IiHlxW2jP9FrlK");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$Vj36vb45zMYlvfGmvFmJGOSYBNZzDRr9MtgT0pX2nLbtGADjnghpK");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$n8AQLYn4wE1h0cjAI3XUqexzLaPZcNEbUADC74D2ZHJCXQKoO/NM6");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$kPETeApz2jKxdh2DsUg7s.dVxlUQOJMS/c.DDK5uawq502YoDPlFO");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 9,
                column: "password",
                value: "$2a$11$rQu6zNJpbBjtaBOVneCSE.UPkrNFg9EaXAO1QO7YKaRjrH5MOPZZq");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 10,
                column: "password",
                value: "$2a$11$WdgNEBaG0Ki5B7SFya28/ea13MOg4/Qvthh7NVmj4KMsKr489fkxW");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$bHv06tjMz7rtJdn6vbotgu/f8UvFiy8BzXuqyKtNiS2IkWG1bPsKq");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$3hiWuAxx4LKnqcF1uj3BFu5dkp3LZHlpXXnGyIjiOTSxq2VFiXuwW");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$yUd0GeDn22EdOpq1QtF42uI7QXeLuoF/pAE9n/8yNeDK.Z5DG6Pf6");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$49SMxGcUdL/tK2L1ML9/EOwWHm5PJmxYoi8fdWESsbxmkcN7TLq.u");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$d3Kd/XHATDJFZIdbbbqxkOh/gC12QvlEkAkbg7Lq6sqqXtmBpaHFO");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$2WMcvkynZgnQ13Jdjq/UV.9w4WEQ3kCa3eCKQd7EUgy0rxUJuJxHi");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$2j8cj/QnHBa8WBavOm3ZC.qbt3zJrr/SIjQ0lj8FJBJ5aEZTXC1DC");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$xJQH72CNUW5KnP0jXmQD6O/ryyQLyq21gUXFLR/EtAMAOGM90gkje");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 9,
                column: "password",
                value: "$2a$11$kZD6R8UMZ5fmLUbdDAgydO8JvN/3Rh4O0tlmkfCUOKLy7y1andM5q");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 10,
                column: "password",
                value: "$2a$11$sBZpZlrqi6ukxJDkP4p9YudN2C4BHJeQ6vNjIoGgu35Z5az/FbRL2");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_doctors_doctor_id",
                table: "appointments",
                column: "doctor_id",
                principalTable: "doctors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_patient_patient_id",
                table: "appointments",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_doctors_doctor_id",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_appointments_patient_patient_id",
                table: "appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_doctors",
                table: "doctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_appointments",
                table: "appointments");

            migrationBuilder.RenameTable(
                name: "doctors",
                newName: "Doctors");

            migrationBuilder.RenameTable(
                name: "appointments",
                newName: "Appointments");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_patient_id",
                table: "Appointments",
                newName: "IX_Appointments_patient_id");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_doctor_id",
                table: "Appointments",
                newName: "IX_Appointments_doctor_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "id");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$fYtTJn237bODly7/CieC9..o.ntTOpB/Ln1Sm6z0.g6jsFWtT4OSG");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$QLDPQzeC7RNujoTtFApFR.Q6n.Mitst5wDF8JPBSxH3uGv1P1JLVy");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$2EolWgi9kZ4/OO8Gls07YONcw5dIr1J8gee3V9nPnnBrvP9bsTYrK");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$Watq2GrIiY4Job9yT/gjHe3680HpEuxHc2cHdz4TSeanl1Xou3wXK");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$zo8fTq5FY3UaTXrx3qvkAOav8269VG2Uk2M93tkLBAudoW.weJ7oq");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$xlWDC.W7R3O4gASt6Y8NW.faULr.tSbyfzLLPG1SYgz1B20KuyIMK");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$OlkJD1kL4gUMW7V2dqakhePkjTeAyY5s0JBmLmMyH.Jl5OIf26wT.");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$n2MOKNALTFHd2P29ZVe3KeI3CbXK2SgQoUEoz56PgMl5n.MehyPO2");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 9,
                column: "password",
                value: "$2a$11$lBUS5cNw0kl9MLQAX1wv8.LN8cg9ayWIllK.CRL7xekE4U.VpwrOy");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 10,
                column: "password",
                value: "$2a$11$oKJ.UEXdCdxjoU6BWa.BCOoZGKBSLfMa5Fu3IZjUbtIatDIGjwxgO");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$eFfQEOve7sPD03aE7IVMiufsKbmnq0o.bWrU7eag1HJqHe9IwyIGC");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$YKjHlqDSvBljqKsC3kDFhuLqMYkAlHfw2YTbNQ2Elm9DkeNClYmQK");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$tSM3hP9DHdZBSEs/f//yiuzZMnY1iEYlYf5zdO9eG3nxW3I4Uyf0S");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$SUf5LfbPp9HkFG07T4XlXeN3gyxqaF887HfvLjcmN8YfdY5PNZy1a");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$xfZQoE0P6HhIWyK1eq2JAuWqOAJua3iLMTLOWapEQXWJMLzom.BSG");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$geCCAI.qlzERxZ.a5tajHODhRH/tHEYLAEAs0QPq17Owsej7FbtzS");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$YqoAbn02Vxqmrh1pIRUm1umyzjQS5pwr4h2BwjdGe2HZUNBWg2Lfu");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$yYz7KTb150QFWF/nSvOGGuNUQS29HH88Se3gZnkRFtFy/Ojy5S5LK");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 9,
                column: "password",
                value: "$2a$11$0LE3SE38oypHJXJjlwGBlOU6/TXXwuw1TVESUQ8mBJ/90/gsBhVyW");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 10,
                column: "password",
                value: "$2a$11$soUrEOriB48xYLl.fsAk4.Sx8XTW8OHa8yB3ThIBfD6md2XH4rQDG");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctors_doctor_id",
                table: "Appointments",
                column: "doctor_id",
                principalTable: "Doctors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_patient_patient_id",
                table: "Appointments",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
