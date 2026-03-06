namespace Avalon.Console;

public class ProgramOutModeList : Any
{
    public static ProgramOutModeList This { get; } = ShareCreate();

    private static ProgramOutModeList ShareCreate()
    {
        ProgramOutModeList share;
        share = new ProgramOutModeList();
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

        this.SeparateChannels = this.AddItem(Extern.Stat_ProgramOutModeSeparateChannels(stat));
        this.MergedChannels = this.AddItem(Extern.Stat_ProgramOutModeMergedChannels(stat));
        this.ForwardedChannels = this.AddItem(Extern.Stat_ProgramOutModeForwardedChannels(stat));
        this.ForwardedOutputChannel = this.AddItem(Extern.Stat_ProgramOutModeForwardedOutputChannel(stat));
        this.ForwardedErrorChannel = this.AddItem(Extern.Stat_ProgramOutModeForwardedErrorChannel(stat));
        return true;
    }

    public virtual ProgramOutMode SeparateChannels { get; set; }
    public virtual ProgramOutMode MergedChannels { get; set; }
    public virtual ProgramOutMode ForwardedChannels { get; set; }
    public virtual ProgramOutMode ForwardedOutputChannel { get; set; }
    public virtual ProgramOutMode ForwardedErrorChannel { get; set; }

    protected virtual ProgramOutMode AddItem(ulong o)
    {
        ProgramOutMode item;
        item = new ProgramOutMode();
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

    protected virtual long ArrayCount { get { return 5; } set { } }

    public virtual long Count { get; set; }
    
    protected virtual long Index { get; set; }

    public virtual ProgramOutMode Get(long index)
    {
        return this.Array.GetAt(index) as ProgramOutMode;
    }
}