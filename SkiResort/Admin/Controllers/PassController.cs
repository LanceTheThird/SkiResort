using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Services.Abstract;
using Data.Entities.Card;
using Data.Repository.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class PassController : Controller
    {       
        private IPassService _passService;
        public PassController(IPassService service)
        {
            _passService = service;
        }
        // GET: Pass
        public ActionResult Index()
        {
            return View(_passService.GetAll());
        }

        // GET: Pass/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Pass pass)
        {
            _passService.Create(pass);
            return new RedirectToActionResult("Index", "Pass", null);
        }

        // GET: Pass/Edit/5
        public ActionResult Edit(Guid id)
        {
            var pass = _passService.GetByCondition(x => x.Id == id).FirstOrDefault();
            return View(pass);
        }

        [HttpPost]
        public ActionResult Edit(Pass pass)
        {
            _passService.Update(pass);
            return new RedirectToActionResult("Index", "Pass", null);
        }

        // GET: Pass/Delete/5
        public ActionResult Delete(Guid id)
        {
            var pass = _passService.GetByCondition(x => x.Id == id).FirstOrDefault();
            _passService.Delete(pass);
            return new RedirectToActionResult("Index", "Pass", null);
        }

        public ActionResult EditPassTurnstiles(Guid Id)
        {
            return View(_passService.GetTurnstiles(Id));
        }
        [HttpPost]
        public ActionResult AddTurnstile(Guid passId, Guid turnstileId)
        {
            _passService.AddTurnstile(passId, turnstileId);
            return EditPassTurnstiles(passId);
        }
        [HttpPost]
        public ActionResult RemoveTurnstile(Guid passId, Guid turnstileId)
        {
            _passService.RemoveTurnstile(passId, turnstileId);
            return EditPassTurnstiles(passId);
        }
    }
}