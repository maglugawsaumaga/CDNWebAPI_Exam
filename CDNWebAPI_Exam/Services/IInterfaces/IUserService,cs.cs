using CDNWebAPI_Exam.Models;

namespace CDNWebAPI_Exam.Services.IInterfaces
{
    public interface IUserService
    {
        Task<IEnumerable<Users>> GetAllUsersAsync();
        Task<Users> GetUserByIdAsync(int id);
        Task<Users> CreateUserAsync(Users user);
        Task<bool> UpdateUserAsync(int id, Users updatedUser);
        Task<bool> DeleteUserAsync(int id);
    }
}
