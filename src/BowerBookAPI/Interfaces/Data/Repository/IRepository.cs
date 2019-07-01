using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowerBookAPI.Interfaces.Data.Repository
{
    public interface IRepository<T>
    {
        IMongoCollection<T> Collection { get; set; }
        T Get(int id);
        List<T> GetAll();
    }
}
