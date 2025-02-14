using DBRepositories;
using DBRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServices
{
    public class ModelDataService
    {
        private static ModelDataService instance = null;
        private ModelDataRepo modelDataRepo = null;

        private ModelDataService()
        {
            modelDataRepo = new ModelDataRepo();
        }

        public static ModelDataService GetInstance()
        {
            if(instance == null)
                instance = new ModelDataService();
            return instance;
        }

        public List<ModelDatum> GetByDate(DateTime start, DateTime end)
        {
            try
            {
                return modelDataRepo.GetByDate(start, end);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Create(ModelDatum modelData)
        {
            try
            {
                modelDataRepo.Create(modelData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(ModelDatum modelData)
        {
            try
            {
                modelDataRepo.Update(modelData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                modelDataRepo.Delete(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
