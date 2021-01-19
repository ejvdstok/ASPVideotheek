using System;
using System.Collections.Generic;
using System.Text;
using Data.Models;

namespace Data.Repositories
{
    public interface IFilmRepository
    {
        IEnumerable<Film> GetAll();
        Film Get(int id);
    }
}
