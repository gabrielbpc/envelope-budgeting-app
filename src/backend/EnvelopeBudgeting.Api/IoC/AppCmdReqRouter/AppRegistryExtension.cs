using EnvelopeBudgeting.Api.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace EnvelopeBudgeting.Api.IoC.AppCmdReqRouter
{
    public static class AppRegistryExtension
    {
        public static void AddAppRequests<TCommandRequest>(this IServiceCollection services) where TCommandRequest : IUseCase<TCommandRequest>
        {
            services.TryAddScoped(typeof(IUseCase<TCommandRequest>));
        }
    }
}
