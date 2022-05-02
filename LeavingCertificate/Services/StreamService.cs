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

        public Stream GetStream()
        {
            return _StreamDataAccess.GetStream();
        }
        public bool Update(Stream stream)
        {
            return _StreamDataAccess.Update(stream);
        }
    }
}
