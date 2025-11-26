namespace Saber.Node;

public class NullOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        NullOperate node;
        node = arg.Node as NullOperate;
        return true;
    }
}