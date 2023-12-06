using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProviderRepository
    {
        public List<Provider> GetAll()
        {
            return new GameCard2023DBContext().Providers.ToList();
        }
    }
}
