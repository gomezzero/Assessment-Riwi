using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assessment_Riwi.Migrations
{
    /// <inheritdoc />
    public partial class createOfModelsAndSeeders2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Appointments",
                type: "varchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 1,
                column: "description",
                value: "check-up with dr. martinez");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 2,
                column: "description",
                value: "follow-up consultation");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 3,
                column: "description",
                value: "routine physical exam");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 4,
                column: "description",
                value: "dental check-up");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 5,
                column: "description",
                value: "general health assessment");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 6,
                column: "description",
                value: "eye examination");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 7,
                column: "description",
                value: "annual check-up");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 8,
                column: "description",
                value: "post-surgery follow-up");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 9,
                column: "description",
                value: "consultation on chronic pain");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 10,
                column: "description",
                value: "vaccination");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$gtp5M/xBM4qU0MPMMxZ2v.IIncP4iQib0fAa/0.XyqmxWBPUDKZuW");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$D.r8CRY591IHzt9.cPO7Oefi4Xn9nLXyWdXvbZqgHTGbSFwRjWpcO");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$D128DCuQSv9Ou2j0F8TfKOMgUctIyLGXBQo9x/GPtWYtNwgtY3yii");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$1w1kOm5xxWf16rMtbYLTzOcWNnLf5rC2vlhakl/RdLt7ZAd2NLLNW");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$2PYe7J49UAINbu7yQUqinuNAAIU4.eH1T1gcvFfr22hnsDnS1e8TK");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$gLYSCejTumnuhfu00FWOL.OifF7FcW96yh9DmWnZyOkK/zBkkjsr6");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$sNsoP3xPn89Z6iENcTR1keA4EWeVhJEbNM775OTa77oHylWFlphqO");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$uWbJgjZY1Z9JXG4rQQjsFedy.Wnj.0GVI/UBuIKqacIDqwbdkcDqi");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 9,
                column: "password",
                value: "$2a$11$/Nkk3M7QTh7h2f/p14dc1uspiIV3fNVRYqz8Lm11eg4Y6hIEbcKPa");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 10,
                column: "password",
                value: "$2a$11$7BVZp9aqHNDyCuCVdK.TFe9gXqQJe19Y.R6S3iR8iFIMDWJKnbNYu");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$qI80t3i0tqFB50BWusapX.ABz788mLYyFO94bXilc6qCavfbuxfKy");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$JIlfei2Tail/mr0X67hfge77dfAA/nP3kDiY5xzhJwq9BFAuT26B2");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$mdzciIud8Gxxy4LRlIcCNOPkqhvQt2w3FpqMVeHkMsBYIck3Lg6sC");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$am.l4A13KgZnicTM.L6lXOZyXWfTg.L012wPv/UW4pVn/5A.z7lgC");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$IB3/qmsz4JqYVLhuZ/MFe.U52S/nbzQnfcgg5RL44MrPWxlQ8X4D6");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$sIBPAWCdtfBh6uomIUP8MuQ7aPMqjfEcWMvcx9dvX35KvKVKN5FYC");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$ELAdM.oZy84EkIQ2mc.w0u1c2WAGpC2.pxygq7P.uRyf0jtmxyNwu");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$N8zgSBvFCJ3HJnYUvVpDfePqxo4cey24yCXpSc0ZlrNsEj0.rgILK");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 9,
                column: "password",
                value: "$2a$11$vvXQahB/ZARnXfTV6yhtHO59HWk5.8wZvPCon0DHEAzsHHeiDnz1q");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 10,
                column: "password",
                value: "$2a$11$yqVrn52GxcOdJ5P/2UDJkO68IYqZcif6x/7sC9QamIWJSMHsOK7Ee");
        }
    }
}
