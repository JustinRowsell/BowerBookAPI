using System.Collections.Generic;
using System.Linq;
using Amazon.DynamoDBv2;
using BowerBookAPI.Data;
using BowerBookAPI.Data.Collections;
using BowerBookAPI.Interfaces.Services;
using BowerBookAPI.Models.Core;

namespace BowerBookAPI.Services {
  public class InterestDataService: IInterestDataService
  {
        private CoreRepository _repository;
        public InterestDataService(CoreRepository repository = null)
        {
            if (repository != null)
                _repository = repository;
            else
                _repository = new CoreRepository(new BowerBookDatabase());
        }

        public List<Interest> GetAllInterests() {
            return _repository.GetAllInterests()?.Select(i => new Interest
            {
                Category = i.Category,
                InterestId = i.InterestId,
                InterestName = i.InterestName,
                Description = i.Description
            }).ToList();
        }

        public Interest GetInterest(int id)
        {
            throw new System.NotImplementedException();
        }
  }
}
