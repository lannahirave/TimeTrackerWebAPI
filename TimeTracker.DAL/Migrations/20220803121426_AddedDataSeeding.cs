using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeTracker.DAL.Migrations
{
    public partial class AddedDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ActivityTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Regular work" },
                    { 2, "Overtime" },
                    { 3, "Additional work" },
                    { 4, "Voluntary" },
                    { 5, "Training" },
                    { 6, "Other" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeRoles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Developer" },
                    { 2, "QA" },
                    { 3, "Business Analyst" },
                    { 4, "Software Engineer" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthday", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1970, 7, 10, 1, 53, 42, 110, DateTimeKind.Unspecified).AddTicks(4765), "Female", "Judson Gerlach" },
                    { 2, new DateTime(2016, 4, 30, 8, 25, 36, 946, DateTimeKind.Unspecified).AddTicks(1810), "Female", "Sonya Moen" },
                    { 3, new DateTime(2015, 1, 8, 20, 19, 20, 986, DateTimeKind.Unspecified).AddTicks(3706), "Female", "Theo Veum" },
                    { 4, new DateTime(1961, 6, 14, 6, 31, 11, 402, DateTimeKind.Unspecified).AddTicks(251), "Non binary", "Guadalupe Weimann" },
                    { 5, new DateTime(2004, 12, 14, 14, 2, 57, 162, DateTimeKind.Unspecified).AddTicks(820), "Female", "Maudie Schiller" },
                    { 6, new DateTime(1960, 12, 4, 23, 16, 45, 45, DateTimeKind.Unspecified).AddTicks(7843), "Non binary", "Lawson Murray" },
                    { 7, new DateTime(2016, 1, 1, 23, 57, 12, 368, DateTimeKind.Unspecified).AddTicks(8364), "Non binary", "Laney Skiles" },
                    { 8, new DateTime(2010, 7, 31, 14, 33, 34, 953, DateTimeKind.Unspecified).AddTicks(8760), "Female", "Madonna Stehr" },
                    { 9, new DateTime(2008, 12, 30, 19, 8, 54, 265, DateTimeKind.Unspecified).AddTicks(1366), "Female", "Mervin Glover" },
                    { 10, new DateTime(2019, 11, 23, 12, 40, 12, 539, DateTimeKind.Unspecified).AddTicks(7656), "Non binary", "Hershel Schamberger" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2016, 7, 9, 2, 47, 44, 951, DateTimeKind.Unspecified).AddTicks(985), "deleniti", new DateTime(2000, 11, 4, 9, 55, 39, 958, DateTimeKind.Unspecified).AddTicks(3801) },
                    { 2, new DateTime(2002, 6, 7, 7, 6, 29, 80, DateTimeKind.Unspecified).AddTicks(9784), "neque", new DateTime(2000, 8, 22, 0, 31, 30, 426, DateTimeKind.Unspecified).AddTicks(8904) },
                    { 3, new DateTime(2007, 10, 7, 1, 28, 9, 64, DateTimeKind.Unspecified).AddTicks(2158), "sed", new DateTime(2005, 3, 8, 14, 2, 56, 828, DateTimeKind.Unspecified).AddTicks(1776) },
                    { 4, new DateTime(2020, 12, 5, 18, 19, 38, 580, DateTimeKind.Unspecified).AddTicks(4820), "dolor", new DateTime(2013, 8, 28, 17, 45, 58, 125, DateTimeKind.Unspecified).AddTicks(5038) },
                    { 5, new DateTime(2018, 6, 22, 15, 27, 8, 263, DateTimeKind.Unspecified).AddTicks(3811), "et", new DateTime(2015, 11, 13, 6, 21, 48, 909, DateTimeKind.Unspecified).AddTicks(1156) }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityTypeId", "Date", "EmployeeId", "EmployeeRoleId", "ProjectId" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(2022, 5, 9, 11, 31, 36, 721, DateTimeKind.Local).AddTicks(2579), 9, 1, 1 },
                    { 2, 3, new DateTime(2022, 5, 8, 8, 38, 11, 5, DateTimeKind.Local).AddTicks(6082), 1, 1, 2 },
                    { 3, 5, new DateTime(2021, 11, 16, 18, 31, 5, 81, DateTimeKind.Local).AddTicks(5346), 7, 4, 5 },
                    { 4, 4, new DateTime(2022, 5, 25, 14, 45, 11, 121, DateTimeKind.Local).AddTicks(2874), 9, 3, 2 },
                    { 5, 1, new DateTime(2022, 5, 30, 16, 31, 42, 425, DateTimeKind.Local).AddTicks(2110), 4, 3, 1 },
                    { 6, 2, new DateTime(2021, 8, 31, 16, 40, 21, 477, DateTimeKind.Local).AddTicks(3333), 5, 2, 2 },
                    { 7, 6, new DateTime(2021, 12, 28, 11, 12, 50, 59, DateTimeKind.Local).AddTicks(44), 5, 3, 3 },
                    { 8, 6, new DateTime(2022, 5, 4, 7, 50, 29, 465, DateTimeKind.Local).AddTicks(7217), 2, 2, 4 },
                    { 9, 1, new DateTime(2022, 5, 24, 11, 33, 1, 459, DateTimeKind.Local).AddTicks(7412), 5, 2, 3 },
                    { 10, 4, new DateTime(2022, 5, 1, 8, 34, 34, 763, DateTimeKind.Local).AddTicks(8254), 8, 1, 2 },
                    { 11, 1, new DateTime(2022, 3, 13, 5, 7, 36, 366, DateTimeKind.Local).AddTicks(1578), 9, 3, 1 },
                    { 12, 4, new DateTime(2022, 7, 5, 9, 45, 2, 968, DateTimeKind.Local).AddTicks(4416), 1, 4, 3 },
                    { 13, 1, new DateTime(2021, 8, 22, 16, 13, 49, 960, DateTimeKind.Local).AddTicks(3257), 8, 2, 2 },
                    { 14, 6, new DateTime(2022, 4, 26, 14, 27, 7, 254, DateTimeKind.Local).AddTicks(7012), 8, 4, 2 },
                    { 15, 2, new DateTime(2021, 10, 17, 21, 28, 47, 743, DateTimeKind.Local).AddTicks(3313), 6, 4, 4 },
                    { 16, 1, new DateTime(2022, 1, 28, 10, 13, 46, 595, DateTimeKind.Local).AddTicks(1152), 4, 3, 3 },
                    { 17, 3, new DateTime(2022, 5, 15, 8, 28, 3, 130, DateTimeKind.Local).AddTicks(2456), 5, 1, 1 },
                    { 18, 4, new DateTime(2022, 3, 22, 10, 50, 37, 103, DateTimeKind.Local).AddTicks(8151), 1, 1, 3 },
                    { 19, 4, new DateTime(2021, 12, 22, 22, 3, 49, 643, DateTimeKind.Local).AddTicks(6028), 9, 1, 2 },
                    { 20, 3, new DateTime(2021, 8, 3, 17, 40, 52, 905, DateTimeKind.Local).AddTicks(6708), 9, 2, 2 },
                    { 21, 6, new DateTime(2022, 1, 27, 5, 31, 2, 310, DateTimeKind.Local).AddTicks(8489), 7, 4, 4 },
                    { 22, 1, new DateTime(2022, 7, 5, 8, 54, 37, 76, DateTimeKind.Local).AddTicks(1726), 1, 1, 2 },
                    { 23, 3, new DateTime(2021, 11, 19, 8, 35, 59, 828, DateTimeKind.Local).AddTicks(9548), 9, 1, 5 },
                    { 24, 3, new DateTime(2022, 5, 14, 14, 41, 25, 202, DateTimeKind.Local).AddTicks(7160), 6, 2, 1 },
                    { 25, 2, new DateTime(2021, 12, 26, 13, 18, 39, 28, DateTimeKind.Local).AddTicks(666), 2, 1, 5 },
                    { 26, 1, new DateTime(2022, 1, 28, 2, 20, 50, 523, DateTimeKind.Local).AddTicks(6173), 2, 2, 5 },
                    { 27, 5, new DateTime(2021, 9, 28, 23, 34, 56, 53, DateTimeKind.Local).AddTicks(8642), 8, 4, 4 },
                    { 28, 2, new DateTime(2022, 5, 11, 8, 55, 9, 927, DateTimeKind.Local).AddTicks(1930), 2, 4, 1 },
                    { 29, 1, new DateTime(2021, 11, 17, 10, 8, 28, 459, DateTimeKind.Local).AddTicks(83), 10, 4, 2 },
                    { 30, 4, new DateTime(2022, 7, 18, 0, 55, 38, 722, DateTimeKind.Local).AddTicks(8004), 1, 1, 2 },
                    { 31, 1, new DateTime(2021, 9, 7, 21, 13, 54, 839, DateTimeKind.Local).AddTicks(7584), 5, 1, 2 },
                    { 32, 1, new DateTime(2022, 2, 12, 8, 57, 25, 154, DateTimeKind.Local).AddTicks(8620), 1, 2, 4 },
                    { 33, 2, new DateTime(2021, 10, 14, 9, 45, 59, 744, DateTimeKind.Local).AddTicks(3633), 2, 1, 1 },
                    { 34, 3, new DateTime(2022, 5, 30, 7, 59, 52, 90, DateTimeKind.Local).AddTicks(3765), 8, 2, 5 },
                    { 35, 6, new DateTime(2022, 4, 20, 20, 19, 56, 385, DateTimeKind.Local).AddTicks(1898), 8, 4, 3 },
                    { 36, 4, new DateTime(2022, 1, 19, 16, 22, 31, 59, DateTimeKind.Local).AddTicks(7974), 3, 4, 4 },
                    { 37, 2, new DateTime(2021, 10, 12, 23, 24, 16, 707, DateTimeKind.Local).AddTicks(973), 7, 1, 1 },
                    { 38, 3, new DateTime(2022, 7, 17, 19, 18, 53, 203, DateTimeKind.Local).AddTicks(8694), 1, 4, 4 },
                    { 39, 4, new DateTime(2021, 9, 2, 0, 15, 13, 0, DateTimeKind.Local).AddTicks(1428), 1, 2, 3 },
                    { 40, 1, new DateTime(2022, 1, 28, 22, 11, 12, 808, DateTimeKind.Local).AddTicks(5185), 10, 3, 5 },
                    { 41, 1, new DateTime(2022, 3, 23, 6, 23, 43, 534, DateTimeKind.Local).AddTicks(9781), 5, 3, 1 },
                    { 42, 4, new DateTime(2022, 3, 18, 2, 55, 34, 858, DateTimeKind.Local).AddTicks(355), 5, 2, 5 }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityTypeId", "Date", "EmployeeId", "EmployeeRoleId", "ProjectId" },
                values: new object[,]
                {
                    { 43, 6, new DateTime(2022, 1, 23, 2, 12, 40, 582, DateTimeKind.Local).AddTicks(8080), 9, 2, 5 },
                    { 44, 5, new DateTime(2022, 1, 12, 18, 34, 13, 21, DateTimeKind.Local).AddTicks(7445), 3, 2, 5 },
                    { 45, 5, new DateTime(2021, 11, 7, 5, 19, 10, 640, DateTimeKind.Local).AddTicks(8165), 7, 2, 3 },
                    { 46, 6, new DateTime(2021, 12, 1, 22, 19, 4, 860, DateTimeKind.Local).AddTicks(7803), 3, 4, 4 },
                    { 47, 2, new DateTime(2022, 1, 17, 2, 53, 37, 987, DateTimeKind.Local).AddTicks(7489), 8, 1, 3 },
                    { 48, 6, new DateTime(2022, 4, 20, 21, 15, 39, 443, DateTimeKind.Local).AddTicks(9154), 6, 4, 5 },
                    { 49, 6, new DateTime(2022, 7, 4, 16, 37, 45, 844, DateTimeKind.Local).AddTicks(8672), 6, 4, 1 },
                    { 50, 6, new DateTime(2022, 4, 23, 20, 35, 10, 605, DateTimeKind.Local).AddTicks(7563), 1, 4, 1 },
                    { 51, 3, new DateTime(2022, 5, 26, 10, 1, 15, 132, DateTimeKind.Local).AddTicks(2249), 9, 4, 2 },
                    { 52, 5, new DateTime(2022, 6, 1, 20, 27, 1, 421, DateTimeKind.Local).AddTicks(7994), 2, 4, 4 },
                    { 53, 1, new DateTime(2022, 6, 24, 19, 22, 7, 501, DateTimeKind.Local).AddTicks(1208), 7, 2, 2 },
                    { 54, 1, new DateTime(2022, 5, 29, 4, 34, 31, 939, DateTimeKind.Local).AddTicks(6601), 2, 3, 5 },
                    { 55, 4, new DateTime(2021, 10, 14, 0, 38, 40, 418, DateTimeKind.Local).AddTicks(2200), 5, 4, 3 },
                    { 56, 6, new DateTime(2022, 6, 1, 14, 57, 14, 770, DateTimeKind.Local).AddTicks(2981), 1, 4, 2 },
                    { 57, 4, new DateTime(2022, 5, 10, 11, 50, 34, 781, DateTimeKind.Local).AddTicks(1505), 4, 2, 4 },
                    { 58, 1, new DateTime(2021, 10, 20, 8, 2, 18, 441, DateTimeKind.Local).AddTicks(375), 10, 1, 5 },
                    { 59, 2, new DateTime(2021, 9, 6, 1, 17, 51, 537, DateTimeKind.Local).AddTicks(4325), 10, 1, 2 },
                    { 60, 2, new DateTime(2021, 8, 23, 2, 57, 9, 99, DateTimeKind.Local).AddTicks(6063), 5, 1, 5 },
                    { 61, 1, new DateTime(2021, 9, 1, 15, 7, 25, 506, DateTimeKind.Local).AddTicks(3364), 4, 3, 3 },
                    { 62, 2, new DateTime(2022, 6, 15, 8, 29, 31, 810, DateTimeKind.Local).AddTicks(8341), 1, 3, 4 },
                    { 63, 3, new DateTime(2022, 6, 17, 16, 24, 54, 375, DateTimeKind.Local).AddTicks(5057), 10, 1, 1 },
                    { 64, 1, new DateTime(2022, 6, 8, 20, 19, 26, 21, DateTimeKind.Local).AddTicks(495), 8, 4, 2 },
                    { 65, 1, new DateTime(2021, 9, 17, 17, 41, 47, 747, DateTimeKind.Local).AddTicks(99), 5, 1, 1 },
                    { 66, 4, new DateTime(2021, 12, 20, 3, 50, 42, 693, DateTimeKind.Local).AddTicks(8667), 9, 3, 1 },
                    { 67, 5, new DateTime(2021, 11, 16, 23, 52, 49, 933, DateTimeKind.Local).AddTicks(3247), 9, 1, 3 },
                    { 68, 2, new DateTime(2022, 7, 18, 5, 5, 29, 528, DateTimeKind.Local).AddTicks(7259), 5, 2, 5 },
                    { 69, 1, new DateTime(2021, 10, 10, 1, 17, 20, 899, DateTimeKind.Local).AddTicks(5877), 4, 3, 3 },
                    { 70, 2, new DateTime(2021, 10, 30, 8, 48, 56, 396, DateTimeKind.Local).AddTicks(3518), 4, 1, 4 },
                    { 71, 5, new DateTime(2022, 7, 23, 8, 44, 46, 913, DateTimeKind.Local).AddTicks(1328), 7, 3, 5 },
                    { 72, 6, new DateTime(2022, 4, 30, 13, 49, 0, 616, DateTimeKind.Local).AddTicks(2229), 10, 2, 1 },
                    { 73, 4, new DateTime(2022, 1, 16, 15, 23, 29, 610, DateTimeKind.Local).AddTicks(1179), 10, 2, 2 },
                    { 74, 1, new DateTime(2021, 11, 15, 22, 25, 34, 101, DateTimeKind.Local).AddTicks(8410), 10, 1, 1 },
                    { 75, 4, new DateTime(2021, 10, 9, 21, 49, 29, 591, DateTimeKind.Local).AddTicks(529), 3, 3, 3 },
                    { 76, 1, new DateTime(2022, 2, 11, 5, 58, 39, 28, DateTimeKind.Local).AddTicks(3302), 10, 3, 2 },
                    { 77, 5, new DateTime(2022, 5, 8, 9, 3, 31, 18, DateTimeKind.Local).AddTicks(2139), 8, 4, 3 },
                    { 78, 1, new DateTime(2022, 3, 15, 1, 52, 14, 72, DateTimeKind.Local).AddTicks(7294), 9, 1, 2 },
                    { 79, 3, new DateTime(2022, 1, 15, 9, 22, 37, 600, DateTimeKind.Local).AddTicks(2047), 7, 1, 3 },
                    { 80, 6, new DateTime(2022, 3, 1, 10, 23, 6, 386, DateTimeKind.Local).AddTicks(1579), 7, 3, 2 },
                    { 81, 6, new DateTime(2021, 10, 5, 19, 38, 35, 864, DateTimeKind.Local).AddTicks(4396), 9, 4, 3 },
                    { 82, 4, new DateTime(2022, 4, 23, 2, 21, 5, 500, DateTimeKind.Local).AddTicks(8508), 10, 3, 2 },
                    { 83, 2, new DateTime(2022, 2, 13, 9, 33, 40, 449, DateTimeKind.Local).AddTicks(4454), 2, 4, 1 },
                    { 84, 3, new DateTime(2021, 12, 19, 6, 54, 5, 326, DateTimeKind.Local).AddTicks(3300), 7, 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityTypeId", "Date", "EmployeeId", "EmployeeRoleId", "ProjectId" },
                values: new object[,]
                {
                    { 85, 3, new DateTime(2021, 11, 11, 20, 28, 13, 607, DateTimeKind.Local).AddTicks(2816), 4, 3, 2 },
                    { 86, 3, new DateTime(2022, 6, 11, 17, 33, 2, 949, DateTimeKind.Local).AddTicks(3502), 3, 4, 1 },
                    { 87, 4, new DateTime(2021, 10, 19, 18, 33, 10, 604, DateTimeKind.Local).AddTicks(234), 4, 3, 2 },
                    { 88, 4, new DateTime(2022, 6, 19, 6, 13, 50, 511, DateTimeKind.Local).AddTicks(8970), 1, 3, 1 },
                    { 89, 6, new DateTime(2021, 10, 12, 1, 3, 46, 279, DateTimeKind.Local).AddTicks(407), 2, 2, 1 },
                    { 90, 4, new DateTime(2021, 12, 14, 10, 34, 44, 567, DateTimeKind.Local).AddTicks(8761), 8, 3, 2 },
                    { 91, 4, new DateTime(2022, 3, 5, 12, 53, 50, 422, DateTimeKind.Local).AddTicks(4764), 8, 2, 5 },
                    { 92, 2, new DateTime(2021, 8, 13, 21, 42, 33, 695, DateTimeKind.Local).AddTicks(1791), 1, 3, 1 },
                    { 93, 1, new DateTime(2021, 10, 25, 4, 33, 8, 756, DateTimeKind.Local).AddTicks(4748), 9, 2, 1 },
                    { 94, 6, new DateTime(2022, 1, 7, 1, 53, 50, 480, DateTimeKind.Local).AddTicks(7736), 6, 4, 5 },
                    { 95, 6, new DateTime(2022, 4, 20, 5, 7, 11, 201, DateTimeKind.Local).AddTicks(7381), 3, 1, 4 },
                    { 96, 3, new DateTime(2022, 4, 24, 9, 8, 8, 333, DateTimeKind.Local).AddTicks(4896), 7, 4, 5 },
                    { 97, 4, new DateTime(2022, 7, 16, 12, 7, 46, 707, DateTimeKind.Local).AddTicks(5405), 9, 2, 1 },
                    { 98, 2, new DateTime(2021, 12, 4, 21, 55, 13, 419, DateTimeKind.Local).AddTicks(2864), 3, 4, 3 },
                    { 99, 4, new DateTime(2022, 6, 15, 2, 52, 7, 414, DateTimeKind.Local).AddTicks(7596), 9, 2, 5 },
                    { 100, 5, new DateTime(2022, 1, 13, 1, 4, 19, 7, DateTimeKind.Local).AddTicks(8321), 4, 4, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ActivityTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EmployeeRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeRoles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
