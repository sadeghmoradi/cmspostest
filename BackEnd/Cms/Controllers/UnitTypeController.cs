using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Model.UnitTypes;
using IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitTypeController : ControllerBase
    {
        private readonly IRepositoryWrapperBase _repositoryWrapperBase;

        public UnitTypeController(IRepositoryWrapperBase repositoryWrapperBase)
        {
            this._repositoryWrapperBase = repositoryWrapperBase;
        }
        [HttpGet]
        public IEnumerable<UnitType> GetCities()
        {
            var t = _repositoryWrapperBase.UnitType.FindAll().ToArray();

            return t;
        }
    }
}