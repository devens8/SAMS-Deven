using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAMS_Deven.Data.Migrations
{
    /// <inheritdoc />
    public partial class databases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_roomLocationInfoModels",
                table: "roomLocationInfoModels");

            migrationBuilder.DropColumn(
                name: "synnlabRoomMod",
                table: "synnLabQRNodeModels");

            migrationBuilder.DropColumn(
                name: "synnlabRoomSubject",
                table: "synnLabQRNodeModels");

            migrationBuilder.DropColumn(
                name: "managedTeacherMod",
                table: "substituteInfoModels");

            migrationBuilder.DropColumn(
                name: "bell1CourseCodeMod",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropColumn(
                name: "bell2CourseCodeMod",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropColumn(
                name: "bell3CourseCodeMod",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropColumn(
                name: "bell4CourseCodeMod",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropColumn(
                name: "bell5CourseCodeMod",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropColumn(
                name: "bell6CourseCodeMod",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropColumn(
                name: "bell7CourseCodeMod",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropColumn(
                name: "studentFirstNameMod",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropColumn(
                name: "studentLastNameMod",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropColumn(
                name: "studentCounselorEmailMod",
                table: "studentInfoModels");

            migrationBuilder.DropColumn(
                name: "studentCounselorNameMod",
                table: "studentInfoModels");

            migrationBuilder.DropColumn(
                name: "studentEAEmailMod",
                table: "studentInfoModels");

            migrationBuilder.DropColumn(
                name: "studentEANameMod",
                table: "studentInfoModels");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "passRequestInfoModels");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "passRequestInfoModels");

            migrationBuilder.DropColumn(
                name: "hallPassAddressee",
                table: "passRequestInfoModels");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "hallPassInfoModels");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "hallPassInfoModels");

            migrationBuilder.DropColumn(
                name: "hallPassAddressee",
                table: "hallPassInfoModels");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "fastPassModels");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "fastPassModels");

            migrationBuilder.DropColumn(
                name: "endLocation",
                table: "fastPassModels");

            migrationBuilder.DropColumn(
                name: "startLocation",
                table: "fastPassModels");

            migrationBuilder.DropColumn(
                name: "courseTeacherEmailAddress",
                table: "activeCourseInfoModels");

            migrationBuilder.RenameColumn(
                name: "teacherPreferredNameMod",
                table: "teacherInfoModels",
                newName: "TeacherPreferredNameMod");

            migrationBuilder.RenameColumn(
                name: "teacherPhoneMod",
                table: "teacherInfoModels",
                newName: "TeacherPhoneMod");

            migrationBuilder.RenameColumn(
                name: "teacherMiddleNameMod",
                table: "teacherInfoModels",
                newName: "TeacherMiddleNameMod");

            migrationBuilder.RenameColumn(
                name: "teacherLastNameMod",
                table: "teacherInfoModels",
                newName: "TeacherLastNameMod");

            migrationBuilder.RenameColumn(
                name: "teacherFirstNameMod",
                table: "teacherInfoModels",
                newName: "TeacherFirstNameMod");

            migrationBuilder.RenameColumn(
                name: "teacherEmailMod",
                table: "teacherInfoModels",
                newName: "TeacherEmailMod");

            migrationBuilder.RenameColumn(
                name: "teacherID",
                table: "teacherInfoModels",
                newName: "TeacherID");

            migrationBuilder.RenameColumn(
                name: "scannerMacAddressMod",
                table: "synnLabQRNodeModels",
                newName: "ScannerMacAddressMod");

            migrationBuilder.RenameColumn(
                name: "scannerLabelMod",
                table: "synnLabQRNodeModels",
                newName: "ScannerLabelMod");

            migrationBuilder.RenameColumn(
                name: "scannerDeviceIPAddressMod",
                table: "synnLabQRNodeModels",
                newName: "ScannerDeviceIPAddressMod");

            migrationBuilder.RenameColumn(
                name: "modelNumberMod",
                table: "synnLabQRNodeModels",
                newName: "ModelNumberMod");

            migrationBuilder.RenameColumn(
                name: "scannerID",
                table: "synnLabQRNodeModels",
                newName: "ScannerID");

            migrationBuilder.RenameColumn(
                name: "subPreferredNameMod",
                table: "substituteInfoModels",
                newName: "SubPreferredNameMod");

            migrationBuilder.RenameColumn(
                name: "subPhoneMod",
                table: "substituteInfoModels",
                newName: "SubPhoneMod");

            migrationBuilder.RenameColumn(
                name: "subMiddleNameMod",
                table: "substituteInfoModels",
                newName: "SubMiddleNameMod");

            migrationBuilder.RenameColumn(
                name: "subLastNameMod",
                table: "substituteInfoModels",
                newName: "SubLastNameMod");

            migrationBuilder.RenameColumn(
                name: "subFirstNameMod",
                table: "substituteInfoModels",
                newName: "SubFirstNameMod");

            migrationBuilder.RenameColumn(
                name: "subEmailMod",
                table: "substituteInfoModels",
                newName: "SubEmailMod");

            migrationBuilder.RenameColumn(
                name: "subID",
                table: "substituteInfoModels",
                newName: "SubID");

            migrationBuilder.RenameColumn(
                name: "lunchCodeMod",
                table: "studentScheduleInfoModels",
                newName: "LunchCodeMod");

            migrationBuilder.RenameColumn(
                name: "avesBellRoomCodeMod",
                table: "studentScheduleInfoModels",
                newName: "AvesBellRoomCodeMod");

            migrationBuilder.RenameColumn(
                name: "studentID",
                table: "studentScheduleInfoModels",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "studentPreferredNameMod",
                table: "studentInfoModels",
                newName: "StudentPreferredNameMod");

            migrationBuilder.RenameColumn(
                name: "studentPhoneMod",
                table: "studentInfoModels",
                newName: "StudentPhoneMod");

            migrationBuilder.RenameColumn(
                name: "studentMiddleNameMod",
                table: "studentInfoModels",
                newName: "StudentMiddleNameMod");

            migrationBuilder.RenameColumn(
                name: "studentLastNameMod",
                table: "studentInfoModels",
                newName: "StudentLastNameMod");

            migrationBuilder.RenameColumn(
                name: "studentFirstNameMod",
                table: "studentInfoModels",
                newName: "StudentFirstNameMod");

            migrationBuilder.RenameColumn(
                name: "studentEmailMod",
                table: "studentInfoModels",
                newName: "StudentEmailMod");

            migrationBuilder.RenameColumn(
                name: "parentguard2NameMod",
                table: "studentInfoModels",
                newName: "Parentguard2NameMod");

            migrationBuilder.RenameColumn(
                name: "parentguard2EmailMod",
                table: "studentInfoModels",
                newName: "Parentguard2EmailMod");

            migrationBuilder.RenameColumn(
                name: "parentguard1NameMod",
                table: "studentInfoModels",
                newName: "Parentguard1NameMod");

            migrationBuilder.RenameColumn(
                name: "parentguard1EmailMod",
                table: "studentInfoModels",
                newName: "Parentguard1EmailMod");

            migrationBuilder.RenameColumn(
                name: "studentID",
                table: "studentInfoModels",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "wingNameMod",
                table: "roomLocationInfoModels",
                newName: "WingNameMod");

            migrationBuilder.RenameColumn(
                name: "roomCodeMod",
                table: "roomLocationInfoModels",
                newName: "RoomCodeMod");

            migrationBuilder.RenameColumn(
                name: "roomNumberMod",
                table: "roomLocationInfoModels",
                newName: "RoomNumberMod");

            migrationBuilder.RenameColumn(
                name: "studentNameMod",
                table: "passRequestInfoModels",
                newName: "StudentNameMod");

            migrationBuilder.RenameColumn(
                name: "studentID",
                table: "passRequestInfoModels",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "startLocation",
                table: "passRequestInfoModels",
                newName: "StartLocation");

            migrationBuilder.RenameColumn(
                name: "requestStatus",
                table: "passRequestInfoModels",
                newName: "RequestStatus");

            migrationBuilder.RenameColumn(
                name: "hallPassAssignedBy",
                table: "passRequestInfoModels",
                newName: "HallPassAssignedBy");

            migrationBuilder.RenameColumn(
                name: "endLocation",
                table: "passRequestInfoModels",
                newName: "EndLocation");

            migrationBuilder.RenameColumn(
                name: "bellNumber",
                table: "passRequestInfoModels",
                newName: "BellNumber");

            migrationBuilder.RenameColumn(
                name: "passRequestId",
                table: "passRequestInfoModels",
                newName: "PassRequestId");

            migrationBuilder.RenameColumn(
                name: "nursePreferredNameMod",
                table: "nurseInfoModels",
                newName: "NursePreferredNameMod");

            migrationBuilder.RenameColumn(
                name: "nursePhoneMod",
                table: "nurseInfoModels",
                newName: "NursePhoneMod");

            migrationBuilder.RenameColumn(
                name: "nurseMiddleNameMod",
                table: "nurseInfoModels",
                newName: "NurseMiddleNameMod");

            migrationBuilder.RenameColumn(
                name: "nurseLastNameMod",
                table: "nurseInfoModels",
                newName: "NurseLastNameMod");

            migrationBuilder.RenameColumn(
                name: "nurseFirstNameMod",
                table: "nurseInfoModels",
                newName: "NurseFirstNameMod");

            migrationBuilder.RenameColumn(
                name: "nurseEmailMod",
                table: "nurseInfoModels",
                newName: "NurseEmailMod");

            migrationBuilder.RenameColumn(
                name: "nurseID",
                table: "nurseInfoModels",
                newName: "NurseID");

            migrationBuilder.RenameColumn(
                name: "lawePreferredNameMod",
                table: "lawEnforcementInfoModels",
                newName: "LawePreferredNameMod");

            migrationBuilder.RenameColumn(
                name: "lawePhoneMod",
                table: "lawEnforcementInfoModels",
                newName: "LawePhoneMod");

            migrationBuilder.RenameColumn(
                name: "laweMiddleNameMod",
                table: "lawEnforcementInfoModels",
                newName: "LaweMiddleNameMod");

            migrationBuilder.RenameColumn(
                name: "laweLastNameMod",
                table: "lawEnforcementInfoModels",
                newName: "LaweLastNameMod");

            migrationBuilder.RenameColumn(
                name: "laweFirstNameMod",
                table: "lawEnforcementInfoModels",
                newName: "LaweFirstNameMod");

            migrationBuilder.RenameColumn(
                name: "laweEmailMod",
                table: "lawEnforcementInfoModels",
                newName: "LaweEmailMod");

            migrationBuilder.RenameColumn(
                name: "lawenfID",
                table: "lawEnforcementInfoModels",
                newName: "LawenfID");

            migrationBuilder.RenameColumn(
                name: "studentID",
                table: "hallPassInfoModels",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "startLocation",
                table: "hallPassInfoModels",
                newName: "StartLocation");

            migrationBuilder.RenameColumn(
                name: "endLocation",
                table: "hallPassInfoModels",
                newName: "EndLocation");

            migrationBuilder.RenameColumn(
                name: "bellNumber",
                table: "hallPassInfoModels",
                newName: "BellNumber");

            migrationBuilder.RenameColumn(
                name: "studentNameMod",
                table: "hallPassInfoModels",
                newName: "HallPassAssignedByID");

            migrationBuilder.RenameColumn(
                name: "hallPassAssignedBy",
                table: "hallPassInfoModels",
                newName: "HallPassAddressedByID");

            migrationBuilder.RenameColumn(
                name: "studentNameMod",
                table: "fastPassModels",
                newName: "StudentNameMod");

            migrationBuilder.RenameColumn(
                name: "studentID",
                table: "fastPassModels",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "bellNumber",
                table: "fastPassModels",
                newName: "BellNumber");

            migrationBuilder.RenameColumn(
                name: "fastPassIDMod",
                table: "fastPassModels",
                newName: "FastPassIDMod");

            migrationBuilder.RenameColumn(
                name: "eaStudentManaged",
                table: "eASuportInfoModels",
                newName: "EaStudentManaged");

            migrationBuilder.RenameColumn(
                name: "eaPreferredNameMod",
                table: "eASuportInfoModels",
                newName: "EaPreferredNameMod");

            migrationBuilder.RenameColumn(
                name: "eaPhoneMod",
                table: "eASuportInfoModels",
                newName: "EaPhoneMod");

            migrationBuilder.RenameColumn(
                name: "eaMiddleNameMod",
                table: "eASuportInfoModels",
                newName: "EaMiddleNameMod");

            migrationBuilder.RenameColumn(
                name: "eaLastNameMod",
                table: "eASuportInfoModels",
                newName: "EaLastNameMod");

            migrationBuilder.RenameColumn(
                name: "eaFirstNameMod",
                table: "eASuportInfoModels",
                newName: "EaFirstNameMod");

            migrationBuilder.RenameColumn(
                name: "eaEmailMod",
                table: "eASuportInfoModels",
                newName: "EaEmailMod");

            migrationBuilder.RenameColumn(
                name: "eaID",
                table: "eASuportInfoModels",
                newName: "EaID");

            migrationBuilder.RenameColumn(
                name: "developerPreferredNameMod",
                table: "developerInfoModels",
                newName: "DeveloperPreferredNameMod");

            migrationBuilder.RenameColumn(
                name: "developerMiddleNameMod",
                table: "developerInfoModels",
                newName: "DeveloperMiddleNameMod");

            migrationBuilder.RenameColumn(
                name: "developerLastNameMod",
                table: "developerInfoModels",
                newName: "DeveloperLastNameMod");

            migrationBuilder.RenameColumn(
                name: "developerFirstNameMod",
                table: "developerInfoModels",
                newName: "DeveloperFirstNameMod");

            migrationBuilder.RenameColumn(
                name: "developerEmailMod",
                table: "developerInfoModels",
                newName: "DeveloperEmailMod");

            migrationBuilder.RenameColumn(
                name: "developerID",
                table: "developerInfoModels",
                newName: "DeveloperID");

            migrationBuilder.RenameColumn(
                name: "aoMemberPreferredNameMod",
                table: "attendanceOfficeMemberModels",
                newName: "AoMemberPreferredNameMod");

            migrationBuilder.RenameColumn(
                name: "aoMemberPhoneMod",
                table: "attendanceOfficeMemberModels",
                newName: "AoMemberPhoneMod");

            migrationBuilder.RenameColumn(
                name: "aoMemberMiddleNameMod",
                table: "attendanceOfficeMemberModels",
                newName: "AoMemberMiddleNameMod");

            migrationBuilder.RenameColumn(
                name: "aoMemberLastNameMod",
                table: "attendanceOfficeMemberModels",
                newName: "AoMemberLastNameMod");

            migrationBuilder.RenameColumn(
                name: "aoMemberFirstNameMod",
                table: "attendanceOfficeMemberModels",
                newName: "AoMemberFirstNameMod");

            migrationBuilder.RenameColumn(
                name: "aoMemberEmailMod",
                table: "attendanceOfficeMemberModels",
                newName: "AoMemberEmailMod");

            migrationBuilder.RenameColumn(
                name: "aoMemberID",
                table: "attendanceOfficeMemberModels",
                newName: "AoMemberID");

            migrationBuilder.RenameColumn(
                name: "adminID",
                table: "adminInfoModels",
                newName: "AdminID");

            migrationBuilder.RenameColumn(
                name: "courseName",
                table: "activeCourseInfoModels",
                newName: "CourseName");

            migrationBuilder.RenameColumn(
                name: "courseLevel",
                table: "activeCourseInfoModels",
                newName: "CourseLevel");

            migrationBuilder.RenameColumn(
                name: "courseCode",
                table: "activeCourseInfoModels",
                newName: "CourseCode");

            migrationBuilder.RenameColumn(
                name: "courseBellNumber",
                table: "activeCourseInfoModels",
                newName: "CourseBellNumber");

            migrationBuilder.RenameColumn(
                name: "courseId",
                table: "activeCourseInfoModels",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "wingName",
                table: "activeCourseInfoModels",
                newName: "CourseTaughtDays");

            migrationBuilder.RenameColumn(
                name: "roomNumber",
                table: "activeCourseInfoModels",
                newName: "CourseRoomID");

            migrationBuilder.RenameColumn(
                name: "courseTeacherName",
                table: "activeCourseInfoModels",
                newName: "CourseLength");

            migrationBuilder.AddColumn<bool>(
                name: "Teaches5Days",
                table: "teacherInfoModels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeachingScheduleID",
                table: "teacherInfoModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SynnlabRoomIDMod",
                table: "synnLabQRNodeModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ManagedTeacherIdMod",
                table: "substituteInfoModels",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ScheduledDate",
                table: "substituteInfoModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "LunchCodeMod",
                table: "studentScheduleInfoModels",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "AvesBellRoomCodeMod",
                table: "studentScheduleInfoModels",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "studentScheduleInfoModels",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Bell1EnrollmentCodeMod",
                table: "studentScheduleInfoModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Bell2EnrollmentCodeMod",
                table: "studentScheduleInfoModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Bell3EnrollmentCodeMod",
                table: "studentScheduleInfoModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Bell4EnrollmentCodeMod",
                table: "studentScheduleInfoModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Bell5EnrollmentCodeMod",
                table: "studentScheduleInfoModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Bell6EnrollmentCodeMod",
                table: "studentScheduleInfoModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Bell7EnrollmentCodeMod",
                table: "studentScheduleInfoModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ActivationCode",
                table: "studentInfoModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EASuportEaID",
                table: "studentInfoModels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasEASupport",
                table: "studentInfoModels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "StudentCounselorID",
                table: "studentInfoModels",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentEAID",
                table: "studentInfoModels",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StudentGradYearMod",
                table: "studentInfoModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumberMod",
                table: "roomLocationInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "roomLocationInfoModels",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "RoomAssignedToTeacherID",
                table: "roomLocationInfoModels",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RoomScannerId",
                table: "roomLocationInfoModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "HallPassAssignedBy",
                table: "passRequestInfoModels",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDateTime",
                table: "passRequestInfoModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "HallPassAddressedBy",
                table: "passRequestInfoModels",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDateTime",
                table: "passRequestInfoModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "AssignedByAdminAdminID",
                table: "hallPassInfoModels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssignedByAttendanceOfficeMemberAoMemberID",
                table: "hallPassInfoModels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssignedByCounselorCounselorId",
                table: "hallPassInfoModels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssignedByLawEnfLawenfID",
                table: "hallPassInfoModels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssignedByNurseNurseID",
                table: "hallPassInfoModels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssignedByTeacherTeacherID",
                table: "hallPassInfoModels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDateTime",
                table: "hallPassInfoModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDateTime",
                table: "hallPassInfoModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CourseIDFromStudentSchedule",
                table: "fastPassModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDateTime",
                table: "fastPassModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EndLocationID",
                table: "fastPassModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "fastPassModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDateTime",
                table: "fastPassModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "StartLocationID",
                table: "fastPassModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentScheduleStudentID",
                table: "fastPassModels",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EaStudentManaged",
                table: "eASuportInfoModels",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "activeCourseInfoModels",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CourseTeacherID",
                table: "activeCourseInfoModels",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstituteSubID",
                table: "activeCourseInfoModels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_roomLocationInfoModels",
                table: "roomLocationInfoModels",
                column: "RoomId");

            migrationBuilder.CreateTable(
                name: "ActivationModel",
                columns: table => new
                {
                    StudId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivationModel", x => x.StudId);
                    table.ForeignKey(
                        name: "FK_ActivationModel_studentInfoModels_StudId",
                        column: x => x.StudId,
                        principalTable: "studentInfoModels",
                        principalColumn: "StudentID");
                });

            migrationBuilder.CreateTable(
                name: "BellAttendanceModel",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    BellAttendanceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReasonForAbsence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BellNumId = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BellAttendanceModel", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_BellAttendanceModel_studentInfoModels_StudentId",
                        column: x => x.StudentId,
                        principalTable: "studentInfoModels",
                        principalColumn: "StudentID");
                });

            migrationBuilder.CreateTable(
                name: "CounselorModel",
                columns: table => new
                {
                    CounselorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CounselorFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CounselorMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CounselorLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CounselorPreferredName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CounselorEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CounselorPhone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CounselorModel", x => x.CounselorId);
                });

            migrationBuilder.CreateTable(
                name: "CourseEnrollmentModel",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnrollmentStudentId = table.Column<int>(type: "int", nullable: false),
                    EnrollmentCourseId = table.Column<int>(type: "int", nullable: false),
                    EnrollmentDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActiveCoursesCourseId = table.Column<int>(type: "int", nullable: true),
                    StudentSchedulesStudentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseEnrollmentModel", x => x.EnrollmentId);
                    table.ForeignKey(
                        name: "FK_CourseEnrollmentModel_activeCourseInfoModels_ActiveCoursesCourseId",
                        column: x => x.ActiveCoursesCourseId,
                        principalTable: "activeCourseInfoModels",
                        principalColumn: "CourseId");
                    table.ForeignKey(
                        name: "FK_CourseEnrollmentModel_studentInfoModels_EnrollmentStudentId",
                        column: x => x.EnrollmentStudentId,
                        principalTable: "studentInfoModels",
                        principalColumn: "StudentID");
                    table.ForeignKey(
                        name: "FK_CourseEnrollmentModel_studentScheduleInfoModels_StudentSchedulesStudentID",
                        column: x => x.StudentSchedulesStudentID,
                        principalTable: "studentScheduleInfoModels",
                        principalColumn: "StudentID");
                });

            migrationBuilder.CreateTable(
                name: "DailyAttendanceModel",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReasonForAbsence = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyAttendanceModel", x => x.AttendanceId);
                    table.ForeignKey(
                        name: "FK_DailyAttendanceModel_studentInfoModels_StudentId",
                        column: x => x.StudentId,
                        principalTable: "studentInfoModels",
                        principalColumn: "StudentID");
                });

            migrationBuilder.CreateTable(
                name: "TeachingScheduleModel",
                columns: table => new
                {
                    ScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DaysOfWeek = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachingScheduleModel", x => x.ScheduleID);
                    table.ForeignKey(
                        name: "FK_TeachingScheduleModel_teacherInfoModels_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "teacherInfoModels",
                        principalColumn: "TeacherID");
                });

            migrationBuilder.CreateTable(
                name: "RoomScheduleModel",
                columns: table => new
                {
                    RoomScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    TeacherID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ScheduleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomScheduleModel", x => x.RoomScheduleID);
                    table.ForeignKey(
                        name: "FK_RoomScheduleModel_TeachingScheduleModel_ScheduleID",
                        column: x => x.ScheduleID,
                        principalTable: "TeachingScheduleModel",
                        principalColumn: "ScheduleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomScheduleModel_roomLocationInfoModels_RoomId",
                        column: x => x.RoomId,
                        principalTable: "roomLocationInfoModels",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomScheduleModel_teacherInfoModels_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "teacherInfoModels",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_synnLabQRNodeModels_SynnlabRoomIDMod",
                table: "synnLabQRNodeModels",
                column: "SynnlabRoomIDMod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_substituteInfoModels_ManagedTeacherIdMod",
                table: "substituteInfoModels",
                column: "ManagedTeacherIdMod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_studentInfoModels_EASuportEaID",
                table: "studentInfoModels",
                column: "EASuportEaID");

            migrationBuilder.CreateIndex(
                name: "IX_studentInfoModels_StudentCounselorID",
                table: "studentInfoModels",
                column: "StudentCounselorID");

            migrationBuilder.CreateIndex(
                name: "IX_studentInfoModels_StudentEAID",
                table: "studentInfoModels",
                column: "StudentEAID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_roomLocationInfoModels_RoomAssignedToTeacherID",
                table: "roomLocationInfoModels",
                column: "RoomAssignedToTeacherID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_passRequestInfoModels_HallPassAddressedBy",
                table: "passRequestInfoModels",
                column: "HallPassAddressedBy");

            migrationBuilder.CreateIndex(
                name: "IX_passRequestInfoModels_HallPassAssignedBy",
                table: "passRequestInfoModels",
                column: "HallPassAssignedBy");

            migrationBuilder.CreateIndex(
                name: "IX_passRequestInfoModels_StudentID",
                table: "passRequestInfoModels",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_hallPassInfoModels_AssignedByAdminAdminID",
                table: "hallPassInfoModels",
                column: "AssignedByAdminAdminID");

            migrationBuilder.CreateIndex(
                name: "IX_hallPassInfoModels_AssignedByAttendanceOfficeMemberAoMemberID",
                table: "hallPassInfoModels",
                column: "AssignedByAttendanceOfficeMemberAoMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_hallPassInfoModels_AssignedByCounselorCounselorId",
                table: "hallPassInfoModels",
                column: "AssignedByCounselorCounselorId");

            migrationBuilder.CreateIndex(
                name: "IX_hallPassInfoModels_AssignedByLawEnfLawenfID",
                table: "hallPassInfoModels",
                column: "AssignedByLawEnfLawenfID");

            migrationBuilder.CreateIndex(
                name: "IX_hallPassInfoModels_AssignedByNurseNurseID",
                table: "hallPassInfoModels",
                column: "AssignedByNurseNurseID");

            migrationBuilder.CreateIndex(
                name: "IX_hallPassInfoModels_AssignedByTeacherTeacherID",
                table: "hallPassInfoModels",
                column: "AssignedByTeacherTeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_hallPassInfoModels_StudentID",
                table: "hallPassInfoModels",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_fastPassModels_RoomId",
                table: "fastPassModels",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_fastPassModels_StudentID",
                table: "fastPassModels",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_fastPassModels_StudentScheduleStudentID",
                table: "fastPassModels",
                column: "StudentScheduleStudentID");

            migrationBuilder.CreateIndex(
                name: "IX_activeCourseInfoModels_CourseRoomID",
                table: "activeCourseInfoModels",
                column: "CourseRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_activeCourseInfoModels_CourseTeacherID",
                table: "activeCourseInfoModels",
                column: "CourseTeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_activeCourseInfoModels_SubstituteSubID",
                table: "activeCourseInfoModels",
                column: "SubstituteSubID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseEnrollmentModel_ActiveCoursesCourseId",
                table: "CourseEnrollmentModel",
                column: "ActiveCoursesCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseEnrollmentModel_EnrollmentStudentId",
                table: "CourseEnrollmentModel",
                column: "EnrollmentStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseEnrollmentModel_StudentSchedulesStudentID",
                table: "CourseEnrollmentModel",
                column: "StudentSchedulesStudentID");

            migrationBuilder.CreateIndex(
                name: "IX_DailyAttendanceModel_StudentId",
                table: "DailyAttendanceModel",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomScheduleModel_RoomId",
                table: "RoomScheduleModel",
                column: "RoomId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomScheduleModel_ScheduleID",
                table: "RoomScheduleModel",
                column: "ScheduleID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomScheduleModel_TeacherID",
                table: "RoomScheduleModel",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_TeachingScheduleModel_TeacherID",
                table: "TeachingScheduleModel",
                column: "TeacherID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_activeCourseInfoModels_roomLocationInfoModels_CourseRoomID",
                table: "activeCourseInfoModels",
                column: "CourseRoomID",
                principalTable: "roomLocationInfoModels",
                principalColumn: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_activeCourseInfoModels_substituteInfoModels_SubstituteSubID",
                table: "activeCourseInfoModels",
                column: "SubstituteSubID",
                principalTable: "substituteInfoModels",
                principalColumn: "SubID");

            migrationBuilder.AddForeignKey(
                name: "FK_activeCourseInfoModels_teacherInfoModels_CourseTeacherID",
                table: "activeCourseInfoModels",
                column: "CourseTeacherID",
                principalTable: "teacherInfoModels",
                principalColumn: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_fastPassModels_roomLocationInfoModels_RoomId",
                table: "fastPassModels",
                column: "RoomId",
                principalTable: "roomLocationInfoModels",
                principalColumn: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_fastPassModels_studentInfoModels_StudentID",
                table: "fastPassModels",
                column: "StudentID",
                principalTable: "studentInfoModels",
                principalColumn: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_fastPassModels_studentScheduleInfoModels_StudentScheduleStudentID",
                table: "fastPassModels",
                column: "StudentScheduleStudentID",
                principalTable: "studentScheduleInfoModels",
                principalColumn: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_hallPassInfoModels_CounselorModel_AssignedByCounselorCounselorId",
                table: "hallPassInfoModels",
                column: "AssignedByCounselorCounselorId",
                principalTable: "CounselorModel",
                principalColumn: "CounselorId");

            migrationBuilder.AddForeignKey(
                name: "FK_hallPassInfoModels_CounselorModel_HallPassID",
                table: "hallPassInfoModels",
                column: "HallPassID",
                principalTable: "CounselorModel",
                principalColumn: "CounselorId");

            migrationBuilder.AddForeignKey(
                name: "FK_hallPassInfoModels_adminInfoModels_AssignedByAdminAdminID",
                table: "hallPassInfoModels",
                column: "AssignedByAdminAdminID",
                principalTable: "adminInfoModels",
                principalColumn: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_hallPassInfoModels_adminInfoModels_HallPassID",
                table: "hallPassInfoModels",
                column: "HallPassID",
                principalTable: "adminInfoModels",
                principalColumn: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_hallPassInfoModels_attendanceOfficeMemberModels_AssignedByAttendanceOfficeMemberAoMemberID",
                table: "hallPassInfoModels",
                column: "AssignedByAttendanceOfficeMemberAoMemberID",
                principalTable: "attendanceOfficeMemberModels",
                principalColumn: "AoMemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_hallPassInfoModels_attendanceOfficeMemberModels_HallPassID",
                table: "hallPassInfoModels",
                column: "HallPassID",
                principalTable: "attendanceOfficeMemberModels",
                principalColumn: "AoMemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_hallPassInfoModels_lawEnforcementInfoModels_AssignedByLawEnfLawenfID",
                table: "hallPassInfoModels",
                column: "AssignedByLawEnfLawenfID",
                principalTable: "lawEnforcementInfoModels",
                principalColumn: "LawenfID");

            migrationBuilder.AddForeignKey(
                name: "FK_hallPassInfoModels_lawEnforcementInfoModels_HallPassID",
                table: "hallPassInfoModels",
                column: "HallPassID",
                principalTable: "lawEnforcementInfoModels",
                principalColumn: "LawenfID");

            migrationBuilder.AddForeignKey(
                name: "FK_hallPassInfoModels_nurseInfoModels_AssignedByNurseNurseID",
                table: "hallPassInfoModels",
                column: "AssignedByNurseNurseID",
                principalTable: "nurseInfoModels",
                principalColumn: "NurseID");

            migrationBuilder.AddForeignKey(
                name: "FK_hallPassInfoModels_nurseInfoModels_HallPassID",
                table: "hallPassInfoModels",
                column: "HallPassID",
                principalTable: "nurseInfoModels",
                principalColumn: "NurseID");

            migrationBuilder.AddForeignKey(
                name: "FK_hallPassInfoModels_studentInfoModels_StudentID",
                table: "hallPassInfoModels",
                column: "StudentID",
                principalTable: "studentInfoModels",
                principalColumn: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_hallPassInfoModels_teacherInfoModels_AssignedByTeacherTeacherID",
                table: "hallPassInfoModels",
                column: "AssignedByTeacherTeacherID",
                principalTable: "teacherInfoModels",
                principalColumn: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_hallPassInfoModels_teacherInfoModels_HallPassID",
                table: "hallPassInfoModels",
                column: "HallPassID",
                principalTable: "teacherInfoModels",
                principalColumn: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_passRequestInfoModels_CounselorModel_HallPassAddressedBy",
                table: "passRequestInfoModels",
                column: "HallPassAddressedBy",
                principalTable: "CounselorModel",
                principalColumn: "CounselorId");

            migrationBuilder.AddForeignKey(
                name: "FK_passRequestInfoModels_CounselorModel_HallPassAssignedBy",
                table: "passRequestInfoModels",
                column: "HallPassAssignedBy",
                principalTable: "CounselorModel",
                principalColumn: "CounselorId");

            migrationBuilder.AddForeignKey(
                name: "FK_passRequestInfoModels_adminInfoModels_HallPassAddressedBy",
                table: "passRequestInfoModels",
                column: "HallPassAddressedBy",
                principalTable: "adminInfoModels",
                principalColumn: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_passRequestInfoModels_adminInfoModels_HallPassAssignedBy",
                table: "passRequestInfoModels",
                column: "HallPassAssignedBy",
                principalTable: "adminInfoModels",
                principalColumn: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_passRequestInfoModels_attendanceOfficeMemberModels_HallPassAddressedBy",
                table: "passRequestInfoModels",
                column: "HallPassAddressedBy",
                principalTable: "attendanceOfficeMemberModels",
                principalColumn: "AoMemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_passRequestInfoModels_attendanceOfficeMemberModels_HallPassAssignedBy",
                table: "passRequestInfoModels",
                column: "HallPassAssignedBy",
                principalTable: "attendanceOfficeMemberModels",
                principalColumn: "AoMemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_passRequestInfoModels_lawEnforcementInfoModels_HallPassAddressedBy",
                table: "passRequestInfoModels",
                column: "HallPassAddressedBy",
                principalTable: "lawEnforcementInfoModels",
                principalColumn: "LawenfID");

            migrationBuilder.AddForeignKey(
                name: "FK_passRequestInfoModels_lawEnforcementInfoModels_HallPassAssignedBy",
                table: "passRequestInfoModels",
                column: "HallPassAssignedBy",
                principalTable: "lawEnforcementInfoModels",
                principalColumn: "LawenfID");

            migrationBuilder.AddForeignKey(
                name: "FK_passRequestInfoModels_nurseInfoModels_HallPassAddressedBy",
                table: "passRequestInfoModels",
                column: "HallPassAddressedBy",
                principalTable: "nurseInfoModels",
                principalColumn: "NurseID");

            migrationBuilder.AddForeignKey(
                name: "FK_passRequestInfoModels_nurseInfoModels_HallPassAssignedBy",
                table: "passRequestInfoModels",
                column: "HallPassAssignedBy",
                principalTable: "nurseInfoModels",
                principalColumn: "NurseID");

            migrationBuilder.AddForeignKey(
                name: "FK_passRequestInfoModels_studentInfoModels_StudentID",
                table: "passRequestInfoModels",
                column: "StudentID",
                principalTable: "studentInfoModels",
                principalColumn: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_passRequestInfoModels_teacherInfoModels_HallPassAddressedBy",
                table: "passRequestInfoModels",
                column: "HallPassAddressedBy",
                principalTable: "teacherInfoModels",
                principalColumn: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_passRequestInfoModels_teacherInfoModels_HallPassAssignedBy",
                table: "passRequestInfoModels",
                column: "HallPassAssignedBy",
                principalTable: "teacherInfoModels",
                principalColumn: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_roomLocationInfoModels_teacherInfoModels_RoomAssignedToTeacherID",
                table: "roomLocationInfoModels",
                column: "RoomAssignedToTeacherID",
                principalTable: "teacherInfoModels",
                principalColumn: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_studentInfoModels_CounselorModel_StudentCounselorID",
                table: "studentInfoModels",
                column: "StudentCounselorID",
                principalTable: "CounselorModel",
                principalColumn: "CounselorId");

            migrationBuilder.AddForeignKey(
                name: "FK_studentInfoModels_eASuportInfoModels_EASuportEaID",
                table: "studentInfoModels",
                column: "EASuportEaID",
                principalTable: "eASuportInfoModels",
                principalColumn: "EaID");

            migrationBuilder.AddForeignKey(
                name: "FK_studentInfoModels_eASuportInfoModels_StudentEAID",
                table: "studentInfoModels",
                column: "StudentEAID",
                principalTable: "eASuportInfoModels",
                principalColumn: "EaID");

            migrationBuilder.AddForeignKey(
                name: "FK_studentScheduleInfoModels_BellAttendanceModel_StudentID",
                table: "studentScheduleInfoModels",
                column: "StudentID",
                principalTable: "BellAttendanceModel",
                principalColumn: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_studentScheduleInfoModels_studentInfoModels_StudentID",
                table: "studentScheduleInfoModels",
                column: "StudentID",
                principalTable: "studentInfoModels",
                principalColumn: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_substituteInfoModels_teacherInfoModels_ManagedTeacherIdMod",
                table: "substituteInfoModels",
                column: "ManagedTeacherIdMod",
                principalTable: "teacherInfoModels",
                principalColumn: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_synnLabQRNodeModels_roomLocationInfoModels_SynnlabRoomIDMod",
                table: "synnLabQRNodeModels",
                column: "SynnlabRoomIDMod",
                principalTable: "roomLocationInfoModels",
                principalColumn: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_activeCourseInfoModels_roomLocationInfoModels_CourseRoomID",
                table: "activeCourseInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_activeCourseInfoModels_substituteInfoModels_SubstituteSubID",
                table: "activeCourseInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_activeCourseInfoModels_teacherInfoModels_CourseTeacherID",
                table: "activeCourseInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_fastPassModels_roomLocationInfoModels_RoomId",
                table: "fastPassModels");

            migrationBuilder.DropForeignKey(
                name: "FK_fastPassModels_studentInfoModels_StudentID",
                table: "fastPassModels");

            migrationBuilder.DropForeignKey(
                name: "FK_fastPassModels_studentScheduleInfoModels_StudentScheduleStudentID",
                table: "fastPassModels");

            migrationBuilder.DropForeignKey(
                name: "FK_hallPassInfoModels_CounselorModel_AssignedByCounselorCounselorId",
                table: "hallPassInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_hallPassInfoModels_CounselorModel_HallPassID",
                table: "hallPassInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_hallPassInfoModels_adminInfoModels_AssignedByAdminAdminID",
                table: "hallPassInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_hallPassInfoModels_adminInfoModels_HallPassID",
                table: "hallPassInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_hallPassInfoModels_attendanceOfficeMemberModels_AssignedByAttendanceOfficeMemberAoMemberID",
                table: "hallPassInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_hallPassInfoModels_attendanceOfficeMemberModels_HallPassID",
                table: "hallPassInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_hallPassInfoModels_lawEnforcementInfoModels_AssignedByLawEnfLawenfID",
                table: "hallPassInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_hallPassInfoModels_lawEnforcementInfoModels_HallPassID",
                table: "hallPassInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_hallPassInfoModels_nurseInfoModels_AssignedByNurseNurseID",
                table: "hallPassInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_hallPassInfoModels_nurseInfoModels_HallPassID",
                table: "hallPassInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_hallPassInfoModels_studentInfoModels_StudentID",
                table: "hallPassInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_hallPassInfoModels_teacherInfoModels_AssignedByTeacherTeacherID",
                table: "hallPassInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_hallPassInfoModels_teacherInfoModels_HallPassID",
                table: "hallPassInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_passRequestInfoModels_CounselorModel_HallPassAddressedBy",
                table: "passRequestInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_passRequestInfoModels_CounselorModel_HallPassAssignedBy",
                table: "passRequestInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_passRequestInfoModels_adminInfoModels_HallPassAddressedBy",
                table: "passRequestInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_passRequestInfoModels_adminInfoModels_HallPassAssignedBy",
                table: "passRequestInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_passRequestInfoModels_attendanceOfficeMemberModels_HallPassAddressedBy",
                table: "passRequestInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_passRequestInfoModels_attendanceOfficeMemberModels_HallPassAssignedBy",
                table: "passRequestInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_passRequestInfoModels_lawEnforcementInfoModels_HallPassAddressedBy",
                table: "passRequestInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_passRequestInfoModels_lawEnforcementInfoModels_HallPassAssignedBy",
                table: "passRequestInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_passRequestInfoModels_nurseInfoModels_HallPassAddressedBy",
                table: "passRequestInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_passRequestInfoModels_nurseInfoModels_HallPassAssignedBy",
                table: "passRequestInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_passRequestInfoModels_studentInfoModels_StudentID",
                table: "passRequestInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_passRequestInfoModels_teacherInfoModels_HallPassAddressedBy",
                table: "passRequestInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_passRequestInfoModels_teacherInfoModels_HallPassAssignedBy",
                table: "passRequestInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_roomLocationInfoModels_teacherInfoModels_RoomAssignedToTeacherID",
                table: "roomLocationInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_studentInfoModels_CounselorModel_StudentCounselorID",
                table: "studentInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_studentInfoModels_eASuportInfoModels_EASuportEaID",
                table: "studentInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_studentInfoModels_eASuportInfoModels_StudentEAID",
                table: "studentInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_studentScheduleInfoModels_BellAttendanceModel_StudentID",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_studentScheduleInfoModels_studentInfoModels_StudentID",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_substituteInfoModels_teacherInfoModels_ManagedTeacherIdMod",
                table: "substituteInfoModels");

            migrationBuilder.DropForeignKey(
                name: "FK_synnLabQRNodeModels_roomLocationInfoModels_SynnlabRoomIDMod",
                table: "synnLabQRNodeModels");

            migrationBuilder.DropTable(
                name: "ActivationModel");

            migrationBuilder.DropTable(
                name: "BellAttendanceModel");

            migrationBuilder.DropTable(
                name: "CounselorModel");

            migrationBuilder.DropTable(
                name: "CourseEnrollmentModel");

            migrationBuilder.DropTable(
                name: "DailyAttendanceModel");

            migrationBuilder.DropTable(
                name: "RoomScheduleModel");

            migrationBuilder.DropTable(
                name: "TeachingScheduleModel");

            migrationBuilder.DropIndex(
                name: "IX_synnLabQRNodeModels_SynnlabRoomIDMod",
                table: "synnLabQRNodeModels");

            migrationBuilder.DropIndex(
                name: "IX_substituteInfoModels_ManagedTeacherIdMod",
                table: "substituteInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_studentInfoModels_EASuportEaID",
                table: "studentInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_studentInfoModels_StudentCounselorID",
                table: "studentInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_studentInfoModels_StudentEAID",
                table: "studentInfoModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_roomLocationInfoModels",
                table: "roomLocationInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_roomLocationInfoModels_RoomAssignedToTeacherID",
                table: "roomLocationInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_passRequestInfoModels_HallPassAddressedBy",
                table: "passRequestInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_passRequestInfoModels_HallPassAssignedBy",
                table: "passRequestInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_passRequestInfoModels_StudentID",
                table: "passRequestInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_hallPassInfoModels_AssignedByAdminAdminID",
                table: "hallPassInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_hallPassInfoModels_AssignedByAttendanceOfficeMemberAoMemberID",
                table: "hallPassInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_hallPassInfoModels_AssignedByCounselorCounselorId",
                table: "hallPassInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_hallPassInfoModels_AssignedByLawEnfLawenfID",
                table: "hallPassInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_hallPassInfoModels_AssignedByNurseNurseID",
                table: "hallPassInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_hallPassInfoModels_AssignedByTeacherTeacherID",
                table: "hallPassInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_hallPassInfoModels_StudentID",
                table: "hallPassInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_fastPassModels_RoomId",
                table: "fastPassModels");

            migrationBuilder.DropIndex(
                name: "IX_fastPassModels_StudentID",
                table: "fastPassModels");

            migrationBuilder.DropIndex(
                name: "IX_fastPassModels_StudentScheduleStudentID",
                table: "fastPassModels");

            migrationBuilder.DropIndex(
                name: "IX_activeCourseInfoModels_CourseRoomID",
                table: "activeCourseInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_activeCourseInfoModels_CourseTeacherID",
                table: "activeCourseInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_activeCourseInfoModels_SubstituteSubID",
                table: "activeCourseInfoModels");

            migrationBuilder.DropColumn(
                name: "Teaches5Days",
                table: "teacherInfoModels");

            migrationBuilder.DropColumn(
                name: "TeachingScheduleID",
                table: "teacherInfoModels");

            migrationBuilder.DropColumn(
                name: "SynnlabRoomIDMod",
                table: "synnLabQRNodeModels");

            migrationBuilder.DropColumn(
                name: "ManagedTeacherIdMod",
                table: "substituteInfoModels");

            migrationBuilder.DropColumn(
                name: "ScheduledDate",
                table: "substituteInfoModels");

            migrationBuilder.DropColumn(
                name: "Bell1EnrollmentCodeMod",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropColumn(
                name: "Bell2EnrollmentCodeMod",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropColumn(
                name: "Bell3EnrollmentCodeMod",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropColumn(
                name: "Bell4EnrollmentCodeMod",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropColumn(
                name: "Bell5EnrollmentCodeMod",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropColumn(
                name: "Bell6EnrollmentCodeMod",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropColumn(
                name: "Bell7EnrollmentCodeMod",
                table: "studentScheduleInfoModels");

            migrationBuilder.DropColumn(
                name: "ActivationCode",
                table: "studentInfoModels");

            migrationBuilder.DropColumn(
                name: "EASuportEaID",
                table: "studentInfoModels");

            migrationBuilder.DropColumn(
                name: "HasEASupport",
                table: "studentInfoModels");

            migrationBuilder.DropColumn(
                name: "StudentCounselorID",
                table: "studentInfoModels");

            migrationBuilder.DropColumn(
                name: "StudentEAID",
                table: "studentInfoModels");

            migrationBuilder.DropColumn(
                name: "StudentGradYearMod",
                table: "studentInfoModels");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "roomLocationInfoModels");

            migrationBuilder.DropColumn(
                name: "RoomAssignedToTeacherID",
                table: "roomLocationInfoModels");

            migrationBuilder.DropColumn(
                name: "RoomScannerId",
                table: "roomLocationInfoModels");

            migrationBuilder.DropColumn(
                name: "EndDateTime",
                table: "passRequestInfoModels");

            migrationBuilder.DropColumn(
                name: "HallPassAddressedBy",
                table: "passRequestInfoModels");

            migrationBuilder.DropColumn(
                name: "StartDateTime",
                table: "passRequestInfoModels");

            migrationBuilder.DropColumn(
                name: "AssignedByAdminAdminID",
                table: "hallPassInfoModels");

            migrationBuilder.DropColumn(
                name: "AssignedByAttendanceOfficeMemberAoMemberID",
                table: "hallPassInfoModels");

            migrationBuilder.DropColumn(
                name: "AssignedByCounselorCounselorId",
                table: "hallPassInfoModels");

            migrationBuilder.DropColumn(
                name: "AssignedByLawEnfLawenfID",
                table: "hallPassInfoModels");

            migrationBuilder.DropColumn(
                name: "AssignedByNurseNurseID",
                table: "hallPassInfoModels");

            migrationBuilder.DropColumn(
                name: "AssignedByTeacherTeacherID",
                table: "hallPassInfoModels");

            migrationBuilder.DropColumn(
                name: "EndDateTime",
                table: "hallPassInfoModels");

            migrationBuilder.DropColumn(
                name: "StartDateTime",
                table: "hallPassInfoModels");

            migrationBuilder.DropColumn(
                name: "CourseIDFromStudentSchedule",
                table: "fastPassModels");

            migrationBuilder.DropColumn(
                name: "EndDateTime",
                table: "fastPassModels");

            migrationBuilder.DropColumn(
                name: "EndLocationID",
                table: "fastPassModels");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "fastPassModels");

            migrationBuilder.DropColumn(
                name: "StartDateTime",
                table: "fastPassModels");

            migrationBuilder.DropColumn(
                name: "StartLocationID",
                table: "fastPassModels");

            migrationBuilder.DropColumn(
                name: "StudentScheduleStudentID",
                table: "fastPassModels");

            migrationBuilder.DropColumn(
                name: "CourseTeacherID",
                table: "activeCourseInfoModels");

            migrationBuilder.DropColumn(
                name: "SubstituteSubID",
                table: "activeCourseInfoModels");

            migrationBuilder.RenameColumn(
                name: "TeacherPreferredNameMod",
                table: "teacherInfoModels",
                newName: "teacherPreferredNameMod");

            migrationBuilder.RenameColumn(
                name: "TeacherPhoneMod",
                table: "teacherInfoModels",
                newName: "teacherPhoneMod");

            migrationBuilder.RenameColumn(
                name: "TeacherMiddleNameMod",
                table: "teacherInfoModels",
                newName: "teacherMiddleNameMod");

            migrationBuilder.RenameColumn(
                name: "TeacherLastNameMod",
                table: "teacherInfoModels",
                newName: "teacherLastNameMod");

            migrationBuilder.RenameColumn(
                name: "TeacherFirstNameMod",
                table: "teacherInfoModels",
                newName: "teacherFirstNameMod");

            migrationBuilder.RenameColumn(
                name: "TeacherEmailMod",
                table: "teacherInfoModels",
                newName: "teacherEmailMod");

            migrationBuilder.RenameColumn(
                name: "TeacherID",
                table: "teacherInfoModels",
                newName: "teacherID");

            migrationBuilder.RenameColumn(
                name: "ScannerMacAddressMod",
                table: "synnLabQRNodeModels",
                newName: "scannerMacAddressMod");

            migrationBuilder.RenameColumn(
                name: "ScannerLabelMod",
                table: "synnLabQRNodeModels",
                newName: "scannerLabelMod");

            migrationBuilder.RenameColumn(
                name: "ScannerDeviceIPAddressMod",
                table: "synnLabQRNodeModels",
                newName: "scannerDeviceIPAddressMod");

            migrationBuilder.RenameColumn(
                name: "ModelNumberMod",
                table: "synnLabQRNodeModels",
                newName: "modelNumberMod");

            migrationBuilder.RenameColumn(
                name: "ScannerID",
                table: "synnLabQRNodeModels",
                newName: "scannerID");

            migrationBuilder.RenameColumn(
                name: "SubPreferredNameMod",
                table: "substituteInfoModels",
                newName: "subPreferredNameMod");

            migrationBuilder.RenameColumn(
                name: "SubPhoneMod",
                table: "substituteInfoModels",
                newName: "subPhoneMod");

            migrationBuilder.RenameColumn(
                name: "SubMiddleNameMod",
                table: "substituteInfoModels",
                newName: "subMiddleNameMod");

            migrationBuilder.RenameColumn(
                name: "SubLastNameMod",
                table: "substituteInfoModels",
                newName: "subLastNameMod");

            migrationBuilder.RenameColumn(
                name: "SubFirstNameMod",
                table: "substituteInfoModels",
                newName: "subFirstNameMod");

            migrationBuilder.RenameColumn(
                name: "SubEmailMod",
                table: "substituteInfoModels",
                newName: "subEmailMod");

            migrationBuilder.RenameColumn(
                name: "SubID",
                table: "substituteInfoModels",
                newName: "subID");

            migrationBuilder.RenameColumn(
                name: "LunchCodeMod",
                table: "studentScheduleInfoModels",
                newName: "lunchCodeMod");

            migrationBuilder.RenameColumn(
                name: "AvesBellRoomCodeMod",
                table: "studentScheduleInfoModels",
                newName: "avesBellRoomCodeMod");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "studentScheduleInfoModels",
                newName: "studentID");

            migrationBuilder.RenameColumn(
                name: "StudentPreferredNameMod",
                table: "studentInfoModels",
                newName: "studentPreferredNameMod");

            migrationBuilder.RenameColumn(
                name: "StudentPhoneMod",
                table: "studentInfoModels",
                newName: "studentPhoneMod");

            migrationBuilder.RenameColumn(
                name: "StudentMiddleNameMod",
                table: "studentInfoModels",
                newName: "studentMiddleNameMod");

            migrationBuilder.RenameColumn(
                name: "StudentLastNameMod",
                table: "studentInfoModels",
                newName: "studentLastNameMod");

            migrationBuilder.RenameColumn(
                name: "StudentFirstNameMod",
                table: "studentInfoModels",
                newName: "studentFirstNameMod");

            migrationBuilder.RenameColumn(
                name: "StudentEmailMod",
                table: "studentInfoModels",
                newName: "studentEmailMod");

            migrationBuilder.RenameColumn(
                name: "Parentguard2NameMod",
                table: "studentInfoModels",
                newName: "parentguard2NameMod");

            migrationBuilder.RenameColumn(
                name: "Parentguard2EmailMod",
                table: "studentInfoModels",
                newName: "parentguard2EmailMod");

            migrationBuilder.RenameColumn(
                name: "Parentguard1NameMod",
                table: "studentInfoModels",
                newName: "parentguard1NameMod");

            migrationBuilder.RenameColumn(
                name: "Parentguard1EmailMod",
                table: "studentInfoModels",
                newName: "parentguard1EmailMod");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "studentInfoModels",
                newName: "studentID");

            migrationBuilder.RenameColumn(
                name: "WingNameMod",
                table: "roomLocationInfoModels",
                newName: "wingNameMod");

            migrationBuilder.RenameColumn(
                name: "RoomNumberMod",
                table: "roomLocationInfoModels",
                newName: "roomNumberMod");

            migrationBuilder.RenameColumn(
                name: "RoomCodeMod",
                table: "roomLocationInfoModels",
                newName: "roomCodeMod");

            migrationBuilder.RenameColumn(
                name: "StudentNameMod",
                table: "passRequestInfoModels",
                newName: "studentNameMod");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "passRequestInfoModels",
                newName: "studentID");

            migrationBuilder.RenameColumn(
                name: "StartLocation",
                table: "passRequestInfoModels",
                newName: "startLocation");

            migrationBuilder.RenameColumn(
                name: "RequestStatus",
                table: "passRequestInfoModels",
                newName: "requestStatus");

            migrationBuilder.RenameColumn(
                name: "HallPassAssignedBy",
                table: "passRequestInfoModels",
                newName: "hallPassAssignedBy");

            migrationBuilder.RenameColumn(
                name: "EndLocation",
                table: "passRequestInfoModels",
                newName: "endLocation");

            migrationBuilder.RenameColumn(
                name: "BellNumber",
                table: "passRequestInfoModels",
                newName: "bellNumber");

            migrationBuilder.RenameColumn(
                name: "PassRequestId",
                table: "passRequestInfoModels",
                newName: "passRequestId");

            migrationBuilder.RenameColumn(
                name: "NursePreferredNameMod",
                table: "nurseInfoModels",
                newName: "nursePreferredNameMod");

            migrationBuilder.RenameColumn(
                name: "NursePhoneMod",
                table: "nurseInfoModels",
                newName: "nursePhoneMod");

            migrationBuilder.RenameColumn(
                name: "NurseMiddleNameMod",
                table: "nurseInfoModels",
                newName: "nurseMiddleNameMod");

            migrationBuilder.RenameColumn(
                name: "NurseLastNameMod",
                table: "nurseInfoModels",
                newName: "nurseLastNameMod");

            migrationBuilder.RenameColumn(
                name: "NurseFirstNameMod",
                table: "nurseInfoModels",
                newName: "nurseFirstNameMod");

            migrationBuilder.RenameColumn(
                name: "NurseEmailMod",
                table: "nurseInfoModels",
                newName: "nurseEmailMod");

            migrationBuilder.RenameColumn(
                name: "NurseID",
                table: "nurseInfoModels",
                newName: "nurseID");

            migrationBuilder.RenameColumn(
                name: "LawePreferredNameMod",
                table: "lawEnforcementInfoModels",
                newName: "lawePreferredNameMod");

            migrationBuilder.RenameColumn(
                name: "LawePhoneMod",
                table: "lawEnforcementInfoModels",
                newName: "lawePhoneMod");

            migrationBuilder.RenameColumn(
                name: "LaweMiddleNameMod",
                table: "lawEnforcementInfoModels",
                newName: "laweMiddleNameMod");

            migrationBuilder.RenameColumn(
                name: "LaweLastNameMod",
                table: "lawEnforcementInfoModels",
                newName: "laweLastNameMod");

            migrationBuilder.RenameColumn(
                name: "LaweFirstNameMod",
                table: "lawEnforcementInfoModels",
                newName: "laweFirstNameMod");

            migrationBuilder.RenameColumn(
                name: "LaweEmailMod",
                table: "lawEnforcementInfoModels",
                newName: "laweEmailMod");

            migrationBuilder.RenameColumn(
                name: "LawenfID",
                table: "lawEnforcementInfoModels",
                newName: "lawenfID");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "hallPassInfoModels",
                newName: "studentID");

            migrationBuilder.RenameColumn(
                name: "StartLocation",
                table: "hallPassInfoModels",
                newName: "startLocation");

            migrationBuilder.RenameColumn(
                name: "EndLocation",
                table: "hallPassInfoModels",
                newName: "endLocation");

            migrationBuilder.RenameColumn(
                name: "BellNumber",
                table: "hallPassInfoModels",
                newName: "bellNumber");

            migrationBuilder.RenameColumn(
                name: "HallPassAssignedByID",
                table: "hallPassInfoModels",
                newName: "studentNameMod");

            migrationBuilder.RenameColumn(
                name: "HallPassAddressedByID",
                table: "hallPassInfoModels",
                newName: "hallPassAssignedBy");

            migrationBuilder.RenameColumn(
                name: "StudentNameMod",
                table: "fastPassModels",
                newName: "studentNameMod");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "fastPassModels",
                newName: "studentID");

            migrationBuilder.RenameColumn(
                name: "BellNumber",
                table: "fastPassModels",
                newName: "bellNumber");

            migrationBuilder.RenameColumn(
                name: "FastPassIDMod",
                table: "fastPassModels",
                newName: "fastPassIDMod");

            migrationBuilder.RenameColumn(
                name: "EaStudentManaged",
                table: "eASuportInfoModels",
                newName: "eaStudentManaged");

            migrationBuilder.RenameColumn(
                name: "EaPreferredNameMod",
                table: "eASuportInfoModels",
                newName: "eaPreferredNameMod");

            migrationBuilder.RenameColumn(
                name: "EaPhoneMod",
                table: "eASuportInfoModels",
                newName: "eaPhoneMod");

            migrationBuilder.RenameColumn(
                name: "EaMiddleNameMod",
                table: "eASuportInfoModels",
                newName: "eaMiddleNameMod");

            migrationBuilder.RenameColumn(
                name: "EaLastNameMod",
                table: "eASuportInfoModels",
                newName: "eaLastNameMod");

            migrationBuilder.RenameColumn(
                name: "EaFirstNameMod",
                table: "eASuportInfoModels",
                newName: "eaFirstNameMod");

            migrationBuilder.RenameColumn(
                name: "EaEmailMod",
                table: "eASuportInfoModels",
                newName: "eaEmailMod");

            migrationBuilder.RenameColumn(
                name: "EaID",
                table: "eASuportInfoModels",
                newName: "eaID");

            migrationBuilder.RenameColumn(
                name: "DeveloperPreferredNameMod",
                table: "developerInfoModels",
                newName: "developerPreferredNameMod");

            migrationBuilder.RenameColumn(
                name: "DeveloperMiddleNameMod",
                table: "developerInfoModels",
                newName: "developerMiddleNameMod");

            migrationBuilder.RenameColumn(
                name: "DeveloperLastNameMod",
                table: "developerInfoModels",
                newName: "developerLastNameMod");

            migrationBuilder.RenameColumn(
                name: "DeveloperFirstNameMod",
                table: "developerInfoModels",
                newName: "developerFirstNameMod");

            migrationBuilder.RenameColumn(
                name: "DeveloperEmailMod",
                table: "developerInfoModels",
                newName: "developerEmailMod");

            migrationBuilder.RenameColumn(
                name: "DeveloperID",
                table: "developerInfoModels",
                newName: "developerID");

            migrationBuilder.RenameColumn(
                name: "AoMemberPreferredNameMod",
                table: "attendanceOfficeMemberModels",
                newName: "aoMemberPreferredNameMod");

            migrationBuilder.RenameColumn(
                name: "AoMemberPhoneMod",
                table: "attendanceOfficeMemberModels",
                newName: "aoMemberPhoneMod");

            migrationBuilder.RenameColumn(
                name: "AoMemberMiddleNameMod",
                table: "attendanceOfficeMemberModels",
                newName: "aoMemberMiddleNameMod");

            migrationBuilder.RenameColumn(
                name: "AoMemberLastNameMod",
                table: "attendanceOfficeMemberModels",
                newName: "aoMemberLastNameMod");

            migrationBuilder.RenameColumn(
                name: "AoMemberFirstNameMod",
                table: "attendanceOfficeMemberModels",
                newName: "aoMemberFirstNameMod");

            migrationBuilder.RenameColumn(
                name: "AoMemberEmailMod",
                table: "attendanceOfficeMemberModels",
                newName: "aoMemberEmailMod");

            migrationBuilder.RenameColumn(
                name: "AoMemberID",
                table: "attendanceOfficeMemberModels",
                newName: "aoMemberID");

            migrationBuilder.RenameColumn(
                name: "AdminID",
                table: "adminInfoModels",
                newName: "adminID");

            migrationBuilder.RenameColumn(
                name: "CourseName",
                table: "activeCourseInfoModels",
                newName: "courseName");

            migrationBuilder.RenameColumn(
                name: "CourseLevel",
                table: "activeCourseInfoModels",
                newName: "courseLevel");

            migrationBuilder.RenameColumn(
                name: "CourseCode",
                table: "activeCourseInfoModels",
                newName: "courseCode");

            migrationBuilder.RenameColumn(
                name: "CourseBellNumber",
                table: "activeCourseInfoModels",
                newName: "courseBellNumber");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "activeCourseInfoModels",
                newName: "courseId");

            migrationBuilder.RenameColumn(
                name: "CourseTaughtDays",
                table: "activeCourseInfoModels",
                newName: "wingName");

            migrationBuilder.RenameColumn(
                name: "CourseRoomID",
                table: "activeCourseInfoModels",
                newName: "roomNumber");

            migrationBuilder.RenameColumn(
                name: "CourseLength",
                table: "activeCourseInfoModels",
                newName: "courseTeacherName");

            migrationBuilder.AddColumn<string>(
                name: "synnlabRoomMod",
                table: "synnLabQRNodeModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "synnlabRoomSubject",
                table: "synnLabQRNodeModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "managedTeacherMod",
                table: "substituteInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "lunchCodeMod",
                table: "studentScheduleInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<string>(
                name: "avesBellRoomCodeMod",
                table: "studentScheduleInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "studentID",
                table: "studentScheduleInfoModels",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "bell1CourseCodeMod",
                table: "studentScheduleInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bell2CourseCodeMod",
                table: "studentScheduleInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bell3CourseCodeMod",
                table: "studentScheduleInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bell4CourseCodeMod",
                table: "studentScheduleInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bell5CourseCodeMod",
                table: "studentScheduleInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bell6CourseCodeMod",
                table: "studentScheduleInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bell7CourseCodeMod",
                table: "studentScheduleInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "studentFirstNameMod",
                table: "studentScheduleInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "studentLastNameMod",
                table: "studentScheduleInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "studentCounselorEmailMod",
                table: "studentInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "studentCounselorNameMod",
                table: "studentInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "studentEAEmailMod",
                table: "studentInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "studentEANameMod",
                table: "studentInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "roomNumberMod",
                table: "roomLocationInfoModels",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "hallPassAssignedBy",
                table: "passRequestInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "passRequestInfoModels",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartTime",
                table: "passRequestInfoModels",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "hallPassAddressee",
                table: "passRequestInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "hallPassInfoModels",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartTime",
                table: "hallPassInfoModels",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "hallPassAddressee",
                table: "hallPassInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "fastPassModels",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartTime",
                table: "fastPassModels",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "endLocation",
                table: "fastPassModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "startLocation",
                table: "fastPassModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "eaStudentManaged",
                table: "eASuportInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "courseId",
                table: "activeCourseInfoModels",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "courseTeacherEmailAddress",
                table: "activeCourseInfoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_roomLocationInfoModels",
                table: "roomLocationInfoModels",
                column: "roomNumberMod");
        }
    }
}
