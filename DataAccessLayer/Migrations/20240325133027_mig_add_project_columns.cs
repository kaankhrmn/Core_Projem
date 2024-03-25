﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_project_columns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "İmageUrl2",
            //    table: "Portfolios",
            //    newName: "Price");

            migrationBuilder.RenameColumn(
                name: "ProjectUrl",
                table: "Portfolios",
                newName: "Platform");

            //migrationBuilder.AddColumn<string>(
            //    name: "Image1",
            //    table: "Portfolios",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "Image2",
            //    table: "Portfolios",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "Image3",
            //    table: "Portfolios",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "Image4",
            //    table: "Portfolios",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<bool>(
            //    name: "Status",
            //    table: "Portfolios",
            //    type: "bit",
            //    nullable: false,
            //    defaultValue: false);

            //migrationBuilder.AddColumn<int>(
            //    name: "Value",
            //    table: "Portfolios",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "Image1",
            //    table: "Portfolios");

            //migrationBuilder.DropColumn(
            //    name: "Image2",
            //    table: "Portfolios");

            //migrationBuilder.DropColumn(
            //    name: "Image3",
            //    table: "Portfolios");

            //migrationBuilder.DropColumn(
            //    name: "Image4",
            //    table: "Portfolios");

            //migrationBuilder.DropColumn(
            //    name: "Status",
            //    table: "Portfolios");

            //migrationBuilder.DropColumn(
            //    name: "Value",
            //    table: "Portfolios");

            //migrationBuilder.RenameColumn(
            //    name: "Price",
            //    table: "Portfolios",
            //    newName: "İmageUrl2");

            migrationBuilder.RenameColumn(
                name: "Platform",
                table: "Portfolios",
                newName: "ProjectUrl");
        }
    }
}