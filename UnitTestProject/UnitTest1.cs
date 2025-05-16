using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryProject.Tests
{
    [TestClass]
    public class Class1Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var class1 = new Class1();

            // Act
            // (Chame o método que você deseja testar aqui)

            // Assert
            Assert.IsNotNull(class1); // Exemplo de verificação
        }
    }

    internal class Class1
    {
        public Class1()
        {
        }
    }
}
