
using NUnit.Framework;
using RegexProject;

namespace NunitTest
{
    public class Tests
    {
        RegexPatterns obj;



        [SetUp]
        public void Setup()
        {
            obj = new RegexPatterns();
        }

        [Test]
        public void GivenUserInput_ShouldValidate_GivenPatternOfFirstName()
        {
            var result = obj.FirstNameValidate("Vishal");
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenUserInput_ShouldValidate_GivenPatternOfLirstName()
        {
            var result = obj.FirstNameValidate("Girase");
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenUserInput_ShouldValidate_GivenPatternOfMailID()
        {
            var result = obj.EmailIdValidate("dayalcool123@yahoo.com");
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenUserInput_ShouldValidate_GivenPatternOfPhoneNumber()
        {
            var result = obj.PhoneNumberValidate("91 8806001896");
            Assert.IsTrue(result);
        }
    }

}