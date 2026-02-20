namespace Z.Tool.Infra.StatPlayStatus;

class Gen : StatGen
{
    public override long Execute()
    {
        this.ClassName = this.S("PlayStatus");
        this.ScopeName = this.S("QMediaPlayer");
        this.ValueOffset = this.S(" + 1");
        this.ItemListFileName = this.S("ToolData/Infra/ItemListPlayStatus.txt");

        return base.Execute();
    }
}