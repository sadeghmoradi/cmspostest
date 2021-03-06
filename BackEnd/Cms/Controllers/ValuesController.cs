﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IRepository;
using Microsoft.AspNetCore.Mvc;



namespace Cms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IRepositoryWrapper _repositorywrapper{ get; set; }
        public ValuesController(IRepositoryWrapper repositorywrapper)
        {
            _repositorywrapper = repositorywrapper;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var goods = _repositorywrapper.Good.FindAll().FirstOrDefault();
            var fac= _repositorywrapper.FactorDocDetail.FindAll().FirstOrDefault();
            
            //return new string[] {goods.Code , goods.Name};
            return new string[] { "vv", "ss" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
