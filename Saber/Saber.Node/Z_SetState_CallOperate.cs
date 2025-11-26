namespace Saber.Node;

public class CallOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        CallOperate node;
        node = arg.Node as CallOperate;
        node.This = arg.Field00 as Operate;
        node.Maide = arg.Field01 as MaideName;
        node.Argue = arg.Field02 as Argue;
        return true;
    }
}