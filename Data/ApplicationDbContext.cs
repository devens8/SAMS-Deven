using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SAMS_Deven.Models;

namespace SAMS_Deven.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ActiveCourseInfoModel> activeCourseInfoModels { get; set; } = null!;
        public DbSet<AdminInfoModel> adminInfoModels { get; set; } = null!;
        public DbSet<AttendanceOfficeMemberModel> attendanceOfficeMemberModels { get; set; } = null!;
        public DbSet<DailyBellScheduleModel> dailyBellScheduleModels { get; set; } = null!;
        public DbSet<DeveloperInfoModel> developerInfoModels { get; set; } = null!;
        public DbSet<EASuportInfoModel> eASuportInfoModels { get; set; } = null!;
        public DbSet<ExtendedAvesBellScheduleModel> extendedAvesModels { get; set; } = null!;
        public DbSet<FastPassModel> fastPassModels { get; set; } = null!;
        public DbSet<HallPassInfoModel> hallPassInfoModels { get; set; } = null!;
        public DbSet<LawEnforcementInfoModel> lawEnforcementInfoModels { get; set; } = null!;
        public DbSet<NurseInfoModel> nurseInfoModels { get; set; } = null!;
        public DbSet<PassRequestInfoModel> passRequestInfoModels { get; set; } = null!;
        public DbSet<PepRallyBellScheduleModel> pepRallyBellScheduleModels { get; set; } = null!;
        public DbSet<RoomLocationInfoModel> roomLocationInfoModels { get; set; } = null!;
        public DbSet<StudentInfoModel> studentInfoModels { get; set; } = null!;
        public DbSet<StudentScheduleInfoModel> studentScheduleInfoModels { get; set; } = null!;
        public DbSet<SubstituteInfoModel> substituteInfoModels { get; set; } = null!;
        public DbSet<SynnLabQRNodeModel> synnLabQRNodeModels { get; set; } = null!;
        public DbSet<TeacherInfoModel> teacherInfoModels { get; set; } = null!;
        public DbSet<TwoHrDelayBellScheduleModel> twoHrDelayBellScheduleModels { get; set; } = null!;
        public DbSet<DailyBellScheduleModel> DailyBellScheduleModel { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {

            /* LIST OF TODO'S
             * 1) Structure Program so that one class is being used to begin relationship - minimize cofusion
             * 2) Set conventions for navigation variables (Class name but with camel case)
             * 3) Set same foreign key in all programs (not dependent on class)
             * 4) Establish relationship types with team
            */

            //Creating all the classes related to StudentInfoModel

            builder.Entity<StudentInfoModel>()
            .HasOne(a => a.ActivationCodes)
            .WithOne(b => b.Student)
            .HasForeignKey<ActivationModel>(c => c.StudId)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<StudentInfoModel>()
            .HasOne(a => a.StudentSchedule)
            .WithOne(b => b.Student)
            .HasForeignKey<StudentScheduleInfoModel>(c => c.StudentID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<StudentInfoModel>()
            .HasMany(a => a.CourseEnrollments)
            .WithOne(b => b.Student)
            .HasForeignKey(c => c.EnrollmentStudentId)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<StudentInfoModel>()
            .HasMany(a => a.BellAttendances)
            .WithOne(b => b.StudentInfo)
            .HasForeignKey(c => c.StudentId)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<StudentInfoModel>()
            .HasMany(a => a.DailyAttendances)
            .WithOne(b => b.Student)
            .HasForeignKey(c => c.StudentId)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<StudentInfoModel>()
            .HasOne(a => a.Counselor)
            .WithMany(b => b.CounselorManagedStudents)
            .HasForeignKey(c => c.StudentCounselorID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<StudentInfoModel>()
            .HasOne(a => a.AssignedEASuport)
            .WithOne(b => b.Student)
            .HasForeignKey<StudentInfoModel>(c => c.StudentEAID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<StudentInfoModel>()
            .HasMany(a => a.PassRequestsForStudent)
            .WithOne(b => b.Student)
            .HasForeignKey(c => c.StudentID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<StudentInfoModel>()
            .HasMany(a => a.FastPasses)
            .WithOne(b => b.Student)
            .HasForeignKey(c => c.StudentID)
            .OnDelete(DeleteBehavior.NoAction);


            //Creating all classes related to HallPassInfoModel

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.Student)
            .WithMany(b => b.HallPasses)
            .HasForeignKey(c => c.StudentID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.AssignedByAdmin)
            .WithMany(b => b.AssignedHallPasses)
            .HasForeignKey(c => c.HallPassID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.AssignedByLawEnf)
            .WithMany(b => b.AssignedHallPasses)
            .HasForeignKey(c => c.HallPassID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.AssignedByNurse)
            .WithMany(b => b.AssignedHallPasses)
            .HasForeignKey(c => c.HallPassID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.AssignedByTeacher)
            .WithMany(b => b.AssignedHallPasses)
            .HasForeignKey(c => c.HallPassID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.AssignedByAttendanceOfficeMember)
            .WithMany(b => b.AssignedHallPasses)
            .HasForeignKey(c => c.HallPassID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.AssignedByCounselor)
            .WithMany(b => b.AssignedHallPasses)
            .HasForeignKey(c => c.HallPassID)
            .OnDelete(DeleteBehavior.NoAction);

            //addressed by
            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.AddressedByAdmin)
            .WithMany(b => b.AddressedHallPasses)
            .HasForeignKey(c => c.HallPassID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.AddressedByLawEnf)
            .WithMany(b => b.AddressedHallPasses)
            .HasForeignKey(c => c.HallPassID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.AddressedByNurse)
            .WithMany(b => b.AddressedHallPasses)
            .HasForeignKey(c => c.HallPassID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.AddressedByTeacher)
            .WithMany(b => b.AddressedHallPasses)
            .HasForeignKey(c => c.HallPassID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.AddressedByAttendanceOfficeMember)
            .WithMany(b => b.AddressedHallPasses)
            .HasForeignKey(c => c.HallPassID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.AddressedByCounselor)
            .WithMany(b => b.AddressedHallPasses)
            .HasForeignKey(c => c.HallPassID)
            .OnDelete(DeleteBehavior.NoAction);

            //Creating all relationships to PassRequest


            builder.Entity<PassRequestInfoModel>()
            .HasOne(a => a.AssignedByAdmin)
            .WithMany(b => b.RequestAssignedHallPasses)
            .HasForeignKey(c => c.HallPassAssignedBy)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<PassRequestInfoModel>()
            .HasOne(a => a.AssignedByLawEnf)
            .WithMany(b => b.RequestAssignedHallPasses)
            .HasForeignKey(c => c.HallPassAssignedBy)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<PassRequestInfoModel>()
            .HasOne(a => a.AssignedByNurse)
            .WithMany(b => b.RequestAssignedHallPasses)
            .HasForeignKey(c => c.HallPassAssignedBy)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<PassRequestInfoModel>()
            .HasOne(a => a.AssignedByTeacher)
            .WithMany(b => b.RequestAssignedHallPasses)
            .HasForeignKey(c => c.HallPassAssignedBy)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<PassRequestInfoModel>()
            .HasOne(a => a.AssignedByAttendanceOfficeMember)
            .WithMany(b => b.RequestAssignedHallPasses)
            .HasForeignKey(c => c.HallPassAssignedBy)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<PassRequestInfoModel>()
            .HasOne(a => a.AssignedByCounselor)
            .WithMany(b => b.RequestAssignedHallPasses)
            .HasForeignKey(c => c.HallPassAssignedBy)
            .OnDelete(DeleteBehavior.NoAction);

            //addressed by
            builder.Entity<PassRequestInfoModel>()
            .HasOne(a => a.AddressedByAdmin)
            .WithMany(b => b.RequestAddressedHallPasses)
            .HasForeignKey(c => c.HallPassAddressedBy)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<PassRequestInfoModel>()
            .HasOne(a => a.AddressedByLawEnf)
            .WithMany(b => b.RequestAddressedHallPasses)
            .HasForeignKey(c => c.HallPassAddressedBy)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<PassRequestInfoModel>()
            .HasOne(a => a.AddressedByNurse)
            .WithMany(b => b.RequestAddressedHallPasses)
            .HasForeignKey(c => c.HallPassAddressedBy)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<PassRequestInfoModel>()
            .HasOne(a => a.AddressedByTeacher)
            .WithMany(b => b.RequestAddressedHallPasses)
            .HasForeignKey(c => c.HallPassAddressedBy)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<PassRequestInfoModel>()
            .HasOne(a => a.AddressedByAttendanceOfficeMember)
            .WithMany(b => b.RequestAddressedHallPasses)
            .HasForeignKey(c => c.HallPassAddressedBy)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<PassRequestInfoModel>()
            .HasOne(a => a.AddressedByCounselor)
            .WithMany(b => b.RequestAddressedHallPasses)
            .HasForeignKey(c => c.HallPassAddressedBy)
            .OnDelete(DeleteBehavior.NoAction);


            //Creating all classes realted to TeacherInfoModel

            builder.Entity<TeacherInfoModel>()
            .HasMany(a => a.ActiveCourses)
            .WithOne(b => b.Teacher)
            .HasForeignKey(c => c.CourseTeacherID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TeacherInfoModel>()
            .HasOne(a => a.SubTeachers)
            .WithOne(b => b.TeacherManaged)
            .HasForeignKey<SubstituteInfoModel>(c => c.ManagedTeacherIdMod)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TeacherInfoModel>()
            .HasOne(a => a.Room)
            .WithOne(b => b.Teacher)
            .HasForeignKey<RoomLocationInfoModel>(c => c.RoomAssignedToTeacherID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TeacherInfoModel>()
            .HasOne(a => a.TeachingSchedule)
            .WithOne(b => b.Teacher)
            .HasForeignKey<TeachingScheduleModel>(c => c.TeacherID)
            .OnDelete(DeleteBehavior.NoAction);


            //Creating all other class relationships

            builder.Entity<ActiveCourseInfoModel>()
            .HasOne(a => a.Room)
            .WithMany(b => b.ActiveCourseInfos)
            .HasForeignKey(c => c.CourseRoomID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<RoomLocationInfoModel>()
            .HasOne(a => a.SynnLabQRNode)
            .WithOne(b => b.Room)
            .HasForeignKey<SynnLabQRNodeModel>(c => c.SynnlabRoomIDMod)
            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<StudentScheduleInfoModel>()
            .HasOne(a => a.BellAttendance)
            .WithOne(b => b.StudentScheduleInfoModel)
            .HasForeignKey<StudentScheduleInfoModel>(c => c.StudentID)
            .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(builder);
        }

    }
}
