namespace Saber.Node;

public class FieldSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        Field node;
        node = arg.Node as Field;
        node.Class = arg.Field00 as ClassName;
        node.Name = arg.Field01 as FieldName;
        node.Count = arg.Field02 as Count;
        node.Get = arg.Field03 as State;
        node.Set = arg.Field04 as State;
        return true;
    }
}