namespace Saber.Node;

public class LessOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new LessOperate();
        return true;
    }
}