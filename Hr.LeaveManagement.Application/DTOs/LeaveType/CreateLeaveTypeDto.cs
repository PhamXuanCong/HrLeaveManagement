using System;
using System.Collections.Generic;
using System.Text;

namespace Hr.LeaveManagement.Application.DTOs.LeaveType
{
    public class CreateLeaveTypeDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
