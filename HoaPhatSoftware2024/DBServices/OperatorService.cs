using DBRepositories;
using DBRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServices
{
    public class OperatorService
    {
        private static OperatorService instance = null;
        private OperatorRepo operatorRepo = null;

        private OperatorService() 
        { 
            operatorRepo = new OperatorRepo();
        }

        public static OperatorService GetInstance()
        {
            if(instance == null)
                instance = new OperatorService();
            return instance;
        }

        public List<Operator> GetByModelCode(string modelCode)
        {
            try
            {
                return operatorRepo.GetByModelCode(modelCode);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Create(Operator opera)
        {
            try
            {
                operatorRepo.Create(opera);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Operator opera)
        {
            try
            {
                operatorRepo.Update(opera);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(int numOperator, string modelCode)
        {
            try
            {
                operatorRepo.Delete(numOperator, modelCode);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
