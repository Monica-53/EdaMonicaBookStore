using EdaMonicaBookStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdaMonicaBookStore.DataAccess.Repository.IRepository
{
    public interface IProductRepository
    {
        void Update(Product product);
    }
}
