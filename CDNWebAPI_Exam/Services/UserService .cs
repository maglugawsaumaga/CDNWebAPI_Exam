using CDNWebAPI_Exam.Data;
using CDNWebAPI_Exam.Models;
using CDNWebAPI_Exam.Services.IInterfaces;
using Dapper;

namespace CDNWebAPI_Exam.Services
{
    public class UserService : IUserService
    {
        private readonly DapperContext _context;

        public UserService(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Users>> GetAllUsersAsync()
        {
            var query = "SELECT * FROM Users";

            using (var connection = _context.CreateConnection())
            {
                var users = await connection.QueryAsync<Users>(query);
                return users;
            }
        }

        public async Task<Users> GetUserByIdAsync(int id)
        {
            var query = "SELECT * FROM Users WHERE Id = @Id";

            using (var connection = _context.CreateConnection())
            {
                var user = await connection.QuerySingleOrDefaultAsync<Users>(query, new { Id = id });
                return user;
            }
        }

        public async Task<Users> CreateUserAsync(Users user)
        {
            var query = "INSERT INTO Users (Username, Email, PhoneNumber, Skillsets, Hobby) " +
                        "VALUES (@Username, @Email, @PhoneNumber, @Skillsets, @Hobby);" +
                        "SELECT CAST(SCOPE_IDENTITY() as int);";

            using (var connection = _context.CreateConnection())
            {
                var id = await connection.QuerySingleAsync<int>(query, user);
                user.Id = id;
                return user;
            }
        }

        public async Task<bool> UpdateUserAsync(int id, Users updatedUser)
        {
            var query = "UPDATE Users SET Username = @Username, Email = @Email, " +
                        "PhoneNumber = @PhoneNumber, Skillsets = @Skillsets, Hobby = @Hobby " +
                        "WHERE Id = @Id";

            using (var connection = _context.CreateConnection())
            {
                var result = await connection.ExecuteAsync(query, new
                {
                    Id = id,
                    updatedUser.Username,
                    updatedUser.Email,
                    updatedUser.PhoneNumber,
                    updatedUser.Skillsets,
                    updatedUser.Hobby
                });
                return result > 0;
            }
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var query = "DELETE FROM Users WHERE Id = @Id";

            using (var connection = _context.CreateConnection())
            {
                var result = await connection.ExecuteAsync(query, new { Id = id });
                return result > 0;
            }
        }
    }
}
