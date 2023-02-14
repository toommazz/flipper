using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Flipper.People.Domain.ValuesObjects
{
    public class State
    {

        public string Description { get; private set; }

        public State(string description)
        {
            Description = description;
        }
        
    }
}
