using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController(IActorsService service) : Controller
    {
        private readonly IActorsService _service = service;

        public async Task<IActionResult> Index()
        {
            var allActors = await _service.GetAllAsync();
            return View(allActors);
        }

        // GET: Actors/Create
        public  IActionResult Create()
        {
            return View();
        }
    }
}
