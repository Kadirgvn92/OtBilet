using FluentValidation.AspNetCore;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using OtBilet.BusinessLayer.Abstract;
using OtBilet.BusinessLayer.Concrete;
using OtBilet.DAL.Abstract;
using OtBilet.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtBilet.DTOLayer.SeatDTO;
using OtBilet.BusinessLayer.ValidationRules;
using OtBilet.EntityLayer;

namespace OtBilet.BusinessLayer.Container;
public static class Extension
{
    public static void ContainerDependencies(this IServiceCollection services)
    {

        services.AddScoped<IBusService, BusManager>();
        services.AddScoped<IBusDal, EfBusDal>();

        services.AddScoped<IDestinationService, DestinationManager>();
        services.AddScoped<IDestinationDal, EfDestinationDal>();

        services.AddScoped<ITicketService, TicketManager>();
        services.AddScoped<ITicketDal, EfTicketDal>();

        services.AddScoped<IPassengerService, PassengerManager>();
        services.AddScoped<IPassengerDal, EfPassengerDal>();

        services.AddScoped<IBusService, BusManager>();
        services.AddScoped<IBusDal, EfBusDal>();

        services.AddScoped<ISeatService, SeatManager>();    
        services.AddScoped<ISeatDal, EfSeatDal>();

        services.AddFluentValidationAutoValidation(config =>
        {
            config.DisableDataAnnotationsValidation = true;
        });

        services.AddValidatorsFromAssemblyContaining<TicketValidator>();

    }
}
