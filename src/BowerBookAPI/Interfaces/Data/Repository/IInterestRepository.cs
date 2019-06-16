using BowerBookAPI.Models.Core;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowerBookAPI.Interfaces.Data.Repository
{
    public interface IInterestRepository : IRepository<Interest>
    {
    }
}
