using System;
using System.Collections.Generic;
using System.Text;
using Data.Models;

namespace Data.Repositories
{
    public class SQLGenreRepository : IGenreRepository
    {
        private VideoVerhuurContext context;
        public SQLGenreRepository(VideoVerhuurContext context)
        {
            this.context = context;
        }
        public IEnumerable<Genre> GetAll()
        {
            return context.Genres;
        }
    }
}
