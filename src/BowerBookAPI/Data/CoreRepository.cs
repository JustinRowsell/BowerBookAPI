using BowerBookAPI.Data.Collections;
using BowerBookAPI.Data.Core;
using BowerBookAPI.Interfaces.Data.Repository;
using BowerBookAPI.Models.Core;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowerBookAPI.Data
{
    public class CoreRepository
    {
        private BaseMongoDatabase _database;
        public CoreRepository(BaseMongoDatabase database)
        {
            _database = database;
        }

        #region Interests
        public List<Interest> GetAllInterests()
        {
            return Interests.GetAll();
        }

        public Interest GetInterest(ObjectId id)
        {
            return Interests.Get(id);
        }

        private Interests _interests;
        public Interests Interests
        {
            get
            {
                if (_interests == null)
                    _interests = new Interests(_database.Database);
                return _interests;
            }
        }
        #endregion

        #region
        private Tags _tags;
        public Tags Tags
        {
            get
            {
                if (_tags == null)
                    _tags = new Tags(_database.Database);
                return _tags;
            }
        }
        public List<Tag> GetAllTags()
        {
            return Tags.GetAll();
        }
        public Tag GetTag(ObjectId id)
        {
            return Tags.Get(id);
        }
        #endregion

        #region Resources
        private Resources _resources;
        public Resources Resources
        {
            get
            {
                if (_resources == null)
                    _resources = new Resources(_database.Database);
                return _resources;
            }
        }
        public List<Resource> GetAllResources()
        {
            return Resources.GetAll();
        }
        public Resource GetResource(ObjectId id)
        {
            return Resources.Get(id);
        }
        #endregion

        #region Progress
        private Progresses _progresses;
        public Progresses Progresses
        {
            get
            {
                if (_progresses == null)
                    _progresses = new Progresses(_database.Database);
                return _progresses;
            }
        }
        public Progress GetProgress(ObjectId id)
        {
            return Progresses.Get(id);
        }
        public List<Progress> GetAllProgresses()
        {
            return Progresses.GetAll();
        }
        #endregion
    }
}