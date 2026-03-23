namespace Z.Tool.Infra.StatPlayCase;

class Gen : StatGen
{
    public override long Execute()
    {
        this.ClassName = this.S("PlayCase");
        this.ScopeName = this.S("QMediaPlayer");
        this.ValuePostfix = this.S("State");
        this.ValueOffset = this.S(" + 1");
        this.ItemListFileName = this.S("ToolData/Infra/ItemListPlayCase.txt");

        return base.Execute();
    }
}