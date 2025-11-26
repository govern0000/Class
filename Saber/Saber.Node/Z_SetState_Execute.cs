namespace Saber.Node;

public class ExecuteSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        Execute node;
        node = arg.Node as Execute;
        return true;
    }
}