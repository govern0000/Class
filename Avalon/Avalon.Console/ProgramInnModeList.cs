namespace Avalon.Console;

public class ProgramInnModeList : Any
{
    public static ProgramInnModeList This { get; } = ShareCreate();

    private static ProgramInnModeList ShareCreate()
    {
        ProgramInnModeList share;
        share = new ProgramInnModeList();
        Any a;
        a = share;
        a.Init();
        return share;
    }

    public override bool Init()
    {
        base.Init();
        this.InitArray();
        this.Count = this.Array.Count;
        this.Index = 0;

        ulong share;
        share = Extern.Infra_Share();
        ulong stat;
        stat = Extern.Share_Stat(share);

        this.Managed = this.AddItem(Extern.Stat_ProgramInnModeManaged(stat));
        this.Forwarded = this.AddItem(Extern.Stat_ProgramInnModeForwarded(stat));
        return true;
    }

    public virtual ProgramInnMode Managed { get; set; }
    public virtual ProgramInnMode Forwarded { get; set; }

    protected virtual ProgramInnMode AddItem(ulong o)
    {
        ProgramInnMode item;
        item = new ProgramInnMode();
        item.Init();
        item.Index = this.Index;
        item.Intern = o;
        this.Array.SetAt(item.Index, item);
        this.Index = this.Index + 1;
        return item;
    }

    protected virtual bool InitArray()
    {
        this.Array = new Array();
        this.Array.Count = this.ArrayCount;
        this.Array.Init();
        return true;
    }

    protected virtual Array Array { get; set; }

    protected virtual long ArrayCount { get { return 2; } set { } }

    public virtual long Count { get; set; }
    
    protected virtual long Index { get; set; }

    public virtual ProgramInnMode Get(long index)
    {
        return this.Array.GetAt(index) as ProgramInnMode;
    }
}