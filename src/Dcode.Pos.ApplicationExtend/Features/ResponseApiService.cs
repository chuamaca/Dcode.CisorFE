using Dcode.Pos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dcode.Pos.ApplicationExtend.Features
{
    public static class ResponseApiService
    {
        public static BaseResponseModel Response(
            int statusCode, object Data = null, string message = null)
        {
            bool success = false;

            if (statusCode >= 200 && statusCode < 300)
                success = true;

            var result = new BaseResponseModel
            {
                StatusCode = statusCode,
                Success = success,
                Message = message,
                Data = Data
            };

            return result;
        }
    }
}
