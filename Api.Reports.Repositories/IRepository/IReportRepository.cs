using Api.Reports.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Reports.Repositories.IRepository
{
   public interface IReportRepository
    {
        void Add(Report model);
        void Delete(Report model);
        Task<List<Report>> GetAll();
        Task<Report> Get(int id);
    }
}
