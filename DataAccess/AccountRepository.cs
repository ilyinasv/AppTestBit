using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace DataAccess
{
    public class AccountRepository : IAccountRepository
    {
        private AppTestContext context;
        public AccountRepository(AppTestContext context)
        {
            this.context = context;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return context.Accounts.ToList();
        }
        public Account GetAccByID(int id)
        {
            return context.Accounts.Find(id);
        }
        public void CreateAcc(Account acc)
        {
            context.Accounts.Add(acc);
        }
        public void DeleteAcc(int id)
        {
            Account acc = context.Accounts.Find(id);
            context.Accounts.Remove(acc);
        }
        public void UpdateAcc(Account acc)
        {
            context.Entry(acc).State = EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
