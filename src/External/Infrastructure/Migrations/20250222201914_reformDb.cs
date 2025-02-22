using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class reformDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 500, DateTimeKind.Utc).AddTicks(5893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 368, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 500, DateTimeKind.Utc).AddTicks(4926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 368, DateTimeKind.Utc).AddTicks(893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 503, DateTimeKind.Utc).AddTicks(4325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 368, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 503, DateTimeKind.Utc).AddTicks(2227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 368, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutEquipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 502, DateTimeKind.Utc).AddTicks(2107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 368, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutEquipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 502, DateTimeKind.Utc).AddTicks(336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 368, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutAgeRanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 501, DateTimeKind.Utc).AddTicks(2766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 368, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutAgeRanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 501, DateTimeKind.Utc).AddTicks(643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 368, DateTimeKind.Utc).AddTicks(2642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 498, DateTimeKind.Utc).AddTicks(5163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 498, DateTimeKind.Utc).AddTicks(4406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Sports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 500, DateTimeKind.Utc).AddTicks(216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Sports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 499, DateTimeKind.Utc).AddTicks(9191),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 494, DateTimeKind.Utc).AddTicks(1060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 493, DateTimeKind.Utc).AddTicks(9996),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 496, DateTimeKind.Utc).AddTicks(1483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 496, DateTimeKind.Utc).AddTicks(521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(4788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 495, DateTimeKind.Utc).AddTicks(6462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(3350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 495, DateTimeKind.Utc).AddTicks(5592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanEquipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 495, DateTimeKind.Utc).AddTicks(663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanEquipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 494, DateTimeKind.Utc).AddTicks(9781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 494, DateTimeKind.Utc).AddTicks(5529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(9365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 494, DateTimeKind.Utc).AddTicks(4580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "MusclePriorities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 493, DateTimeKind.Utc).AddTicks(5737),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(5745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "MusclePriorities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 493, DateTimeKind.Utc).AddTicks(4749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Exercises",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 493, DateTimeKind.Utc).AddTicks(275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Exercises",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 492, DateTimeKind.Utc).AddTicks(9343),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(3501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Equipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 499, DateTimeKind.Utc).AddTicks(5040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(7391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Equipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 499, DateTimeKind.Utc).AddTicks(4201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 492, DateTimeKind.Utc).AddTicks(3191),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 492, DateTimeKind.Utc).AddTicks(2293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(1098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "BodyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 499, DateTimeKind.Utc).AddTicks(173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(5447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BodyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 498, DateTimeKind.Utc).AddTicks(8998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Bodies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 491, DateTimeKind.Utc).AddTicks(7327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 364, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bodies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 491, DateTimeKind.Utc).AddTicks(5697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 364, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Bodies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Athletes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 496, DateTimeKind.Utc).AddTicks(8888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Athletes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 496, DateTimeKind.Utc).AddTicks(8022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(7524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "AthleteInjuries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 497, DateTimeKind.Utc).AddTicks(9708),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AthleteInjuries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 497, DateTimeKind.Utc).AddTicks(8588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "AthleteImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 497, DateTimeKind.Utc).AddTicks(4602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AthleteImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 497, DateTimeKind.Utc).AddTicks(3744),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(9588));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Bodies");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 368, DateTimeKind.Utc).AddTicks(1189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 500, DateTimeKind.Utc).AddTicks(5893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 368, DateTimeKind.Utc).AddTicks(893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 500, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 368, DateTimeKind.Utc).AddTicks(6912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 503, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 368, DateTimeKind.Utc).AddTicks(6533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 503, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutEquipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 368, DateTimeKind.Utc).AddTicks(4647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 502, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutEquipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 368, DateTimeKind.Utc).AddTicks(4289),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 502, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutAgeRanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 368, DateTimeKind.Utc).AddTicks(2988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 501, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutAgeRanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 368, DateTimeKind.Utc).AddTicks(2642),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 501, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(3742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 498, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(3435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 498, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Sports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(9151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 500, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Sports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(8858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 499, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(7781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 494, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(7434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 493, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(5082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 496, DateTimeKind.Utc).AddTicks(1483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(4788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 496, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(3350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 495, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(2877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 495, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanEquipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(1236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 495, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanEquipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 494, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(9365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 494, DateTimeKind.Utc).AddTicks(5529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(9066),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 494, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "MusclePriorities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(5745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 493, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "MusclePriorities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(5446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 493, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Exercises",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(3942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 493, DateTimeKind.Utc).AddTicks(275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Exercises",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(3501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 492, DateTimeKind.Utc).AddTicks(9343));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Equipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(7391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 499, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Equipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(6987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 499, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(1443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 492, DateTimeKind.Utc).AddTicks(3191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 365, DateTimeKind.Utc).AddTicks(1098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 492, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "BodyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(5447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 499, DateTimeKind.Utc).AddTicks(173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BodyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(5129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 498, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Bodies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 364, DateTimeKind.Utc).AddTicks(9831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 491, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bodies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 364, DateTimeKind.Utc).AddTicks(9492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 491, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Athletes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(7866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 496, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Athletes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(7524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 496, DateTimeKind.Utc).AddTicks(8022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "AthleteInjuries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(1705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 497, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AthleteInjuries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 367, DateTimeKind.Utc).AddTicks(1421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 497, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "AthleteImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(9967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 497, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AthleteImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 12, 0, 59, 366, DateTimeKind.Utc).AddTicks(9588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 497, DateTimeKind.Utc).AddTicks(3744));
        }
    }
}
