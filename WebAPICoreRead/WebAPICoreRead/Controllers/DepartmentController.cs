using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrgDAL;

namespace WebAPICoreRead.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class DepartmentController : Controller
    {
        DepartmentDbContext dbContext;
        public DepartmentController(DepartmentDbContext departmentDb)
        {
            this.dbContext = departmentDb;
        }
        public  IEnumerable<Department> GetDepartments()
        {
            throw new Exception();
            return dbContext.departments.ToList();

        }
        [HttpGet("{id}")]
        public Department GetDepartment(int id)
        {
            return dbContext.departments.Where(i => i.DeptID == id).FirstOrDefault();



        }
        [HttpPost]
        public Department InsertDepartment(Department department )
        {
            dbContext.departments.Add(department);
            dbContext.SaveChanges();
            return department;
        }
    }
}