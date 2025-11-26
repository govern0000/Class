namespace Saber.Node;

public class IntHexSignValueNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new IntHexSignValue();
        return true;
    }
}