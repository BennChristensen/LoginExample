using LoginExample.Models;
using LoginExample.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginExample.Controllers
{
    public class DefaultController : Controller
    {
        UserStorage _userStorage;

        public DefaultController()
        {
            _userStorage = new UserStorage();
        }
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            User foundUser = _userStorage.Users.Where(u => u.UserName.Equals(user.UserName)).FirstOrDefault();

            if (foundUser == null)
            {
                return View("NotFound", user);
            }
            else
            {
                return View("Details", foundUser);
            }
        }
    }
}