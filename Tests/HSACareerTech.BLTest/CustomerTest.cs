using System;
using HSACareerTech.BL;
using NUnit.Framework;

namespace HSACareerTech.BLTest
{
    public class CustomerTest
    {
        private Customer _SUP;

        [SetUp]
        public void Setup()
        {
            _SUP = new Customer();
        }

        [Test]
        public void FullNameTestValid()
        {
            //Arrange
            _SUP.FirstName = "Guleid";
            _SUP.LastName = "Farah";
            var expected = "Farah, Guleid";

            //Act
            var actual = _SUP.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FullNameEmptyLastNameTestInvalid()
        {
            //Arrange
            _SUP.FirstName = "Guleid";
            var expected = "Guleid";

            //Act
            var actual = _SUP.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FullNameEmptyFirstNameTestInvalid()
        {
            //Arrange
            _SUP.LastName = "Farah";
            var expected = "Farah";

            //Act
            var actual = _SUP.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateTestValid()
        {
            //Arrange
            _SUP.LastName = "Farah";
            _SUP.EmailAddress = "farah@farah.com";
            var expected = true;

            //Act
            var actual = _SUP.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateEmptyLastNameTestInvalid()
        {
            //Arrange
            _SUP.LastName = "";
            _SUP.EmailAddress = "farah@farah.com";
            var expected = false;

            //Act
            var actual = _SUP.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateNullLastNameTestInvalid()
        {
            //Arrange
            _SUP.EmailAddress = "farah@farah.com";
            var expected = false;

            //Act
            var actual = _SUP.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateEmptyEmailTestInvalid()
        {
            //Arrange
            _SUP.LastName = "Farah";
            _SUP.EmailAddress = "";
            var expected = false;

            //Act
            var actual = _SUP.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateNullEmailTestInvalid()
        {
            //Arrange
            _SUP.LastName = "Farah";
            var expected = false;

            //Act
            var actual = _SUP.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}