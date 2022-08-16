using myApp.Core.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace myApp.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await Task.Run(() =>
            {
                _context.SaveChangesAsync();
            });
        }
    }
}
