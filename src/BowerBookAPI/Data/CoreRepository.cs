using BowerBookAPI.Data.Collections;
using BowerBookAPI.Interfaces.Data.Repository;
using BowerBookAPI.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowerBookAPI.Data
{
    public class CoreRepository
    {
        private BaseMongoDatabase _database;
        public CoreRepository(BaseMongoDatabase database)
        {
            _database = database;
        }

        public List<Interest> GetAllInterests()
        {
            // return _context.Interest.ToList();
            return new List<Interest>
            {
                new Interest { InterestId = 1, InterestName = "Test"}
            };
        }

        public Interest GetInterest(int id)
        {
            // return _context.Interest.FirstOrDefault(b => b.InterestId == id);
            return InterestRepository.Get(1);
        }

        public IInterestRepository InterestRepository { get; set; }
    }
}