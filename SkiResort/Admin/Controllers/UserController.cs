using System;
using System.Linq;
using Admin.Services.Abstract;
using Data.Entities.Users;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService service)
        {
            _userService = service;
        }
        // GET: User
        public ActionResult Index()
        {
            return View(_userService.GetAll());
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User User)
        {
            _userService.Create(User);
            return new RedirectToActionResult("Index", "User", null);
        }

        // GET: User/Edit/5
        public ActionResult Edit(Guid id)
        {
            var User = _userService.GetByCondition(x => x.Id == id).FirstOrDefault();
            return View(User);
        }

        [HttpPost]
        public ActionResult Edit(User User)
        {
            _userService.Update(User);
            return new RedirectToActionResult("Index", "User", null);
        }

        // GET: User/Delete/5
        public ActionResult Delete(Guid id)
        {
            var User = _userService.GetByCondition(x => x.Id == id).FirstOrDefault();
            _userService.Delete(User);
            return new RedirectToActionResult("Index", "User", null);
        }
    }
}