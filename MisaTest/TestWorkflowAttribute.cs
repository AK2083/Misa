using Misa;

namespace MisaTest
{
    public class TestWorkflowAttribute
    {
        [Fact]
        public void WorkflowValidity_shouldBeAppliedTo_DummyObject()
        {
            var dummyType = typeof(DummyObject);
            var attr = Attribute.GetCustomAttribute(dummyType, typeof(WorkflowValidityAttribute)) as WorkflowValidityAttribute;

            Assert.NotNull(attr);
        }
    }
}