using DBRepositories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepositories
{
    public class ModelRepo
    {
        HoaPhat2024Context dbContext = new HoaPhat2024Context();

        public ModelRepo() 
        { 

        }

        public List<Model> GetAll()
        {
            try
            {
                return dbContext.Models.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Create(Model model)
        {
            try
            {
                dbContext.Models.Add(model);
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Model model)
        {
            try
            {
                var itemToUpdate = dbContext.Models.SingleOrDefault(m => m.ModelCode == model.ModelCode);
                if (itemToUpdate != null)
                {
                    itemToUpdate.ModelCode = model.ModelCode;
                    itemToUpdate.ModelName = model.ModelName;
                    itemToUpdate.GrossWeight = model.GrossWeight;
                    itemToUpdate.ToLerance = model.ToLerance;
                    dbContext.Models.Update(itemToUpdate);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(string modelCode)
        {
            try
            {
                var itemToRemove = dbContext.Models.SingleOrDefault(m => m.ModelCode == modelCode); //returns a single item.
                if (itemToRemove != null)
                {
                    dbContext.Models.Remove(itemToRemove);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Model> GetByModel(string modelCode)
        {
            List<Model> lst = dbContext.Models.Where(o => o.ModelCode == modelCode).ToList();
            return lst;
        }

    }
}
