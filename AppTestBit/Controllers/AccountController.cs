using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DataAccess;
using Database;

namespace AppTestBit.Controllers
{
    public class AccountController : ApiController
    {
        private readonly IAccountRepository accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }
        // GET: api/Account
        public IHttpActionResult GetAccounts()
        {
            return Ok(accountRepository.GetAccounts());
        }

        // GET: api/Account/5
        public IHttpActionResult GetAccount(int id)
        {
            var account = accountRepository.GetAccByID(id);
            if (account == null)
            {
                return NotFound();
            }

            return Ok(account);
        }

        // PUT: api/Account/5
        public IHttpActionResult PutAccount(int id, Account account)
        {
            if (ModelState.IsValid)
            {
                accountRepository.CreateAcc(account);
                accountRepository.Save();
            }
            return Ok(account);
        }

        // POST: api/Account
        public IHttpActionResult PostAccount(Account account)
        {
            if (ModelState.IsValid)
            {
                accountRepository.CreateAcc(account);
                accountRepository.Save();
            }
            return CreatedAtRoute("DefaultApi", new { id = account.AccountId }, account);
        }

        // DELETE: api/Account/5
        public IHttpActionResult DeleteAccount(int id)
        {         
            accountRepository.DeleteAcc(id);
            accountRepository.Save();
            return Ok();
        }
    }
}