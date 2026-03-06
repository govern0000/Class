namespace Z.Tool.Avalon.ProgramInnModeList;

public class Gen : SourceGen
{
    public override bool Init()
    {
        base.Init();
        this.Module = this.S("Avalon.Console");
        this.ClassName = this.S("ProgramOutModeList");
        this.BaseClassName = this.S("Any");
        this.AnyClassName = this.S("Any");
        this.ItemClassName = this.S("ProgramOutMode");
        this.ArrayClassName = this.S("Array");
        this.Export = true;
        this.StatItemClassName = this.S("ProgramOutMode");
        this.ItemListFileName = this.GetStatItemListFileName();
        return true;
    }
}