namespace Saber.Class;

public class ClassGenOperate : Any
{
    public virtual LibraryGen Gen { get; set; }

    public virtual bool ExecuteChar(long o)
    {
        return false;
    }

    public virtual bool ExecuteTextInt(long o)
    {
        return false;
    }

    public virtual bool ExecuteTextIntHex(long o)
    {
        return false;
    }
}