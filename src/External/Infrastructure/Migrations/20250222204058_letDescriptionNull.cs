using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class letDescriptionNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(9130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 246, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Workouts",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2500)",
                oldMaxLength: 2500);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(8832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 246, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(4768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 248, DateTimeKind.Utc).AddTicks(5018));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "WorkoutLevels",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(4467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 248, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutEquipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(2552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 247, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutEquipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(2245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 247, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutAgeRanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 247, DateTimeKind.Utc).AddTicks(2614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutAgeRanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 247, DateTimeKind.Utc).AddTicks(1426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(1643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 244, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(1347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 244, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Sports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(7036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 246, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Sports",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Sports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(6663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 245, DateTimeKind.Utc).AddTicks(9968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(5864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 239, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(5528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 239, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(3102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 241, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(2772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 241, DateTimeKind.Utc).AddTicks(8497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(1344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 241, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(1018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 241, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanEquipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(9270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 240, DateTimeKind.Utc).AddTicks(8033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanEquipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(8925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 240, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(7477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 240, DateTimeKind.Utc).AddTicks(2498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(7176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 240, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "MusclePriorities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(4044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 239, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "MusclePriorities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(3741),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 239, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Exercises",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(2258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 238, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Exercises",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(1917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 238, DateTimeKind.Utc).AddTicks(4774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Equipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(5143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 245, DateTimeKind.Utc).AddTicks(5695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Equipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(4848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 245, DateTimeKind.Utc).AddTicks(4836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 283, DateTimeKind.Utc).AddTicks(9493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 237, DateTimeKind.Utc).AddTicks(8622));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Diseases",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2500)",
                oldMaxLength: 2500);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 283, DateTimeKind.Utc).AddTicks(9172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 237, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "BodyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(3352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 245, DateTimeKind.Utc).AddTicks(178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BodyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(3049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 244, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Bodies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 283, DateTimeKind.Utc).AddTicks(7812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 237, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Bodies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bodies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 283, DateTimeKind.Utc).AddTicks(7447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 237, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Athletes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(5810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 242, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Athletes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(5473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 242, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "AthleteInjuries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(9620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 243, DateTimeKind.Utc).AddTicks(8913));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AthleteInjuries",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2500)",
                oldMaxLength: 2500);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AthleteInjuries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(9326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 243, DateTimeKind.Utc).AddTicks(8068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "AthleteImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(7819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 243, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AthleteImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(7475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 243, DateTimeKind.Utc).AddTicks(2779));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 246, DateTimeKind.Utc).AddTicks(7440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Workouts",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2500)",
                oldMaxLength: 2500,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 246, DateTimeKind.Utc).AddTicks(6570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 248, DateTimeKind.Utc).AddTicks(5018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "WorkoutLevels",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 248, DateTimeKind.Utc).AddTicks(3951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(4467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutEquipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 247, DateTimeKind.Utc).AddTicks(7692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutEquipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 247, DateTimeKind.Utc).AddTicks(6676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutAgeRanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 247, DateTimeKind.Utc).AddTicks(2614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutAgeRanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 247, DateTimeKind.Utc).AddTicks(1426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 244, DateTimeKind.Utc).AddTicks(5101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 244, DateTimeKind.Utc).AddTicks(4146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(1347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Sports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 246, DateTimeKind.Utc).AddTicks(1015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Sports",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Sports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 245, DateTimeKind.Utc).AddTicks(9968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 239, DateTimeKind.Utc).AddTicks(7231),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 239, DateTimeKind.Utc).AddTicks(6223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 241, DateTimeKind.Utc).AddTicks(9477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 241, DateTimeKind.Utc).AddTicks(8497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(2772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 241, DateTimeKind.Utc).AddTicks(4368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(1344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 241, DateTimeKind.Utc).AddTicks(3484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanEquipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 240, DateTimeKind.Utc).AddTicks(8033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanEquipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 240, DateTimeKind.Utc).AddTicks(7050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 240, DateTimeKind.Utc).AddTicks(2498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 240, DateTimeKind.Utc).AddTicks(1016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(7176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "MusclePriorities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 239, DateTimeKind.Utc).AddTicks(1561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "MusclePriorities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 239, DateTimeKind.Utc).AddTicks(661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Exercises",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 238, DateTimeKind.Utc).AddTicks(5783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(2258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Exercises",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 238, DateTimeKind.Utc).AddTicks(4774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(1917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Equipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 245, DateTimeKind.Utc).AddTicks(5695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Equipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 245, DateTimeKind.Utc).AddTicks(4836),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 237, DateTimeKind.Utc).AddTicks(8622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 283, DateTimeKind.Utc).AddTicks(9493));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Diseases",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2500)",
                oldMaxLength: 2500,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 237, DateTimeKind.Utc).AddTicks(7736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 283, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "BodyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 245, DateTimeKind.Utc).AddTicks(178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BodyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 244, DateTimeKind.Utc).AddTicks(9292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Bodies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 237, DateTimeKind.Utc).AddTicks(3931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 283, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Bodies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bodies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 237, DateTimeKind.Utc).AddTicks(2916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 283, DateTimeKind.Utc).AddTicks(7447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Athletes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 242, DateTimeKind.Utc).AddTicks(7690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(5810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Athletes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 242, DateTimeKind.Utc).AddTicks(6662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "AthleteInjuries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 243, DateTimeKind.Utc).AddTicks(8913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AthleteInjuries",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2500)",
                oldMaxLength: 2500,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AthleteInjuries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 243, DateTimeKind.Utc).AddTicks(8068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(9326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "AthleteImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 243, DateTimeKind.Utc).AddTicks(3769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(7819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AthleteImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 31, 56, 243, DateTimeKind.Utc).AddTicks(2779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(7475));
        }
    }
}
