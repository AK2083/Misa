namespace Misa
{
    [AttributeUsage(AttributeTargets.Class)]
    public class WorkflowValidityAttribute : Attribute
    {
        public readonly string ValidFrom;

        public WorkflowValidityAttribute(string validFrom)
        {
            ValidFrom = validFrom;
        }
    }
}
