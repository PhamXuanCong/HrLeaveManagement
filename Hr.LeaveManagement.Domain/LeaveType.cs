using System;
using Hr.LeaveManagement.Domain.Common;

namespace Hr.LeaveManagement.Domain
{
    public class LeaveType:BaseDomainEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
