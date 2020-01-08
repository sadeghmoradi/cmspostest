using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Entity.Model.Units;
using Entity.Model.UnitTypes;
using EntityDB;
using IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly IRepositoryWrapperBase _repositorywrapperBase;

        public UnitController(IRepositoryWrapperBase repositorywrapperBase)
        {
            this._repositorywrapperBase = repositorywrapperBase;
        }
        // GET: api/Unit
        [HttpGet]
        public IEnumerable<UnitDto> Get(string filter, string sortOrder, int pageNumber, int pageSize)
        {
            //IEnumerable<Unit> t;

            //if (filter != null)
            //{
            //    Expression<Func<Unit, bool>> exp = x => x.Name.Contains(filter);
            //    t = _repositorywrapperBase.Unit.FindByCondition(exp);
            //}
            //else
            //{
            //    t = _repositorywrapperBase.Unit.FindAll();
            //}
            //var count = _repositoryWrapper.City.FindAll().Count();

            IEnumerable<UnitDto> t;
            t = _repositorywrapperBase.Unit.GetunitDto();
            var pageSize1 = (pageNumber + 1) * pageSize;
            var skip = (((pageNumber + 1) * pageSize) - (pageSize - 1)) - 1;
            var tt = t.Skip(skip).Take(pageSize).ToArray();
            
            int countCity = t.Count();
            
            foreach (var item in tt)
            {
                item.UnitCount= countCity;
            }
            return tt;
        }

        //// GET: api/Unit/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Unit
        [HttpPost]
        public ActionResult<UnitDto> Post([FromBody] Unit unit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            Expression<Func<Unit, bool>> Expr = s => s.Name == unit.Name|| s.Code == unit.Code;
            var units = _repositorywrapperBase.Unit.FindByCondition(Expr).ToArray();
            if (units.Length > 0)
            {
                return NotFound();
            }
            //var userid = HttpContext.User.Claims.First().Value;
            //city.OwnerId = userid;
            var un = new Unit();
            un.Code = unit.Code;
            un.Name = unit.Name;
            Expression<Func<UnitType, bool>> ex = e => e.Id == unit.UnitTypes.Id;
            var tt =_repositorywrapperBase.UnitType.FindByCondition(ex).First();
            un.UnitTypes = tt;
            _repositorywrapperBase.Unit.Create(un);
            _repositorywrapperBase.Unit.save();
            UnitDto un1 = new UnitDto(unit);
            
            return Ok(un1);
        }

        // PUT: api/Unit/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
