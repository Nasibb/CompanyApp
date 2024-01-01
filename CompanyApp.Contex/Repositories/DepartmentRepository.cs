using System;
using CompanyApp.DataContex.Interfaces;
using CompanyApp.Domain.Models.Common;

namespace CompanyApp.DataContex.Repositories
{
    public class DepartmentRepository : IRepository<Department>
    {
        public bool Create(Department entity)
        {
            try
            {
                DbContex.Departments.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Department entity)
        {
            try
            {
                DbContex.Departments.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Department Get(Predicate<Department> filter)
        {
            return DbContex.Departments.Find(filter);
        }

        public List<Department> GetAll(Predicate<Department> filter = null)
        {
            return filter == null ? DbContex.Departments : DbContex.Departments.FindAll(filter);
        }

        public bool Update(Department entity)
        {
            try
            {
                var existDepartment = Get(d => d.Id == entity.Id);
                existDepartment = entity;
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}

