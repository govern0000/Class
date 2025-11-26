namespace Saber.Node;

public class FieldNameNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new FieldName();
        return true;
    }
}