using DBRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepositories
{
    public class AccountRepo
    {
        HoaPhat2024Context dbContext = new HoaPhat2024Context();

        public AccountRepo()
        {

        }

        public List<Account> GetAll()
        {
            try
            {
                return dbContext.Accounts.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Create(Account account)
        {
            try
            {
                dbContext.Accounts.Add(account);
                dbContext.SaveChanges();
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
                var itemToUpdate = dbContext.Accounts.SingleOrDefault(o => o.UserName == account.UserName);
                if (itemToUpdate != null)
                {
                    itemToUpdate.UserName = account.UserName;
                    itemToUpdate.PassWord = account.PassWord;
                    itemToUpdate.AccountName = account.UserName;
                    itemToUpdate.Role = account.Role;
                    dbContext.Accounts.Update(itemToUpdate);
                    dbContext.SaveChanges();
                }
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
                var itemToRemove = dbContext.Accounts.SingleOrDefault(o => o.UserName == userName); //returns a single item.
                if (itemToRemove != null)
                {
                    dbContext.Accounts.Remove(itemToRemove);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Account> GetByAccount(string userName, string passWord)
        {
            List<Account> lst = dbContext.Accounts.Where(o => o.UserName == userName && o.PassWord == passWord).ToList();
            return lst;
        }

        public List<Account> GetByUserName(string userName)
        {
            List<Account> lst = dbContext.Accounts.Where(o => o.UserName == userName).ToList();
            return lst;
        }
    }
}
