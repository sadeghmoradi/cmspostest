﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        //[HttpGet]
        //public IEnumerable<City> GetCities()
        //{
        //    var t = _repositoryWrapper.City.FindAll().ToArray();

        //    return t;
        //}
        //[Route("Cities/{filter}")]
        [HttpGet]
        public IEnumerable<City> GetCities(string filter, string sortOrder, int pageNumber, int pageSize)
        {
            string url = "/api/Cities?filter=Name = تهران;Id = 1";
            if (filter != null)
            {
                var o = filter?.Split(";");
                var yy = new City();
                Type op = yy.GetType();
                var pp = op.GetProperties();
                string str = string.Empty;
                foreach (var item in pp)
                {
                    foreach (var item1 in o)
                    {
                        if (item.Name == item1.Split(" ")[0].ToString())
                        {
                            str = op.Name + "." + item1 + " AND " + str;
                        }

                    }
                }
                str = str?.Substring(0, str.Length - 4);

            }

            //befor use str ??
            var t = _repositoryWrapper.City.FindAll().ToArray();

            return t;
        }

        //[HttpGet("bypaging")]
        //public IEnumerable<City> GetCities(string filter, string sortOrder, int pageNumber, int pageSize)
        //{

        //    Expression<Func<City, bool>> exp = x => x.Name == filter;
        //    var count = _repositoryWrapper.City.FindAll().Count();

        //    var pageSize1 = pageNumber  * pageSize;
        //    var skip = ((pageNumber * pageSize)-(pageSize-1))-1;
        //    var t = _repositoryWrapper.City.FindAll().Skip(skip).Take(pageSize1).ToArray();

        //    return t;
        //}


        [HttpPost]
        public ActionResult<City> Post([FromBody]City city)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Expression<Func<City, bool>> Expr = s => s.Name == city.Name || s.Code == city.Code;
            var citys = _repositoryWrapper.City.FindByCondition(Expr).ToArray();
            if (citys.Length > 0)
            {
                return NotFound();
            }
            _repositoryWrapper.City.Create(city);
            _repositoryWrapper.City.save();
            return Ok(city);
        }

        [HttpPut("{id}")]
        public ActionResult<City> Put(int id, [FromBody] City city)
        {
            if (id != city.Id)
            {
                return BadRequest();
            }
            _repositoryWrapper.City.Update(city);
            _repositoryWrapper.City.save();
            return Ok(city);
        }

    }
}