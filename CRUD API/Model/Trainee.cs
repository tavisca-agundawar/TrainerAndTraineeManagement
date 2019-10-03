using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_API.Model;
namespace CRUD_API.Model
{
    public class Trainee : Employee
    {
        public int BatchNumber { get; set; }
    }
}
