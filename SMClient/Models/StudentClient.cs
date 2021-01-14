using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMClient.Models
{
    public class StudentClient
    {    
        public int Id { get; set; }     
        public string Rollnumber { get; set; }      
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Introduction { get; set; }
        public int Genre { get; set; } // 1 nam 0 nữ
    }
}