using LeavingCertificate.Models;
using Microsoft.EntityFrameworkCore;
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
        public Stream? GetById(int id)
        {
            using (db)
            {
                return db.Streams
                .AsNoTracking()
                .SingleOrDefault(p => p.Id == id);
            }
        }
        public Stream GetOne()
        {
            return db.Streams.AsNoTracking().FirstOrDefault();
        }
        public List<Stream> GetAll()
        {
            return db.Streams.AsNoTracking().ToList();
        }
        public bool Update(Stream stream)
        {
            using (db)
            {
                var Data = db.Streams.Find(stream.Id); ;
                if (Data == null)
                {
                    return false;
                }
                Data.StreamName = stream.StreamName;

                return db.SaveChanges() > 0;
            }

        }
        public bool Delete(Stream stream)
        {
            using (db)
            {
                var Data = db.Streams.Find(stream.Id); ;
                if (Data == null)
                {
                    return false;
                }
                db.Remove(stream);
                return db.SaveChanges() > 0;
            }

        }
    }
}
