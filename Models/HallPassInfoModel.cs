using SAMS_Deven.Models;
using System.ComponentModel.DataAnnotations;

namespace SAMS_Deven.Models
{
    public class HallPassInfoModel
    {
        public int StudentID { get; set; } = 0!;
        [Key]
        public string HallPassID { get; set; } = null!;
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public TimeSpan Duration { get { return Duration; } set { Duration = EndDateTime - StartDateTime; } }
        public int BellNumber { get; set; } = 0!;
        public string HallPassAssignedBy { get; set; } = null!;
        public string HallPassAddressedBy { get; set; } = null!;
        public string StartLocation { get; set; } = null!;
        public string EndLocation { get; set; } = null!;

        //Navigation properties
        public StudentInfoModel? Student { get; set; }
        public AdminInfoModel? Admin { get; set; }
        public NurseInfoModel? Nurse { get; set; }
        public TeacherInfoModel? Teacher { get; set; }
        public LawEnforcementInfoModel? LawEnf { get; set; }
        public AttendanceOfficeMemberModel? AttendanceOfficeMember { get; set; }
        public CounselorModel? Counselor { get; set; }
    }
}