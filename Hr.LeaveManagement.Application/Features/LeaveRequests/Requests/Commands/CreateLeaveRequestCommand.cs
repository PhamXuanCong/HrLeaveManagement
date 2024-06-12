using Hr.LeaveManagement.Application.Features.LeaveTypes.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Hr.LeaveManagement.Application.DTOs.LeaveRequest;

namespace Hr.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}
