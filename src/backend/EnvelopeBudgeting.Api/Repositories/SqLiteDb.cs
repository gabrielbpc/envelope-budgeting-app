using EnvelopeBudgeting.Api.Domain.Interfaces;
using EnvelopeBudgeting.Api.Domain.Settings;
using Microsoft.Extensions.Options;

namespace EnvelopeBudgeting.Api.Repositories
{
    public class SqLiteDb<T> : IRepository<T> where T : class
    {
        private readonly DatabaseSettings _dbConfig;

        public SqLiteDb(IOptions<DatabaseSettings> config)
        {
            _dbConfig = config.Value;
        }

        public Task<T> GetAllAsync(int take, int skip, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<T> SaveAsync(T entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(Guid id, T entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
