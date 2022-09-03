namespace LibraryAppBackend.Infrastructure.UoW
{
    public interface IUnitOfWork
    {
        public Task<bool> SaveEntitiesAsync();
    }
}
