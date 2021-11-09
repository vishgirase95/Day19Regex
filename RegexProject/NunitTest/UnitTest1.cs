
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
            var result=obj.FirstNameValidate("Vishal");

            Assert.IsTrue(result);
        }
    }
}