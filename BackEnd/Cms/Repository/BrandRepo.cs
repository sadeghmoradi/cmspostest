using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Model.Brands;
using EntityDB;
using IRepository;

namespace Repository
{
    public class BrandRepo : RepositoryBase<Brand>, IRepositoryBrand
    {
        public BrandRepo(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }
    }
}
