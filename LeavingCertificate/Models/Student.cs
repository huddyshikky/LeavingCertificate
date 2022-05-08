using LeavingCertificate.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeavingCertificate.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int AdmNo { get; set; }
        public String StudName { get; set; }
        public EnrolledEnum ClassFirstEnrolled { get; set; }
        public StudCatEnum Category { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfAdmission { get; set; }
        public GenderEnum Gender { get; set; }

        //Navigational properties
        public int StreamId { get; set; }
        public Stream Stream { get; set; }

        public int LeavingCertDetailsId { get; set; }
        public virtual LeavingCertDetail LeavingCert { get; set; }



    }
}
