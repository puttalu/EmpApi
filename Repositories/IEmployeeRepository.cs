using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeApi.Models;

namespace EmployeeApi.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployeeByIdAsync(int empId);
        Task AddEmployeeAsync(Employee employee);
        Task UpdateEmployeeAsync(Employee employee);
    }
}