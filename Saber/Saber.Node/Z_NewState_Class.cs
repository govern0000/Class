namespace Saber.Node;

public class ClassNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new Class();
        return true;
    }
}