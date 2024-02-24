namespace NUnitHW;

[AttributeUsage(AttributeTargets.Method)]
public class SeverityAttribute : PropertyAttribute
{
    public SeverityAttribute(SeverityLevel level) : base(level.ToString()) { }
}