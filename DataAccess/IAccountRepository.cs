using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace DataAccess
{
    public interface IAccountRepository 
    {
        IEnumerable<Account> GetAccounts();
        Account GetAccByID(int id);
        void CreateAcc(Account acc);
        void DeleteAcc(int id);
        void UpdateAcc(Account acc);
        void Save();
    }
}
