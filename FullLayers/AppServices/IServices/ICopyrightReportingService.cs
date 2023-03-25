using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface ICopyrightReportingService
    {
        public void AddCopyrightReporting(CopyrightReportingViewModel copyrightReporting);

        public void DeleteCopyrightReporting(int id);

        public List<CopyrightReportingViewModel> GetList();

        public CopyrightReportingViewModel GetById(int id);
    }
}
