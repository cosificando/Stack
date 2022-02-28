using NUnit.Framework;

namespace Stack.Test
{
    public class StackTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanCreateStack()
        {
            Stack stack = new Stack();

            Assert.IsTrue(stack.IsEmpty());
        }

        [Test]
        public void CanPush()
        {
            Stack stack = new Stack();

            stack.Push(0);
        }
    }
}