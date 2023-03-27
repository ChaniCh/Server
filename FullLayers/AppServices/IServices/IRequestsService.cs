using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface IRequestsService
    {
        public void AddRequest(RequestsViewModel request);

        public void DeleteRequest(int id);

        public RequestsViewModel GetById(int id);

        public List<RequestsViewModel> GetList();

        public void UpdateStatus(int requestId);
    }
}
