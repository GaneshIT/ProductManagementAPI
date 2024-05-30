using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementBusiness.Response
{
    public class ProductResponse
    {
        public object? response { get; set; }
        public int statusCode { get; set; }
        public string? message { get; set; }
    }
}
