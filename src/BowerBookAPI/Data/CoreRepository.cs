using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowerBookAPI.Data
{
    public class CoreRepository
    {
        private CoreContext _context;

        public CoreRepository(CoreContext context)
        {
            _context = context;
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
            return _context.Interest.FirstOrDefault(b => b.InterestId == id);
        }
    }
}
