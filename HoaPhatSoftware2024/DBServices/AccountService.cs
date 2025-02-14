using DBRepositories;
using DBRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServices
{
    public class AccountService
    {
        private static AccountService instance = null;
        private AccountRepo accountRepo = null;
        private AccountService()
        {
            accountRepo = new AccountRepo();
        }
        public static AccountService GetInstance()
        {
            if (instance == null)
                instance = new AccountService();
            return instance;
        }

        public List<Account> GetAll()
        {
            return accountRepo.GetAll();
        }

        public void Create(Account account)
        {
            try
            {
                accountRepo.Create(account);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Account account)
        {
            try
            {
                accountRepo.Update(account);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(string userName)
        {
            try
            {
                accountRepo.Delete(userName);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Account GetAccount(string userName, string passWord)
        {
            List<Account> lst = accountRepo.GetByAccount(userName, passWord);
            if (lst.Count > 0)
                return lst[0];
            else
                return null;
        }

        public Account GetUserName(string userName)
        {
            List<Account> lst = accountRepo.GetByUserName(userName);
            if (lst.Count > 0)
                return lst[0];
            else
                return null;
        }
    }
}
