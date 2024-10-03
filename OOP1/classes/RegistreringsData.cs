using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.classes
{
    public class RegistreringsData
    {
        private DateTime _date;
        private string _licenseID;
        
        public RegistreringsData(string licenseid, DateTime date) 
        {
            _date = date;
            _licenseID = licenseid;
        }

        public string LicenseID { get => _licenseID;}
    }
}
