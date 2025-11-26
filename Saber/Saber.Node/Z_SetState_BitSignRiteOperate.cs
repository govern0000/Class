namespace Saber.Node;

public class BitSignRiteOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        BitSignRiteOperate node;
        node = arg.Node as BitSignRiteOperate;
        node.Value = arg.Field00 as Operate;
        node.Count = arg.Field01 as Operate;
        return true;
    }
}