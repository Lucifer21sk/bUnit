using Bunit;
using Microsoft.AspNetCore.Components;
using Ppt23.Client.Components;
using Ppt23.Shared;
using Xunit;

namespace TestPpt23.Tests
{
    public class HospitalTest : TestContext
    {
        [Fact]
        public void PerformRevisionButton_Clicked_CallsOnRevisionEvent()
        {
            // Arrange
            bool onRevisionCalled = false;
            var equipment = new EquipmentVm();
            var component = RenderComponent<EquipmentRow>(
                parameters => parameters
                    .Add(p => p.Equi, equipment)
                    .Add(p => p.OnRevision, EventCallback.Factory.Create(this, () => onRevisionCalled = true))
            );

            // Act
            component.Find("button:contains('Perform Revision')").Click();

            // Assert
            Assert.True(onRevisionCalled);
        }
    }
}
