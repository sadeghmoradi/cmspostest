using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Model.Goods;
using EntityDB;
using IRepository;


namespace Repository
{
    public class GoodRepo: RepositoryBase<Good>, IRepositoryGood
    {
        public GoodRepo(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }
    }
}
