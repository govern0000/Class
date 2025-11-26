namespace Saber.Node;

public class StringValueNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new StringValue();
        return true;
    }
}