using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace miniPOS.Model
{
    public static class miniPOS_Enum
    {
        public enum DOC_FLAG
        {
            [Description("Draft")]
            DRAFT = 0,

            [Description("Open")]
            OPEN = 100,

            [Description("Active")]
            ACTIVE = 300,

            [Description("Complete")]
            COMPLETE = 500,

            [Description("Complete")]
            INACTIVE = -300,

            [Description("Delete")]
            DELETE = -500
        }

        public enum USER_STATUS
        {
            [Description("Active")]
            ACTIVE = 300,

            [Description("InActive")]
            OPEN = -300,
        }

        public enum USER_TYPE
        {
            [Description("System Admin")]
            SYSTEM_ADMIN = 0,

            [Description("Ownner")]
            OWNNER = 100,

            [Description("Employee")]
            EMPLOYEE = 200,
        }
    }
}
