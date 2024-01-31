using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Models.DataModels;

namespace DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private DataContext _db;
        public CompanyRepository(DataContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}