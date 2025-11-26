namespace Saber.Node;

public class ClassNameNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new ClassName();
        return true;
    }
}