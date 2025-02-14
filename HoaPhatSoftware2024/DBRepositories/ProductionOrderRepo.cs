using DBRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepositories
{
    public class ProductionOrderRepo
    {
        HoaPhat2024Context dbContext = new HoaPhat2024Context();

        public ProductionOrderRepo()
        {

        }
        public List<ProductionOrder> GetAll()
        {
            try
            {
                return dbContext.ProductionOrders.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Create(ProductionOrder order)
        {
            try
            {
                dbContext.ProductionOrders.Add(order);
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(ProductionOrder order)
        {
            try
            {
                var itemToUpdate = dbContext.ProductionOrders.SingleOrDefault(o => o.ModelCode == order.ModelCode);
                if (itemToUpdate != null)
                {
                    itemToUpdate.Date = order.Date;
                    itemToUpdate.ModelCode = order.ModelCode;
                    itemToUpdate.ExpectedOutput = order.ExpectedOutput;
                    itemToUpdate.ActualOutput = order.ActualOutput;
                    itemToUpdate.Status = order.Status;

                    dbContext.ProductionOrders.Update(itemToUpdate);
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
                var itemToRemove = dbContext.ProductionOrders.SingleOrDefault(o => o.Id == id);
                if (itemToRemove != null)
                {
                    dbContext.ProductionOrders.Remove(itemToRemove);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteAll()
        {
            var all = from c in dbContext.ProductionOrders select c;
            dbContext.ProductionOrders.RemoveRange(all);
            dbContext.SaveChanges();
        }
    }
}
