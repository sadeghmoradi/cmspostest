using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Model.LocationTypes;
using EntityDB;
using IRepository;


namespace Repository
{
    public class LocationTypeRepo : RepositoryBase<LocationType>, IRepositoryLocationType
    {
        public LocationTypeRepo(RepositoryContext repositoryContext) :base(repositoryContext)
        {

        }
    }
}
