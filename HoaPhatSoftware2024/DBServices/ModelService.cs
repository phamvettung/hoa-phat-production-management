using DBRepositories;
using DBRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServices
{
    public class ModelService
    {
        private static ModelService instance = null;
        private ModelRepo modelRepo = null;
        private ModelService()
        {
            modelRepo = new ModelRepo();
        }
        public static ModelService GetInstance()
        {
            if (instance == null)
                instance = new ModelService();
            return instance;
        }

        public List<Model> GetAll() 
        { 
            return modelRepo.GetAll();
        }

        public void Create(Model model)
        {
            try
            {
                modelRepo.Create(model);
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
                modelRepo.Update(model);
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
                modelRepo.Delete(modelCode);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelCode"></param>
        /// <param name="actualWeight"></param>
        /// <returns> return is 0 if OK, is 1 if NG, -1 if list query = 0</returns>
        public int GetResultEscale(string modelCode, float actualWeight)
        {
            List<Model> list = modelRepo.GetByModel(modelCode);
            if (list.Count > 0)
            {
                float grossWeight = list[0].GrossWeight;
                int toLerance = list[0].ToLerance;
                float allowableVolumeDifference = toLerance;
                float actualDifferenceVolume = Math.Abs(actualWeight*1000 - grossWeight*1000);
                if (actualDifferenceVolume <= allowableVolumeDifference)
                    return 0; //OK
                else
                    return 1;//NG
            }
            else
                return -1;
        }
    }
}
