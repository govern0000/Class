namespace Z.Tool.Infra.StatProgramOutMode;

class Gen : StatGen
{
    public override long Execute()
    {
        this.ClassName = this.S("ProgramOutMode");
        this.ScopeName = this.S("QProcess");
        this.ValueOffset = this.S(" + 1");
        this.ItemListFileName = this.S("ToolData/Infra/ItemListProgramOutMode.txt");

        return base.Execute();
    }
}