using DBRepositories;
using DBRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServices
{
    public class OperationDataService
    {
        private static OperationDataService instance = null;
        private OperationDataRepo operaDataRepo = null;

        private OperationDataService() 
        {
            operaDataRepo = new OperationDataRepo();        
        }

        public static OperationDataService GetInstance()
        {
            if (instance == null)
                instance = new OperationDataService();
            return instance;
        }

        public List<OperationDatum> GetByDateAndNumOperator(DateTime start, DateTime end, int numOp)
        {
            try
            {
                return operaDataRepo.GetByDateAndNumOperator(start, end, numOp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Create(OperationDatum datum) 
        {
            try
            {
                operaDataRepo.Create(datum);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(OperationDatum datum)
        {
            try
            {
                operaDataRepo.Update(datum);
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
                operaDataRepo.Delete(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
