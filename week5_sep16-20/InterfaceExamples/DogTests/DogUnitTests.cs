namespace DogTests
{
    public class DogUnitTests
    {
        [Fact]
        public void DefaultDogUnitTests()
        {
            Dog d = new Dog();

            //Assert.Equal(expected, actual)

            Assert.Equal(0u, d.Age);
            Assert.Equal(4u, d.Legs);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 15)]
        [InlineData(2, 24)]
        [InlineData(3, 29)]
        [InlineData(15, 24 + 5 * (15 - 2))]
        [InlineData(8, 24 + 5 * (8 - 2))]
        public void PeopleYearsUnitTest(uint dogAge, uint expectedPeople)
        {
            Dog d = new() { Age = dogAge };
            Assert.Equal(expectedPeople, d.PeopleYears);
        }
    }
}