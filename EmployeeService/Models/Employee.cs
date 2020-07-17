using System;
using System.Collections.Generic;

namespace EmployeeService.Models
{
    public partial class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public DateTime JoinDate { get; set; }
        public int? FkPid { get; set; }

        public virtual Project FkP { get; set; }
    }
}
