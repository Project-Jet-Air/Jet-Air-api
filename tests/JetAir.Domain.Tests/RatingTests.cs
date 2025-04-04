using Microsoft.VisualStudio.TestTools.UnitTesting;
using JetAir.Domain;
using System;

namespace JetAir.Domain.Tests
{
    [TestClass]
    public class RatingTests
    {
        [TestMethod]
        public void Can_Create_New_Rating()
        {
            // Arrange
            var rating = new Rating(1, "Mike", "Great fit!");

            // Act (empty)

            // Assert
            Assert.AreEqual(1, rating.Stars);
            Assert.AreEqual("Mike", rating.UserName);
            Assert.AreEqual("Great fit!", rating.Review);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_With_Invalid_Stars_Should_Throw_ArgumentException()
        {
            // Arrange
            var invalidStars = 10;

            // Act
            var rating = new Rating(invalidStars, "Mike", "This should fail");

            // Assert is handled by ExpectedException
        }
    }
}
