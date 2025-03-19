using EmployeeManagementApi.DTOs;

namespace EmployeeManagementApi.Services
{
    public interface IAuthService
    {
        Task<string> RegisterAsync(RegisterDto registerDto);
        Task<string> LoginAsync(LoginDto loginDto);
    }
}