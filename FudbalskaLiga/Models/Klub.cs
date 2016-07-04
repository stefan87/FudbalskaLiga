using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FudbalskaLiga.Models
{
    public class Klub
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public DateTime DatumOsnivanja { get; set; }
        public string Grad { get; set; }
    }
}