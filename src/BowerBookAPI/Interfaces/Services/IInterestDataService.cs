using System.Collections.Generic;
using BowerBookAPI.Data.Core;
using BowerBookAPI.Models.Core;

namespace BowerBookAPI.Interfaces.Services {
  public interface IInterestDataService
  {
        List<Interest> GetAllInterests();
        Interest GetInterest(int id);
  }
}
