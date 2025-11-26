namespace Saber.Node;

public class StateSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        State node;
        node = arg.Node as State;
        node.Value = arg.Field00 as Array;
        return true;
    }
}