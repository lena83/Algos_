using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.TRowePrice
{
    public class SimpleSqlAccess
    {
        private readonly string _connectionString;
        public SimpleSqlAccess(string connectionString) 
        { 
            _connectionString = connectionString;
            Connection = new SqlConnection(connectionString);
        }

        public IDbConnection Connection { get; private set; }

        public async Task<IQueryable<T>> ExecuteAsync<T>(string strSql, object param)
        {
            using IDbConnection conn = Connection;

            var res = await conn.QueryAsync<T>(strSql, param);

            return res.AsQueryable<T>();
        }

    }
}
