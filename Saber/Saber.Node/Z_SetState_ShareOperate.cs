namespace Saber.Node;

public class ShareOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        ShareOperate node;
        node = arg.Node as ShareOperate;
        node.Class = arg.Field00 as ClassName;
        return true;
    }
}