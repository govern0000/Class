namespace Saber.Node;

public class OperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        Operate node;
        node = arg.Node as Operate;
        return true;
    }
}