namespace Saber.Node;

public class PronateCountNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new PronateCount();
        return true;
    }
}