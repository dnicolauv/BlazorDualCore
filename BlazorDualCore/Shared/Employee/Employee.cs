using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDualCore.Shared.Data
{
    public class Employee : Person
    {
        public string Title { get; set; }
        public string Department { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }
    }
}
