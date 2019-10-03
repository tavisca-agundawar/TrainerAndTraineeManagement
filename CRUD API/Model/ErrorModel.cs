using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_API.Model
{
    public class ErrorModel
    {
        public int Status { get; private set; }
        public string Message { get; private set; }

        public ErrorModel(int status, string message)
        {
            Status = status;
            Message = message;
        }
    }
}
