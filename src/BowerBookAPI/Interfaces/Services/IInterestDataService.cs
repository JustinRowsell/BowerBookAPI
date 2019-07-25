using System.Collections.Generic;
using System.Threading.Tasks;
using BowerBookAPI.Data.Core;
using BowerBookAPI.Models.Core;

namespace BowerBookAPI.Interfaces.Services {
  public interface IInterestDataService
  {
        List<InterestModel> GetAllInterests();
        InterestModel GetInterest(string id);
        IEnumerable<ResourceModel> GetAllResources();
        IEnumerable<ProgressModel> GetAllProgresses();
        IEnumerable<TagModel> GetAllTags();
        ProgressModel GetProgress(string progressId);
        string CreateInterest(InterestModel interest);
        string CreateResource(ResourceModel resource);
        string CreateTag(TagModel tag);
        Task<string> AddResourceToInterest(string id, string name, string link);
    }
}
