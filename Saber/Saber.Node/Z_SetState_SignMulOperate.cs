namespace Saber.Node;

public class SignMulOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        SignMulOperate node;
        node = arg.Node as SignMulOperate;
        node.Lite = arg.Field00 as Operate;
        node.Rite = arg.Field01 as Operate;
        return true;
    }
}