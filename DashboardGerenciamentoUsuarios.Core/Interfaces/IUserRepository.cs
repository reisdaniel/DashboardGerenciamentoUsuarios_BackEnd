using DashboardGerenciamentoUsuarios.Core.Entities;

namespace DashboardGerenciamentoUsuarios.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmailAsync(string email);
        Task AddUserAsync(User user);

    }
}
