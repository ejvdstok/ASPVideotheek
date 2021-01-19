using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Models;

namespace Data.Repositories
{
    public class SQLKlantRepository : IKlantRepository
    {
        private VideoVerhuurContext context;
        public SQLKlantRepository(VideoVerhuurContext context)
        {
            this.context = context;
        }
        public Klant Get(int id)
        {
            return context.Klanten.Find(id);
        }

        public IEnumerable<Klant> GetAll()
        {
            return context.Klanten;
        }

        public Klant GetByName(string naam)
        {
            return context.Klanten
                .Where(k => k.Naam == naam.ToLower())
                .FirstOrDefault();
        }


    }
}
