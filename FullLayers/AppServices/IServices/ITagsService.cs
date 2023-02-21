using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface ITagsService
    {
        public void AddTag(TagsViewModel tag);

        public void DeleteTag(int id);

        public List<TagsViewModel> GetList();
    }
}
