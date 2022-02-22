using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lsiApi.Entity
{
    public class Export
    {
        public int ID { set; get; }
        public string ExportName { set; get; }
        public DateTime ExportDate { set; get; }
        public string UserName { set; get; }
        public string Place { set; get; }
    }
}
