using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ESport.Model
{
    [Table("Games")]

    public class Game
    {
        public Game()
        {
            this.Profiles = new HashSet<Profile>();
            this.Maps = new HashSet<Map>();
        }
        [Key]
        [Required]
        public int GameId { get; set; }
        [Required]
        public string GameName { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
        public virtual ICollection<Map> Maps { get; set; }

    }
}
