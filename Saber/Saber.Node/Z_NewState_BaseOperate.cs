namespace Saber.Node;

public class BaseOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new BaseOperate();
        return true;
    }
}