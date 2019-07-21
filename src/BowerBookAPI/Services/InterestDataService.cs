using System.Collections.Generic;
using System.Linq;
using Amazon.DynamoDBv2;
using BowerBookAPI.Data;
using BowerBookAPI.Data.Collections;
using BowerBookAPI.Data.Core;
using BowerBookAPI.Interfaces.Services;
using BowerBookAPI.Models.Core;
using MongoDB.Bson;

namespace BowerBookAPI.Services {
    public class InterestDataService : IInterestDataService
    {
        private bool _offline = false;
        private CoreRepository _repository;
        public InterestDataService(CoreRepository repository = null)
        {
            if (repository != null)
                _repository = repository;
            else if (_offline == false)
                _repository = new CoreRepository(new InterestDatabase());
        }

        public string CreateInterest(InterestModel model)
        {
            return _repository.CreateInterest(model).ToString();
        }

        public IEnumerable<ResourceModel> GetAllResources()
        {
            var resources = new List<ResourceModel>();
            List<Resource> resourcesDb = null;
            if (!_offline)
                resourcesDb = _repository.GetAllResources();
            else
                resourcesDb = Offline.Data.Resources;
            foreach (var resource in resourcesDb)
            {
                resources.Add(new ResourceModel
                {
                    ResourceId = resource.ResourceId.ToString(),
                    ResourceName = resource.ResourceName,
                    ResourceLink = resource.ResourceLink,
                    Progress = GetProgress(resource.ProgressId.ToString())
                });
            }
            return resources;
        }

        public IEnumerable<TagModel> GetAllTags()
        {
            var tags = new List<TagModel>();
            List<Tag> tagsDb = null;
            if (!_offline)
                tagsDb = _repository.GetAllTags();
            else
                tagsDb = Offline.Data.Tags;
            foreach (var tag in tagsDb)
            {
                tags.Add(new TagModel
                {
                    TagId = tag.TagId.ToString(),
                    TagName = tag.TagName
                });
            }
            return tags;
        }

        public IEnumerable<ProgressModel> GetAllProgresses()
        {
            var progressModels = new List<ProgressModel>();
            List<Progress> progresses = null;
            if (!_offline)
                progresses = _repository.GetAllProgresses();
            else
                progresses = Offline.Data.Progress;

            foreach (var progress in progresses)
            {
                progressModels.Add(GetProgressModel(progress));
            }
            return progressModels;
        }

        public ProgressModel GetProgressModel(Progress progress)
        {
            return new ProgressModel
            {
                ProgressId = progress.ProgressId.ToString(),
                ProgressName = progress.ProgressName,
                Color = progress.Color,
                Sequence = progress.Sequence
            };
        }

        public ProgressModel GetProgress(string progressId)
        {
            Progress progress = null;
            if (!_offline)
                progress = _repository.GetProgress(ObjectId.Parse(progressId));
            else
                progress = Offline.Data.Progress.First(p => p.ProgressId == ObjectId.Parse(progressId));
            return GetProgressModel(progress);
        }

        public List<InterestModel> GetAllInterests() {
            var models = new List<InterestModel>();
            List<Interest> interests = null;
            List<Resource> resources = null;
            List<Tag> tags = null;
            List<Progress> progresses = null;
            if (_offline)
            {
                interests = Offline.Data.Interests;
                resources = Offline.Data.Resources;
                progresses = Offline.Data.Progress;
                tags = Offline.Data.Tags;
            }
            else
            {
                interests = _repository.GetAllInterests();
                resources = _repository.GetAllResources();
                tags = _repository.GetAllTags();
                progresses = _repository.GetAllProgresses();
            }
            

            foreach (var interest in interests)
            {
                var model = new InterestModel
                {
                    InterestId = interest.InterestId.ToString(),
                    InterestName = interest.InterestName,
                    Description = interest.Description,
                    Category = interest.Category
                };
                model.Tags = new List<TagModel>();
                model.Resources = new List<ResourceModel>();
                foreach (var tagId in interest.Tags)
                {
                    var tag = tags.FirstOrDefault(t => t.TagId == tagId);
                    if (tag != null)
                    {
                        model.Tags.Add(new TagModel
                        {
                            TagId = tag.TagId.ToString(),
                            TagName = tag.TagName
                        });
                    }
                }
                foreach (var resourceId in interest.Resources)
                {
                    var resource = resources.FirstOrDefault(r => r.ResourceId == resourceId);
                    if (resource != null)
                    {
                        var resourceModel = new ResourceModel
                        {
                            ResourceId = resource.ResourceId.ToString(),
                            ResourceName = resource.ResourceName,
                            ResourceLink = resource.ResourceLink,

                        };
                        var progress = progresses.FirstOrDefault(p => p.ProgressId == resource.ProgressId);
                        if (progress != null)
                        {
                            resourceModel.Progress = new ProgressModel
                            {
                                ProgressId = progress.ProgressId.ToString(),
                                ProgressName = progress.ProgressName,
                                Color = progress.Color,
                                Sequence = progress.Sequence
                            };
                        }                    
                        model.Resources.Add(resourceModel);
                    }
                }
                models.Add(model);
            }
            return models;
        }

        public InterestModel GetInterest(string id)
        {        
            Interest interest = _repository.GetInterest(ObjectId.Parse(id));
            var model = new InterestModel();
            if (interest != null)
            {
                model = new InterestModel
                {
                    InterestId = interest.InterestId.ToString(),
                    InterestName = interest.InterestName,
                    Description = interest.Description,
                    Category = interest.Category
                };
                model.Tags = new List<TagModel>();
                foreach (var tagId in interest.Tags)
                {
                    Tag tag = _repository.GetTag(tagId);
                    model.Tags.Add(new TagModel { TagId = tagId.ToString(), TagName = tag.TagName });
                }
                model.Resources = new List<ResourceModel>();
                foreach (var resourceId in interest.Resources)
                {
                    var resource = _repository.GetResource(resourceId);
                    var progress = _repository.GetProgress(resource.ProgressId);
                    model.Resources.Add(new ResourceModel
                    {
                        ResourceId = resourceId.ToString(),
                        ResourceLink = resource.ResourceLink,
                        ResourceName = resource.ResourceName,
                        Progress = new ProgressModel {
                            ProgressId = progress.ProgressId.ToString(),
                            ProgressName = progress.ProgressName,
                            Color = progress.Color,
                            Sequence = progress.Sequence
                        }
                    });
                }
            }


            return model;
        }

        public string CreateResource(ResourceModel resource)
        {
            return _repository.CreateResource(resource).ToString();
        }
    }
}
