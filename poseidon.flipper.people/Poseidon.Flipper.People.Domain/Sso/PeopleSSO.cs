using Poseidon.Flipper.People.Domain.Core.Models;

namespace Poseidon.Flipper.People.Domain.Sso
{
    public class PeopleSSO : Entity
    {
        public Domain.ValuesObjects.People People { get; private set; }

        public PeopleSSO(ValuesObjects.People people)
        {
            People = people;
        }
    }
}
