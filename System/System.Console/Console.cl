class Console : Any
{
    maide prusate Bool Init()
    {
        base.Init();
        this.InternInfra : share InternInfra;

        this.Intern : new ConsoleIntern;
        this.Intern.Init();

        this.Out : cast Out(this.InternInfra.ConsoleOut);
        this.Err : cast Out(this.InternInfra.ConsoleErr);
        this.Inn : cast Inn(this.InternInfra.ConsoleInn);

        inf (this.Out = null)
        {
            var ConsoleOut ka;
            ka : new ConsoleOut;
            ka.Init();
            ka.Intern : this.Intern;
            ka.Stream : 0;
            this.Out : ka;
        }

        inf (this.Err = null)
        {
            var ConsoleOut kb;
            kb : new ConsoleOut;
            kb.Init();
            kb.Intern : this.Intern;
            kb.Stream : 1;
            this.Err : kb;
        }

        inf (this.Inn = null)
        {
            var ConsoleInn kc;
            kc : new ConsoleInn;
            kc.Init();
            kc.Intern : this.Intern;
            this.Inn : kc;
        }

        return true;
    }

    field prusate Out Out { get { return data; } set { data : value; } }
    field prusate Out Err { get { return data; } set { data : value; } }
    field prusate Inn Inn { get { return data; } set { data : value; } }
    field private InternInfra InternInfra { get { return data; } set { data : value; } }
    field private ConsoleIntern Intern { get { return data; } set { data : value; } }
}