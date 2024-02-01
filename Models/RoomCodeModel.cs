using System.ComponentModel.DataAnnotations;

namespace SAMS.Models
{
    public class RoomCodeModel
    {
        [Key]
        public int CodeID { get; set; }

        public string RoomCode { get; set; } = null!;
        [Display(Name = ("Room Code"))]


        //Navigation properties
        public RoomLocationInfoModel? RoomLocationInfoModel { get; set; }
    }
}
