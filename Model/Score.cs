using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ESport.Model
{
    [Table("Score")]
    public class Score
    {
        public Score()
        {
            this.Maps = new HashSet<Map>();
        }
        [Key]
        [Required]
        public int ScoreId { get; set; }
        [Required]
        public int Stat { get; set; }
        public virtual  ICollection<Map> Maps { get; set; }
        
    }
}
