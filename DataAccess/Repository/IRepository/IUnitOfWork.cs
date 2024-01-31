namespace DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        IApplicationUserRepository ApplicationUser { get; }
        ICompanyRepository Company { get; }

        Task Save();
    }
}
