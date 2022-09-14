using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AUTOPRODAVNICA.Models
{
    public partial class Servis
    {
        public Servis()
        {
            Servismusterija = new HashSet<Servismusterija>();
        }

        public int ServisId { get; set; }

        public virtual Radnomjesto ServisNavigation { get; set; }
        public virtual ICollection<Servismusterija> Servismusterija { get; set; }
    }
}
