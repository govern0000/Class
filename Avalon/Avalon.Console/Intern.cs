namespace Avalon.Console;

class Intern : Any
{
    public static Intern This { get; } = ShareCreate();

    private static Intern ShareCreate()
    {
        Intern share;
        share = new Intern();
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