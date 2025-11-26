namespace Saber.Node;

public class BitLiteOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        BitLiteOperate node;
        node = arg.Node as BitLiteOperate;
        node.Value = arg.Field00 as Operate;
        node.Count = arg.Field01 as Operate;
        return true;
    }
}