﻿using System;
using System.Collections.Generic;
using System.Text;
using Data.Models;

namespace Data.Repositories
{
    public interface IKlantRepository
    {
        Klant Get(int id);
        Klant GetByName(string naam);
        IEnumerable<Klant> GetAll();
    }
}
