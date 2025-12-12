namespace Saber.Class;

public class ModuleRefStringGen : TextAdd
{
    public virtual LibraryGen Gen { get; set; }
    public virtual ClassModule Module { get; set; }
    public virtual String Result { get; set; }

    public virtual bool Execute()
    {
        LibraryGen gen;
        gen = this.Gen;

        gen.Arg = new LibraryGenArg();
        gen.Arg.Init();

        gen.Operate = gen.CountOperate;

        gen.ResetStage();
        this.ExecuteStage();

        long count;
        count = gen.Arg.Index;
        count = count * sizeof(int);
        gen.Arg.Data = new Data();
        gen.Arg.Data.Count = count;
        gen.Arg.Data.Init();

        gen.Operate = gen.SetOperate;

        gen.ResetStage();
        this.ExecuteStage();

        String k;
        k = this.StringComp.CreateData(gen.Arg.Data, null);
        this.Result = k;

        gen.Operate = null;
        gen.Arg = null;
        return true;
    }

    public virtual bool ExecuteStage()
    {
        LibraryGen gen;
        gen = this.Gen;

        gen.ModuleStructName(this.Module.Ref);
        return true;
    }
}