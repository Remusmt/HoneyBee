using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HoneyBee.ApplicationCore.Interfaces
{
    public interface IMessenger
    {
        Task SendEmailAsync(string email, string subject, string message);
        Task SendSMSasync(string phoneNumber, string message);
    }
}
