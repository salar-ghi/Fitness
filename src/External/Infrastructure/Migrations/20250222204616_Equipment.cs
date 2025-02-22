using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Equipment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(9511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(9161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 181, DateTimeKind.Utc).AddTicks(9512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 181, DateTimeKind.Utc).AddTicks(9166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(4467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutEquipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 181, DateTimeKind.Utc).AddTicks(7180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutEquipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 181, DateTimeKind.Utc).AddTicks(6888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutAgeRanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 181, DateTimeKind.Utc).AddTicks(5470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutAgeRanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 181, DateTimeKind.Utc).AddTicks(5100),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(1998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(1700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(1347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Sports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(7363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Sports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(7076),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(2499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(2196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(9710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(9380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(2772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(7988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(1344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(7692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanEquipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(5897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanEquipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(5594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(4101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(3803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(7176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "MusclePriorities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "MusclePriorities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Exercises",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 177, DateTimeKind.Utc).AddTicks(8917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(2258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Exercises",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 177, DateTimeKind.Utc).AddTicks(8546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(1917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Equipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(5602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Equipments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Equipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(5267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 177, DateTimeKind.Utc).AddTicks(6514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 283, DateTimeKind.Utc).AddTicks(9493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 177, DateTimeKind.Utc).AddTicks(6222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 283, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "BodyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(3718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BodyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(3353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Bodies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 177, DateTimeKind.Utc).AddTicks(4931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 283, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bodies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 177, DateTimeKind.Utc).AddTicks(4626),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 283, DateTimeKind.Utc).AddTicks(7447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Athletes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 179, DateTimeKind.Utc).AddTicks(5043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(5810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Athletes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 179, DateTimeKind.Utc).AddTicks(4152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "AthleteInjuries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 179, DateTimeKind.Utc).AddTicks(9970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AthleteInjuries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 179, DateTimeKind.Utc).AddTicks(9625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(9326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "AthleteImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 179, DateTimeKind.Utc).AddTicks(7721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(7819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AthleteImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 179, DateTimeKind.Utc).AddTicks(7199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(7475));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(9130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Workouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(8832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(4768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 181, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(4467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 181, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutEquipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(2552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 181, DateTimeKind.Utc).AddTicks(7180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutEquipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(2245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 181, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "WorkoutAgeRanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 181, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "WorkoutAgeRanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 287, DateTimeKind.Utc).AddTicks(512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 181, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(1643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(1998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(1347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Sports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(7036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Sports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(6663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(5864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(2499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(5528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(3102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(2772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(1344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(7988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(1018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanEquipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(9270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanEquipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(8925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(5594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "PlanDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(7477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "PlanDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(7176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "MusclePriorities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(4044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "MusclePriorities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(3741),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 178, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Exercises",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(2258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 177, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Exercises",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 284, DateTimeKind.Utc).AddTicks(1917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 177, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Equipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(5143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Equipments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Equipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(4848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(5267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 283, DateTimeKind.Utc).AddTicks(9493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 177, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Diseases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 283, DateTimeKind.Utc).AddTicks(9172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 177, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "BodyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(3352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BodyWorkouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 286, DateTimeKind.Utc).AddTicks(3049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 180, DateTimeKind.Utc).AddTicks(3353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Bodies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 283, DateTimeKind.Utc).AddTicks(7812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 177, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bodies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 283, DateTimeKind.Utc).AddTicks(7447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 177, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Athletes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(5810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 179, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Athletes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(5473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 179, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "AthleteInjuries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(9620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 179, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AthleteInjuries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(9326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 179, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "AthleteImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(7819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 179, DateTimeKind.Utc).AddTicks(7721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AthleteImgs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 22, 20, 40, 58, 285, DateTimeKind.Utc).AddTicks(7475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 22, 20, 46, 16, 179, DateTimeKind.Utc).AddTicks(7199));
        }
    }
}
