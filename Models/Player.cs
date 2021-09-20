using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Anna_E_Seo_301098222.Models
{
    public class Player
    {
        [Key]
        public string Name { get; set; }
        public string Club { get; set; }
        public int JersyNumber { get; set; }
        public int Rank { get; set; }
        public int totalGoals { get; set; }
    }
}
