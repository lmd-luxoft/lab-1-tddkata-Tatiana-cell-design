// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDKata
{
    [TestFixture]
    public class TestClass
    {
    /*   [Test]
        public void SimpleTest()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("2,2");
            Assert.That(value, Is.EqualTo(4), "Wrong actual value");
        }
    */
        [Test1]
        public void SimpleTest1()
        {
            //Arrange
            StringCalc calc = new StringCalc();
  
            //Act
            int value = calc.Sum("-2,2");
            //Assert
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test2]
        public void SimpleTest2()
        {
            //Arrange
            StringCalc calc = new StringCalc();

            //Act
            int value = calc.Sum("-1,2,4");
            //Assert
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test3]
        public void SimpleTest3()
        {
            //Arrange
            StringCalc calc = new StringCalc();

            //Act
            int value = calc.Sum("-1,4");
            //Assert
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test4]
        public void SimpleTest4()
        {
            //Arrange
            StringCalc calc = new StringCalc();

            //Act
            int value = calc.Sum("-1,");
            //Assert
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test5]
        public void SimpleTest5()
        {
            //Arrange
            StringCalc calc = new StringCalc();

            //Act
            int value = calc.Sum(",,,,");
            //Assert
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }
    }
}
}
