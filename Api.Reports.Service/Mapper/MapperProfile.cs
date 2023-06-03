using Api.Reports.Entitiy;
using Api.Reports.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Reports.Service.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Report, ReportModel>();
            CreateMap<ReportModel, Report>();
        }
    }
}
