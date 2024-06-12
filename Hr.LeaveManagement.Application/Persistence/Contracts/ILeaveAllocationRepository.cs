using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Hr.LeaveManagement.Domain;

namespace Hr.LeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id);
        Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails();
        Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails(string userId);

        Task<bool>AllocationExists(string userId, int leaveTypeId, int period);

        Task Addllocations(List<LeaveAllocation> allocations);
        Task<LeaveAllocation> GetUserAllocations(string userId, int leaveTypeId);
    }
}
