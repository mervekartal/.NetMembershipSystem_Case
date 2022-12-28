//using ApplicationCore.Interfaces.Repositories;
using ApplicationCore.Interfaces.Services;
using ApplicationCore.Interfaces.UnitOfWork;
using Case.ApplicationCore.Interfaces.Repositories;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Infrastructure.UOW;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class InfraServiceRegistration
    {

        public static void AddInfraServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IAsyncRepository<>), typeof(AsyncRepository<>));
            serviceCollection.AddScoped<IMailService, MailService>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
        }

    }
}
