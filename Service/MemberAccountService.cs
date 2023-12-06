using Repositories;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class MemberAccountService
    {
        public MemberAccount? CheckLogin(string email, string password)
        {
            MemberAccountRepository repo = new MemberAccountRepository();

            MemberAccount account = repo.Get(email);

            return account != null && account.MemberAccountPassword == password ? account : null;
        }
    }
}
