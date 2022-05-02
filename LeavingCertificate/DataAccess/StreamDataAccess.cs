using LeavingCertificate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeavingCertificate.DataAccess
{
    public class StreamDataAccess
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public bool Add(Stream stream)
        {
            using (db)
            {
                db.Streams.Add(stream);
                return db.SaveChanges() > 0;
            }

        }
        public Stream GetStream()
        {
            return db.Streams.FirstOrDefault();
        }
        public bool Update(Stream stream)
        {
            using (db)
            {
                var Data = db.Streams.Find(stream.Id);
                if (Data == null)
                {
                    return false;
                }
                Data.StreamName = stream.StreamName;

                return db.SaveChanges() > 0;
            }

        }
    }
}
