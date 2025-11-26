namespace Saber.Node;

public class BitRiteOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        BitRiteOperate node;
        node = arg.Node as BitRiteOperate;
        node.Value = arg.Field00 as Operate;
        node.Count = arg.Field01 as Operate;
        return true;
    }
}