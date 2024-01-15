using SAMS_Deven.Models;
using System.ComponentModel.DataAnnotations;

namespace SAMS_Deven.Models
{
    public class TeacherInfoModel
    {
        [Key]
        public string TeacherID { get; set; } = null!;
        public string TeacherFirstNameMod { get; set; } = null!;
        public string TeacherMiddleNameMod { get; set; } = null!;
        public string TeacherLastNameMod { get; set; } = null!;
        public string TeacherPreferredNameMod { get; set; } = null!;
        public string TeacherEmailMod { get; set; } = null!;
        public string TeacherPhoneMod { get; set; } = null!;
        public Boolean Teaches5Days { get; set; }
        public int TeachingScheduleID { get; set; } = 0!;

        //Navigation properties
        public ICollection<ActiveCourseInfoModel>? ActiveCourses { get; set; }
        public ICollection<SubstituteInfoModel>? SubTeachers { get; set; }
        public ICollection<RoomLocationInfoModel>? RoomLocations { get; set; }
        public ICollection<HallPassInfoModel>? AssignedHallPasses { get; set; }

    }
}