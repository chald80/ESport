using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ESport.Model
{
    [Table("Info")]

    public class Info
    {
        [ForeignKey("Profile")]
        public int InfoId { get; set; }
        public int ProfileId { get; set; }
        public string InfoName { get; set; }
    }
}
