using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Sabbir",
                    Department = Dept.HR,
                    Email = "shawon.ict@gmail.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Ahmed",
                    Department = Dept.IT,
                    Email = "sabbir.ahmed.dev@gmail.com"
                }
            );
        }
    }
}
