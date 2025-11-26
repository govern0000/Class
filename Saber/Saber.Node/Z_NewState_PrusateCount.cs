namespace Saber.Node;

public class PrusateCountNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new PrusateCount();
        return true;
    }
}