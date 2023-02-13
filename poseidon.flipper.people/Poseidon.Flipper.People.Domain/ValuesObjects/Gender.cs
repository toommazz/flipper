using Poseidon.Flipper.People.Domain.Core.Models;

namespace Poseidon.Flipper.People.Domain.ValuesObjects
{
    public class Gender
    {
        public string Description { get; private set; }

        public Gender(string description)
        {
            Description = description;
        }
    }
}
