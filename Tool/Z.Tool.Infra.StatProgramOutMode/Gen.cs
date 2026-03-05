namespace Z.Tool.Infra.StatPlayCase;

class Gen : StatGen
{
    public override long Execute()
    {
        this.ClassName = this.S("ProgramInnMode");
        this.ScopeName = this.S("QProcess");
        this.ValuePostfix = this.S("InputChannel");
        this.ValueOffset = this.S(" + 1");
        this.ItemListFileName = this.S("ToolData/Infra/ItemListProgramInnMode.txt");

        return base.Execute();
    }
}