using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Model.Customers;
using EntityDB;
using IRepository;

namespace Repository
{
    public class CustomerRepo : RepositoryBase<Customer>,IRepositoryCustomer
    {
        public CustomerRepo(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }
    }
}
