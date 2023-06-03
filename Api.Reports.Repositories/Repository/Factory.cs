using Api.Reports.Entitiy;
using Api.Reports.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Reports.Repositories.Repository
{
    public class Factory : IFactory
    {
        ReportDbContext db;
        public Factory(ReportDbContext _db)
        {
            db = _db;
        }
        public async Task SaveChange()
        {
            await db.SaveChangesAsync();
        }
    }
}
