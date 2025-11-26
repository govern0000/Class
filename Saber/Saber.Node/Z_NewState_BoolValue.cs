namespace Saber.Node;

public class BoolValueNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new BoolValue();
        return true;
    }
}