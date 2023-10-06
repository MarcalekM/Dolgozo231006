using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozo
{
    class Dolgozo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public bool Gender { get; set; }
        public string MartialStatus { get; set; }
        public int Salary { get; set; }

        public Dolgozo(string sor)
        {
            var v = sor.Split(';');
            Name = v[0];
            Age = int.Parse(v[1]);
            City = v[2];
            Department = v[3];
            Position = v[4];
            Gender = v[5] == "Male";
            MartialStatus = v[6];
            Salary = int.Parse(v[7]);
        }
    }

    
}
