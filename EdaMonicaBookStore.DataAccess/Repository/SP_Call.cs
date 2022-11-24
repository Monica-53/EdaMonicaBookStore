﻿using Dapper;
using EdaMonicaBookStore.DataAccess.Repository.IRepository;
using EdaMonicaBookStore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace EdaMonicaBookStore.DataAccess.Repository
{
    public class SP_Call : ISP_Call

    {
        //access the databse
        private readonly ApplicationDbContext _db;
        private static string ConnectionString = ""; //needed to call the stored procedures
        //constructor to open a SQL conection
        public SP_Call(ApplicationDbContext db)
        {
            _db = db;
            ConnectionString = db.Database.GetDbConnection().ConnectionString;
        }
        //implements the ISP_Call interface
        public void Dispose()
        {
            _db.Dispose();
            //throw new NotImplementedException();
        }

        public void Execute(string procedurename, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString)) {
                sqlCon.Open();
                SqlCon.Execute(procedureName, param, commandType: System.Data > CommandType.StoreProcedure);
                //throw new NotImplementedException();

            }

        }

        public IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null)
        {
            using (sqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.open();
                return sqlCon.Query<T>(procedurename, param, commandType: CommandType:System.Data.CommandType.StoredProcedure);
                //throw new NotImplementedException();
            }
        }
        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1,T2>(string procedurename, DynamicParameters param = null)
        {
        using (sqlConnection sqlCon = new SqlConnection(ConnectionString))
        {
            sqlCon.Open();
            var result = SqlMapper.QueryMultiple(sqlCon, procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            var item1 = result.Read<T1>().ToList();
            var item2 = result.Read<T2>().ToList();

            if (item1 != null && item2 != null)
            {
                return new Tuple<IEnumerable<T1>, IEnumerable<T2>>(item1, item2);
            }
 }
        return new Tuple<IEnumerable<T1>, IEnumerable<T2>>(new List<T1>(), new List<T2>());

    }

        public T OneRecord<T>(string procedurename, DynamicParameters param = null)
        {
        //throw new NotImplementedException();
        using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
        {
            sqlCon.Open();
            var value = sqlCon.Query<T>(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            return (T)Convert.ChangeType(value.FirstOrDefault(), typeof(T));
        }
    }

        public T Single<T>(string procedurename, DynamicParameters param = null)
        {
        using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
        {
            sqlCon.Open();
            return (T)Convert.ChangeType(sqlCon.ExecuteScalar<T>(procedureName, param, commandType: System.Data.CommandType.StoredProcedure), typeof(T));
        }
        //throw new NotImplementedException();
        }
    }


    






