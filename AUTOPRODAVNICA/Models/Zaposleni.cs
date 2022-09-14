using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AUTOPRODAVNICA.Models
{
    public partial class Zaposleni
    {
        public int WId { get; set; }
        public string WfName { get; set; }
        public string WlName { get; set; }
        public int RmId { get; set; }

        public virtual Radnomjesto Rm { get; set; }
    }
}
