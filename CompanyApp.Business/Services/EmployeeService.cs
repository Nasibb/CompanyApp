using System;
using CompanyApp.Business.Interfaces;
using CompanyApp.DataContex.Repositories;
using CompanyApp.Domain.Models.Common;

namespace CompanyApp.Business.Services
{
    public class EmployeeService : IEmployee
    {
        private readonly EmployeeRepository _employeeRepository;
        private readonly DepartmentRepository _departmentRepository;
        private static int Count = 1;

        public EmployeeService()
        {
            _employeeRepository = new();
            _departmentRepository = new();
        }

        public Employee Create(Employee employee, string departmentName)
        {
            var existDepartment = _departmentRepository.
                Get(d=>d.Name.ToLower()==departmentName.ToLower());
            if (existDepartment is  null) return null;
            employee.Id = Count;
            employee.Department = existDepartment;
           bool result= _employeeRepository.Create(employee);
            if (!result) return null;
            Count++;
            return employee;
        }




        public Employee Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll(int age)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll(Department departmentName)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll(string name)
        {
            throw new NotImplementedException();
        }

        public Employee Update(int id, Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}

