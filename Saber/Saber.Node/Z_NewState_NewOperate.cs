namespace Saber.Node;

public class NewOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new NewOperate();
        return true;
    }
}