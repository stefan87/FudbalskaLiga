using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FudbalskaLiga.Models
{
    public class Utakmica
    {
        public int Id { get; set; }
        public int DomacinId { get; set; }
        public int GostId { get; set; }
        public DateTime DatumOdigravanja { get; set; }
        public int DomacinGolova { get; set; }
        public int GostGolova { get; set; }
    }
}