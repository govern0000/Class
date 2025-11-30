namespace Z.Tool.Saber.TaskKindList;

public class Gen : SourceGen
{
    public override bool Init()
    {
        base.Init();
        this.Module = this.S("Saber.Class");
        this.ClassName = this.S("TaskKindList");
        this.BaseClassName = this.S("Any");
        this.AnyClassName = this.S("Any");
        this.ItemClassName = this.S("TaskKind");
        this.ArrayClassName = this.S("Array");
        this.Export = true;
        this.ItemListFileName = this.S("ToolData/Saber/ItemListTaskKind.txt");
        this.AddMethodFileName = this.S("ToolData/Saber/AddMaideTaskKind.txt");
        this.OutputFilePath = this.S("../../Saber/Saber.Class/TaskKindList.cs");
        return true;
    }
}