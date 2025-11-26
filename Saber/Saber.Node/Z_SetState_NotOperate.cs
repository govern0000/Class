namespace Saber.Node;

public class NotOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        NotOperate node;
        node = arg.Node as NotOperate;
        node.Value = arg.Field00 as Operate;
        return true;
    }
}