using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AUTOPRODAVNICA.Models
{
    public partial class Cenovnik
    {
        public Cenovnik()
        {
            Automobil = new HashSet<Automobil>();
            Stavka = new HashSet<Stavka>();
        }

        public int CenovnikId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public virtual ICollection<Automobil> Automobil { get; set; }
        public virtual ICollection<Stavka> Stavka { get; set; }
    }
}
