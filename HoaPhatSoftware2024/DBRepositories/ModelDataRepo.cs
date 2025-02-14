using DBRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepositories
{
    public class ModelDataRepo
    {
        HoaPhat2024Context dbContext = new HoaPhat2024Context();

        public ModelDataRepo()
        {

        }

        public List<ModelDatum> GetAll()
        {
            try
            {
                return dbContext.ModelData.ToList();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public List<ModelDatum> GetByDate(DateTime start, DateTime end)
        {
            try
            {
                return dbContext.ModelData.Where(m =>  m.Date >= start && m.Date <= end).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Create(ModelDatum modelData)
        {
            try
            {
                dbContext.ModelData.Add(modelData);
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(ModelDatum modelData)
        {
            try
            {
                var itemToUpdate = dbContext.ModelData.SingleOrDefault(m => m.Id == modelData.Id);
                if (itemToUpdate != null)
                {
                    itemToUpdate.Id = modelData.Id;
                    itemToUpdate.ModelCode = modelData.ModelCode;
                    itemToUpdate.Date = modelData.Date;
                    itemToUpdate.ExpectedOutput = modelData.ExpectedOutput;
                    itemToUpdate.ActualOutput = modelData.ActualOutput;
                    dbContext.ModelData.Update(itemToUpdate);
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
                var itemToRemove = dbContext.ModelData.SingleOrDefault(m => m.Id == id); //returns a single item.
                if (itemToRemove != null)
                {
                    dbContext.ModelData.Remove(itemToRemove);
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
