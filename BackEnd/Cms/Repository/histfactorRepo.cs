﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityDB;
using IRepository;
using Entity.Model.FactorDocs;

namespace Repository
{
    public class FactorDocRepo : RepositoryBase<FactorDoc> , IRepositoryFactorDoc
    {
        public FactorDocRepo(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }
    }
}
