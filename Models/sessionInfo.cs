using System.ComponentModel.DataAnnotations;

namespace sso.Models
{
    public class sessionInfo
    {
        [Key]
        public DateTime session { get; set; }
        public int sessionId { get; set; }
        public string token { get; set; } = string.Empty;

        public bool Isactive { get; set; }
        public DateTime sessionDates { get; set; }

    }

}
