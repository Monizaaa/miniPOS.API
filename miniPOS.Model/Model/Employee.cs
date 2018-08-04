using System;
using System.Collections.Generic;
using System.Text;

namespace miniPOS.Model
{
    public class Employee
    {
        public string username { get; set; }
        public string password { get; set; }
        public string full_name { get; set; }
        public string profile_img { get; set; }
        public DateTime? create_date { get; set; }
        public DateTime? update_date { get; set; }
        public EmployeeDevice employee_device { get; set; }
    }

    public class EmployeeDevice
    {
        public string os { get; set; }
        public string device_key { get; set; }
        public string token {get;set;}
        public bool is_active { get; set; }
        public DateTime? expire_date { get; set; }
    }

    public class EmployeeLog
    {
        public 
    }
}
