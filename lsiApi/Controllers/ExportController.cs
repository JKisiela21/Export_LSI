using lsiApi.Filter;
using lsiApi.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lsiApi.Controllers
{
    [Route("api/[controller]")]
    public class ExportController : ControllerBase
    {
        private readonly IExportService _exportService; 

        public ExportController(IExportService exportService)
        {
            _exportService = exportService;
        }

        [HttpGet]
        public ActionResult GetFiltered([FromQuery] ExportFilter filter)
        {
            return Ok(_exportService.GetFiltered(filter));
        }
    }
}
