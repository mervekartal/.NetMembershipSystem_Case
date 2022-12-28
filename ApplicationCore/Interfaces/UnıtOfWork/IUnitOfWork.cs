using ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IMailService MailService { get; }
        int Complete();

    }
}
