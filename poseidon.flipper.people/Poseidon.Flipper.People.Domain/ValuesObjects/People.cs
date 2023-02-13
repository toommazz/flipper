using Poseidon.Flipper.People.Domain.Core.Models;

namespace Poseidon.Flipper.People.Domain.ValuesObjects
{
    public class People : Entity
    {
        public People(string firstName, 
            string middleName, string lastName, DateTime birthDate, Gender gender)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
        }

        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Gender Gender { get; private set; }
    }
}
