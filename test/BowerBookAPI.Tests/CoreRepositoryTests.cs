using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BowerBookAPI.Data;
using NUnit.Framework;

namespace BowerBookAPI.Tests
{
    [TestFixture]
    public class CoreRepositoryTests : CoreTestBase
    {
        [Test]
        public void ShouldGetFeaturedBlogs()
        {
            // Arrange            
            var coreRepo = new CoreRepository(_context);

            // Act
            var interests = coreRepo.GetAllInterests();

            // Assert
            Assert.AreEqual(interests.Count(), 3);
        }

        [Test]
        public void ShouldGetInterest()
        {
            // Arrange
            var coreRepo = new CoreRepository(_context);

            // Act
            var interest = coreRepo.GetInterest(1);

            // Assert
            Assert.NotNull(interest);
        }
    }
}
