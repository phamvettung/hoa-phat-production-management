using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepositories
{
    public static class DbContextExtension
    {
        public static DataTable DataTable(this DbContext context, string sqlQuery,
                                      params DbParameter[] parameters)
        {
            try
            {
                DataTable dataTable = new DataTable();
                DbConnection connection = context.Database.GetDbConnection();
                DbProviderFactory dbFactory = DbProviderFactories.GetFactory(connection);
                using (var cmd = dbFactory.CreateCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sqlQuery;
                    cmd.CommandTimeout = 60;
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            cmd.Parameters.Add(item);
                        }
                    }
                    using (DbDataAdapter adapter = dbFactory.CreateDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dataTable);
                    }
                }
                return dataTable;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
