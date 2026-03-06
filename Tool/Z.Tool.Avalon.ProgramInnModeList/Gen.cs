namespace Z.Tool.Avalon.ProgramInnModeList;

public class Gen : SourceGen
{
    public override bool Init()
    {
        base.Init();
        this.Module = this.S("Avalon.Console");
        this.ClassName = this.S("ProgramInnModeList");
        this.BaseClassName = this.S("Any");
        this.AnyClassName = this.S("Any");
        this.ItemClassName = this.S("ProgramInnMode");
        this.ArrayClassName = this.S("Array");
        this.Export = true;
        this.StatItemClassName = this.S("ProgramInnMode");
        this.ItemListFileName = this.GetStatItemListFileName();
        return true;
    }
}