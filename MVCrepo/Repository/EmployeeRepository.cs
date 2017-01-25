using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCrepo.Models;
using System.Data;
using System.Data.Entity;

namespace MVCrepo.Repository
{



    public class EmployeeRepository : IEmployee
    {
        private EmployeeDBEntities db;


        public EmployeeRepository() 
        { 
        db = new EmployeeDBEntities();
        
        }

        public EmployeeRepository(EmployeeDBEntities objempcontext)
        {

            this.db = objempcontext;

        }

        public void InsertEmployee(Models.EmployeeDetail Employee)
        {

            db.EmployeeDetails.Add(Employee);

            db.SaveChanges();

        }

        public IEnumerable<Models.EmployeeDetail> GetEmployees()
        {

            return db.EmployeeDetails.ToList();

           

        }

        public Models.EmployeeDetail GetEmployeeByID(int EmployeeId)
        {

            return db.EmployeeDetails.Find(EmployeeId);

        }

        public void UpdateEmployee(Models.EmployeeDetail Employee)
        {

            db.Entry(Employee).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();

        }

        public void DeleteEmployee(int EmployeeId)
        {

            EmployeeDetail user = db.EmployeeDetails.Find(EmployeeId);

            db.EmployeeDetails.Remove(user);

            db.SaveChanges();
        
        }

        public void Save() {

            db.SaveChanges();
        
        }
    }

}