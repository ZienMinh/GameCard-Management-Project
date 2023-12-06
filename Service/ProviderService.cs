using Repositories;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProviderService
    {
        private ProviderRepository repo;
        public List<Provider> GetAllProviders()
        {
            repo = new ProviderRepository();
            return repo.GetAll();
        }
    }
}
