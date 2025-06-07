using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.DAO
{
    public class SqlDao
    {
        //paso 1
        private static SqlDao _instance;

        private string _connectionString;
        
        //paso 2
        private SqlDao()
        {
            // Initialize the connection string here
            _connectionString = string.Empty; 
        }

        //paso 3
        public SqlDao GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SqlDao();
            }
            return _instance;
        }

        //ejecucion sp sin retorno
        public void ExecuteProcedure(SqlOperation operation) { 
        }


        //metodosp retorno data
        public List<Dictionary<string, object>> ExecuteQuery(SqlOperation operation)
        {
            var list = new List<Dictionary<string, object>>();
            return list;
        }





    }
}
