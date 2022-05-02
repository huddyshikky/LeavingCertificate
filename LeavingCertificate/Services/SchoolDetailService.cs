using LeavingCertificate.DataAccess;
using LeavingCertificate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeavingCertificate.Services
{
    public class SchoolDetailService
    {
        SchoolDetailsDataAccess _SchoolDetailsDataAccess = new SchoolDetailsDataAccess();

        public bool Add(SchoolDetail schoolDetail)
        {
            return _SchoolDetailsDataAccess.Add(schoolDetail);
        }

        public SchoolDetail GetSchoolDetail()
        {
            return _SchoolDetailsDataAccess.GetSchoolDetail();
        }
        public bool Update(SchoolDetail schoolDetail)
        {
            return _SchoolDetailsDataAccess.Update(schoolDetail);
        }
    }
}
