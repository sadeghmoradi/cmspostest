using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Model.sal;
using Model.Base;

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

    public interface IRepositoryWrapper
    {
        //base
        IRepositoryGood Good { get;  }
        IRepositoryCity City { get; }
        IRepositoryLocation Location { get; }
        IRepositoryLocationType LocationType { get; }
        //sale
        IRepositoryFactorDoc FactorDoc { get; }
        IRepositoryFactorDocDetail FactorDocDetail { get; }

    }
    //base
    public interface IRepositoryGood : IRepositoryBase<Good>
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
