namespace Avalon.Entry;

public class Entry : Any
{
    public override bool Init()
    {
        base.Init();
        this.InternIntern = Intern.This;
        this.InternInfra = InternInfra.This;
        return true;
    }

    private Intern InternIntern { get; set; }
    private InternInfra InternInfra { get; set; }
    private StorageInfra StorageInfra { get; set; }
    private StringComp StringComp { get; set; }
    protected virtual TextStringValue TextStringValue { get; set; }
    private StorageComp StorageComp { get; set; }
    private string[] InternArg { get; set; }

    public virtual int Execute()
    {
        this.MainBefore();

        long k;
        k = this.ExecuteMain();

        k = this.StatusWrite(k);

        this.MainAfter();

        int a;
        a = (int)k;
        return a;
    }

    protected virtual long StatusWrite(long value)
    {
        long k;
        k = value;

        if (!(k == 0))
        {
            ConsoleConsole ka;
            ka = new ConsoleConsole();
            ka.Init();

            ka.Err.Write(TextCreate.This.Add().AddS("Status: ").AddInt(k).AddLine().AddResult());

            k = 1;
        }

        return k;
    }

    protected virtual bool MainBefore()
    {
        Extern.Main_Init(0, 1, 0);

        ThreadThread o;
        o = new ThreadThread();
        o.InitMainThread();

        this.TextStringValue = TextStringValue.This;

        this.StorageComp = StorageComp.This;

        String kk;
        kk = this.StorageComp.ThisFoldGet();

        this.InternInfra.ModuleFoldPath = kk;

        this.StorageComp.ModuleFoldPath = kk;

        this.ArrayArg();

        this.StringComp = StringComp.This;

        this.StorageInfra = StorageInfra.This;

        this.MainBeforeConsole();
        return true;
    }

    protected virtual bool MainAfter()
    {
        this.MainAfterConsole();

        Extern.Main_Final();
        return true;
    }

    protected virtual long ExecuteMain()
    {
        return 0;
    }

    protected virtual bool ArrayArg()
    {
        string[] ao;
        ao = this.InternArg;

        long count;
        count = ao.LongLength;
        Array array;
        array = new Array();
        array.Count = count;
        array.Init();
        long i;
        i = 0;
        while (i < count)
        {
            string ku;
            ku = ao[i];

            String a;
            a = this.S(ku);

            array.SetAt(i, a);
            i = i + 1;
        }
        this.Arg = array;

        return true;
    }

    private bool MainBeforeConsole()
    {
        this.InternInfra.ConsoleOutPath = this.ConsolePath(Extern.Environ_OutPath());
        this.InternInfra.ConsoleErrPath = this.ConsolePath(Extern.Environ_ErrPath());
        this.InternInfra.ConsoleInnPath = this.ConsolePath(Extern.Environ_InnPath());

        if (!(this.InternInfra.ConsoleOutPath == null))
        {
            this.InternInfra.ConsoleOut = this.CreatePathOut();
        }

        if (!(this.InternInfra.ConsoleErrPath == null))
        {
            this.InternInfra.ConsoleErr = this.CreatePathOut();
        }

        if (!(this.InternInfra.ConsoleInnPath == null))
        {
            String innString;
            innString = this.StorageInfra.TextRead(this.InternInfra.ConsoleInnPath);

            if (innString == null)
            {
                Extern.Environ_Exit(193);
            }

            PathInn inn;
            inn = new PathInn();
            inn.Init();

            inn.String = innString;
            inn.Index = 0;

            this.InternInfra.ConsoleInn = inn;
        }
        return true;
    }

    private bool MainAfterConsole()
    {
        if (!(this.InternInfra.ConsoleOutPath == null))
        {
            StringOut stringOut;
            stringOut = this.InternInfra.ConsoleOut as StringOut;

            String outText;
            outText = stringOut.Result();

            bool ba;
            ba = this.StorageInfra.TextWrite(this.InternInfra.ConsoleOutPath, outText);

            if (!ba)
            {
                Extern.Environ_Exit(191);
            }
        }

        if (!(this.InternInfra.ConsoleErrPath == null))
        {
            StringOut stringErr;
            stringErr = this.InternInfra.ConsoleErr as StringOut;

            String errText;
            errText = stringErr.Result();

            bool bb;
            bb = this.StorageInfra.TextWrite(this.InternInfra.ConsoleErrPath, errText);

            if (!bb)
            {
                Extern.Environ_Exit(192);
            }
        }

        return true;
    }

    private PathOut CreatePathOut()
    {
        PathOut a;
        a = new PathOut();
        a.Init();
        return a;
    }

    private String ConsolePath(ulong k)
    {
        String kk;
        kk = this.InternInfra.StringCreateIntern(k);

        if (this.StringComp.Count(kk) == 0)
        {
            kk = null;
        }

        String a;
        a = kk;
        return a;
    }

    public virtual Array Arg
    {
        get; set;
    }

    public virtual bool ArgSet(string[] arg)
    {
        this.InternArg = arg;
        return true;
    }

    protected virtual String S(string o)
    {
        return this.TextStringValue.Execute(o);
    }

    public static int Main(Entry entry, string[] arg)
    {
        entry.Init();
        entry.ArgSet(arg);
        int o;
        o = entry.Execute();
        return o;
    }
}