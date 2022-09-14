using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AUTOPRODAVNICA.Models
{
    public partial class Racun
    {
        public int BillId { get; set; }
        public int BillPrice { get; set; }
        public DateTime BillDate { get; set; }
        public int? Musterija { get; set; }
        public int? Stavka { get; set; }

        public virtual Musterija MusterijaNavigation { get; set; }
        public virtual Stavka StavkaNavigation { get; set; }
    }
}
