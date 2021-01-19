using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Verhuur
    {
        public int VerhuurNr { get; set; }
        public int KlantId { get; set; }
        public int FilmId { get; set; }
        public DateTime VerhuurDatum { get; set; }

        public virtual Film BandNrNavigation { get; set; }
        public virtual Klant KlantNrNavigation { get; set; }
    }
}
