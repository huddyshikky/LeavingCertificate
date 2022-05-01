using System;
using System.Collections.Generic;
using System.Text;

namespace LeavingCertificate.Models
{
    public class LeavingCertDetail
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime Leaving_Date { get; set; }
        public string ClassOfLeaving { get; set; }
        public string Status { get; set; }


        //Navigational properties
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
