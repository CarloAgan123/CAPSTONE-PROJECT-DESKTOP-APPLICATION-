using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPSTONE_STOLE_ADMIN
{
    internal class StallInfo
    {
        public string stallNumber { get; set; }
        public string email { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string middlename { get; set; }
        public string contactNumber { get; set; }
        public string timein { get; set; }
        public string timeout { get; set; }
        public string stallName { get; set; }
        public List<string> selectedDays { get; set; }
        public string Img { get; set; }
    }
}
