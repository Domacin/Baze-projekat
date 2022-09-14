using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AUTOPRODAVNICA.Models
{
    public partial class Radnomjesto
    {
        public Radnomjesto()
        {
            Zaposleni = new HashSet<Zaposleni>();
        }

        public int WsId { get; set; }
        public string WsName { get; set; }

        public virtual Radnja Radnja { get; set; }
        public virtual Servis Servis { get; set; }
        public virtual ICollection<Zaposleni> Zaposleni { get; set; }
    }
}
