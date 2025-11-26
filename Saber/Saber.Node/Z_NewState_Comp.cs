namespace Saber.Node;

public class CompNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new Comp();
        return true;
    }
}