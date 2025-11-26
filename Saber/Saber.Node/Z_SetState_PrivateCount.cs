namespace Saber.Node;

public class PrivateCountSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        PrivateCount node;
        node = arg.Node as PrivateCount;
        return true;
    }
}