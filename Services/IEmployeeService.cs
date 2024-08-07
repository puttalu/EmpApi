// Services/IEmployeeService.cs
using System.Threading.Tasks;
using EmployeeApi.Models;

namespace EmployeeApi.Services
{
    public interface IEmployeeService
    {
        Task<Employee> GetEmployeeByIdAsync(int empId);
        Task AddEmployeeAsync(Employee employee);
        Task UpdateEmployeeAsync(Employee employee);
    }
}
