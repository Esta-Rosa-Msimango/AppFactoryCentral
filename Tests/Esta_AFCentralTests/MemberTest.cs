using Esta_AFCentral.Models;
using System;
using Xunit;

namespace Esta_AFCentralTests
{
    public class MemberTest
    {
        [Fact]
        public void FullNameValidTest()
        {
            //Arrange
            MemberModel staff = new ()
            {
                //test variable
                FirstName = "Esta",
                LastName = "Msimango"
            }; //instance of the object variable to reference the project
            string expected = "Esta Msimango";

            //Act
            string actual = staff.FullName;

            //Assert
            Assert.Equal(expected, actual); //verify if expected value equal actual value
        }
    }
}
