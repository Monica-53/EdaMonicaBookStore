using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdaMonicaBookStore.DataAccess.Repository.IRepository
{
    interface ISP_Call : IDisposable
    {
        //e.g first column of first row in the result set

        T Single<T>(string procedurename, DynamicParameters param = null);
        //execute something to the databse but not retrieve anything
        void Execute(string procedurename, DynamicParameters param = null);
        //retrives the complete row or record

        T OneRecord<T>(string prodcedurename, DynamicParameters param = null);
        //get allo of the rows

        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);
        //stored procedure that returns two tables
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
  
    }
}
