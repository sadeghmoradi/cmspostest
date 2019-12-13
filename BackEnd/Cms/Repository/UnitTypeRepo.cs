using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Model.UnitTypes;
using EntityDB;
using IRepository;

namespace Repository
{
    public class UnitTypeRepo : RepositoryBase<UnitType> , IRepositoryUnitType
    {
        public UnitTypeRepo(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }
    }
}
