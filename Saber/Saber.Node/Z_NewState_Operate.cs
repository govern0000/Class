namespace Saber.Node;

public class OperateNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new Operate();
        return true;
    }
}