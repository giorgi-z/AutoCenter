﻿using AutoCenter.Domain.Interfaces.Repositories;
using AutoCenter.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoCenter.Repository
{
    public class AdministrationEmployeeRepository : RepositoryBase<AdministrationEmployee>
    {
        public AdministrationEmployeeRepository(AutoCenterDbContext db) : base(db)
        {
        }
    }
}
