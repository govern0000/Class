namespace Saber.Node;

public class CountNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new Count();
        return true;
    }
}