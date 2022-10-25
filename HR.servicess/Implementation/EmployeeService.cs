using HR.entity;
using HR.entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AgriBookContext _context;
        public EmployeeService(AgriBookContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Employee newEmployee)
        {
            //await _context.Employees.AddAsync(newEmployee);
            //await _context.SaveChangesAsync();

            _context.Database.ExecuteSqlRaw("exec spAddNewEmployee {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",


             newEmployee.EmployeeFirstName,
             newEmployee.EmployeeMiddleName,
             newEmployee.EmployeeLastName,
             newEmployee.EmployeeDateOfBirth,
             newEmployee.EmployeePhoneNumber,
             newEmployee.EmployeeFinancialNumber,
             newEmployee.EmployeeAutomatedNumber,
             newEmployee.EmployeeImageUrl,
             newEmployee.EmployeeTaxNumber,
             newEmployee.FkacademicQualificationId,
             newEmployee.FkmaritalStatusId
                );


        }

        public async Task Delete(int EmployeeId)
        
            //var employee = GetById(EmployeeId);
            //_context.Remove(employee);
            //await _context.SaveChangesAsync();
            //_context.Database.ExecuteSqlRaw("EXECUTE DeleteEmployeeById {0}", EmployeeId);
          =>  _context.Database.ExecuteSqlRaw("spDeleteEmployeeById {0}", EmployeeId);
        

        public List<Employee> GetAll() => _context.Employees.FromSqlRaw("spGetAllEmployees").ToList();
        //=> _context.Employees.ToList();

        public Employee GetById(int EmployeeId)
        //  => _context.Employees.OrderBy(e => e.PkemployeeId == EmployeeId).FirstOrDefault();

            => _context.Employees.FromSqlRaw("spGetById {0}", EmployeeId).ToList().FirstOrDefault();



        public async Task UpdateAsync(Employee Employee, int Id)
        {
            //_context.Update(Employee);
            //await _context.SaveChangesAsync();
            _context.Database.ExecuteSqlRaw("exec spUpdateEmployee {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",

           Employee.PkemployeeId,
           Employee.EmployeeFirstName,
           Employee.EmployeeMiddleName,
           Employee.EmployeeLastName,
           Employee.EmployeeDateOfBirth,
           Employee.EmployeePhoneNumber,
           Employee.EmployeeFinancialNumber,
           Employee.EmployeeAutomatedNumber,
           Employee.EmployeeImageUrl,
           Employee.EmployeeTaxNumber,

           Employee.FkacademicQualificationId,
           Employee.FkmaritalStatusId);



        }

        public async Task UpdateAsync(int id)
        {
            var employee = GetById(id);
            _context.Update(employee);
            await _context.SaveChangesAsync();
        }


    }
}
