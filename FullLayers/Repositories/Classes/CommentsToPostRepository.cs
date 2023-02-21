using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class CommentsToPostRepository : ICommentsToPostRepository
    {
        LibraryContext context;

        public CommentsToPostRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(CommentsToPost obj)
        {
            context.CommentsToPost.Add(obj);
        }

        public void Delete(int id)
        {
            context.CommentsToPost.Remove(context.CommentsToPost.First(c => c.Id == id));
            context.SaveChanges();
        }

        public List<CommentsToPost> GetAll()
        {
            return context.CommentsToPost.ToList();
        }

        public CommentsToPost GetById(int id)
        {
            return context.CommentsToPost.First(c => c.Id == id);
        }

        public void Update(CommentsToPost obj)
        {
            context.CommentsToPost.Update(obj);
        }
    }
}
