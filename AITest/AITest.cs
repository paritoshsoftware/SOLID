namespace AITest
{
    using Moq;
    using Xunit;

    // Abstract class to be mocked
    public abstract class AITestAbstractClass
    {
        public abstract string GetValue();
    }

    // Class that depends on the abstract class
    public class ClassThatUsesAbstractClass
    {
        private AITestAbstractClass _abstractClass;

        public ClassThatUsesAbstractClass(AITestAbstractClass abstractClass)
        {
            _abstractClass = abstractClass;
        }

        public string DoSomethingWithAbstractClass()
        {
            return _abstractClass.GetValue();
        }
    }

    // Test class
    public class TestClass
    {
        [Fact]
        public void TestClassThatUsesAbstractClass()
        {
            // Arrange
            var mockAbstractClass = new Mock<AITestAbstractClass>();
            mockAbstractClass.Setup(x => x.GetValue()).Returns("Mocked value");

            var classThatUsesAbstractClass = new ClassThatUsesAbstractClass(mockAbstractClass.Object);

            // Act
            var result = classThatUsesAbstractClass.DoSomethingWithAbstractClass();

            // Assert
            Assert.Equal("Mocked value", result);
        }
    }

}
