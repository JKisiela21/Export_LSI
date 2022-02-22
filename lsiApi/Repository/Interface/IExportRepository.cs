using lsiApi.Entity;
using lsiApi.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lsiApi.Repository.Interface
{
    public interface IExportRepository
    {
        List<Export> GetFiltered(ExportFilter filter);
    }
}
