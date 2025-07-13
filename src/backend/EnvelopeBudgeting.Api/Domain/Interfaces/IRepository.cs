namespace EnvelopeBudgeting.Api.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> UpdateAsync(Guid id, T entity, CancellationToken cancellationToken);
        Task<T> SaveAsync(T entity, CancellationToken cancellationToken);
        Task<T> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<T> GetAllAsync(int take, int skip, CancellationToken cancellationToken);
    }
}
