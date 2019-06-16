using BowerBookAPI.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowerBookAPI.Tests
{
    public class CoreTestBase
    {
        protected readonly CoreContext _context;
        public CoreTestBase()
        {
            var options = new DbContextOptionsBuilder<CoreContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            _context = new CoreContext(options);
            _context.Database.EnsureCreated();

            Seed(_context);
        }

        public void Dispose()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        private void Seed(CoreContext context)
        {
            var interests = new List<Interest>
            {
                new Interest { InterestId = 1, InterestName = "Machine Learning" },
                new Interest { InterestId = 2, InterestName = "Jump roping" },
                new Interest { InterestId = 3, InterestName = "Jest" }
            };

            context.Interest.AddRange(interests);

            context.SaveChanges();
        }
    }
}
