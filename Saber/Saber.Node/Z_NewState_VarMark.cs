namespace Saber.Node;

public class VarMarkNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new VarMark();
        return true;
    }
}