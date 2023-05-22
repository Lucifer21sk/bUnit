using Bunit;
using Ppt23.Client.Pages;

namespace TestPpt23
{
    public class UnitTest1: TestContext
    {
        [Fact]
        public void CounterShouldIncrementWhenClicked()
        {
            // Arrange
            var cut = RenderComponent<Counter>();
            // Act
            cut.Find("button").Click();
            // Assert
            cut.Find("p").MarkupMatches("<p>Current count: 1</p>");
        }
    }
}