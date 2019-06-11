using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityDB;
using IRepository;
using Model.sal;

namespace Repository
{
    public class FactorDocDetailRepo : RepositoryBase<FactorDocDetail> , IRepositoryFactorDocDetail
    {
        public FactorDocDetailRepo(RepositoryContext repositoryContext): base(repositoryContext)
        {

        }
    }
}
