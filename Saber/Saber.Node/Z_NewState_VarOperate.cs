namespace Saber.Node;

public class VarOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new VarOperate();
        return true;
    }
}