﻿using AutoCenter.Domain.Interfaces.Repositories;
using AutoCenter.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace AutoCenter.Repository
{
    public class CategoryRepository : RepositoryBase<Category>
    {
        public CategoryRepository(AutoCenterDbContext db) : base(db)
        {
        }
    }
}
