using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ESport.Model
{
    [Table("Maps")]

    public class Map
    {
        
        [Key]
        [Required]
        public int MapsId { get; set; }
        [Required]
        public string MapsName { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}
