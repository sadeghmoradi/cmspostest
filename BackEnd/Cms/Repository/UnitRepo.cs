using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Model.Units;
using EntityDB;
using IRepository;

namespace Repository
{
    public class UnitRepo : RepositoryBase<Unit>, IRepositoryUnit
    {
        public UnitRepo(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }
    }
}
