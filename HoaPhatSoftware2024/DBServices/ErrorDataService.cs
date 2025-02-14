using DBRepositories;
using DBRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServices
{
    public class ErrorDataService
    {
        private static ErrorDataService instance;
        private ErrorDataRepo errorDataRepo;

        private ErrorDataService()
        {
            errorDataRepo = new ErrorDataRepo();
        }

        public static ErrorDataService GetInstance()
        {
            if(instance == null)      
                instance = new ErrorDataService();
            return instance;
        }

        public List<ErrorDatum> GetByDate(DateTime start, DateTime end)
        {
            try
            {
                return errorDataRepo.GetByDate(start, end);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Create(ErrorDatum errData)
        {
            try
            {
                errorDataRepo.Create(errData);
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
                errorDataRepo.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
