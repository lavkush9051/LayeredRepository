using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using EmployeeRepositories.Data;
using EmployeeRepositories.DTO;

namespace EmployeeRepositories
{
    
    public class EmployeeRepository:IEmployeeRepository
    {
        EfCoreDbContext db = new EfCoreDbContext();

        public EmployeeRepository(EfCoreDbContext context)
        {
            this.db = context;
        }

        public EmployeeRepository()
        {

        }
        public List<EmployeeDTO> GetEmployees()
        {
            Employee emp = new Employee();
            var query = db.Employees.Select(e => new EmployeeDTO
            {
                EmployeeName = e.EmployeeName,
                DepartmentName = e.Department.DepartmentName,
                Salary = e.Salary,
                EmployeeId = e.EmployeeId,
                JoinDate = e.JoinDate,
            }).ToList();

            //emp.Department = emp.DepartmentId.Value;
            //return db.Employees.ToList();
            return query;
        }
        public void UpdateEmployees(string name, int salary) { 
            //Employee emp = new Employee();
            
        }
    }
}
