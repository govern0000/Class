namespace Saber.Node;

public class FieldNewState : NewState
{
    public override bool Execute()
    {
        this.Result = new Field();
        return true;
    }
}