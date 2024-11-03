using System.ComponentModel.DataAnnotations;

namespace sso.Models
{
    public class userCred
    {
        [Key]
        public int userName { get; set; }
        public string password { get; set; } = string.Empty;
    }
}
