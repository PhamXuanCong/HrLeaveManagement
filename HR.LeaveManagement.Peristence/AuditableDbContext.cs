using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Peristence
{
    public abstract class AuditableDbContext : DbContext
    {
        public AuditableDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual async Task<int> SaveChangeAsync(string name = "System")
        {

            var result = await base.SaveChangesAsync();

            return result;
        }
    }
}
