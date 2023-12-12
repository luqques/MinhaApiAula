using MinhaApiAula.Entity;

namespace MinhaApiAula.Contracts.Repository
{
    public interface IUserRepository
    {
        Task Add(UserEntity user);
        Task Update(UserEntity user);
        Task Delete(int id);
        Task<UserEntity> GetById(int id);
        Task<IEnumerable<UserEntity>> Get();
    }
}
