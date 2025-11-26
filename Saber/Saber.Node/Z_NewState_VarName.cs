namespace Saber.Node;

public class VarNameNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new VarName();
        return true;
    }
}