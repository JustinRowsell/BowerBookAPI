using BowerBookAPI.Models.Global;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowerBookAPI.Data.Collections
{
    public class Interests : BaseCollection
    {
        public override string CollectionName => Constants.Data.Collections.Interests;
    }
}
