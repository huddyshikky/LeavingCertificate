using LeavingCertificate.DataAccess;
using LeavingCertificate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeavingCertificate.Services
{
    public class StreamService
    {
        StreamDataAccess _StreamDataAccess = new StreamDataAccess();

        public bool Add(Stream stream)
        {
            return _StreamDataAccess.Add(stream);
        }

        public Stream GetOne()
        {
            return _StreamDataAccess.GetOne();
        }
        public List<Stream> GetAll()
        {
            return _StreamDataAccess.GetAll();
        }
        public bool Update(Stream stream)
        {
            return _StreamDataAccess.Update(stream);
        }
        public bool Delete(Stream stream)
        {
            return _StreamDataAccess.Delete(stream);
        }
    }
}
