using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAutoIdIncrementToConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 246, DateTimeKind.Utc).AddTicks(7440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 500, DateTimeKind.Utc).AddTicks(5893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 246, DateTimeKind.Utc).AddTicks(6570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 500, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 248, DateTimeKind.Utc).AddTicks(5018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 503, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 248, DateTimeKind.Utc).AddTicks(3951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 503, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutEquipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 247, DateTimeKind.Utc).AddTicks(7692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 502, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutEquipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 247, DateTimeKind.Utc).AddTicks(6676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 502, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutAgeRanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 247, DateTimeKind.Utc).AddTicks(2614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 501, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutAgeRanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 247, DateTimeKind.Utc).AddTicks(1426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 501, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 244, DateTimeKind.Utc).AddTicks(5101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 498, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 244, DateTimeKind.Utc).AddTicks(4146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 498, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Sports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 246, DateTimeKind.Utc).AddTicks(1015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 500, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Sports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 245, DateTimeKind.Utc).AddTicks(9968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 499, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 239, DateTimeKind.Utc).AddTicks(7231),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 494, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 239, DateTimeKind.Utc).AddTicks(6223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 493, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 241, DateTimeKind.Utc).AddTicks(9477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 496, DateTimeKind.Utc).AddTicks(1483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 241, DateTimeKind.Utc).AddTicks(8497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 496, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 241, DateTimeKind.Utc).AddTicks(4368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 495, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 241, DateTimeKind.Utc).AddTicks(3484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 495, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanEquipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 240, DateTimeKind.Utc).AddTicks(8033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 495, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanEquipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 240, DateTimeKind.Utc).AddTicks(7050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 494, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 240, DateTimeKind.Utc).AddTicks(2498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 494, DateTimeKind.Utc).AddTicks(5529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 240, DateTimeKind.Utc).AddTicks(1016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 494, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "MusclePriorities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 239, DateTimeKind.Utc).AddTicks(1561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 493, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "MusclePriorities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 239, DateTimeKind.Utc).AddTicks(661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 493, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Exercises",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 238, DateTimeKind.Utc).AddTicks(5783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 493, DateTimeKind.Utc).AddTicks(275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Exercises",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 238, DateTimeKind.Utc).AddTicks(4774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 492, DateTimeKind.Utc).AddTicks(9343));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Equipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 245, DateTimeKind.Utc).AddTicks(5695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 499, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Equipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 245, DateTimeKind.Utc).AddTicks(4836),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 499, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 237, DateTimeKind.Utc).AddTicks(8622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 492, DateTimeKind.Utc).AddTicks(3191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 237, DateTimeKind.Utc).AddTicks(7736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 492, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "BodyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 245, DateTimeKind.Utc).AddTicks(178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 499, DateTimeKind.Utc).AddTicks(173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BodyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 244, DateTimeKind.Utc).AddTicks(9292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 498, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Bodies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 237, DateTimeKind.Utc).AddTicks(3931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 491, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bodies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 237, DateTimeKind.Utc).AddTicks(2916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 491, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Athletes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 242, DateTimeKind.Utc).AddTicks(7690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 496, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Athletes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 242, DateTimeKind.Utc).AddTicks(6662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 496, DateTimeKind.Utc).AddTicks(8022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "AthleteInjuries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 243, DateTimeKind.Utc).AddTicks(8913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 497, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AthleteInjuries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 243, DateTimeKind.Utc).AddTicks(8068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 497, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "AthleteImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 243, DateTimeKind.Utc).AddTicks(3769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 497, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AthleteImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 243, DateTimeKind.Utc).AddTicks(2779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 497, DateTimeKind.Utc).AddTicks(3744));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 500, DateTimeKind.Utc).AddTicks(5893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 246, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 500, DateTimeKind.Utc).AddTicks(4926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 246, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 503, DateTimeKind.Utc).AddTicks(4325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 248, DateTimeKind.Utc).AddTicks(5018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 503, DateTimeKind.Utc).AddTicks(2227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 248, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutEquipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 502, DateTimeKind.Utc).AddTicks(2107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 247, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutEquipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 502, DateTimeKind.Utc).AddTicks(336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 247, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutAgeRanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 501, DateTimeKind.Utc).AddTicks(2766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 247, DateTimeKind.Utc).AddTicks(2614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutAgeRanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 501, DateTimeKind.Utc).AddTicks(643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 247, DateTimeKind.Utc).AddTicks(1426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 498, DateTimeKind.Utc).AddTicks(5163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 244, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 498, DateTimeKind.Utc).AddTicks(4406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 244, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Sports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 500, DateTimeKind.Utc).AddTicks(216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 246, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Sports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 499, DateTimeKind.Utc).AddTicks(9191),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 245, DateTimeKind.Utc).AddTicks(9968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 494, DateTimeKind.Utc).AddTicks(1060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 239, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 493, DateTimeKind.Utc).AddTicks(9996),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 239, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 496, DateTimeKind.Utc).AddTicks(1483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 241, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 496, DateTimeKind.Utc).AddTicks(521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 241, DateTimeKind.Utc).AddTicks(8497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 495, DateTimeKind.Utc).AddTicks(6462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 241, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 495, DateTimeKind.Utc).AddTicks(5592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 241, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanEquipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 495, DateTimeKind.Utc).AddTicks(663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 240, DateTimeKind.Utc).AddTicks(8033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanEquipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 494, DateTimeKind.Utc).AddTicks(9781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 240, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 494, DateTimeKind.Utc).AddTicks(5529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 240, DateTimeKind.Utc).AddTicks(2498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 494, DateTimeKind.Utc).AddTicks(4580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 240, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "MusclePriorities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 493, DateTimeKind.Utc).AddTicks(5737),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 239, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "MusclePriorities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 493, DateTimeKind.Utc).AddTicks(4749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 239, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Exercises",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 493, DateTimeKind.Utc).AddTicks(275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 238, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Exercises",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 492, DateTimeKind.Utc).AddTicks(9343),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 238, DateTimeKind.Utc).AddTicks(4774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Equipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 499, DateTimeKind.Utc).AddTicks(5040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 245, DateTimeKind.Utc).AddTicks(5695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Equipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 499, DateTimeKind.Utc).AddTicks(4201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 245, DateTimeKind.Utc).AddTicks(4836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 492, DateTimeKind.Utc).AddTicks(3191),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 237, DateTimeKind.Utc).AddTicks(8622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 492, DateTimeKind.Utc).AddTicks(2293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 237, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "BodyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 499, DateTimeKind.Utc).AddTicks(173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 245, DateTimeKind.Utc).AddTicks(178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BodyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 498, DateTimeKind.Utc).AddTicks(8998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 244, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Bodies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 491, DateTimeKind.Utc).AddTicks(7327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 237, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bodies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 491, DateTimeKind.Utc).AddTicks(5697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 237, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Athletes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 496, DateTimeKind.Utc).AddTicks(8888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 242, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Athletes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 496, DateTimeKind.Utc).AddTicks(8022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 242, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "AthleteInjuries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 497, DateTimeKind.Utc).AddTicks(9708),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 243, DateTimeKind.Utc).AddTicks(8913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AthleteInjuries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 497, DateTimeKind.Utc).AddTicks(8588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 243, DateTimeKind.Utc).AddTicks(8068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "AthleteImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 497, DateTimeKind.Utc).AddTicks(4602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 243, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AthleteImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 19, 13, 497, DateTimeKind.Utc).AddTicks(3744),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 243, DateTimeKind.Utc).AddTicks(2779));
        }
    }
}
