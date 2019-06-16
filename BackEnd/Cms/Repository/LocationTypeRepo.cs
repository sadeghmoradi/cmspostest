using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityDB;
using IRepository;
using Model.Base;

namespace Repository
{
    public class LocationTypeRepo : RepositoryBase<LocationType>, IRepositoryLocationType
    {
        public LocationTypeRepo(RepositoryContext repositoryContext) :base(repositoryContext)
        {

        }
    }
}
