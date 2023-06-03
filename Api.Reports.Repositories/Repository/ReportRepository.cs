using Api.Reports.Entitiy;
using Api.Reports.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            db.Reports.Add(model);
        }

        public void Delete(Report model)
        {
            var entity = db.Entry(model);
            entity.State = EntityState.Deleted;
        }

        public async Task<Report> Get(int id)
        {
            return await db.Reports.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Report>> GetAll()
        {
            return await db.Reports.ToListAsync();
        }
    }
}
