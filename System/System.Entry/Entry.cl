class Entry : Any
{
    maide prusate Int Execute()
    {
        this.MainBefore();

        var Int a;
        a : this.ExecuteMain();

        this.MainAfter();

        return a;
    }

    maide prusate Bool Init()
    {
        base.Init();
        this.InternIntern : share Intern;
        this.InternInfra : share InternInfra;
        return true;
    }

    field prusate Array Arg { get { return data; } set { data : value; } }
    field private Intern InternIntern { get { return data; } set { data : value; } }
    field private InternInfra InternInfra { get { return data; } set { data : value; } }
    field private StorageComp StorageComp { get { return data; } set { data : value; } }

    maide precate Bool MainBefore()
    {
        var Thread ka;
        ka : new Thread;
        ka.InitMainThread();

        this.StorageComp : share StorageComp;

        var String k;
        k : this.StorageComp.ThisFoldGet();

        this.InternInfra.ModuleFoldPath : k;

        this.StorageComp.ModuleFoldPath : k;

        this.ArrayArg();

        this.MainBeforeConsole();
        return true;
    }

    maide precate Bool MainAfter()
    {
        this.MainAfterConsole();
        return true;
    }

    maide precate Int ExecuteMain()
    {
        return 0;
    }

    maide precate Bool ArrayArg()
    {
        var Int count;
        count : this.InternIntern.ArgCount();

        var Array array;
        array : new Array;
        array.Count : count;
        array.Init();

        var Int i;
        i : 0;
        while (i < count)
        {
            var String k;
            k : this.InternIntern.Arg(i);

            array.Set(i, k);

            i : i + 1;
        }

        this.Arg : array;
        return true;
    }

    private bool MainBeforeConsole()
    {
        this.InternInfra.ConsoleOutPath : this.ConsolePath(Extern.Environ_OutPath());
        this.InternInfra.ConsoleErrPath : this.ConsolePath(Extern.Environ_ErrPath());
        this.InternInfra.ConsoleInnPath : this.ConsolePath(Extern.Environ_InnPath());

        if (!(this.InternInfra.ConsoleOutPath == null))
        {
            this.InternInfra.ConsoleOut : this.CreateStringOut();
        }

        if (!(this.InternInfra.ConsoleErrPath == null))
        {
            this.InternInfra.ConsoleErr : this.CreateStringOut();
        }

        if (!(this.InternInfra.ConsoleInnPath == null))
        {
            String innString;
            innString : this.StorageInfra.TextRead(this.InternInfra.ConsoleInnPath);

            if (innString == null)
            {
                Extern.Environ_Exit(193);
            }

            StringInn inn;
            inn : new StringInn();
            inn.Init();

            inn.String : innString;
            inn.Index : 0;

            this.InternInfra.ConsoleInn : inn;
        }
        return true;
    }

    private bool MainAfterConsole()
    {
        if (!(this.InternInfra.ConsoleOutPath == null))
        {
            StringOut stringOut;
            stringOut : this.InternInfra.ConsoleOut as StringOut;

            String outText;
            outText : stringOut.Result();

            bool ba;
            ba : this.StorageInfra.TextWrite(this.InternInfra.ConsoleOutPath, outText);

            if (!ba)
            {
                Extern.Environ_Exit(191);
            }
        }

        if (!(this.InternInfra.ConsoleErrPath == null))
        {
            StringOut stringErr;
            stringErr : this.InternInfra.ConsoleErr as StringOut;

            String errText;
            errText : stringErr.Result();

            bool bb;
            bb : this.StorageInfra.TextWrite(this.InternInfra.ConsoleErrPath, errText);

            if (!bb)
            {
                Extern.Environ_Exit(192);
            }
        }

        return true;
    }

    private StringOut CreateStringOut()
    {
        StringOut a;
        a : new StringOut();
        a.Init();
        return a;
    }

    private String ConsolePath(ulong k)
    {
        String kk;
        kk : this.InternInfra.StringCreateIntern(k);

        if (this.StringComp.Count(kk) == 0)
        {
            kk : null;
        }

        String a;
        a : kk;
        return a;
    }
}