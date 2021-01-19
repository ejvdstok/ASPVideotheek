using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace ASP_Eindtest.Services
{
    public class KlantService
    {
        private IKlantRepository klantInterface;
        public KlantService(IKlantRepository klantInterface)
        {
            this.klantInterface = klantInterface;
        }
    }
}
