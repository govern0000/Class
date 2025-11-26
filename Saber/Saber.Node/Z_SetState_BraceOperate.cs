namespace Saber.Node;

public class BraceOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        BraceOperate node;
        node = arg.Node as BraceOperate;
        node.Any = arg.Field00 as Operate;
        return true;
    }
}