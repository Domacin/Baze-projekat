using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AUTOPRODAVNICA.Models
{
    public partial class Servismusterija
    {
        public int SId { get; set; }
        public int MId { get; set; }

        public virtual Musterija M { get; set; }
        public virtual Servis S { get; set; }
    }
}
