using DBRepositories;
using DBRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DBServices
{
    public class DataReaderService
    {
        private static DataReaderService instance = null;
        private DataReaderRepo dataRederRepo = null;

        private DataReaderService()
        {
            dataRederRepo = new DataReaderRepo();
        }

        public static DataReaderService GetInstance()
        {
            if(instance == null)
                instance = new DataReaderService();
            return instance;
        }

        public List<DataReader> GetByDate(DateTime start, DateTime end)
        {
            try
            {
                return dataRederRepo.GetByDate(start, end);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Create(DataReader dataReader)
        {
            try
            {
                dataRederRepo.Create(dataReader);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(DataReader dataReader)
        {
            try
            {
                dataRederRepo.Update(dataReader);
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
                dataRederRepo.Delete(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
