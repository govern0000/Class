namespace Saber.Node;

public class IntValueSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        IntValue node;
        node = arg.Node as IntValue;
        node.Value = arg.FieldInt;
        return true;
    }
}