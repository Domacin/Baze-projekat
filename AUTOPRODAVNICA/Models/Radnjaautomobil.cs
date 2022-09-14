using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AUTOPRODAVNICA.Models
{
    public partial class Radnjaautomobil
    {
        public int RadId { get; set; }
        public int AutoId { get; set; }

        public virtual Automobil Auto { get; set; }
        public virtual Radnja Rad { get; set; }
    }
}
