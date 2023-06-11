using DTO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validators;
using Validators.ValidatorsModels;

namespace Configuration;

public static class ValidatorConfiguration
{
    public static IServiceCollection AddValidatorConfiguration(this IServiceCollection services, IConfiguration config)
    {
        services.AddTransient<IValidator<AccountsDTO>, AccountsValidator>();

        services.AddTransient<IValidator<GamesDTO>, GamesValidator>();

        services.AddTransient<IValidator<ReviewsDTO>, ReviewsValidator>();

        return services;
    }
}