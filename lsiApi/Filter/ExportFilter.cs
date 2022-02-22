using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lsiApi.Filter
{
    public class ExportFilter
    {
        public DateTime? DateFrom { set; get; }
        public DateTime? DateTo { set; get; }
        public string Place { set; get; }
    }
}
