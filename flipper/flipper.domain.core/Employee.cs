using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flipper.domain.core
{
    public class Employee : Entity
    {
       
        public Employee(string name, byte age, DateTime birthday, bool isDayOff)
            : base(DateTime.Now)
        {
            Name = name;
            Age = age;
            Birthday = birthday;
            IsDayOff = isDayOff;
        }

        public string Name { get; private set; }
        public byte Age { get; private set; }
        public DateTime Birthday { get; private set; }
        public bool IsDayOff { get; protected set; }
    }
}
