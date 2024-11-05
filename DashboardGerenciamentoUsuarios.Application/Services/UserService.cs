using DashboardGerenciamentoUsuarios.Application.Helpers;
using DashboardGerenciamentoUsuarios.Core.Entities;
using DashboardGerenciamentoUsuarios.Core.Interfaces;

namespace DashboardGerenciamentoUsuarios.Application.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task AddUserAsync(User user)
        {
            user.PasswordHash = PasswordHasher.HashPassword(user.PasswordHash);
            await _userRepository.AddUserAsync(user);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _userRepository.GetUserByEmailAsync(email);
        }
    }
}
