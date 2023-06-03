using Api.Reports.Entitiy;
using Api.Reports.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Reports.Repositories.Repository
{
    public class ReportRepository : IReportRepository
    {
        ReportDbContext db;
        public ReportRepository(ReportDbContext _db)
        {
            db = _db;
        }
        public void Add(Report model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Report model)
        {
            throw new NotImplementedException();
        }

        public Task<Report> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Report>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
