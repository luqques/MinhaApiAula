using MinhaApiAula.Contracts.Repository;
using MinhaApiAula.Entity;
using MinhaApiAula.Infrastructure;
using Dapper;

namespace MinhaApiAula.Repository
{
    public class UserRepository : Connection, IUserRepository
    {
        public Task Add(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserEntity>> Get()
        {
            string sql = "SELECT * FROM USER";
            return await GetConnection().QueryAsync<UserEntity>(sql);
        }

        public Task<UserEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}
