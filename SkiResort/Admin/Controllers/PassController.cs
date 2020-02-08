using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Entities.Card;
using Data.Repository.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class PassController : Controller
    {
        private IResortRepository<Pass> _repository;
        public PassController(IResortRepository<Pass> repository)
        {
            _repository = repository;
        }
        // GET: Pass
        public ActionResult Index()
        {
            return View(_repository.GetAll());
        }

        // GET: Pass/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Pass pass)
        {
            _repository.Create(pass);
            return new RedirectToActionResult("Index", "Pass", null);
        }

        // GET: Pass/Edit/5
        public ActionResult Edit(Guid id)
        {
            var pass = _repository.GetByCondition(x => x.Id == id).FirstOrDefault();
            return View(pass);
        }

        [HttpPost]
        public ActionResult Edit(Pass pass)
        {
            _repository.Update(pass);
            return new RedirectToActionResult("Index", "Pass", null);
        }

        // GET: Pass/Delete/5
        public ActionResult Delete(Guid id)
        {
            var pass = _repository.GetByCondition(x => x.Id == id).FirstOrDefault();
            _repository.Delete(pass);
            return new RedirectToActionResult("Index", "Pass", null);
        }
    }
}