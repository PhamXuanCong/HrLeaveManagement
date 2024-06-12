using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Hr.LeaveManagement.Application.Features.LeaveTypes.Requets.Commands;
using Hr.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace Hr.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
 {
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly  ILeaveRequestRepository _leaveRequestRepository;

        public CreateLeaveTypeCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _mapper = mapper;
            _leaveRequestRepository = leaveRequestRepository;
        }

        public Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            
        }
    }
}
