using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Model.OwnerIdentitys;
using EntityDB;
using IRepository;

namespace Repository
{
    public class OwnerIdentityRepo: RepositoryBase<OwnerIdentity>, IRepositoryOwnerIdentity
    {
        public OwnerIdentityRepo(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }
    }
}
