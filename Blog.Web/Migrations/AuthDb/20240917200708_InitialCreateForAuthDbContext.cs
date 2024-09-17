using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class InitialCreateForAuthDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b8de756-ab7e-4424-b9ec-b380802e54d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73b4a811-5e85-4bf3-89a9-815a37b1a00e", "AQAAAAIAAYagAAAAEAazQe6a/7pA3LOvaf059Hh3LcMyW4T1LVWw0Al5nPiDFabOLi0/td1moERPWIFh+w==", "ef4c7e75-888c-49c8-a5aa-674973bc1d27" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b8de756-ab7e-4424-b9ec-b380802e54d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad77497d-d9be-49f0-84fa-fd170e7b8d45", "AQAAAAIAAYagAAAAELMoHW7u6Lw2CvszIm3UGgMJ3Ah6zCpCWnfoeSyViY1Xd91IyjHDr8EQUyzux9TioA==", "aa7d6896-5a65-4016-b108-6ce32d960ebe" });
        }
    }
}
