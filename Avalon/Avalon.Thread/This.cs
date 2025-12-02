namespace Avalon.Thread;

public class ThreadThis : Any
{
    public static ThreadThis This { get; } = ShareCreate();

    private static ThreadThis ShareCreate()
    {
        ThreadThis share;
        share = new ThreadThis();
        Any a;
        a = share;
        a.Init();
        return share;
    }

    public virtual Thread Thread
    {
        get
        {
            return InternIntern.ThisThread as Thread;
        }
        set
        {
        }
    }
}