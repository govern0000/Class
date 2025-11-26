namespace Saber.Node;

public class VarSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        Var node;
        node = arg.Node as Var;
        node.Class = arg.Field00 as ClassName;
        node.Name = arg.Field01 as VarName;
        return true;
    }
}