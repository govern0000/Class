namespace Saber.Node;

public class FieldNameSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        FieldName node;
        node = arg.Node as FieldName;
        node.Value = arg.Field00 as String;
        return true;
    }
}