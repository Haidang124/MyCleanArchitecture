using MyCleanArchitecture.Application.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCleanArchitecture.Application.Common
{
    public class ApiResponse<T> where T : IResponse
    {
        public dynamic data;
        public string message;
        public ApiResponse(dynamic data, string message)
        {
            this.data = data;
            this.message = message;
        }
    }
}
