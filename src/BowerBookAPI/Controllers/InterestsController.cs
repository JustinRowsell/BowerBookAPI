﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BowerBookAPI.Data.Core;
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
        public InterestModel Get(string id)
        {
            return _dataService.GetInterest(id);
        }

        [HttpPost("new")]
        public string Post([FromBody]InterestModel interest)
        {
            return _dataService.CreateInterest(interest);
        }

        [HttpPut("update")]
        public async Task<string> Put([FromBody]InterestModel model)
        {
            return await _dataService.UpdateInterest(model);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
