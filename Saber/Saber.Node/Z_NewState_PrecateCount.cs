namespace Saber.Node;

public class PrecateCountNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new PrecateCount();
        return true;
    }
}