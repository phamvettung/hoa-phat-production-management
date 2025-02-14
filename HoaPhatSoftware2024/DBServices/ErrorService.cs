using DBRepositories;
using DBRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServices
{
    public class ErrorService
    {
        private static ErrorService instance;
        private ErrorRepo errRepo;

        private ErrorService() 
        {
            errRepo = new ErrorRepo();
        }

        public static ErrorService GetInstance()
        {
            if(instance == null)
                instance = new ErrorService();
            return instance;
        }

        public List<Error> GetAll()
        {
            try
            {
                return errRepo.GetAll();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Create(Error err)
        {
            try
            {
                errRepo.Create(err);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Error err)
        {
            try
            {
                errRepo.Update(err);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string bitErr)
        {
            try
            {
                errRepo.Delete(bitErr);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
