using lsiApi.Entity;
using lsiApi.Filter;
using lsiApi.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lsiApi.Repository
{
    public class ExportRepository : IExportRepository
    {
        private readonly LsiDbContext _contextDb;

        public ExportRepository(LsiDbContext contextDb)
        {
            _contextDb = contextDb;
        }

        public List<Export> GetFiltered(ExportFilter filter)
        {
            return _contextDb.Exports.Where(x =>

                (filter.DateFrom == null || x.ExportDate >= filter.DateFrom) &&
                (filter.DateTo == null || x.ExportDate <= filter.DateTo) &&
                (string.IsNullOrEmpty(filter.Place) || x.Place.Equals(filter.Place))

            ).ToList();
        }
    }
}
