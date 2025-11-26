namespace Saber.Node;

public class AndOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new AndOperate();
        return true;
    }
}