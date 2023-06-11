using DTO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.ModelServices;
using Services.ModelServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validators;

namespace Configuration;

public static class ServiceConfiguration
{
    public static IServiceCollection AddServiceConfiguration(this IServiceCollection services, IConfiguration config)
    {
        services.AddTransient<IAccountsService, AccountsService>();

        services.AddTransient<IGamesServices, GamesServices>();

        services.AddTransient<IReviewsService, ReviewsService>();

        return services;
    }
}
