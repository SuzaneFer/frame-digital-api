using FrameDigitalApi.Business;
using FrameDigitalApi.Business.Interface;
using FrameDigitalApi.Repository;
using FrameDigitalApi.Repository.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace FrameDigitalApi.Injection
{
    public static class Injection
    {
        public static void InjectDependencies(this IServiceCollection services)
        {
            services.AddScoped<ISampleBusiness, SampleBusiness>();
            services.AddScoped<ISampleRepository, SampleRepository>();
        }
    }
}
