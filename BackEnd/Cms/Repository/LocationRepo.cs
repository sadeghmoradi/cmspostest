using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Model.Locations;
using EntityDB;
using IRepository;


namespace Repository
{
    public class LocationRepo : RepositoryBase<Location>,IRepositoryLocation 
    {
        public LocationRepo(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }
    }
}
