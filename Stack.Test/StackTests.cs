using NUnit.Framework;

namespace Stack.Test
{
    [TestFixture]
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

            Assert.AreEqual(0,stack.Size);
            Assert.IsTrue(stack.IsEmpty());
        }

        [Test]
        public void afterTwoPushes_sizeIsTwo()
        {
            stack.Push(0);
            stack.Push(0);

            Assert.AreEqual(2, stack.Size);
        }

        [Test]
        // [ExpectedException(typeof(UnderflowException))] // Para MSTests & NUnit 2+
        public void popInEmptyStack_throwsUnderflowException()
        {
            stack.Pop();
        }

        [Test]
        public void AfterPushingX_WillPopX()
        {
            stack.Push(69);
            Assert.AreEqual(69, stack.Pop());

            stack.Push(70);
            Assert.AreEqual(70, stack.Pop());
        }

        [Test]
        public void AfterPushingXAndY_WillPopYThenX()
        {
            Assert.Fail("Not implemented yet");
        }
    }
}