namespace Saber.Node;

public class PartNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new Part();
        return true;
    }
}