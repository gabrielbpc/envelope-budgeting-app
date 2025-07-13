namespace EnvelopeBudgeting.Api.Domain.Interfaces
{
    public abstract class IUseCase<TCommandRequest> where TCommandRequest : class
    {
        public abstract Task<TCommandResponse> SendAsync<TCommandResponse>(TCommandRequest command, CancellationToken cancellationToken);
        public abstract Task SendAsync(TCommandRequest command, CancellationToken cancellationToken);
    }
}
