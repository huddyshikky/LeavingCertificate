using LeavingCertificate.DataAccess;
using LeavingCertificate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeavingCertificate.Services
{
    public class StudentService
    {
        StudentDataAccess _StudentDataAccess = new StudentDataAccess();

        public bool Add(Student student)
        {
            return _StudentDataAccess.Add(student);
        }

        public Student GetOne(int Id)
        {
            return _StudentDataAccess.GetOne(Id);
        }
        public List<Student> GetAll()
        {
            return _StudentDataAccess.GetAll();
        }
        public bool Update(Student student)
        {
            return _StudentDataAccess.Update(student);
        }
        public bool Delete(int Id)
        {
            return _StudentDataAccess.Delete(Id);
        }
    }
}
