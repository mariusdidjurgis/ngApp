﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ngApp.Web.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO makes (name) VALUES ('Audi'), ('BMW'), ('Mercedes-Benz'), ('Volvo'), ('Volkswagen')");

            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('A1', (select Id from makes WHERE name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('A3', (select Id from makes WHERE name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('A4', (select Id from makes WHERE name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('A5', (select Id from makes WHERE name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('A6', (select Id from makes WHERE name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('A7', (select Id from makes WHERE name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('A8', (select Id from makes WHERE name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('Q2', (select Id from makes WHERE name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('Q3', (select Id from makes WHERE name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('Q5', (select Id from makes WHERE name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('Q7', (select Id from makes WHERE name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('TT', (select Id from makes WHERE name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('R8', (select Id from makes WHERE name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('e-tron', (select Id from makes WHERE name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('2 series', (select Id from makes WHERE name = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('3 series', (select Id from makes WHERE name = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('4 series', (select Id from makes WHERE name = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('5 series', (select Id from makes WHERE name = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('X1', (select Id from makes WHERE name = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('X2', (select Id from makes WHERE name = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('X3', (select Id from makes WHERE name = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('X4', (select Id from makes WHERE name = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('X5', (select Id from makes WHERE name = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('X6', (select Id from makes WHERE name = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('V40', (select Id from makes WHERE name = 'Volvo'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('V60', (select Id from makes WHERE name = 'Volvo'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('V90', (select Id from makes WHERE name = 'Volvo'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('XC40', (select Id from makes WHERE name = 'Volvo'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('XC60', (select Id from makes WHERE name = 'Volvo'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('XC90', (select Id from makes WHERE name = 'Volvo'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('S60', (select Id from makes WHERE name = 'Volvo'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('S90', (select Id from makes WHERE name = 'Volvo'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('Golf', (select Id from makes WHERE name = 'Volkswagen'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('e-Golf', (select Id from makes WHERE name = 'Volkswagen'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('Polo', (select Id from makes WHERE name = 'Volkswagen'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('Pasat', (select Id from makes WHERE name = 'Volkswagen'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('Tiguan', (select Id from makes WHERE name = 'Volkswagen'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('Touareg', (select Id from makes WHERE name = 'Volkswagen'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('Arteon', (select Id from makes WHERE name = 'Volkswagen'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('Sharan', (select Id from makes WHERE name = 'Volkswagen'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('Touran', (select Id from makes WHERE name = 'Volkswagen'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('Amarok', (select Id from makes WHERE name = 'Volkswagen'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('Caddy', (select Id from makes WHERE name = 'Volkswagen'))");
            migrationBuilder.Sql("INSERT INTO models (name, makeId) VALUES ('Transporter', (select Id from makes WHERE name = 'Volkswagen'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM makes");

        }
    }
}
