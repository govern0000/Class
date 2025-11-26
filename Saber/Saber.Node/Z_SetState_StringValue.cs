namespace Saber.Node;

public class StringValueSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        StringValue node;
        node = arg.Node as StringValue;
        node.Value = arg.Field00 as String;
        return true;
    }
}