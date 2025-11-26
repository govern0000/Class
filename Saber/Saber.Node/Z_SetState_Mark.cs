namespace Saber.Node;

public class MarkSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        Mark node;
        node = arg.Node as Mark;
        return true;
    }
}