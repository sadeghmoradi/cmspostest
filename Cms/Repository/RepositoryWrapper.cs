using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityDB;
using IRepository;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _RepositoryContext;
        private IRepositoryGood _Good;
        private IRepositoryCity _City;
        private IRepositoryLocation _location;
        private IRepositoryFactorDoc _FactorDoc;
        private IRepositoryFactorDocDetail _FactorDocDetail;

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _RepositoryContext = repositoryContext;
        }
        //base
        public IRepositoryGood Good {
            get
            {
                if (_Good == null)
                {
                    _Good = new GoodRepo(_RepositoryContext);
                }
                return _Good;
            }
        }
        public IRepositoryCity City
        {
            get
            {
                if (_City == null)
                {
                    _City = new CityRepo(_RepositoryContext);
                }
                return _City;
            }
        }
        public IRepositoryLocation Location {
            get
            {
                if (_location==null)
                {
                    _location = new LocationRepo(_RepositoryContext);
                }
                return _location;
            }
        }
        //sale
        public IRepositoryFactorDoc FactorDoc{
            get
            {
                if (_FactorDoc ==null)
                {
                    _FactorDoc = new FactorDocRepo(_RepositoryContext);
                }
                return _FactorDoc;
            }
        }
        public IRepositoryFactorDocDetail FactorDocDetail {
            get
            {
                if (_FactorDocDetail == null)
                {
                    _FactorDocDetail = new FactorDocDetailRepo(_RepositoryContext);
                }
                return _FactorDocDetail;
            }
        }
    }
}
