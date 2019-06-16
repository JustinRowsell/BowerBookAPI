using System.Collections.Generic;
using BowerBookAPI.Models.Core;

namespace BowerBookAPI.Interfaces.Services {
  public interface IInterestDataService
  {
        List<InterestModel> GetAllInterests();
        InterestModel GetInterest(int id);
  }
}
