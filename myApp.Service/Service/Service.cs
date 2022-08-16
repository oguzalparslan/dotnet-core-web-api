
using Microsoft.EntityFrameworkCore;
using myApp.Core.Repositories;
using myApp.Core.Services;
using myApp.Core.UnitOfWork;

namespace myApp.Service.Service
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IGenericRepository<T> genericRepository;

        public Service(IUnitOfWork unitOfWork, IGenericRepository<T> genericRepository)
        {
            this.unitOfWork = unitOfWork;
            this.genericRepository = genericRepository;
        }

        public async Task<T> AddAsync(T entity)
        {
            await genericRepository.AddAsync(entity);
            await unitOfWork.CommitAsync();
            return entity;
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await genericRepository.GetAll().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {

            return await genericRepository.GetByIdAsync(id);
        }

        public async void RemoveAsync(T entity)
        {
            genericRepository.Remove(entity);
            await unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            genericRepository.Update(entity);
            await unitOfWork.CommitAsync();
        }
    }
}
