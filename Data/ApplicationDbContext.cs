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
            .HasForeignKey<ActivationModel>(c => c.StudId);

            builder.Entity<StudentInfoModel>()
            .HasOne(a => a.studentScheduleInfoModel)
            .WithOne(b => b.Student)
            .HasForeignKey<StudentScheduleInfoModel>(c => c.StudentID);

            builder.Entity<StudentInfoModel>()
            .HasMany(a => a.CourseEnrollments)
            .WithOne(b => b.Student)
            .HasForeignKey(c => c.EnrollmentStudentId);

            builder.Entity<StudentInfoModel>()
            .HasMany(a => a.bellAttendanceModel)
            .WithOne(b => b.StudentInfo)
            .HasForeignKey(c => c.StudentId);

            builder.Entity<StudentInfoModel>()
            .HasOne(a => a.DailyAttendanceModel)
            .WithOne(b => b.Student)
            .HasForeignKey<DailyAttendanceModel>(c => c.StudentId);

            builder.Entity<StudentInfoModel>()
            .HasOne(a => a.Counselor)
            .WithMany(b => b.Student)
            .HasForeignKey(c => c.StudentID);

            builder.Entity<StudentInfoModel>()
            .HasOne(a => a.AssignedEASuport)
            .WithOne(b => b.Student)
            .HasForeignKey<EASuportInfoModel>(c => c.StudentId);

            builder.Entity<StudentInfoModel>()
            .HasOne(a => a.passRequestInfoModel)
            .WithOne(b => b.Student)
            .HasForeignKey<PassRequestInfoModel>(c => c.Student);

            builder.Entity<StudentInfoModel>()
            .HasMany(a => a.FastPasses)
            .WithOne(b => b.Student)
            .HasForeignKey(c => c.Student);


            //Creating all classes related to HallPassInfoModel

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.Student)
            .WithMany(b => b.HallPasses)
            .HasForeignKey(c => c.HallPassID);

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.Admin)
            .WithMany(b => b.AssignedHallPasses)
            .HasForeignKey(c => c.HallPassID);

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.LawEnf)
            .WithMany(b => b.AssignedHallPasses)
            .HasForeignKey(c => c.HallPassID);

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.Nurse)
            .WithMany(b => b.AssignedHallPasses)
            .HasForeignKey(c => c.HallPassID);

            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.Teacher)
            .WithMany(b => b.AssignedHallPasses)
            .HasForeignKey(c => c.HallPassID); 
            
            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.AttendanceOfficeMember)
            .WithMany(b => b.AssignedHallPasses)
            .HasForeignKey(c => c.HallPassID); 
            
            builder.Entity<HallPassInfoModel>()
            .HasOne(a => a.Counselor)
            .WithMany(b => b.AssignedHallPasses)
            .HasForeignKey(c => c.HallPassID);

            //Creating all classes realted to TeacherInfoModel

            builder.Entity<TeacherInfoModel>()
            .HasMany(a => a.ActiveCourses)
            .WithOne(b => b.Teacher)
            .HasForeignKey(c => c.CourseTeacherID);

            builder.Entity<TeacherInfoModel>()
            .HasMany(a => a.SubTeachers)
            .WithOne(b => b.Teacher)
            .HasForeignKey(c => c.Teacher);

            builder.Entity<TeacherInfoModel>()
            .HasMany(a => a.RoomLocations)
            .WithMany(b => b.Teacher);

            //Creating all other class relationships

            builder.Entity<ActiveCourseInfoModel>()
            .HasMany(a => a.Room)
            .WithMany(b => b.ActiveCourseInfos);

            builder.Entity<RoomLocationInfoModel>()
            .HasOne(a => a.SynnLabQRNode)
            .WithOne(b => b.Room)
            .HasForeignKey<SynnLabQRNodeModel>(c => c.SynnlabRoomMod);


            base.OnModelCreating(builder);
        }

    }
}
