using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Base;

namespace Cms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        public IRepositoryWrapper _repositoryWrapper { get; set; }
        public CitiesController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        [HttpPost]
        public IActionResult  Post(City city)
        {
            if (!ModelState.IsValid )
            {
                return  BadRequest(ModelState);
            }
             _repositoryWrapper.City.Create(city);
            _repositoryWrapper.City.save();
            return Ok(city);
        }
    }
}