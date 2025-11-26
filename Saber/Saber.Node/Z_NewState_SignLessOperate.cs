namespace Saber.Node;

public class SignLessOperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new SignLessOperate();
        return true;
    }
}