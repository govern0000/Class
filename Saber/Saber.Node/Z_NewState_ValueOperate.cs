namespace Saber.Node;

public class ValueOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new ValueOperate();
        return true;
    }
}