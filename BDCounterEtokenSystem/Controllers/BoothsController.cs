using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDCounterETokenSystem.Models;
using BDCounterETokenSystem.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BDCounterETokenSystem.Controllers
{
    public class BoothsController:Controller
    {
        private readonly IBoothRepository _boothRepository;

        public BoothsController(IBoothRepository boothRepository)
        {
            _boothRepository = boothRepository;
        }

        public IEnumerable<Booth> GetBooths()
        {
            return _boothRepository.GetBooths();
        }

        public IEnumerable<Booth> GetBoothByCounter(string counterId)
        {
            return _boothRepository.GetBoothsByCounter(counterId);
        }

        public int AddBooth(Booth booth)
        {
            return _boothRepository.AddBooth(booth);
        }
    }
}
