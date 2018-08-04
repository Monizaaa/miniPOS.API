using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using static miniPOS.Model.miniPOS_Enum;

namespace miniPOS.Model
{
    public class Employee
    {
        [BsonId]
        public ObjectId ID { get; set; }

        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("full_name")]
        public string FullName { get; set; }

        [BsonElement("profile_img")]
        public string ProfileImg { get; set; }

        [BsonElement("create_date")]
        public DateTime? CreateDate { get; set; }

        [BsonElement("update_date")]
        public DateTime? UpdateDate { get; set; }

        [BsonElement("employee_devices")]
        public EmployeeDevice EmployeeDevices { get; set; }

        [BsonElement("status")]
        public USER_STATUS Status { get; set; }
    }

    public class EmployeeDevice
    {
        [BsonId]
        public ObjectId ID { get; set; }

        [BsonElement("os")]
        public string OS { get; set; }

        [BsonElement("device_key")]
        public string DeviceKey { get; set; }

        [BsonElement("token")]
        public string Token {get;set;}

        [BsonElement("is_active")]
        public bool IsActive { get; set; }

        [BsonElement("expire_date")]
        public DateTime? ExpireDate { get; set; }
    }

    public class EmployeeLog
    {
        [BsonId]
        public ObjectId ID { get; set; }
        [BsonElement("event_name")]
        public string EventName { get; set; }
        [BsonElement("create_date")]
        public DateTime? CreateDate { get; set; }
    }
}
