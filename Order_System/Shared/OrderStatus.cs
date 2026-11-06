using System;
using System.Collections.Generic;
using System.Text;

namespace Order_System.Shared
{
    public enum OrderStatus
    {
        Pending,
        Validated,
        Rejected,
        Completed,
        Failed
    }
}
