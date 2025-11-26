namespace Saber.Node;

public class GetOperateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        GetOperate node;
        node = arg.Node as GetOperate;
        node.This = arg.Field00 as Operate;
        node.Field = arg.Field01 as FieldName;
        return true;
    }
}