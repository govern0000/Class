namespace Saber.Node;

public class MaideSetState : SetState
{
    public override bool Execute()
    {
        SetStateArg arg;
        arg = this.Arg as SetStateArg;

        Maide node;
        node = arg.Node as Maide;
        node.Class = arg.Field00 as ClassName;
        node.Name = arg.Field01 as MaideName;
        node.Count = arg.Field02 as Count;
        node.Param = arg.Field03 as Param;
        node.Call = arg.Field04 as State;
        return true;
    }
}