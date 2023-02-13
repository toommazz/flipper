using Poseidon.Flipper.People.Domain.Sso;

namespace Poseidon.Flipper.People.Domain.Test
{
    public class Tests
    {
        ValuesObjects.People people;
        ValuesObjects.Gender gender;

        [SetUp]
        public void Setup()
        {
            gender = new ValuesObjects.Gender("Masculino");
            people = new ValuesObjects.People("Lula", "Inácio", "da Silva", new DateTime(1927, 01, 01), gender);
        }

        [Test]
        public void ContainsLulaTest()
        {
            PeopleSSO peopleSSO = new PeopleSSO(people);
            Assert.IsTrue(peopleSSO.People.FirstName.Contains("Lula"));
        }
    }
}