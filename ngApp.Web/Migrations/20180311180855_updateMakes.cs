using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ngApp.Web.Migrations
{
    public partial class updateMakes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE makes SET HeadQuatersLocation = 'Ingolstadt, Germany', Date = '1910-04-25' WHERE name = 'Audi'");
            migrationBuilder.Sql("UPDATE makes SET HeadQuatersLocation = 'Munich, Germany', Date = '1916-03-07' WHERE name = 'BMW'");
            migrationBuilder.Sql("UPDATE makes SET HeadQuatersLocation = 'Stuttgart, Germany', Date = '1926-06-28' WHERE name = 'Mercedes-Benz'");
            migrationBuilder.Sql("UPDATE makes SET HeadQuatersLocation = 'Gothenburg, Sweden', Date = '1927-01-01' WHERE name = 'Volvo'");
            migrationBuilder.Sql("UPDATE makes SET HeadQuatersLocation = 'Wolfsburg, Germany', Date = '1937-05-28' WHERE name = 'Volkswagen'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE makes SET HeadQuatersLocation = '', Date = GETDATE()");
        }
    }
}
