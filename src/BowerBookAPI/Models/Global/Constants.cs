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
            public static string InterestDatabaseName = "interest";
            public static class Collections
            {
                public static string Interests = "interests";
                public static string Resources = "resources";
                public static string Tags = "tags";
                public static string Progress = "progress";
            }
        }
    }
}
