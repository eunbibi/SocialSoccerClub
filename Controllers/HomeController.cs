using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Anna_E_Seo_301098222.Models;

namespace Anna_E_Seo_301098222.Controllers
{
    public class HomeController : Controller
    {
        IPlayerRepository repository_player;
        IClubRepository repository_club;

        public HomeController(IClubRepository club, IPlayerRepository player)
        {
            this.repository_club = club;
            this.repository_player = player;
        }

        public IActionResult Index()
        {
            return View("Index");
        }
    }
}