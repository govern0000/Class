class Entry : Any
{
    maide prusate Int Execute()
    {
        this.MainBefore();

        var Int a;
        a : this.ExecuteMain();

        a : this.StatusWrite(a);

        this.MainAfter();

        return a;
    }

    maide prusate Bool Init()
    {
        base.Init();
        this.InternIntern : share Intern;
        this.Extern : share Extern;
        this.InternInfra : share InternInfra;
        return true;
    }

    field prusate Array Arg { get { return data; } set { data : value; } }
    field private Intern InternIntern { get { return data; } set { data : value; } }
    field private Extern Extern { get { return data; } set { data : value; } }
    field private InternInfra InternInfra { get { return data; } set { data : value; } }
    field private StorageInfra StorageInfra { get { return data; } set { data : value; } }
    field private StringComp StringComp { get { return data; } set { data : value; } }
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

        this.StringComp : share StringComp;

        this.StorageInfra : share StorageInfra;

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

    maide private Int StatusWrite(var Int value)
    {
        var Int k;
        k : value;

        inf (~(k = 0))
        {
            var ConsoleConsole ka;
            ka : new ConsoleConsole;
            ka.Init();

            var Format format;
            format : new Format;
            format.Init();

            var FormatArg arg;
            arg : new FormatArg;
            arg.Init();

            arg.Kind : 1;
            arg.Value : k;
            arg.Base : 10;
            arg.AlignLeft : false;
            arg.FieldWidth : 0;
            arg.MaxWidth : null;
            arg.FillChar : 0;
            arg.Form : null;

            format.ExecuteArgCount(arg);

            var Text kd;
            kd : this.TextInfra.TextCreate(arg.Count);

            format.ExecuteArgResult(arg, kd);

            var String kb;
            kb : this.TextInfra.StringCreate(kd);

            var StringAdd add;
            add : new StringAdd;
            add.Init();

            this.TextInfra.AddString(add, "Status: ");
            this.TextInfra.AddString(add, kb);
            this.TextInfra.AddString(add, this.TextInfra.NewLine);

            var String kk;
            kk : add.Result();

            ka.Err.Write(kk);

            k : 1;
        }

        return k;
    }

    maide private Bool MainBeforeConsole()
    {
        var Extern extern;
        extern : this.Extern;

        this.InternInfra.ConsoleOutPath : this.ConsolePath(extern.Environ_OutPath());
        this.InternInfra.ConsoleErrPath : this.ConsolePath(extern.Environ_ErrPath());
        this.InternInfra.ConsoleInnPath : this.ConsolePath(extern.Environ_InnPath());

        inf (~(this.InternInfra.ConsoleOutPath = null))
        {
            this.InternInfra.ConsoleOut : this.CreatePathOut();
        }

        inf (~(this.InternInfra.ConsoleErrPath = null))
        {
            this.InternInfra.ConsoleErr : this.CreatePathOut();
        }

        inf (~(this.InternInfra.ConsoleInnPath = null))
        {
            var String innString;
            innString : this.StorageInfra.TextRead(this.InternInfra.ConsoleInnPath);

            inf (innString = null)
            {
                extern.Environ_Exit(193);
            }

            var PathInn inn;
            inn : new PathInn;
            inn.Init();

            inn.String : innString;
            inn.Index : 0;

            this.InternInfra.ConsoleInn : inn;
        }
        return true;
    }

    maide private Bool MainAfterConsole()
    {
        var Extern extern;
        extern : this.Extern;

        inf (~(this.InternInfra.ConsoleOutPath = null))
        {
            var StringOut stringOut;
            stringOut : cast StringOut(this.InternInfra.ConsoleOut);

            var String outText;
            outText : stringOut.Result();

            var Bool ba;
            ba : this.StorageInfra.TextWrite(this.InternInfra.ConsoleOutPath, outText);

            inf (~ba)
            {
                extern.Environ_Exit(191);
            }
        }

        inf (~(this.InternInfra.ConsoleErrPath = null))
        {
            var StringOut stringErr;
            stringErr : cast StringOut(this.InternInfra.ConsoleErr);

            var String errText;
            errText : stringErr.Result();

            var Bool bb;
            bb : this.StorageInfra.TextWrite(this.InternInfra.ConsoleErrPath, errText);

            inf (~bb)
            {
                extern.Environ_Exit(192);
            }
        }

        return true;
    }

    maide private PathOut CreatePathOut()
    {
        var PathOut a;
        a : new PathOut;
        a.Init();
        return a;
    }

    maide private String ConsolePath(var Int k)
    {
        var String kk;
        kk : this.InternInfra.StringCreateIntern(k);

        inf (this.StringComp.Count(kk) = 0)
        {
            kk : null;
        }

        var String a;
        a : kk;
        return a;
    }
}