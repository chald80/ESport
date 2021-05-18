using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESport.Model
{
    [Table("Profile")]

    public class Profile
    {
        [Key]
        [Required]
        public int ProfileId { get; set; }
        public string ProfileName { get; set; }
        public  Info Info { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}
