using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IRepository;
using Model.Base;
using EntityDB;

namespace Repository
{
    public class CityRepo : RepositoryBase<City> ,IRepositoryCity
    {
        public CityRepo(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }
    }
}
