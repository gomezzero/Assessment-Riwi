using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assessment_Riwi.Migrations
{
    /// <inheritdoc />
    public partial class fixadrresDoctors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "doctors",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "address", "password" },
                values: new object[] { "smith.gomez@email.com", "$2a$11$Jwa4yGhoLIY31DxKtX4Cf.T20vYUYqrk/hvavRz0cDn5VU0ryjAXy" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "address", "password" },
                values: new object[] { "davis.gomez@email.com", "$2a$11$lK9hyALcCcxXZ1sZtOK78ec6JrjkwBgfuNqK8cqKt89hcGVVHLwI." });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "address", "password" },
                values: new object[] { "johnson.gomez@email.com", "$2a$11$KOLUu8pyDF9VGb7YHf93T.1m6yVd6Gsivm6Lah1sx7rJVuF9x8Nqy" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "address", "password" },
                values: new object[] { "brown.gomez@email.com", "$2a$11$zp94w.8gBBbmfUlgcb80su97HMCR7A0/l6taSKdfga5jRt6VHj2r2" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "address", "password" },
                values: new object[] { "james.gomez@email.com", "$2a$11$1.n.TLnaqSVaeZvwE6s1C.r2dMkUd6G55cVFyfbRVgbMUI8.PCwbO" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "address", "password" },
                values: new object[] { "olivia.gomez@email.com", "$2a$11$IEH/Yd9LcOLqofdVNNodHuT4sXDn4eap6J3XR8CB06KMKCogc9vaK" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "address", "password" },
                values: new object[] { "benjamin.gomez@email.com", "$2a$11$9EvYWa5qzomSrXmIC77KS.7W2oQgE1whED7UV07QQG6E0S8TPW4.O" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "address", "password" },
                values: new object[] { "miller.gomez@email.com", "$2a$11$qm0CFGelAAUfbcWBW1ktAucH2cQoBQSAtVb0.bwsGA.Ht5j1WoXie" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "address", "password" },
                values: new object[] { "clark.gomez@email.com", "$2a$11$5NJiFbx.D0EG9QqqrYUQ2.Y1kT0FDXUzZ.VztzcgFaztDTEBO7zRu" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "address", "password" },
                values: new object[] { "garcia.gomez@email.com", "$2a$11$lHZRU/wNlFhGj4NsieM69Or3PhNmbzHT8.1J7JOX2Iy/kkCKFQzRi" });

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$mzPDxc3UAWpZMlEJmj3xGu8/t8hduW7BIpGOfH0Sm/WA21fLeIF6C");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$p/ZxWzcYD1VBB8rPUY2pH.mG3JNRdmsxPq8oXu2S46YkMF6mz7.a6");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$7sq.MGjwnhDR0f0.Js2eeeq6tT3RTPdJCEfhspg5MJg8aE87NhBzO");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$8MgHntp9MZQoUn4GcUkthOoogYudVkrDR60pcEFL4255aSG1l.1Cu");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$yQk7nGI7JklrbGI46re2kOLiWpQD4QRahIHVTCqKiUz68mTRc2Xza");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$cKKLYVY1Dw9GdbM4oa836.KCXrGJxecGdkgQWpZazbZu56B.vA6hO");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$Gq9B4zFDP3.wPIk6zbklaO8bV4I6tnlen74X2LPqsgwwoLaAw0XnK");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$BYkjWoj9CXZTchiPWeas2uJyvnStIMmijmRJLDgL.2g20JKQxeJUi");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 9,
                column: "password",
                value: "$2a$11$kONP/NJV7AABXheAP4sO9O36SRw2PAQbXnvzyk7DMMnnQgMTdHpJ6");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 10,
                column: "password",
                value: "$2a$11$iHZKi05e3jDtra0E9sSXUOwHhiSZqUwvPTddJE05Q.Yx88ff8JEtO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "doctors");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$Rqf/r2dysNFHc3q9OkYczu87i85nlLTOgqgeXg1j5eOSAYqO4F2fS");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$s0Ws.QlzhPbKjLpqEKv5fOnzT9ySk5sxOdsTgYEiiAqArKEt8CWpa");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$kDUqrf3D3cW0GlQq6xy3ce9O3FMuB7TMJLpXUd041R9Wolk2Gx.qG");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$J26ujo7qyuVoj//GN2NprOmLVZMyXi1QeeVJfspp59NTBM3j9Ao8O");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$6GNF.XTIU1YurQUKv/kqr.JvII0sCKeX/ue8EFGIG2Bw/elNTy.qq");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$CKvAZI9Ic0yu6AkqqeI7xe0hEulXLhZNoQnuCeaDu4zAuHv9koXuq");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$W4thB1nCaMBTVj10tm8ilefTppjipGBY9LO8c6a9smeLy5mYcQ1sy");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$ulrU4/oiwSeVkGSHhEzbRewrLslwRwTfBptMuWrXkwp1jhsCzxXTO");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 9,
                column: "password",
                value: "$2a$11$CJBlP.PNlu5nT5eLOk811uBYZENcRk3uy3kAbC0Ewj96jIBqmlFZa");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 10,
                column: "password",
                value: "$2a$11$NczxXe8a1.w.52fTft9QyukUWMUrJuvecjiKI1d9WNT4KrqWGU/Ie");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$NW028I4bGiUkEnTIKP4sa.bIbwZVkcdg9/uDUHwYNL78tuU7xhHZG");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$ATBvBmcGxyT8RkoFHvm2SeqUINk98sFwxcMTxq8vLYAOCWUWM3dMC");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$q1J4lFtBHft1rhlsp3GPxepymSsQiSAaykCwwlGIc1dbubsxZHhym");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$fGN.ivwEIuzOetoxZMB8red026LOCnNoSf1/Wuz0IP3BsSGaxLSA6");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$/OBKKOzAHZxYApboXZNEneoPRId6pGbrz5SaPlMP612iXUM3eypoS");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$Est.vxJXXJ1woQiBAHRNseZyd5GvjtG/iNW7gXydGbXgNMnGbjzSW");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$YVuOOlV9ZPL047zBRwbkjesWdz8vN1bGny3em60ZY6aT111/u5yFy");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$Cv3xDyWxydmHQLqeVBFpceFl23jqG8gG9GeA9enGNty.JN8HiOl7C");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 9,
                column: "password",
                value: "$2a$11$ZPQ5GFaSByvU3h6h.fxc9ecSkZdRC14z9802HiyDkpBh1QqsNsSW.");

            migrationBuilder.UpdateData(
                table: "patient",
                keyColumn: "id",
                keyValue: 10,
                column: "password",
                value: "$2a$11$YS9kKNFEiex/ZwNLgPBNAOP8V7sAkuX.Cm0F/yrcTDKuohYeDGAWW");
        }
    }
}
