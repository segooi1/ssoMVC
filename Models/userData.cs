using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sso.Models
{
    public class userData
    {
        [Key]
        public string email { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int telephone {  get; set; }
        
        public string description { get; set; } = string.Empty;
        public string authDomin { get; set; } = string.Empty;

        public int? userName { get; set; }
        [ForeignKey("userName")]
     
        public virtual userCred UserCred { get; set; }

    }
}
