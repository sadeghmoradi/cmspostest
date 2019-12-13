using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Entity.Model.LocationTypes;
using IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
  

namespace Cms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationTypeController : ControllerBase
    {
        public IRepositoryWrapperBase _repositoryWrapperBase;
        public LocationTypeController(IRepositoryWrapperBase repositoryWrapperBase)
        {
            _repositoryWrapperBase = repositoryWrapperBase;
        }

        [HttpGet]
        public IEnumerable<LocationType> GetLocationType()
        {
            var loc = _repositoryWrapperBase.LocationType.FindAll().ToArray();
            return loc;
        }




        [HttpPost]
        public ActionResult<LocationType> Post([FromBody]LocationType locationType )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Expression<Func<LocationType, bool>> exp = x => x.Code == locationType.Code || x.Name == locationType.Name;
            var loc = _repositoryWrapperBase.LocationType.FindByCondition(exp).ToArray();
            if (loc.Length>0)
            {
                return BadRequest();
            }
            _repositoryWrapperBase.LocationType.Create(locationType);
            _repositoryWrapperBase.LocationType.save();
            return Ok(locationType);
        }

        [HttpPut("{id}")]
        public ActionResult<LocationType> Put(int id, [FromBody] LocationType locationType)
        {
            if (id != locationType.Id)
            {
                return BadRequest();
            }
            _repositoryWrapperBase.LocationType.Update(locationType);
            _repositoryWrapperBase.LocationType.save();
            return Ok(locationType);
        }

    }
}