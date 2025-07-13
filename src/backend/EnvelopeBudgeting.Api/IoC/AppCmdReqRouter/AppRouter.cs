using EnvelopeBudgeting.Api.Domain.Interfaces;

namespace EnvelopeBudgeting.Api.IoC.AppCmdReqRouter
{
    public sealed class AppRouter(IServiceProvider services)
    {
        private readonly IServiceProvider _services = services;

        public async Task<TCommandResponse> SendAsync<TCommandRequest, TCommandResponse>(TCommandRequest command, CancellationToken cancellationToken)
            where TCommandRequest : IUseCase<TCommandRequest>
        {
            var svc = _services.GetRequiredService<IUseCase<TCommandRequest>>();

            return await svc.SendAsync<TCommandResponse>(command, cancellationToken);
        }
        public async Task SendAsync<TCommandRequest>(TCommandRequest command, CancellationToken cancellationToken) where TCommandRequest : IUseCase<TCommandRequest>
        {
            var svc = _services.GetRequiredService<IUseCase<TCommandRequest>>();

            await svc.SendAsync(command, cancellationToken);
        }
    }
}
