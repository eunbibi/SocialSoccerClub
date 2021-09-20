using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anna_E_Seo_301098222.Models
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> playerdatafromdb { get; }

        void AddResponse(Player player);
        void Delete(String playerName);
        void EditPlayer(Player player);
    }
}
