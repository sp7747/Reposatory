using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCrepo.Models;
namespace MVCrepo.Repository
{
    interface IEmployee
    {


        void InsertEmployee(EmployeeDetail Employee); // C

        IEnumerable<EmployeeDetail> GetEmployees(); // R

        EmployeeDetail GetEmployeeByID(int EmployeeId); // R

        void UpdateEmployee(EmployeeDetail Employee); //U

        void DeleteEmployee(int EmployeeId); //D

        void Save();

    }
}
