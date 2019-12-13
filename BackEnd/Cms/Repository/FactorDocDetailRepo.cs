using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Model.FactorDocDetails;
using EntityDB;
using IRepository;


namespace Repository
{
    public class FactorDocDetailRepo : RepositoryBase<FactorDocDetail> , IRepositoryFactorDocDetail
    {
        public FactorDocDetailRepo(RepositoryContext repositoryContext): base(repositoryContext)
        {

        }
    }
}
