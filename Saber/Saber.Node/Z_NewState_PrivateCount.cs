namespace Saber.Node;

public class PrivateCountNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new PrivateCount();
        return true;
    }
}