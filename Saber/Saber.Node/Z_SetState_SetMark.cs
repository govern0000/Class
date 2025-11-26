namespace Saber.Node;

public class SetMarkSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        SetMark node;
        node = arg.Node as SetMark;
        node.This = arg.Field00 as Operate;
        node.Field = arg.Field01 as FieldName;
        return true;
    }
}