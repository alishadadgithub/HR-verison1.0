using HR.entity.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.services
{
    public interface IEmployeeService
    {
        Task CreateAsync(Employee newEmployee);

        Employee GetById(int employeeId);

        Task UpdateAsync(Employee Employee , int Id);

        Task UpdateAsync(int id);

        Task Delete(int employeeId);

        List<Employee> GetAll();
    }
}
