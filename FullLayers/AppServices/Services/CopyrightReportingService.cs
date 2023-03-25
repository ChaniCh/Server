using AppServices.IServices;
using AutoMapper;
using Common.ViewModels;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Services
{
    public class CopyrightReportingService : ICopyrightReportingService
    {
        ICopyrightReportingRepository repository;
        IMapper mapper;

        public CopyrightReportingService(ICopyrightReportingRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddCopyrightReporting(CopyrightReportingViewModel copyrightReporting)
        {
            repository.Create(mapper.Map<CopyrightReporting>(copyrightReporting));
        }

        public void DeleteCopyrightReporting(int id)
        {
            repository.Delete(id);
        }

        public CopyrightReportingViewModel GetById(int id)
        {
            CopyrightReporting copyrightReporting = repository.GetById(id);
            return mapper.Map<CopyrightReportingViewModel>(copyrightReporting);
        }

        public List<CopyrightReportingViewModel> GetList()
        {
            List<CopyrightReportingViewModel> copyrightReportingViewModels = new List<CopyrightReportingViewModel>();
            foreach(var copyrightReporting in GetList())
            {
                copyrightReportingViewModels.Add(mapper.Map<CopyrightReportingViewModel>(copyrightReporting));
            }
            return copyrightReportingViewModels;
        }
    }
}
