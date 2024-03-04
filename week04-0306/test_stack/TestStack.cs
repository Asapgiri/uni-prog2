using NUnit.Framework;
using stack;

namespace Tests
{
    public class StackTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0)]
        [TestCase(10)]
        [TestCase(50)]
        [TestCase(200)]
        [TestCase(20000)]
        public void IsEmpty(int stackSize)
        {
            Stack stack = new Stack(stackSize);

            Assert.That(stack.Empty(), Is.True);
        }

        [TestCase(0)]
        [TestCase(10)]
        [TestCase(50)]
        [TestCase(200)]
        [TestCase(20000)]
        public void IsFull(int stackSize)
        {
            Stack stack = new Stack(stackSize);

            for (int i = 0; i < stackSize; i++) {
                stack.Push('a');
            }

            Assert.That(stack.Full(), Is.True);
        }

        [TestCase(0)]
        [TestCase(10)]
        [TestCase(50)]
        [TestCase(200)]
        [TestCase(20000)]
        public void IsEmptyAfterFill(int stackSize)
        {
            Stack stack = new Stack(stackSize);

            for (int i = 0; i < stackSize; i++) {
                Assert.That(stack.Push('a'), Is.True);
            }
            for (int i = 0; i < stackSize; i++) {
                Assert.That(stack.Pop(out char a), Is.True);
            }

            Assert.That(stack.Empty(), Is.True);
        }

        [TestCase(10)]
        public void IsFillable(int stackSize)
        {
            Stack stack = new Stack(stackSize);

            Assert.That(stack.Push('a'), Is.True);
            Assert.That(stack.Push('a'), Is.True);
            Assert.That(stack.Push('a'), Is.True);

            Assert.That(stack.Empty(), Is.False);
            Assert.That(stack.Full(), Is.False);
        }

        [TestCase(10)]
        [TestCase(50)]
        [TestCase(200)]
        [TestCase(20000)]
        public void IsConsistent(int stackSize) {
            Stack stack = new Stack(stackSize);
            string hello = "Hello!";
            string result = string.Empty;

            // Put characters in stack
            for (int i = 0; i < hello.Length && !stack.Full(); i++) {
                stack.Push(hello[i]);
            }

            // Pop characters bask from stack
            for (int i = 0; i < hello.Length && !stack.Full(); i++) {
                stack.Pop(out char item);
                result = item + result;
            }

            Assert.That(hello, Is.EqualTo(result));
        }

        [TestCase(0)]
        [TestCase(2)]
        [TestCase(5)]
        public void FailsIfNoSpaceLeft(int stackSize) {
            Stack stack = new Stack(stackSize);

            // Put characters in stack
            for (int i = 0; i < stackSize; i++) {
                stack.Push('a');
            }
            Assert.That(stack.Push('a'), Is.False);

            // Pop characters bask from stack
            for (int i = 0; i < stackSize; i++) {
                stack.Pop(out char item);
            }
            Assert.That(stack.Pop(out char a), Is.False);
        }
    }
}
