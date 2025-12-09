namespace Z.Tool.ToolEntryGen;

class Gen : ToolBase
{
    protected virtual String SourceTemplate { get; set; }

    public virtual long Execute()
    {
        this.SourceTemplate = this.StorageTextRead(this.S("ToolData/Entry.txt"));

        this.ExecuteOne("Avalon.TextCodeKindList");
        this.ExecuteOne("Avalon.StorageStatusList");
        this.ExecuteOne("Avalon.NetworkCaseList");
        this.ExecuteOne("Avalon.NetworkPortKindList");
        this.ExecuteOne("Avalon.NetworkStatusList");
        this.ExecuteOne("Saber.CountList");
        this.ExecuteOne("Saber.LimitList");
        this.ExecuteOne("Saber.IndexList");
        this.ExecuteOne("Saber.ErrorKindList");
        this.ExecuteOne("Saber.TaskKindList");
        this.ExecuteOne("Saber.OperateKindList");
        this.ExecuteOne("Saber.NodeList");
        this.ExecuteOne("System.TextCodeKindList");
        this.ExecuteOne("System.StorageStatusList");
        this.ExecuteOne("System.NetworkCaseList");
        this.ExecuteOne("System.NetworkPortKindList");
        this.ExecuteOne("System.NetworkStatusList");
        this.ExecuteOne("Infra.StatTextCodeKind");
        this.ExecuteOne("Infra.StatThreadCase");
        this.ExecuteOne("Infra.StatStreamKind");
        this.ExecuteOne("Infra.StatStorageMode");
        this.ExecuteOne("Infra.StatStorageStatus");
        this.ExecuteOne("Infra.StatNetworkCase");
        this.ExecuteOne("Infra.StatNetworkPortKind");
        this.ExecuteOne("Infra.StatNetworkStatus");
        this.ExecuteOne("Infra.StatBrushCap");
        this.ExecuteOne("Infra.StatBrushJoin");
        this.ExecuteOne("Infra.StatBrushKind");
        this.ExecuteOne("Infra.StatBrushLine");
        this.ExecuteOne("Infra.StatComp");
        this.ExecuteOne("Infra.StatGradientKind");
        this.ExecuteOne("Infra.StatGradientSpread");
        this.ExecuteOne("Infra.StatImageBinary");
        this.ExecuteOne("MathGen");
        this.ExecuteOne("PrusateGen");
        this.ExecuteOne("NodeListGen");

        return 0;
    }

    protected virtual bool ExecuteOne(string toolName)
    {
        String ka;
        ka = this.S(toolName);

        Text k;
        k = this.TextCreate(this.SourceTemplate);
        k = this.Place(k, "#Name#", ka);

        String a;
        a = this.StringCreate(k);

        String path;
        path = this.AddClear().AddS("../../Tool/Z.Tool.").Add(ka).AddS("/Entry.cs").AddResult();

        this.StorageTextWrite(path, a);
        return true;
    }
}