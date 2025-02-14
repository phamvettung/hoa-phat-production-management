using DBRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepositories
{
    public class OperationDataRepo
    {
        HoaPhat2024Context dbContext = new HoaPhat2024Context();

        public OperationDataRepo() 
        {

        }

        public List<OperationDatum> GetAll()
        {
            try
            {
                return dbContext.OperationData.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<OperationDatum> GetByDateAndNumOperator(DateTime start, DateTime end, int numOp)
        {
            try
            {
                return dbContext.OperationData.Where(o => o.Date >= start && o.Date <= end && o.NumOperator == numOp).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Create(OperationDatum operaData)
        {
            try
            {
                dbContext.OperationData.Add(operaData);
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(OperationDatum operaData)
        {
            try
            {
                var itemToUpdate = dbContext.OperationData.SingleOrDefault(o => o.Id == operaData.Id);
                if (itemToUpdate != null)
                {
                    itemToUpdate.Id = operaData.Id;
                    itemToUpdate.NumOperator = operaData.NumOperator;
                    itemToUpdate.ModelCode = operaData.ModelCode;
                    itemToUpdate.Date = operaData.Date;
                    itemToUpdate.StartTime = operaData.StartTime;
                    itemToUpdate.EndTime = operaData.EndTime;
                    dbContext.OperationData.Update(itemToUpdate);
                    dbContext.SaveChanges();
                }
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
                var itemToRemove = dbContext.OperationData.SingleOrDefault(o => o.Id == id);
                if (itemToRemove != null)
                {
                    dbContext.OperationData.Remove(itemToRemove);
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
