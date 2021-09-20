using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anna_E_Seo_301098222.Models.ViewModels
{
    public class PlayerClubViewModel
    {
        public IEnumerable<Club> club { get; set; }
        public IEnumerable<Player> player { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
