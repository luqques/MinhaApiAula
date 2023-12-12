using MinhaApiAula.Contracts.Repository;
using MinhaApiAula.Entity;
using MinhaApiAula.Infrastructure;
using Dapper;
using MinhaApiAula.DTO;

namespace MinhaApiAula.Repository
{
    public class UserRepository : Connection, IUserRepository
    {
        public async Task Add(UserDTO user)
        {
            string sql = @"
                INSERT INTO USER (Name, Email, Password)
                            VALUE (@Name, @Email, @Password)
            ";
            await Execute(sql, user);
        }

        public async Task Delete(int id)
        {
            string sql = @"DELETE FROM USER WHERE Id = @id";
            await Execute(sql, new { id });
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

        public async Task Update(UserEntity user)
        {
            string sql = @"
                UPDATE USER 
                    SET Name = @Name, 
                        Email = @Email, 
                        Password = @Password
                    WHERE Id = @Id
            ";
            await Execute(sql, user);
        }
    }
}
