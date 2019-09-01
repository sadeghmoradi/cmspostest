using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IRepository;
using EntityDB;
using Entity.Model.Citys;

namespace Repository
{
    public class CityRepo : RepositoryBase<City> ,IRepositoryCity
    {
        public CityRepo(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }
    }
}
