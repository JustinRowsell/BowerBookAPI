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
    public class ResourcesController
    {
        private IInterestDataService _dataService;
        public ResourcesController(IInterestDataService dataService)
        {
            _dataService = dataService;
        }

        // GET api/resources
        [HttpGet]
        public IEnumerable<ResourceModel> GetAll()
        {
            return _dataService.GetAllResources();
        }

        // POST api/values
        [HttpPost("new")]
        public string Post([FromBody]ResourceModel resource)
        {
            return _dataService.CreateResource(resource);
        }

        // POST api/values
        [HttpPost("add")]
        public async Task<string> Post([FromBody]AddResourceModel resource)
        {
            return await _dataService.AddResourceToInterest(resource.Id, resource.Name, resource.Link);
        }

        [HttpPut("update")]
        public async Task<string> Put([FromBody]ResourceModel model)
        {
            return await _dataService.UpdateResource(model);
        }
    }
}
