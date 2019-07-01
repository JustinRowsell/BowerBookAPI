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
    public class ProgressController
    {
        private IInterestDataService _dataService;
        public ProgressController(IInterestDataService dataService)
        {
            _dataService = dataService;
        }

        // GET api/resources
        [HttpGet]
        public IEnumerable<ProgressModel> GetAll()
        {
            return _dataService.GetAllProgresses();
        }
    }
}
