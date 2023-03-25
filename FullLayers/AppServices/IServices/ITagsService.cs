using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppServices.IServices
{
    public interface ITagsService
    {
        public void AddTag(TagsViewModel tag);

        public void DeleteTag(int id);

        public TagsViewModel GetById(int id);

        public List<TagsViewModel> GetList();

        public Task<bool> CheckTagExistsAsync(string tag);
    }
}
