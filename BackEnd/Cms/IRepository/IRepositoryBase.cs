using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Entity.Model.Brands;
using Entity.Model.Citys;
using Entity.Model.Customers;
using Entity.Model.CustomerTypes;
using Entity.Model.FactorDocDetails;
using Entity.Model.FactorDocs;
using Entity.Model.Goods;
using Entity.Model.Locations;
using Entity.Model.LocationTypes;
using Entity.Model.OwnerIdentitys;
using Entity.Model.Units;
using Entity.Model.UnitTypes;

namespace IRepository
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> FindAll();
        IEnumerable<T> FindByCondition(Expression<Func<T,bool>> expression);
        void Create(T context);
        void Update( T context);
        void Delete(T context);
        void save();

    }

    public interface IRepositoryWrapperBase
    {
        //base
        IRepositoryGood Good { get;  }
        IRepositoryCity City { get; }
        IRepositoryLocation Location { get; }
        IRepositoryLocationType LocationType { get; }

        IRepositoryUnit Unit { get; }
        IRepositoryUnitType UnitType { get; }

   
        //sale
        IRepositoryFactorDoc FactorDoc { get; }
        IRepositoryFactorDocDetail FactorDocDetail { get; }
    }
    
    //base
    public interface IRepositoryGood : IRepositoryBase<Good>
    {
    }
    public interface IRepositoryBrand : IRepositoryBase<Brand>
    {
    }
    public interface IRepositoryCustomer : IRepositoryBase<Customer>
    {
    }
    public interface IRepositoryCustomerType : IRepositoryBase<CustomerType>
    {
    }
    public interface IRepositoryOwnerIdentity : IRepositoryBase<OwnerIdentity>
    {
    }
    public interface IRepositoryUnit : IRepositoryBase<Unit>
    {
        IEnumerable<UnitDto> GetunitDto();
    }
    public interface IRepositoryUnitType : IRepositoryBase<UnitType>
    {
    }
    public interface IRepositoryCity : IRepositoryBase<City>
    {
        
    }
    public interface IRepositoryLocation : IRepositoryBase<Location>
    {
    }
    public interface IRepositoryLocationType : IRepositoryBase<LocationType>
    {
    }
    //sale
    public interface IRepositoryFactorDoc : IRepositoryBase<FactorDoc>
    {
    }
    public interface IRepositoryFactorDocDetail : IRepositoryBase<FactorDocDetail>
    {
    }
}
