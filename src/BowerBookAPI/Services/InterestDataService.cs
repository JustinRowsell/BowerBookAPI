using System.Collections.Generic;
using System.Linq;
using Amazon.DynamoDBv2;
using BowerBookAPI.Data;
using BowerBookAPI.Interfaces.Services;
using BowerBookAPI.Models.Core;

namespace BowerBookAPI.Services {
  public class InterestDataService: IInterestDataService
  {
        private CoreRepository _repository;
        public InterestDataService(CoreContext context, CoreRepository repository = null)
        {
            if (repository != null)
                _repository = repository;
            else
                _repository = new CoreRepository(context);
        }

        public List<InterestModel> GetAllInterests() {
            return _repository.GetAllInterests()?.Select(i => new InterestModel
            {
                Category = i.Category,
                InterestId = i.InterestId,
                InterestName = i.InterestName,
                Description = i.Description
            }).ToList();
        }

        public InterestModel GetInterest(int id)
        {
            throw new System.NotImplementedException();
        }
  }
}
