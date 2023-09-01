using Repository.Interfaces;
using Repository.Repositories;
using Repository.Repositories.Context;
using Service.Interfaces;
using Service.Services;

namespace RestorantProje.Extensions
{
    public static class ServiceExtension
    {

        public static void MyconfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IAboutRepository, AboutRepository>();

            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<IMenuRepository, MenuRepository>();

            services.AddScoped<IHizmetService, HizmetService>();
            services.AddScoped<IHizmetRepository, HizmetRepository>();

            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<ITeamRepository, TeamRepository>();

            services.AddScoped<ITestimonialService, TestimanialServices>();
            services.AddScoped<ITestimaonialRepository, TestimaonialRepository>();

            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<IBookingRepository, BookingRepository>();

            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IContactRepository, ContactRepository>();



        }
    }
}
