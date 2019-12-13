using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Entity.Model.Citys;
using EntityDB;
using IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace Cms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        public IRepositoryWrapperBase _repositoryWrapperBase { get; set; }

        public CitiesController(IRepositoryWrapperBase repositorywrapperBase)
        {
            _repositoryWrapperBase = repositorywrapperBase;
        }
        //[HttpGet]
        //public IEnumerable<City> GetCities()
        //{
        //    var t = _repositoryWrapper.City.FindAll().ToArray();

        //    return t;
        //}
        //[Route("Cities/{filter}")]
        //[HttpGet]
        //public IEnumerable<City> GetCities(string filter, string sortOrder, int pageNumber, int pageSize)
        //{
        //    string url = "/api/Cities?filter=Name = تهران;Id = 1";
        //    if (filter != null)
        //    {
        //        var o = filter?.Split(";");
        //        var yy = new City();
        //        var yy1 = new City();

        //        Type op = yy.GetType();
        //        var pp = op.GetProperties();
        //        string str = string.Empty;
        //        foreach (var item in pp)
        //        {
        //            foreach (var item1 in o)
        //            {
        //                if (item.Name == item1.Split(" ")[0].ToString())
        //                {
        //                    str = op.Name + "." + item1 + " AND " + str;

        //                    Expression<Func<City, bool>> exp = x => x.GetType().GetProperty("Id").GetValue(this,null).ToString() == "1";
        //                    var citys = _repositoryWrapper.City.FindByCondition(exp).ToArray();
        //                }

        //            }
        //        }
        //        str = str?.Substring(0, str.Length - 4);

        //    }

        //    //befor use str ??
        //    var t = _repositoryWrapper.City.FindAll().ToArray();

        //    return t;
        //}

        [HttpGet]
        //[HttpGet("{bypaging}")]
        public IEnumerable<CityDto> GetCities(string filter, string sortOrder, int pageNumber, int pageSize)
        {
            IEnumerable<City> t;
            
            if (filter != null)
            {
                Expression<Func<City, bool>> exp = x => x.Name.Contains(filter);
                 t = _repositoryWrapperBase.City.FindByCondition(exp);
            }else
            {
                t = _repositoryWrapperBase.City.FindAll();
            }
            //var count = _repositoryWrapper.City.FindAll().Count();

            var pageSize1 = (pageNumber + 1) * pageSize;
            var skip = (((pageNumber + 1) * pageSize) - (pageSize - 1)) - 1;
            var tt = t.Skip(skip).Take(pageSize).ToArray();
            int countCity = t.Count();
            List<CityDto> cityDtos=new List<CityDto>();
            foreach (var item in tt)
            {
                var cityd = new CityDto(item);
                cityd.cityCount = countCity;
                cityDtos.Add(cityd);
            }
            return cityDtos;
        }

        [Authorize]
        [HttpPost]
        public ActionResult<City> Post([FromBody]City city)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            Expression<Func<City, bool>> Expr = s => s.Name == city.Name || s.Code == city.Code;
            var citys = _repositoryWrapperBase.City.FindByCondition(Expr).ToArray();
            if (citys.Length > 0)
            {
                return NotFound();
            }
            var userid = HttpContext.User.Claims.First().Value;
            city.OwnerId = userid;
            _repositoryWrapperBase.City.Create(city);
            _repositoryWrapperBase.City.save();
            return Ok(city);
        }

        [HttpPut("{id}")]
        public ActionResult<City> Put(int id, [FromBody] City city)
        {
            if (id != city.Id)
            {
                return BadRequest();
            }
            _repositoryWrapperBase.City.Update(city);
            _repositoryWrapperBase.City.save();
            return Ok(city);
        }

    }
}