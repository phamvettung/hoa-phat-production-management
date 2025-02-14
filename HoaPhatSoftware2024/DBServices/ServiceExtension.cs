using DBRepositories;
using DBRepositories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DBServices
{
    public class ServiceExtension
    {
        private static ServiceExtension instance = null;
        private HoaPhat2024Context dbContext = null;

        private ServiceExtension() 
        {
            dbContext = new HoaPhat2024Context();
        }

        public static ServiceExtension GetInstance()
        {
            if(instance == null)
                instance = new ServiceExtension();
            return instance;
        }

        public DataTable GetModelData(DateTime start, DateTime end)
        {
            string query = string.Format("EXEC SelectModelData '{0}', '{1}'", start.ToString("yyyy-MM-dd 00:00:00"), end.ToString("yyyy-MM-dd 23:59:59"));
            return DbContextExtension.DataTable(dbContext, query);
        }

        public DataTable GetOperationData(DateTime start, DateTime end)
        {
            string query = string.Format("EXEC SelectOperationData '{0}', '{1}'", start.ToString("yyyy-MM-dd 00:00:00"), end.ToString("yyyy-MM-dd 23:59:59")); 
            return DbContextExtension.DataTable(dbContext, query);
        }

        public DataTable GetDataReader(DateTime start, DateTime end)
        {
            string query = string.Format("EXEC SelectDataReader '{0}', '{1}'", start.ToString("yyyy-MM-dd 00:00:00"), end.ToString("yyyy-MM-dd 23:59:59"));
            return DbContextExtension.DataTable(dbContext, query);
        }

        public DataTable GetBarcodeQuantity(DateTime start, DateTime end)
        {
            string query = string.Format("EXEC SelectBarcodeQuantity '{0}', '{1}'", start.ToString("yyyy-MM-dd 00:00:00"), end.ToString("yyyy-MM-dd 23:59:59"));
            return DbContextExtension.DataTable(dbContext, query);
        }

        public DataTable GetModelTable()
        {
            string query = string.Format("SELECT ROW_NUMBER() OVER(ORDER BY modelCode) AS 'numOrder', * FROM Model");
            return DbContextExtension.DataTable(dbContext, query);
        }
        public DataTable GetOperatorByModel(string modelCode)
        {
            string query = string.Format("SELECT ROW_NUMBER() OVER(ORDER BY modelCode) AS 'numOrder', * FROM Operator WHERE modelCode = '{0}'", modelCode);
            return DbContextExtension.DataTable(dbContext, query);
        }

        public void CreateOperator(Operator opera)
        {
            try
            {
                int isIgnore = Convert.ToByte(opera.IsIgnore);
                string excuteTime = opera.ExcutionTime.ToString("hh':'mm':'ss");
                string query = string.Format("INSERT INTO Operator VALUES('{0}', {1}, N'{2}', '{3}', {4})", opera.ModelCode, opera.NumOperator, opera.OperatorName, excuteTime, isIgnore);
                DbContextExtension.DataTable(dbContext, query);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateOperator(Operator opera)
        {
            try
            {
                int isIgnore = Convert.ToByte(opera.IsIgnore);
                string excuteTime = opera.ExcutionTime.ToString("hh':'mm':'ss");
                string query = string.Format("UPDATE Operator SET operatorName = N'{0}', excutionTime = '{1}', isIgnore = {2} WHERE modelCode = '{3}' AND numOperator = {4}", opera.OperatorName, excuteTime, isIgnore, opera.ModelCode, opera.NumOperator);
                DbContextExtension.DataTable(dbContext, query);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable GetErrorDataByDate(DateTime start, DateTime end)
        {
            try
            {
                string query = string.Format("SELECT ROW_NUMBER() OVER(ORDER BY id) AS 'numOrder', ED.*, E.errorName, E.solution FROM ErrorData ED, Error E WHERE ED.bitError = E.bitError AND ngay BETWEEN '{0}' AND '{1}'", start.ToString("yyyy-MM-dd 00:00:00"), end.ToString("yyyy-MM-dd 23:59:59"));
                return DbContextExtension.DataTable(dbContext, query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetTotalExpectedOutput()
        {
            try
            {
                string query = "SELECT SUM(expectedOutput) AS 'totalExpectedOutput' FROM ProductionOrder";
                DataTable dt = DbContextExtension.DataTable(dbContext, query);
                return int.Parse(dt.Rows[0]["totalExpectedOutput"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public int CountDataReader(DateTime start, DateTime end, string condition)
        {
            try
            {
                string query = string.Format("EXEC CountDataReader '{0}', '{1}', N'{2}'", start.ToString("yyyy-MM-dd 00:00:00"), end.ToString("yyyy-MM-dd 23:59:59"), condition);
                DataTable dt = DbContextExtension.DataTable(dbContext, query);
                int res = int.Parse(dt.Rows[0]["count"].ToString());
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int CountDataReaderByModel(DateTime start, DateTime end, string condition, string modelCode)
        {
            try
            {
                string query = string.Format("EXEC CountDataReaderByModel '{0}', '{1}', N'{2}', '{3}'", start.ToString("yyyy-MM-dd 00:00:00"), end.ToString("yyyy-MM-dd 23:59:59"), condition, modelCode);
                DataTable dt = DbContextExtension.DataTable(dbContext, query);
                int res = int.Parse(dt.Rows[0]["count"].ToString());
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
