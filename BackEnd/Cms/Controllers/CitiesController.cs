using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityDB;
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
        
        public CitiesController(IRepositoryWrapper repositorywrapper)
        {
            _repositoryWrapper = repositorywrapper;
        }
        [HttpGet]
        public IEnumerable<City> GetCities()
        {
            var t = _repositoryWrapper.City.FindAll().ToArray();
            
            return t;
        }

        [HttpPost]
        public ActionResult<City> Post([FromBody]City city )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _repositoryWrapper.City.Create(city);
            _repositoryWrapper.City.save();
            return Ok(city);
        }

    }
}