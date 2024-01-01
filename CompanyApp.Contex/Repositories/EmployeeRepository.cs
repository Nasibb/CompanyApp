using System;
using CompanyApp.DataContex.Interfaces;
using CompanyApp.Domain.Models.Common;

namespace CompanyApp.DataContex.Repositories
{
	public class EmployeeRepository:IRepository<Employee>
	{
        public bool Create(Employee entity)
        {
            try
            {
                DbContex.Employees.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Employee entity)
        {
            try
            {
                DbContex.Employees.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Employee Get(Predicate<Employee> filter)
        {
            return DbContex.Employees.Find(filter);
        }

        public List<Employee> GetAll(Predicate<Employee> filter =null)
        {
            return filter == null ? DbContex.Employees : DbContex.Employees.FindAll(filter);
        }

        public bool Update(Employee entity)
        {
            try
            {
                var existEmployee = Get(e => e.Id == entity.Id);
                existEmployee = entity;
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

