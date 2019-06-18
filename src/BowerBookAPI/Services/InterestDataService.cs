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
                _repository = new CoreRepository(new InterestDatabase());
        }

        public List<Interest> GetAllInterests() {
            return _repository.GetAllInterests();
        }

        public Interest GetInterest(int id)
        {
            throw new System.NotImplementedException();
        }
  }
}
