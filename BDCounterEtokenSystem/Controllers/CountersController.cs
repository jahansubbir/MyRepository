using System.Collections.Generic;
using BDCounterEtokenSystem.Models;
using BDCounterEtokenSystem.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BDCounterEtokenSystem.Controllers
{
    //[Route("/counters")]
    public class CountersController : Controller
    {
        private readonly ICounterRepository _counterRepository;

        public CountersController(ICounterRepository counterRepository)
        {
            _counterRepository = counterRepository;
        }
        //[HttpGet]
        //public IEnumerable<Counter> Index()
        //{
        //   return  _counterRepository.GetCounters();
        //    //return x.ToList();
        //}
        [HttpGet]
        public IActionResult Index()
        {
            var counters = _counterRepository.GetCounters();
            return View(counters);
        }
        [HttpGet]
        public Counter Get(string counter)
        {
            return _counterRepository.GetCounter(counter);
        }

        [HttpGet]
        public IActionResult AddCounter()
        {
         return   View();
        }
        [HttpPost]
        //[ContentType("application/json")]
        public IActionResult AddCounter([FromBody] Counter counter)
        {
            if (_counterRepository.Add(counter) > 0)
                return Redirect("Index");
            else
            {
                return View(counter);
            }
        }
    }
}