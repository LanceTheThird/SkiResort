using Admin.Services.Abstract;
using Data.Entities.Card;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Admin.Controllers
{
    public class CardController : Controller
    {
        private ICardService _cardService;
        public CardController(ICardService service)
        {
            _cardService = service;
        }
        // GET: Card
        public ActionResult Index()
        {
            return View(_cardService.GetAll());
        }

        // GET: Card/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Card Card)
        {
            _cardService.Create(Card);
            return new RedirectToActionResult("Index", "Card", null);
        }

        // GET: Card/Edit/5
        public ActionResult Edit(Guid id)
        {
            var Card = _cardService.GetByCondition(x => x.Id == id).FirstOrDefault();
            return View(Card);
        }

        [HttpPost]
        public ActionResult Edit(Card Card)
        {
            _cardService.Update(Card);
            return new RedirectToActionResult("Index", "Card", null);
        }

        // GET: Card/Delete/5
        public ActionResult Delete(Guid id)
        {
            var Card = _cardService.GetByCondition(x => x.Id == id).FirstOrDefault();
            _cardService.Delete(Card);
            return new RedirectToActionResult("Index", "Card", null);
        }
    }
}