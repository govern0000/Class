namespace Saber.Node;

public class ArgueNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new Argue();
        return true;
    }
}