using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Film
    {
        public Film()
        {
            Verhuur = new HashSet<Verhuur>();
        }

        public int FilmId { get; set; }
        public string Titel { get; set; }
        public int GenreId { get; set; }
        public int InVoorraad { get; set; }
        public int UitVoorraad { get; set; }
        public decimal Prijs { get; set; }
        public int TotaalVerhuurd { get; set; }

        public virtual Genre GenreNrNavigation { get; set; }
        public virtual ICollection<Verhuur> Verhuur { get; set; }
    }
}
