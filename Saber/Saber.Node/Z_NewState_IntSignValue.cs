namespace Saber.Node;

public class IntSignValueNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new IntSignValue();
        return true;
    }
}