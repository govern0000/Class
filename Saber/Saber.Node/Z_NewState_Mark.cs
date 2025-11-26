namespace Saber.Node;

public class MarkNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new Mark();
        return true;
    }
}