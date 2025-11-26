namespace Saber.Node;

public class BoolValueSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        BoolValue node;
        node = arg.Node as BoolValue;
        node.Value = arg.FieldBool;
        return true;
    }
}