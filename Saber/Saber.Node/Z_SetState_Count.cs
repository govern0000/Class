namespace Saber.Node;

public class CountSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        Count node;
        node = arg.Node as Count;
        return true;
    }
}