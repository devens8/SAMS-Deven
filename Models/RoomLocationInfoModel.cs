using SAMS_Deven.Models;
using System.ComponentModel.DataAnnotations;

namespace SAMS_Deven.Models
{
    public class RoomLocationInfoModel
    {
        [Key]
        public int RoomId { get; set; }
        public string RoomNumberMod { get; set; } = null!;
        public string WingNameMod { get; set; } = null!;
        public string RoomCodeMod { get; set; } = null!;
        public string RoomAssignedToTeacher1ID { get; set; } = null!;

        public string ActiveCourseID { get; set; } = null!;

        //Navigation properties
        public ICollection<TeacherInfoModel>? Teacher { get; set; }
        public ICollection<ActiveCourseInfoModel>? ActiveCourseInfos { get; set; }

        public SynnLabQRNodeModel? SynnLabQRNode { get; set;}
    }
}