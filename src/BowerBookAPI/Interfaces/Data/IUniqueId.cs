using MongoDB.Bson;

namespace BowerBookAPI.Interfaces.Data 
{
    public interface IUniqueId
    {
        ObjectId Id { get; }
    }
}