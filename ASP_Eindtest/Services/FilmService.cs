using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace ASP_Eindtest.Services
{
    public class FilmService
    {
        private IFilmRepository filmInterface;
        public FilmService(IFilmRepository filmInterface)
        {
            this.filmInterface = filmInterface;
        }
        public Film GetFilmById(int id)
        {
            return (filmInterface.Get(id));
        }
    }
}
