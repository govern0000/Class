namespace Saber.Node;

public class ThisOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new ThisOperate();
        return true;
    }
}