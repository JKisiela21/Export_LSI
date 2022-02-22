using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lsiApi
{
    public class ApiResult<T> where T:class
    {
        public List<T> rows { set; get; }
        public int total { set; get; }
    }
}
