using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Models;

namespace Data.Repositories
{
    public class SQLFilmRepository : IFilmRepository
    {
        private VideoVerhuurContext context;
        public SQLFilmRepository(VideoVerhuurContext context)
        {
            this.context = context;
        }

        public Film Get(int id)
        {
            return context.Films
                .Where(f => f.FilmId == id)
                .FirstOrDefault();
        }

        public IEnumerable<Film> GetAll()
        {
            return context.Films;
        }
    }
}
