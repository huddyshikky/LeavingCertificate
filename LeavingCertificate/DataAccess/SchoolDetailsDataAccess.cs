using LeavingCertificate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeavingCertificate.DataAccess
{
    public class SchoolDetailsDataAccess
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public bool Add(SchoolDetail schoolDetail)
        {
            using (db)
            {
                db.SchoolDetails.Add(schoolDetail);
                return db.SaveChanges() > 0;
            }
           
        }
        public SchoolDetail GetSchoolDetail()
        {
            return db.SchoolDetails.FirstOrDefault();
        }
        public bool Update(SchoolDetail schoolDetail)
        {
            using (db)
            {
                var Data=db.SchoolDetails.Find(schoolDetail.Id);
                if (Data==null)
                {
                    return false;
                }
                Data.schname = schoolDetail.schname;
                Data.schaddr = schoolDetail.schaddr;
                Data.schemail = schoolDetail.schemail;
                Data.schmotto = schoolDetail.schmotto;
                Data.city = schoolDetail.city;
                Data.schtel = schoolDetail.schtel;
                Data.schweb = schoolDetail.schweb;

                return db.SaveChanges() > 0;
            }

        }
    }
}
