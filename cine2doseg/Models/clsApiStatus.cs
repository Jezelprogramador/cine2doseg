using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cine2doseg.Models
{
    public class clsApiStatus
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        // Constructor sin parámetros
        public clsApiStatus()
        {
        }

        // Constructor con parámetros
        public clsApiStatus(int status, string message, object data = null)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }


}