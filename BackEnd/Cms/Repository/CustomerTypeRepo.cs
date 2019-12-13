using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Model.CustomerTypes;
using EntityDB;
using IRepository;

namespace Repository
{
    public class CustomerTypeRepo : RepositoryBase<CustomerType>,IRepositoryCustomerType
    {
        public CustomerTypeRepo(RepositoryContext repositoryContext ):base(repositoryContext)
        {

        }
    }
}
