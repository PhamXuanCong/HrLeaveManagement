using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Hr.LeaveManagement.Application.Models;

namespace Hr.LeaveManagement.Application.Contracts.Infrastructure
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(Email email);
    }
}
