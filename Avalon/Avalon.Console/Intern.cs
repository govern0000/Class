namespace Avalon.Console;

class PathIntern : Any
{
    public static PathIntern This { get; } = ShareCreate();

    private static PathIntern ShareCreate()
    {
        PathIntern share;
        share = new PathIntern();
        Any a;
        a = share;
        a.Init();
        return share;
    }

    public override bool Init()
    {
        base.Init();
        this.Phore = new Phore();
        this.Phore.InitCount = 1;
        this.Phore.Init();
        return true;
    }

    public virtual Phore Phore { get; set; }
}