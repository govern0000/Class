namespace Z.Tool.Infra.StatCursorShape;

class Gen : StatGen
{
    public override long Execute()
    {
        this.ClassName = this.S("CursorShape");
        this.ValuePostfix = this.S("Cursor");
        this.ValueOffset = this.S(" + 1");
        this.ItemListFileName = this.S("ToolData/Infra/ItemListCursorShape.txt");

        return base.Execute();
    }
}