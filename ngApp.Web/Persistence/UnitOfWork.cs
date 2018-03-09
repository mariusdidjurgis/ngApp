using ngApp.Web.Interfaces.Repositories.Vehicles;
using ngApp.Web.Persistence.Repositories;
using ngApp.Web.Persistence.Repositories.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngApp.Web.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IFeatureRepository Features { get; }
        IModelRepository Model { get; }
        IMakeRepository Make { get; }
        int Complete();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly NgAppDbContext _context;
        public IFeatureRepository Features { get; private set; }
        public IModelRepository Model { get; private set; }
        public IMakeRepository Make { get; private set; }

        public UnitOfWork(NgAppDbContext context)
        {
            _context = context;
            Features = new FeatureRepository(_context);
            Model = new ModelRepository(_context);
            Make = new MakeRepository(_context);
        }        

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
