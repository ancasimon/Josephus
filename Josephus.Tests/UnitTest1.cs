using System;
using Xunit;

namespace Josephus.Tests
{
    public class the_right_person_survives
    {
        [Fact]
        public void when_one_person_with_an_interval_of_one_then_the_only_person_should_survive() //if I pass in the numbers 1 and 1, then only 1 should be left
        {
            //throw new Exception();

            //Arrange (Given, Set up the context):
            var numberOfPeople = 1;
            var killingInterval = 1;
            var expectedResult = 1;

            var solver = new JosephusSolver();

            //Act (When)
            var solution = solver.Solve(numberOfPeople, killingInterval);

            //Assert (Then)
            Assert.Equal(expectedResult, solution);
        }

        [Fact]
        public void when_two_people_with_an_interval_of_one_then_the_second_person_survives()
        {
            //Arrange
            var numberOfPeople = 2;
            var killingInterval = 1;
            var expectedResult = 2;

            var solver = new JosephusSolver();

            //Act
            var solution = solver.Solve(numberOfPeople, killingInterval);

            //Assert
            Assert.Equal(expectedResult, solution);
        }

        [Fact]
        public void when_two_people_with_an_interval_of_two_then_the_first_person_survives()
        {
            //Arrange
            var numberOfPeople = 2;
            var killingInterval = 2;
            var expectedResult = 1;

            var solver = new JosephusSolver();

            //Act
            var solution = solver.Solve(numberOfPeople, killingInterval);

            //Assert
            Assert.Equal(expectedResult, solution);
        }

        [Fact]
        public void when_seven_people_with_an_interval_of_two_then_the_7th_person_survives()
        {
            //Arrange
            var numberOfPeople = 7;
            var killingInterval = 2;
            var expectedResult = 7;

            var solver = new JosephusSolver();

            //Act
            var solution = solver.Solve(numberOfPeople, killingInterval);

            //Assert
            Assert.Equal(expectedResult, solution);
        }

        [Fact]
        public void when_137_people_with_an_interval_of_two_then_the_137th_person_survives()
        {
            //Arrange
            var numberOfPeople = 137;
            var killingInterval = 2;
            var expectedResult = 19;

            var solver = new JosephusSolver();

            //Act
            var solution = solver.Solve(numberOfPeople, killingInterval);

            //Assert
            Assert.Equal(expectedResult, solution);
        }
    }

}
