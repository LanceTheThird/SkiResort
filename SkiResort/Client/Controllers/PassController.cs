using Data.Entities.Card;
using Microsoft.AspNetCore.Authorization;
using Data.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    public class PassController : Controller
    {
        private IResortRepository<Pass> _repository;
        public PassController(IResortRepository<Pass> repository)
        {
            _repository = repository;
        }

        [Authorize]
        // GET: Pass
        public ActionResult Index()
        {
            return View(_repository.GetAll());
        }

        // GET: Pass/Buy/5
        public ActionResult Buy(int id)
        {
            return View();
        }
    }
}