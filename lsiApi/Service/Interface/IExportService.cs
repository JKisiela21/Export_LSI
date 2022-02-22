using lsiApi.Entity;
using lsiApi.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lsiApi.Service.Interface
{
    public interface IExportService
    {
        ApiResult<Export> GetFiltered(ExportFilter filter);
    }
}
