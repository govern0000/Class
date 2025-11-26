namespace Saber.Node;

public class AddOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new AddOperate();
        return true;
    }
}