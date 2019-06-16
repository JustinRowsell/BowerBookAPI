using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BowerBookAPI.Interfaces.Services;
using BowerBookAPI.Models.Core;
using Microsoft.AspNetCore.Mvc;

namespace BowerBookAPI.Controllers
{
    [Route("api/[controller]")]
    public class InterestsController : Controller
    {
        private IInterestDataService _dataService;
        public InterestsController(IInterestDataService dataService)
        {
            _dataService = dataService;
        }
        // GET api/interests
        [HttpGet]
        public IEnumerable<InterestModel> GetAll()
        {
            return _dataService.GetAllInterests();
        }

        // GET api/interests/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
