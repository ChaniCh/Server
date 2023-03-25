using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface ITagForPostService
    {
        public void AddTagForPost(TagForPostViewModel tagForPost);

        public void DeleteTagForPost(int id);

        public List<TagForPostViewModel> GetList();

        public TagForPostViewModel GetById(int id);
    }
}
