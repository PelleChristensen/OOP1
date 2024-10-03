using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.classes
{
    public class Bil
    {
        private string _brand = "";
        private Person _ejer;
        private List<Person> _passagerer;
        private Motor motor;
        private RegistreringsData registrationdate;
        public Bil(string brand, Person ejer)
        {
            _brand = brand;
            _ejer = ejer;  
            registrationdate = new RegistreringsData("MX28964", DateTime.Now);
        }

        public void TilføjMotor (Motor nymotor)
        {
            motor = nymotor;
        }
    }
}
