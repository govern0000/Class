namespace Saber.Node;

public class SignMulOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new SignMulOperate();
        return true;
    }
}