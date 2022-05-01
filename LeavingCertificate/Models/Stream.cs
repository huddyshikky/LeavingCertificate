using System;
using System.Collections.Generic;
using System.Text;

namespace LeavingCertificate.Models
{
    public class Stream
    {
        public int Id { get; set; }
        public string StreamName { get; set; }

        //Navigational properties
        public List<Student> Students { get; set; }
    }
}
