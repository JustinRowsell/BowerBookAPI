using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowerBookAPI.Models.Global
{
    public static class Constants
    {
        public static class Data
        {
            public static string DatabaseName = "BowerBook";
            public static class Collections
            {
                public static string Interests = "Interests";
                public static string Resources = "Resources";
                public static string Tags = "Tags";
            }
        }
    }
}
