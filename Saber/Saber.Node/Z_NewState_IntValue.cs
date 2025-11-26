namespace Saber.Node;

public class IntValueNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new IntValue();
        return true;
    }
}