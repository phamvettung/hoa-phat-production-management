using DBRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepositories
{
    public class OperatorRepo
    {
        HoaPhat2024Context dbContext = new HoaPhat2024Context();

        public OperatorRepo() 
        {

        }

        public List<Operator> GetAll()
        {
            try
            {
                return dbContext.Operators.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Operator> GetByModelCode(string modelCode)
        {
            try
            {
                return dbContext.Operators.Where(o => o.ModelCode == modelCode).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Create(Operator opera)
        {
            try
            {
                dbContext.Operators.Add(opera);
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Operator opera)
        {
            try
            {
                // update with 2 conditions: numOperator and modelCode
                var itemToUpdate = dbContext.Operators.SingleOrDefault(o => o.NumOperator == opera.NumOperator && o.ModelCode == opera.ModelCode);
                if (itemToUpdate != null)
                {
                    itemToUpdate.ModelCode = opera.ModelCode;
                    itemToUpdate.NumOperator = opera.NumOperator;
                    itemToUpdate.OperatorName = opera.OperatorName;
                    itemToUpdate.IsIgnore = opera.IsIgnore;

                    dbContext.Operators.Update(itemToUpdate);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(int numOperator, string modelCode)
        {
            try
            {
                var itemToRemove = dbContext.Operators.SingleOrDefault(o => o.NumOperator == numOperator && o.ModelCode == modelCode);
                if (itemToRemove != null)
                {
                    dbContext.Operators.Remove(itemToRemove);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
