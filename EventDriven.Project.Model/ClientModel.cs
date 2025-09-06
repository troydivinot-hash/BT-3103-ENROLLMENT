using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string MobileNumber { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
