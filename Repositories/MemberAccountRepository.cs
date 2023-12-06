using System;
using Repositories.Models;
using Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MemberAccountRepository
    {
        GameCard2023DBContext db = new GameCard2023DBContext();
        public MemberAccount? Get(string email)
        {
            GameCard2023DBContext db = new GameCard2023DBContext();
            return db.MemberAccounts.FirstOrDefault(x => x.MemberEmail == email);
        }
        public string GetFullNameByEmail(string email)
        {
            MemberAccount account = Get(email);
            return account?.MemberFullName;
        }
    }
}
