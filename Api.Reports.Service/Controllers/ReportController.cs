using Api.Reports.Entitiy;
using Api.Reports.Models;
using Api.Reports.Repositories.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Reports.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : Controller
    {
        private readonly IMapper mapper;
        private readonly IReportRepository reportRepository;
        private readonly IFactory factory;
        private readonly IService service;
        public ILogger<ReportController> logger;
        public ReportController(IMapper _mapper, IReportRepository _reportRepository, ILogger<ReportController> _logger, IFactory _factory, IService _service)
        {
            mapper = _mapper;
            reportRepository = _reportRepository;
            factory = _factory;
            service = _service;
            logger = _logger;
        }
        [HttpPost]
        [Route("report-create/{lat}/{lon}")]
        public async Task<IActionResult> Create(string lat,string lon)
        {
            logger.LogError("Rapor oluşturuldu.");
            var phoneCount = service.Get("hotels/hotel-phone-count-get/"+ lat + "/"+ lon);
            var hotelCount = service.Get("hotels/hotel-hotel-count-get/" + lat + "/" + lon);
            var model = new ReportModel() { 
            HotelCount=int.Parse(hotelCount),
            PhoneCount=int.Parse(phoneCount),
            RequestDate=DateTime.Now,
            Status=0,
            Lat=lat,
            Lon=lon
            };
            reportRepository.Add(mapper.Map<Report>(model));
            await factory.SaveChange();
            return Ok("Success");
        }
        [Route("report-getall")]
        public async Task<IActionResult> GetAll()
        {
            logger.LogError("Raporlar listelendi");
            return Ok(mapper.Map<List<ReportModel>>(await reportRepository.GetAll()));
        }
        [Route("report-get")]
        public async Task<IActionResult> Get(int id)
        {
            logger.LogError("Rapor detayı çekildi.");
            return Ok(mapper.Map<ReportModel>(await reportRepository.Get(id)));
        }
    }
}
