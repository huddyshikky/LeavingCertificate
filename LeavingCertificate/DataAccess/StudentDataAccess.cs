using LeavingCertificate.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeavingCertificate.DataAccess
{
    public class StudentDataAccess
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public bool Add(Student student)
        {
            using (db)
            {
                try
                {
                    db.Students.Add(student);
                    return db.SaveChanges() > 0;
                }
                catch (Exception ex)
                {

                    throw;
                }
                
            }

        }
        public Student GetOne(int Id)
        {
            return db.Students
                .Where(s=>s.Id== Id)
                .Include(s => s.Stream)
                .Include(l => l.LeavingCert)
                .AsNoTracking().FirstOrDefault();
        }
        public List<Student> GetAll()
        {
            return db.Students
                .Include(s => s.Stream)
                .Include(l => l.LeavingCert)
                .AsNoTracking().ToList();
        }
        public bool Update(Student student)
        {
            using (db)
            {
                var Stud = db.Students.Find(student.Id);
                if (Stud == null)
                {
                    return false;
                }
                Stud.AdmNo = student.AdmNo;
                Stud.StudName = student.StudName;
                Stud.ClassFirstEnrolled = student.ClassFirstEnrolled;
                Stud.Category = student.Category;
                Stud.DateOfBirth = student.DateOfBirth;
                Stud.DateOfAdmission = student.DateOfAdmission;
                Stud.Gender = student.Gender;
                Stud.StreamId = student.StreamId;

                return db.SaveChanges() > 0;
            }
        }
        public bool Delete(int Id)
        {
            using (db)
            {
                var Stud = db.Students.Find(Id);
                if (Stud == null)
                {
                    return false;
                }
                db.Remove(Stud);

                return db.SaveChanges() > 0;
            }
        }
    }
}
