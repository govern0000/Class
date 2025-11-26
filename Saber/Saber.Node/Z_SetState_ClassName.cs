namespace Saber.Node;

public class ClassNameSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        ClassName node;
        node = arg.Node as ClassName;
        node.Value = arg.Field00 as String;
        return true;
    }
}