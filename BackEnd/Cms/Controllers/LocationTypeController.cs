using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Base;   

namespace Cms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationTypeController : ControllerBase
    {
        public IRepositoryWrapper _repositoryWrapper;
        public LocationTypeController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        [HttpGet]
        public IEnumerable<LocationType> GetLocationType()
        {
            var loc = _repositoryWrapper.LocationType.FindAll().ToArray();
            return loc;
        }

        public ActionResult<LocationType> Post([FromBody]LocationType locationType )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Expression<Func<LocationType, bool>> exp = x => x.Code == locationType.Code || x.Name == locationType.Name;
            var loc = _repositoryWrapper.LocationType.FindByCondition(exp).ToArray();
            if (loc.Length>0)
            {
                return BadRequest();
            }
            _repositoryWrapper.LocationType.Create(locationType);
            _repositoryWrapper.LocationType.save();
            return Ok(locationType);
        }

    }
}