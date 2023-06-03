using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Reports.Entitiy
{
    public class ReportDbContext : DbContext
    {
        public ReportDbContext(DbContextOptions<ReportDbContext> options) : base(options)
        {

        }
        public DbSet<Report> Reports { get; set; }
    }
}
