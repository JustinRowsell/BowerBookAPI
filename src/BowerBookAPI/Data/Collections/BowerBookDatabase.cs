﻿using BowerBookAPI.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowerBookAPI.Data.Collections
{
    public class BowerBookDatabase : BaseMongoDatabase
    {
        public override string DatabaseName => Constants.Data.DatabaseName;
    }
}
