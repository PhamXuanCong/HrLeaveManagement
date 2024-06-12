using System;
using System.Collections.Generic;
using System.Text;
using Hr.LeaveManagement.Application.DTOs.Common;

namespace Hr.LeaveManagement.Application.DTOs.LeaveType
{
    public class LeaveTypeDto : BaseDto, ILeaveTypeDto
    {
        public string Name { get; set; }

        public int DefaultDays { get; set; }
    }
}
