using DBRepositories.Entities;
using DBRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServices
{
    public class ProductionOrderService
    {
        private static ProductionOrderService instance = null;
        private ProductionOrderRepo orderRepo = null;

        private ProductionOrderService()
        {
            orderRepo = new ProductionOrderRepo();
        }

        public static ProductionOrderService GetInstance()
        {
            if (instance == null)
                instance = new ProductionOrderService();
            return instance;
        }

        public List<ProductionOrder> GetAll()
        {
            try
            {
                return orderRepo.GetAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Create(ProductionOrder order)
        {
            try
            {
                orderRepo.Create(order);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(ProductionOrder order)
        {
            try
            {
                orderRepo.Update(order);
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
                orderRepo.Delete(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteAll()
        {
            try
            {
                orderRepo.DeleteAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
