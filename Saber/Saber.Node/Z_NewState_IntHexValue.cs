namespace Saber.Node;

public class IntHexValueNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new IntHexValue();
        return true;
    }
}