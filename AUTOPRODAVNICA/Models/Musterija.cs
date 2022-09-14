using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AUTOPRODAVNICA.Models
{
    public partial class Musterija
    {
        public Musterija()
        {
            Racun = new HashSet<Racun>();
            Servismusterija = new HashSet<Servismusterija>();
        }

        public int CId { get; set; }
        public string CfName { get; set; }
        public string ClName { get; set; }

        public virtual ICollection<Racun> Racun { get; set; }
        public virtual ICollection<Servismusterija> Servismusterija { get; set; }
    }
}
