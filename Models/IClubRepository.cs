using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anna_E_Seo_301098222.Models
{
    public interface IClubRepository
    {
        IEnumerable<Club> clubfromdb { get; }
        void AddClub(Club newCLub);
        void Delete(String clubname);
        void EditClub(Club club);
    }
}
