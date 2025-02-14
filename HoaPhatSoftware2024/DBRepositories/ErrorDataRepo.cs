using DBRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepositories
{
    public class ErrorDataRepo
    {
        HoaPhat2024Context dbContext = new HoaPhat2024Context();
        public ErrorDataRepo()
        {

        }

        public List<ErrorDatum> GetByDate(DateTime start, DateTime end)
        {
            try
            {
                return dbContext.ErrorData.Where(o => o.Ngay >= start && o.Ngay <= end).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Create(ErrorDatum errData)
        {
            try
            {
                dbContext.ErrorData.Add(errData);
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var itemToRemove = dbContext.ErrorData.SingleOrDefault(o => o.Id == id);
                if (itemToRemove != null)
                {
                    dbContext.ErrorData.Remove(itemToRemove);
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
