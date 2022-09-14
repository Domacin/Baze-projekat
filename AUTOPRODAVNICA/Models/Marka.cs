using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AUTOPRODAVNICA.Models
{
    public partial class Marka
    {
        public Marka()
        {
            Automobil = new HashSet<Automobil>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string BrandC { get; set; }

        public virtual ICollection<Automobil> Automobil { get; set; }
    }
}
