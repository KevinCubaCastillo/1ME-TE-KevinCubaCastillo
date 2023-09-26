using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Data_Contract
{
    public class Response
    {
        public int errorCode { get; set; }
        public string description { get; set; }
        public string message { get; set; }
        public object data { get; set; }
    }
}
