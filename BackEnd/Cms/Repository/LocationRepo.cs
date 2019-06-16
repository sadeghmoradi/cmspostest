using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityDB;
using IRepository;
using Model.Base;

namespace Repository
{
    public class LocationRepo : RepositoryBase<Location>,IRepositoryLocation 
    {
        public LocationRepo(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }
    }
}
