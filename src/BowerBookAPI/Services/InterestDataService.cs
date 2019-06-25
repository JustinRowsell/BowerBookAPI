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

        public List<InterestModel> GetAllInterests() {
            var models = new List<InterestModel>();
            var interests = _repository.GetAllInterests();
            var resources = _repository.GetAllResources();
            var tags = _repository.GetAllTags();
            var progresses = _repository.GetAllProgresses();

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
                    models.Add(model);
                }
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
  }
}
