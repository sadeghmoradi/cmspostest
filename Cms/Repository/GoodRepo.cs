using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityDB;
using IRepository;
using Model.Base;
using Model.sal;

namespace Repository
{
    public class GoodRepo: RepositoryBase<Good>, IRepositoryGood
    {
        public GoodRepo(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }
    }
}
