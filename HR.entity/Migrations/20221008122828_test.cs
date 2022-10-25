using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HR.entity.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicQualification",
                columns: table => new
                {
                    PKAcademicQualificationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicQualificationType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicQualification", x => x.PKAcademicQualificationID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    PKCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CategoryNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.PKCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ContractType",
                columns: table => new
                {
                    PKContractType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractTypeName = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractType", x => x.PKContractType);
                });

            migrationBuilder.CreateTable(
                name: "DecreeType",
                columns: table => new
                {
                    PKDecreeTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DecreeTypeName = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DecreeType", x => x.PKDecreeTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Directorate",
                columns: table => new
                {
                    PKDirectorateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectorateNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DirectorateNameAR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directorate", x => x.PKDirectorateID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLeaveBalance",
                columns: table => new
                {
                    PKEmployeeLeaveBalanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeLeaveYearlyTakenDaysCount = table.Column<int>(type: "int", nullable: true),
                    EmployeeLeaveSickTakenDaysCount = table.Column<int>(type: "int", nullable: true),
                    EmployeeLeaveUnpaidTakenDaysCount = table.Column<int>(type: "int", nullable: true),
                    EmployeeLeaveLongTermTakenDaysCount = table.Column<int>(type: "int", nullable: true),
                    FKEmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeaveBalance", x => x.PKEmployeeLeaveBalanceID);
                });

            migrationBuilder.CreateTable(
                name: "EmployementStatus",
                columns: table => new
                {
                    PKEmploymentStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmploymentStatusName = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployementStatus", x => x.PKEmploymentStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Extension",
                columns: table => new
                {
                    PKExtensionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtensionNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExtensionNameAR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionService", x => x.PKExtensionID);
                });

            migrationBuilder.CreateTable(
                name: "ExtensionSection",
                columns: table => new
                {
                    PKExtensionSectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtensionSectionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionSection", x => x.PKExtensionSectionID);
                });

            migrationBuilder.CreateTable(
                name: "LeaveType",
                columns: table => new
                {
                    PKLeaveTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveTypeNameEN = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    LeaveTypeNameAR = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveType", x => x.PKLeaveTypeID);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    PKMaritalStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaritalStatusType = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.PKMaritalStatusID);
                });

            migrationBuilder.CreateTable(
                name: "RelativeType",
                columns: table => new
                {
                    PKRelativeTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelativeTypeName = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelativeType", x => x.PKRelativeTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    PKJobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FKCategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.PKJobID);
                    table.ForeignKey(
                        name: "FK_Job_Category",
                        column: x => x.FKCategoryID,
                        principalTable: "Category",
                        principalColumn: "PKCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdministrativeDepartment",
                columns: table => new
                {
                    PKAdministrativeDepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdministrativeDepartmentNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdministrativeDepartmentNameAR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FKDirectorateID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdministrativeDepartment", x => x.PKAdministrativeDepartmentID);
                    table.ForeignKey(
                        name: "FK_AdministrativeDepartment_Directorate",
                        column: x => x.FKDirectorateID,
                        principalTable: "Directorate",
                        principalColumn: "PKDirectorateID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Authority",
                columns: table => new
                {
                    PKAuthorityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorityNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AuthorityNameAR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FKDirectorateID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authority", x => x.PKAuthorityID);
                    table.ForeignKey(
                        name: "FK_Authority_Directorate",
                        column: x => x.FKDirectorateID,
                        principalTable: "Directorate",
                        principalColumn: "PKDirectorateID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExtensionCenter",
                columns: table => new
                {
                    PKExtensionCenterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtensionCenterNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExtensionCenterNameAR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FKExtensionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionCenter", x => x.PKExtensionCenterID);
                    table.ForeignKey(
                        name: "FK_ExtensionCenter_Extension",
                        column: x => x.FKExtensionID,
                        principalTable: "Extension",
                        principalColumn: "PKExtensionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExtensionSectionDetails",
                columns: table => new
                {
                    PKExtensionSectionDetailsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKExtensionID = table.Column<int>(type: "int", nullable: true),
                    FKExtensionSectionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionSectionDetails", x => x.PKExtensionSectionDetailsID);
                    table.ForeignKey(
                        name: "FK_ExtensionSectionDetails_Extension",
                        column: x => x.FKExtensionID,
                        principalTable: "Extension",
                        principalColumn: "PKExtensionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExtensionSectionDetails_ExtensionSection",
                        column: x => x.FKExtensionSectionID,
                        principalTable: "ExtensionSection",
                        principalColumn: "PKExtensionSectionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LeaveTypeDays",
                columns: table => new
                {
                    PKLeaveTypeDaysID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKLeaveTypeID = table.Column<int>(type: "int", nullable: true),
                    FKContractTypeID = table.Column<int>(type: "int", nullable: true),
                    LeaveTypeDaysYearlyPermittedCount = table.Column<int>(type: "int", nullable: true),
                    LeaveTypeSickDaysPermittedCount = table.Column<int>(type: "int", nullable: true),
                    LeaveTypeDaysUnpaidPermittedCount = table.Column<int>(type: "int", nullable: true),
                    LeaveTypeDaysLongTermPermittedCount = table.Column<int>(type: "int", nullable: true),
                    LeaveTypeDaysFamilyPermittedCount = table.Column<int>(type: "int", nullable: true),
                    LeaveTypeDaysMotherhoodCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypeDays", x => x.PKLeaveTypeDaysID);
                    table.ForeignKey(
                        name: "FK_LeaveTypeDays_ContractType",
                        column: x => x.FKContractTypeID,
                        principalTable: "ContractType",
                        principalColumn: "PKContractType",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveTypeDays_LeaveType",
                        column: x => x.FKLeaveTypeID,
                        principalTable: "LeaveType",
                        principalColumn: "PKLeaveTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    PKEmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeeMiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeeLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeeDateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    EmployeePhoneNumber = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    EmployeeFinancialNumber = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    EmployeeAutomatedNumber = table.Column<int>(type: "int", nullable: true),
                    EmployeeImageURL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmployeeTaxNumber = table.Column<int>(type: "int", nullable: true),
                    FKAcademicQualificationID = table.Column<int>(type: "int", nullable: true),
                    FKMaritalStatusID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.PKEmployeeID);
                    table.ForeignKey(
                        name: "FK_Employee_AcademicQualification",
                        column: x => x.FKAcademicQualificationID,
                        principalTable: "AcademicQualification",
                        principalColumn: "PKAcademicQualificationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_MaritalStatus",
                        column: x => x.FKMaritalStatusID,
                        principalTable: "MaritalStatus",
                        principalColumn: "PKMaritalStatusID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DirectorateJob",
                columns: table => new
                {
                    PKDirectorateJobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKDirectorateID = table.Column<int>(type: "int", nullable: false),
                    FKJobID = table.Column<int>(type: "int", nullable: false),
                    DirectorateJobCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectorateJob", x => x.PKDirectorateJobID);
                    table.ForeignKey(
                        name: "FK_DirectorateJob_Directorate",
                        column: x => x.FKDirectorateID,
                        principalTable: "Directorate",
                        principalColumn: "PKDirectorateID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DirectorateJob_Job",
                        column: x => x.FKJobID,
                        principalTable: "Job",
                        principalColumn: "PKJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExtensionSectionJob",
                columns: table => new
                {
                    PKExtensionSectionJobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKExtensionSectionID = table.Column<int>(type: "int", nullable: true),
                    FKJobID = table.Column<int>(type: "int", nullable: true),
                    ExtensionSectionJobCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionSectionJob", x => x.PKExtensionSectionJobID);
                    table.ForeignKey(
                        name: "FK_ExtensionSectionJob_ExtensionSection",
                        column: x => x.FKExtensionSectionID,
                        principalTable: "ExtensionSection",
                        principalColumn: "PKExtensionSectionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExtensionSectionJob_Job",
                        column: x => x.FKJobID,
                        principalTable: "Job",
                        principalColumn: "PKJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdministrativeDepartmentJob",
                columns: table => new
                {
                    PKAdministrativeDepartmentJobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKAdministrativeDepartmentID = table.Column<int>(type: "int", nullable: true),
                    FKJobID = table.Column<int>(type: "int", nullable: true),
                    AdministrativeDepartmentJobCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdministrativeDepartmentJob", x => x.PKAdministrativeDepartmentJobID);
                    table.ForeignKey(
                        name: "FK_AdministrativeDepartmentJob_AdministrativeDepartment",
                        column: x => x.FKAdministrativeDepartmentID,
                        principalTable: "AdministrativeDepartment",
                        principalColumn: "PKAdministrativeDepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdministrativeDepartmentJob_Job",
                        column: x => x.FKJobID,
                        principalTable: "Job",
                        principalColumn: "PKJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuthorityJob",
                columns: table => new
                {
                    PKAuthorityJobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKAuthotityID = table.Column<int>(type: "int", nullable: false),
                    FKJobID = table.Column<int>(type: "int", nullable: false),
                    AuthorityJobCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorityJob", x => x.PKAuthorityJobID);
                    table.ForeignKey(
                        name: "FK_AuthorityJob_Authority",
                        column: x => x.FKAuthotityID,
                        principalTable: "Authority",
                        principalColumn: "PKAuthorityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuthorityJob_Job",
                        column: x => x.FKJobID,
                        principalTable: "Job",
                        principalColumn: "PKJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    PKDepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DepartmentNameAR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FKAuthotiryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.PKDepartmentID);
                    table.ForeignKey(
                        name: "FK_Department_Authority",
                        column: x => x.FKAuthotiryID,
                        principalTable: "Authority",
                        principalColumn: "PKAuthorityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExtensionCenterJob",
                columns: table => new
                {
                    PKExtensionCenterJobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKExtensionCenterID = table.Column<int>(type: "int", nullable: true),
                    FKJobID = table.Column<int>(type: "int", nullable: true),
                    ExtensionCenterJobCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionCenterJob", x => x.PKExtensionCenterJobID);
                    table.ForeignKey(
                        name: "FK_ExtensionCenterJob_ExtensionCenter",
                        column: x => x.FKExtensionCenterID,
                        principalTable: "ExtensionCenter",
                        principalColumn: "PKExtensionCenterID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExtensionCenterJob_Job",
                        column: x => x.FKJobID,
                        principalTable: "Job",
                        principalColumn: "PKJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CareerProgression",
                columns: table => new
                {
                    PKCareerProgressionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CareerProgressionDate = table.Column<DateTime>(type: "date", nullable: true),
                    CareerProgressionRaise = table.Column<decimal>(type: "money", nullable: true),
                    FKEmployeeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerProgression", x => x.PKCareerProgressionID);
                    table.ForeignKey(
                        name: "FK_CareerProgression_Employee",
                        column: x => x.FKEmployeeID,
                        principalTable: "Employee",
                        principalColumn: "PKEmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLeaveApplication",
                columns: table => new
                {
                    PKEmployeeLeaveApplicationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeLeaveApplicationFromDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeLeaveApplicationToDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeLeaveApplicationDaysCount = table.Column<int>(type: "int", nullable: true, computedColumnSql: "(datediff(day,[EmployeeLeaveApplicationToDate],[EmployeeLeaveApplicationFromDate]))", stored: false),
                    EmployeeLeaveApplicationApproved = table.Column<bool>(type: "bit", nullable: true),
                    FKLeaveTypeID = table.Column<int>(type: "int", nullable: false),
                    FKEmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeaveApplication", x => x.PKEmployeeLeaveApplicationID);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveApplication_Employee",
                        column: x => x.FKEmployeeID,
                        principalTable: "Employee",
                        principalColumn: "PKEmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveApplication_LeaveType",
                        column: x => x.FKLeaveTypeID,
                        principalTable: "LeaveType",
                        principalColumn: "PKLeaveTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployementDetails",
                columns: table => new
                {
                    PKEmployementDetailsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployementDecreeDate = table.Column<DateTime>(type: "date", nullable: true),
                    EmployementStartWorkingDate = table.Column<DateTime>(type: "date", nullable: true),
                    EmployementRetirementDate = table.Column<DateTime>(type: "date", nullable: true),
                    FKJobID = table.Column<int>(type: "int", nullable: true),
                    FKCategoryID = table.Column<int>(type: "int", nullable: true),
                    FKEmployeeID = table.Column<int>(type: "int", nullable: true),
                    FKDecreeType = table.Column<int>(type: "int", nullable: true),
                    FKContractType = table.Column<int>(type: "int", nullable: true),
                    FKEmploymentStatusID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployementDetails", x => x.PKEmployementDetailsID);
                    table.ForeignKey(
                        name: "FK_EmployementDetails_Category",
                        column: x => x.FKCategoryID,
                        principalTable: "Category",
                        principalColumn: "PKCategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployementDetails_ContractType",
                        column: x => x.FKContractType,
                        principalTable: "ContractType",
                        principalColumn: "PKContractType",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployementDetails_DecreeType",
                        column: x => x.FKDecreeType,
                        principalTable: "DecreeType",
                        principalColumn: "PKDecreeTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployementDetails_Employee1",
                        column: x => x.FKEmployeeID,
                        principalTable: "Employee",
                        principalColumn: "PKEmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployementDetails_EmployementStatus",
                        column: x => x.FKEmploymentStatusID,
                        principalTable: "EmployementStatus",
                        principalColumn: "PKEmploymentStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployementDetails_Job",
                        column: x => x.FKJobID,
                        principalTable: "Job",
                        principalColumn: "PKJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FamilyDetails",
                columns: table => new
                {
                    PKFamilyDetailsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FamilyDetailsFullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FamilyDetailsDOB = table.Column<DateTime>(type: "date", nullable: true),
                    FamilyDetailsGender = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    FKRelativeTypeID = table.Column<int>(type: "int", nullable: false),
                    FKEmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyDetails", x => x.PKFamilyDetailsID);
                    table.ForeignKey(
                        name: "FK_FamilyDetails_Employee",
                        column: x => x.FKEmployeeID,
                        principalTable: "Employee",
                        principalColumn: "PKEmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FamilyDetails_RelativeType",
                        column: x => x.FKRelativeTypeID,
                        principalTable: "RelativeType",
                        principalColumn: "PKRelativeTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentJob",
                columns: table => new
                {
                    PKDepartmentJobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKDepartmentID = table.Column<int>(type: "int", nullable: false),
                    FKJobID = table.Column<int>(type: "int", nullable: false),
                    DepartmentJobCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentJob", x => x.PKDepartmentJobID);
                    table.ForeignKey(
                        name: "FK_DepartmentJob_Department",
                        column: x => x.FKDepartmentID,
                        principalTable: "Department",
                        principalColumn: "PKDepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartmentJob_Job",
                        column: x => x.FKJobID,
                        principalTable: "Job",
                        principalColumn: "PKJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    PKSectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SectionNameAR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FKDepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.PKSectionID);
                    table.ForeignKey(
                        name: "FK_Section_Department",
                        column: x => x.FKDepartmentID,
                        principalTable: "Department",
                        principalColumn: "PKDepartmentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Center",
                columns: table => new
                {
                    PKCenterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CenterNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CenterNameAR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FKSectionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Center", x => x.PKCenterID);
                    table.ForeignKey(
                        name: "FK_Center_Section",
                        column: x => x.FKSectionID,
                        principalTable: "Section",
                        principalColumn: "PKSectionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SectionJob",
                columns: table => new
                {
                    PKSectionJobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKSectionID = table.Column<int>(type: "int", nullable: false),
                    FKJobID = table.Column<int>(type: "int", nullable: false),
                    SectionJobCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionJob", x => x.PKSectionJobID);
                    table.ForeignKey(
                        name: "FK_SectionJob_Job",
                        column: x => x.FKJobID,
                        principalTable: "Job",
                        principalColumn: "PKJobID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SectionJob_Section",
                        column: x => x.FKSectionID,
                        principalTable: "Section",
                        principalColumn: "PKSectionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CenterJob",
                columns: table => new
                {
                    PKCenterJobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKCenterID = table.Column<int>(type: "int", nullable: false),
                    FKJobID = table.Column<int>(type: "int", nullable: false),
                    CenterJobCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CenterJob", x => x.PKCenterJobID);
                    table.ForeignKey(
                        name: "FK_CenterJob_Center",
                        column: x => x.FKCenterID,
                        principalTable: "Center",
                        principalColumn: "PKCenterID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CenterJob_Job",
                        column: x => x.FKJobID,
                        principalTable: "Job",
                        principalColumn: "PKJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdministrativeDepartment_FKDirectorateID",
                table: "AdministrativeDepartment",
                column: "FKDirectorateID");

            migrationBuilder.CreateIndex(
                name: "IX_AdministrativeDepartmentJob_FKAdministrativeDepartmentID",
                table: "AdministrativeDepartmentJob",
                column: "FKAdministrativeDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_AdministrativeDepartmentJob_FKJobID",
                table: "AdministrativeDepartmentJob",
                column: "FKJobID");

            migrationBuilder.CreateIndex(
                name: "IX_Authority_FKDirectorateID",
                table: "Authority",
                column: "FKDirectorateID");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorityJob_FKAuthotityID",
                table: "AuthorityJob",
                column: "FKAuthotityID");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorityJob_FKJobID",
                table: "AuthorityJob",
                column: "FKJobID");

            migrationBuilder.CreateIndex(
                name: "IX_CareerProgression_FKEmployeeID",
                table: "CareerProgression",
                column: "FKEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Center_FKSectionID",
                table: "Center",
                column: "FKSectionID");

            migrationBuilder.CreateIndex(
                name: "IX_CenterJob_FKCenterID",
                table: "CenterJob",
                column: "FKCenterID");

            migrationBuilder.CreateIndex(
                name: "IX_CenterJob_FKJobID",
                table: "CenterJob",
                column: "FKJobID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_FKAuthotiryID",
                table: "Department",
                column: "FKAuthotiryID");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentJob_FKDepartmentID",
                table: "DepartmentJob",
                column: "FKDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentJob_FKJobID",
                table: "DepartmentJob",
                column: "FKJobID");

            migrationBuilder.CreateIndex(
                name: "IX_DirectorateJob_FKDirectorateID",
                table: "DirectorateJob",
                column: "FKDirectorateID");

            migrationBuilder.CreateIndex(
                name: "IX_DirectorateJob_FKJobID",
                table: "DirectorateJob",
                column: "FKJobID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_FKAcademicQualificationID",
                table: "Employee",
                column: "FKAcademicQualificationID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_FKMaritalStatusID",
                table: "Employee",
                column: "FKMaritalStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveApplication_FKEmployeeID",
                table: "EmployeeLeaveApplication",
                column: "FKEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveApplication_FKLeaveTypeID",
                table: "EmployeeLeaveApplication",
                column: "FKLeaveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployementDetails_FKCategoryID",
                table: "EmployementDetails",
                column: "FKCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployementDetails_FKContractType",
                table: "EmployementDetails",
                column: "FKContractType");

            migrationBuilder.CreateIndex(
                name: "IX_EmployementDetails_FKDecreeType",
                table: "EmployementDetails",
                column: "FKDecreeType");

            migrationBuilder.CreateIndex(
                name: "IX_EmployementDetails_FKEmployeeID",
                table: "EmployementDetails",
                column: "FKEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployementDetails_FKEmploymentStatusID",
                table: "EmployementDetails",
                column: "FKEmploymentStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployementDetails_FKJobID",
                table: "EmployementDetails",
                column: "FKJobID");

            migrationBuilder.CreateIndex(
                name: "IX_ExtensionCenter_FKExtensionID",
                table: "ExtensionCenter",
                column: "FKExtensionID");

            migrationBuilder.CreateIndex(
                name: "IX_ExtensionCenterJob_FKExtensionCenterID",
                table: "ExtensionCenterJob",
                column: "FKExtensionCenterID");

            migrationBuilder.CreateIndex(
                name: "IX_ExtensionCenterJob_FKJobID",
                table: "ExtensionCenterJob",
                column: "FKJobID");

            migrationBuilder.CreateIndex(
                name: "IX_ExtensionSectionDetails_FKExtensionID",
                table: "ExtensionSectionDetails",
                column: "FKExtensionID");

            migrationBuilder.CreateIndex(
                name: "IX_ExtensionSectionDetails_FKExtensionSectionID",
                table: "ExtensionSectionDetails",
                column: "FKExtensionSectionID");

            migrationBuilder.CreateIndex(
                name: "IX_ExtensionSectionJob_FKExtensionSectionID",
                table: "ExtensionSectionJob",
                column: "FKExtensionSectionID");

            migrationBuilder.CreateIndex(
                name: "IX_ExtensionSectionJob_FKJobID",
                table: "ExtensionSectionJob",
                column: "FKJobID");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyDetails_FKEmployeeID",
                table: "FamilyDetails",
                column: "FKEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyDetails_FKRelativeTypeID",
                table: "FamilyDetails",
                column: "FKRelativeTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Job_FKCategoryID",
                table: "Job",
                column: "FKCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveTypeDays_FKContractTypeID",
                table: "LeaveTypeDays",
                column: "FKContractTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveTypeDays_FKLeaveTypeID",
                table: "LeaveTypeDays",
                column: "FKLeaveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Section_FKDepartmentID",
                table: "Section",
                column: "FKDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionJob_FKJobID",
                table: "SectionJob",
                column: "FKJobID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionJob_FKSectionID",
                table: "SectionJob",
                column: "FKSectionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdministrativeDepartmentJob");

            migrationBuilder.DropTable(
                name: "AuthorityJob");

            migrationBuilder.DropTable(
                name: "CareerProgression");

            migrationBuilder.DropTable(
                name: "CenterJob");

            migrationBuilder.DropTable(
                name: "DepartmentJob");

            migrationBuilder.DropTable(
                name: "DirectorateJob");

            migrationBuilder.DropTable(
                name: "EmployeeLeaveApplication");

            migrationBuilder.DropTable(
                name: "EmployeeLeaveBalance");

            migrationBuilder.DropTable(
                name: "EmployementDetails");

            migrationBuilder.DropTable(
                name: "ExtensionCenterJob");

            migrationBuilder.DropTable(
                name: "ExtensionSectionDetails");

            migrationBuilder.DropTable(
                name: "ExtensionSectionJob");

            migrationBuilder.DropTable(
                name: "FamilyDetails");

            migrationBuilder.DropTable(
                name: "LeaveTypeDays");

            migrationBuilder.DropTable(
                name: "SectionJob");

            migrationBuilder.DropTable(
                name: "AdministrativeDepartment");

            migrationBuilder.DropTable(
                name: "Center");

            migrationBuilder.DropTable(
                name: "DecreeType");

            migrationBuilder.DropTable(
                name: "EmployementStatus");

            migrationBuilder.DropTable(
                name: "ExtensionCenter");

            migrationBuilder.DropTable(
                name: "ExtensionSection");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "RelativeType");

            migrationBuilder.DropTable(
                name: "ContractType");

            migrationBuilder.DropTable(
                name: "LeaveType");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "Extension");

            migrationBuilder.DropTable(
                name: "AcademicQualification");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Authority");

            migrationBuilder.DropTable(
                name: "Directorate");
        }
    }
}
