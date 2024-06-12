using System;
using System.Collections.Generic;
using System.Text;
using Hr.LeaveManagement.Domain;

namespace HR.LeaveManagement.Peristence.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>
    {
        private readonly LeaveManagementDbContext _dbContext;

        public LeaveTypeRepository(LeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
