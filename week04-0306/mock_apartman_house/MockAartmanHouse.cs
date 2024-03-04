namespace mock_apartman_house;
using NUnit.Framework;
using apartman_house;
using Moq;

[TestFixture]
public class Tests
{
    Mock<ILoadFlats> mockFileLoader;
    ApartmanHandler aptHandler;

    public Tests() {
        mockFileLoader = new Mock<ILoadFlats>();
        aptHandler = new ApartmanHandler(mockFileLoader.Object);
    }

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestApartmanHouse()
    {
        mockFileLoader.Setup(m => m.Exists()).Returns(true);
        mockFileLoader.Setup(m => m.LoadLines()).Returns(
            new string[] {
                "Bela 50 1000",
                "Ferenc 100 5000"
            }
        );

        aptHandler.LoadFlatsFromFile();
        Assert.That(aptHandler.Count(), Is.EqualTo(2));

        mockFileLoader.Verify(m => m.Exists(), Times.Once);
        mockFileLoader.Verify(m => m.LoadLines(), Times.Once);
    }
}
