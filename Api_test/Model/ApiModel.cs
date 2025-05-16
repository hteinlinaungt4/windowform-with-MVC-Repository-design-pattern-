using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_test.Model
{
    public class ApiModel
    {
        public string id { get; set; }

        public string name { get;set; }

        public Dictionary<string,string> data { get; set; }
    }
}
