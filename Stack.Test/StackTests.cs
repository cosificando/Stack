using NUnit.Framework;

namespace Stack.Test
{
    public class StackTests
    {
        #region private attributes
        Stack stack;
        #endregion
        [SetUp]
        public void Setup()
        {
            this.stack = new Stack();
        }

        [Test]
        public void CanCreateStack()
        {
            Assert.IsTrue(stack.IsEmpty());
        }

        [Test]
        public void afterOnePush_isNotEmpty()
        {
            stack.Push(0);

            Assert.IsFalse(stack.IsEmpty());
        }

        [Test]
        public void afterOnePushAndPop_isEmpty()
        {
            stack.Push(0);
            stack.Pop();

            Assert.IsTrue(stack.IsEmpty());
        }
    }
}