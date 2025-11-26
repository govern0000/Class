namespace Saber.Node;

public class DivOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new DivOperate();
        return true;
    }
}