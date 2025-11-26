namespace Saber.Node;

public class SignDivOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new SignDivOperate();
        return true;
    }
}