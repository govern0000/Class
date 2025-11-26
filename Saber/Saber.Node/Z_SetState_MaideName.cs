namespace Saber.Node;

public class MaideNameSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        MaideName node;
        node = arg.Node as MaideName;
        node.Value = arg.Field00 as String;
        return true;
    }
}