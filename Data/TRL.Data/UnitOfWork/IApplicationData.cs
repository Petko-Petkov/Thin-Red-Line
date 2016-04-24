namespace TRL.Data.UnitOfWork
{
    using Contracts.Repository;
    using Models;

    public interface IApplicationData
    {
        IRepository<User> Users { get; }

        int SaveChanges();
    }
}
