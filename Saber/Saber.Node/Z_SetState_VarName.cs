namespace Saber.Node;

public class VarNameSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        VarName node;
        node = arg.Node as VarName;
        node.Value = arg.Field00 as String;
        return true;
    }
}