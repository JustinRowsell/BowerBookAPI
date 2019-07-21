using BowerBookAPI.Data.Core;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowerBookAPI.Offline
{
    public static class Data
    {
        public static List<Interest> Interests
        {
            get
            {
                return new List<Interest>
                {
                    new Interest
                    {
                        InterestId = ObjectId.GenerateNewId(),
                        InterestName = "Machine Learning",
                        Category = "Computer Science",
                        Resources = ResourceIds,
                        Tags = TagIds
                    },
                    new Interest
                    {
                        InterestId = ObjectId.GenerateNewId(),
                        InterestName = "Bazel",
                        Category = "Builds",
                        Resources = ResourceIds,
                        Tags = TagIds
                    }
                };
            }
        }

        static ObjectId _resourceIdOne = ObjectId.GenerateNewId();
        static ObjectId _resourceIdTwo = ObjectId.GenerateNewId();
        static ObjectId _resourceIdThree = ObjectId.GenerateNewId();

        public static List<ObjectId> ResourceIds
        {
            get
            {
                return new List<ObjectId> { _resourceIdOne, _resourceIdTwo, _resourceIdThree };
            }
        }
        public static List<Resource> Resources
        {
            get
            {
                return new List<Resource>
                {
                    new Resource
                    {
                        ResourceId = _resourceIdOne,
                        ResourceLink = "https://google.com",
                        ResourceName = "Resource One",
                        ProgressId = _pId
                    },
                    new Resource
                    {
                        ResourceId = _resourceIdTwo,
                        ResourceLink = "https://google.com",
                        ResourceName = "Resource Two",
                        ProgressId = _pId
                    },
                    new Resource
                    {
                        ResourceId = _resourceIdThree,
                        ResourceLink = "https://google.com",
                        ResourceName = "Resource Three",
                        ProgressId = _pIdTwo
                    }
                };
            }
        }

        static ObjectId _pId = ObjectId.GenerateNewId();
        static ObjectId _pIdTwo = ObjectId.GenerateNewId();
        public static List<Progress> Progress
        {
            get
            {
                return new List<Progress>
                {
                    new Progress
                    {
                        ProgressId = _pId,
                        ProgressName = "Not Started"
                    },
                    new Progress
                    {
                        ProgressName = "Finished",
                        ProgressId = _pIdTwo
                    }
                };
            }
        }

        private static ObjectId _tagId = ObjectId.GenerateNewId();
        public static List<ObjectId> TagIds
        {
            get
            {
                return new List<ObjectId>
                {
                    _tagId
                };
            }
        }

        public static List<Tag> Tags
        {
            get
            {
                return new List<Tag>
                {
                    new Tag
                    {
                        TagId = _tagId,
                        TagName = "Money Maker"
                    }
                };
            }
        }

    }
}
