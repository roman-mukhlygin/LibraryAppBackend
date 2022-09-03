namespace Library.Infrastructure.UoW
{
    public interface IUnitOfWork
    {
        public Task<bool> SaveEntitiesAsync();
    }
}
