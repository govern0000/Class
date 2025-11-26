namespace Saber.Node;

public class ValueNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new Value();
        return true;
    }
}