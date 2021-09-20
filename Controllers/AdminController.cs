using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anna_E_Seo_301098222.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Anna_E_Seo_301098222.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IClubRepository repository;
        public AdminController(IClubRepository repo) { repository = repo; }
        public ViewResult Index() => View(repository.clubfromdb);
    }
}