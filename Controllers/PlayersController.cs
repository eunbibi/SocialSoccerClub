using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Anna_E_Seo_301098222.Models;
using Microsoft.AspNetCore.Authorization;
using Anna_E_Seo_301098222.Models.ViewModels;

namespace Anna_E_Seo_301098222.Controllers
{
    public class PlayersController : Controller
    {
        IPlayerRepository playerRepository;
        private ApplicationDbContext dbContext;
        public PlayersController(IPlayerRepository repository, ApplicationDbContext applicationDbContext)
        {

            this.playerRepository = repository;
            this.dbContext = applicationDbContext;

        }

        [HttpGet]
        [Authorize]
        public ViewResult AddPlayer()
        {
            ViewBag.Clubs = dbContext.clubitems.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult AddPlayer(Player player)
        {

            if (ModelState.IsValid)
            {
                playerRepository.AddResponse(player);
                ModelState.Clear();
                return RedirectToAction(nameof(ManagePlayers));
            }
            else
            {
                return View();
            }
        }
        public int PageSize = 5;

        public ViewResult ManagePlayers(int productPage = 1)
        {
            return View(new PlayerClubViewModel
            {
                player = playerRepository.playerdatafromdb
                    .OrderBy(p => p.Name).Skip((productPage - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = playerRepository.playerdatafromdb.Count()
                }
            });
        }
    }
}
