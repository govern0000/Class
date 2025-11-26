namespace Saber.Node;

public class GetOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new GetOperate();
        return true;
    }
}