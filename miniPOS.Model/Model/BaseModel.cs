using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using static miniPOS.Model.miniPOS_Enum;

namespace miniPOS.Model
{
    class BaseModel
    {
    }

    public class Audit
    {
        [BsonId]
        public ObjectId ModifyBy { get; set; }
        public string ModifyName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int RowVersion { get; set; }
        public DOC_FLAG DocFlag { get; set; }
    }
}
