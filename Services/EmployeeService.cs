
using System.Threading.Tasks;
using EmployeeApi.Models;
using EmployeeApi.Repositories;

namespace EmployeeApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> GetEmployeeByIdAsync(int empId)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(empId);
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            await _employeeRepository.AddEmployeeAsync(employee);
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            await _employeeRepository.UpdateEmployeeAsync(employee);
        }
    }
}
