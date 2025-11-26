namespace Saber.Node;

public class ParamNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new Param();
        return true;
    }
}