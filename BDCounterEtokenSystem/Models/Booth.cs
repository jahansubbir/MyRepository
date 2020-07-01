using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDCounterEtokenSystem.Models;

namespace BDCounterETokenSystem.Models
{
    public class Booth
    {
        public int Id { get; set; }
        public string CounterId { get; set; }
        public Counter Counter { get; set; }

    }
}
