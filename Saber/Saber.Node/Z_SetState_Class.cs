namespace Saber.Node;

public class ClassSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        Class node;
        node = arg.Node as Class;
        node.Name = arg.Field00 as ClassName;
        node.Base = arg.Field01 as ClassName;
        node.Part = arg.Field02 as Part;
        return true;
    }
}