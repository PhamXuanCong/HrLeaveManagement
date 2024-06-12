using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Hr.LeaveManagement.Application.DTOs;
using Hr.LeaveManagement.Application.DTOs.LeaveRequest;
using Hr.LeaveManagement.Application.DTOs.LeaveType;
using Hr.LeaveManagement.Domain;

namespace Hr.LeaveManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        }
    }
}
