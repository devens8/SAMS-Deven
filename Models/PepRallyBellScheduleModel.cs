using System.ComponentModel.DataAnnotations;

namespace SAMS_Deven.Models
{
    public class PepRallyBellScheduleModel
    {
        public string BellName { get; set; } = null!;
        [Key]
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public TimeSpan Duration { get; set; }
    }
}