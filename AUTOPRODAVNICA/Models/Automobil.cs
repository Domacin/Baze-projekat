using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AUTOPRODAVNICA.Models
{
    public partial class Automobil
    {
        public Automobil()
        {
            Radnjaautomobil = new HashSet<Radnjaautomobil>();
        }

        public int ChasisNum { get; set; }
        public string Model { get; set; }
        public int YearP { get; set; }
        public int? Marka { get; set; }
        public int? Cenovnik { get; set; }

        public virtual Cenovnik CenovnikNavigation { get; set; }
        public virtual Marka MarkaNavigation { get; set; }
        public virtual ICollection<Radnjaautomobil> Radnjaautomobil { get; set; }
    }
}
