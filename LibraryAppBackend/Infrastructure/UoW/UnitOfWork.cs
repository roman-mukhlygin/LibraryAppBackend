using LibraryAppBackend.Infrastructure.Data;

namespace LibraryAppBackend.Infrastructure.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryContext _dbContext;
        public UnitOfWork( LibraryContext dbContext )
        {
            _dbContext = dbContext;
        }
        public async Task<bool> SaveEntitiesAsync()
        {
            return await _dbContext.SaveEntitiesAsync();
        }
    }
}
