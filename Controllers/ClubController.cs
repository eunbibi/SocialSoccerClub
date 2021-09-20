using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Anna_E_Seo_301098222.Models;
using Anna_E_Seo_301098222.Models.ViewModels;
using Anna_E_Seo_301098222;
using Microsoft.AspNetCore.Authorization;

namespace Anna_E_Seo_301098222.Controllers
{
    public class ClubController : Controller
    {
        private IClubRepository clubRepository;
        private IPlayerRepository playerRepository;

        public ClubController(IClubRepository crepo, IPlayerRepository prepo)
        {
            clubRepository = crepo;
            playerRepository = prepo;
        }
        [Authorize]
        [HttpGet]
        public ViewResult AddClub()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddClub(Club clubs)
        {
            clubRepository.AddClub(clubs);
            ModelState.Clear();
            return RedirectToAction("Club", "Club");
        }

        public int PageSize = 3;
        public ViewResult Club(int productPage = 1)
        {
            return View(new PlayerClubViewModel
            {
                club = clubRepository.clubfromdb.OrderBy(c => c.clubName)
                                                .Skip((productPage - 1) * PageSize)
                                                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = clubRepository.clubfromdb.Count()
                }
            });

        }

        [HttpGet]
        public ViewResult ClubDetails(string clubName, int productPage = 1)
        {
            return View(new PlayerClubViewModel
            {
                club = clubRepository.clubfromdb.Where(c => c.clubName == clubName),
                player = playerRepository.playerdatafromdb.Where(p => p.Club == clubName)
            });
        }
    }
}