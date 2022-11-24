using EdaMonicaBookStore.DataAccess.Repository.IRepository;
using EdaMonicaBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdaMonicaBookStore.DataAccess.Repository.IRepository
{
    public class UnitOfWork  //make the method public to access the class
    {
        private readonly ApplicationDbContext_db; //using the statement
        
        public UnitOfWork(ApplicationDbContext db) //constructor to use DI and inject in to the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_call { get; private set;}

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save() //all changes will be saved when the Save method is called at the 'parent' level
        {
            _db.SaveChanges();
        }

    }
    interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
    }
}
