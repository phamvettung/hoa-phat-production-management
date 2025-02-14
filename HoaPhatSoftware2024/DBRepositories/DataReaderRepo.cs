using DBRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepositories
{
    public class DataReaderRepo
    {
        HoaPhat2024Context dbContext = new HoaPhat2024Context();

        public DataReaderRepo() 
        { 

        }

        public List<DataReader> GetAll()
        {
            try
            {
                return dbContext.DataReaders.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<DataReader> GetByDate(DateTime start, DateTime end)
        {
            try
            {
                return dbContext.DataReaders.Where(d => d.Date >= start && d.Date <= end).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Create(DataReader dataReader)
        {
            try
            {
                dbContext.DataReaders.Add(dataReader);
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(DataReader dataReader)
        {
            try
            {
                var itemToUpdate = dbContext.DataReaders.SingleOrDefault(d => d.Id == dataReader.Id);
                if (itemToUpdate != null)
                {
                    itemToUpdate.Id = dataReader.Id;
                    itemToUpdate.ModelCode = dataReader.ModelCode;
                    itemToUpdate.Date = dataReader.Date;
                    itemToUpdate.Barcode = dataReader.Barcode;
                    itemToUpdate.GrossWeight = dataReader.GrossWeight;
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
                var itemToRemove = dbContext.DataReaders.SingleOrDefault(d => d.Id == id);
                if (itemToRemove != null)
                {
                    dbContext.DataReaders.Remove(itemToRemove);
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
