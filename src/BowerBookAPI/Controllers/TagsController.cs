using BowerBookAPI.Interfaces.Services;
using BowerBookAPI.Models.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowerBookAPI.Controllers
{
    [Route("api/[controller]")]
    public class TagsController
    {
        private IInterestDataService _dataService;
        public TagsController(IInterestDataService dataService)
        {
            _dataService = dataService;
        }

        // GET api/resources
        [HttpGet]
        public IEnumerable<TagModel> GetAll()
        {
            return _dataService.GetAllTags();
        }

        // POST api/values
        [HttpPost("new")]
        public string Post([FromBody]TagModel tag)
        {
            return _dataService.CreateTag(tag);
        }
    }
}
