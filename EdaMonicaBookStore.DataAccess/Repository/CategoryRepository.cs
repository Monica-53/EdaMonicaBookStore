﻿using EdaMonicaBookStore.DataAccess.Repository.IRepository;
using EdaMonicaBookStore.Models;
using EdaMonicaBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdaMonicaBookStore.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository

    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            //use .NET LINQ to retreive the first or default category object
            // then pass the id as a generic entity which matches the category
        }
    }
}
