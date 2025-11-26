namespace Saber.Node;

public class VarNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new Var();
        return true;
    }
}