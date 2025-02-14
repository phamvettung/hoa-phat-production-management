using DBRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepositories
{
    public class ErrorRepo
    {
        HoaPhat2024Context dbContext = new HoaPhat2024Context();

        public ErrorRepo()
        {

        }

        public List<Error> GetAll()
        {
            try
            {
                return dbContext.Errors.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Create(Error error)
        {
            try
            {
                dbContext.Errors.Add(error);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Error error)
        {
            try
            {
                var itemToUpdate = dbContext.Errors.SingleOrDefault(o => o.BitError == error.BitError);
                if (itemToUpdate != null)
                {
                    itemToUpdate.BitError = error.BitError;
                    itemToUpdate.ErrorName = error.ErrorName;
                    itemToUpdate.Solution = error.Solution;
                    dbContext.Errors.Update(itemToUpdate);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string bitError)
        {
            try
            {
                var itemToRemove = dbContext.Errors.SingleOrDefault(o => o.BitError == bitError); //returns a single item.
                if (itemToRemove != null)
                {
                    dbContext.Errors.Remove(itemToRemove);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
