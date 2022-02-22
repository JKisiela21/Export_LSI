using lsiApi.Entity;
using lsiApi.Filter;
using lsiApi.Repository;
using lsiApi.Repository.Interface;
using lsiApi.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lsiApi.Service
{
    public class ExportService : IExportService
    {
        private readonly IExportRepository _exportRepository;

        public ExportService(LsiDbContext context)
        {
            _exportRepository = new ExportRepository(context);
        }

        public ApiResult<Export> GetFiltered(ExportFilter filter)
        {
            var list = _exportRepository.GetFiltered(filter);

            return new ApiResult<Export>() { rows = list, total = list.Count };
        }
    }
}
