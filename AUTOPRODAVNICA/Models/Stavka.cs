using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AUTOPRODAVNICA.Models
{
    public partial class Stavka
    {
        public Stavka()
        {
            Racun = new HashSet<Racun>();
        }

        public int ItemId { get; set; }
        public int Amount { get; set; }
        public int ItemPrice { get; set; }
        public int? Cenovnik { get; set; }

        public virtual Cenovnik CenovnikNavigation { get; set; }
        public virtual ICollection<Racun> Racun { get; set; }
    }
}
