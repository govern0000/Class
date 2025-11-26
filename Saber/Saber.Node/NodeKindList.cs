namespace Saber.Node;

public class NodeKindList : Any
{
    public static NodeKindList This { get; } = ShareCreate();

    private static NodeKindList ShareCreate()
    {
        NodeKindList share;
        share = new NodeKindList();
        Any a;
        a = share;
        a.Init();
        return share;
    }

    public override bool Init()
    {
        base.Init();
        this.TextStringValue = TextStringValue.This;
        this.InitArray();
        this.Count = this.Array.Count;
        this.Index = 0;

        this.Class = this.AddItem("Class", new Class(), new ClassNodeState(), new ClassNewState(), new ClassSetState());
        this.Part = this.AddItem("Part", new Part(), new PartNodeState(), new PartNewState(), new PartSetState());
        this.Comp = this.AddItem("Comp", new Comp(), new CompNodeState(), new CompNewState(), new CompSetState());
        this.Field = this.AddItem("Field", new Field(), new FieldNodeState(), new FieldNewState(), new FieldSetState());
        this.Maide = this.AddItem("Maide", new Maide(), new MaideNodeState(), new MaideNewState(), new MaideSetState());
        this.Param = this.AddItem("Param", new Param(), new ParamNodeState(), new ParamNewState(), new ParamSetState());
        this.Var = this.AddItem("Var", new Var(), new VarNodeState(), new VarNewState(), new VarSetState());
        this.ItemCount = this.AddItem("Count", new Count(), new CountNodeState(), new CountNewState(), new CountSetState());
        this.PrusateCount = this.AddItem("PrusateCount", new PrusateCount(), new PrusateCountNodeState(), new PrusateCountNewState(), new PrusateCountSetState());
        this.PrecateCount = this.AddItem("PrecateCount", new PrecateCount(), new PrecateCountNodeState(), new PrecateCountNewState(), new PrecateCountSetState());
        this.PronateCount = this.AddItem("PronateCount", new PronateCount(), new PronateCountNodeState(), new PronateCountNewState(), new PronateCountSetState());
        this.PrivateCount = this.AddItem("PrivateCount", new PrivateCount(), new PrivateCountNodeState(), new PrivateCountNewState(), new PrivateCountSetState());
        this.State = this.AddItem("State", new State(), new StateNodeState(), new StateNewState(), new StateSetState());
        this.Execute = this.AddItem("Execute", new Execute(), new ExecuteNodeState(), new ExecuteNewState(), new ExecuteSetState());
        this.InfExecute = this.AddItem("InfExecute", new InfExecute(), new InfExecuteNodeState(), new InfExecuteNewState(), new InfExecuteSetState());
        this.WhileExecute = this.AddItem("WhileExecute", new WhileExecute(), new WhileExecuteNodeState(), new WhileExecuteNewState(), new WhileExecuteSetState());
        this.ReturnExecute = this.AddItem("ReturnExecute", new ReturnExecute(), new ReturnExecuteNodeState(), new ReturnExecuteNewState(), new ReturnExecuteSetState());
        this.ReferExecute = this.AddItem("ReferExecute", new ReferExecute(), new ReferExecuteNodeState(), new ReferExecuteNewState(), new ReferExecuteSetState());
        this.AreExecute = this.AddItem("AreExecute", new AreExecute(), new AreExecuteNodeState(), new AreExecuteNewState(), new AreExecuteSetState());
        this.OperateExecute = this.AddItem("OperateExecute", new OperateExecute(), new OperateExecuteNodeState(), new OperateExecuteNewState(), new OperateExecuteSetState());
        this.Argue = this.AddItem("Argue", new Argue(), new ArgueNodeState(), new ArgueNewState(), new ArgueSetState());
        this.Mark = this.AddItem("Mark", new Mark(), new MarkNodeState(), new MarkNewState(), new MarkSetState());
        this.VarMark = this.AddItem("VarMark", new VarMark(), new VarMarkNodeState(), new VarMarkNewState(), new VarMarkSetState());
        this.SetMark = this.AddItem("SetMark", new SetMark(), new SetMarkNodeState(), new SetMarkNewState(), new SetMarkSetState());
        this.Operate = this.AddItem("Operate", new Operate(), new OperateNodeState(), new OperateNewState(), new OperateSetState());
        this.GetOperate = this.AddItem("GetOperate", new GetOperate(), new GetOperateNodeState(), new GetOperateNewState(), new GetOperateSetState());
        this.CallOperate = this.AddItem("CallOperate", new CallOperate(), new CallOperateNodeState(), new CallOperateNewState(), new CallOperateSetState());
        this.ThisOperate = this.AddItem("ThisOperate", new ThisOperate(), new ThisOperateNodeState(), new ThisOperateNewState(), new ThisOperateSetState());
        this.BaseOperate = this.AddItem("BaseOperate", new BaseOperate(), new BaseOperateNodeState(), new BaseOperateNewState(), new BaseOperateSetState());
        this.NullOperate = this.AddItem("NullOperate", new NullOperate(), new NullOperateNodeState(), new NullOperateNewState(), new NullOperateSetState());
        this.NewOperate = this.AddItem("NewOperate", new NewOperate(), new NewOperateNodeState(), new NewOperateNewState(), new NewOperateSetState());
        this.ShareOperate = this.AddItem("ShareOperate", new ShareOperate(), new ShareOperateNodeState(), new ShareOperateNewState(), new ShareOperateSetState());
        this.CastOperate = this.AddItem("CastOperate", new CastOperate(), new CastOperateNodeState(), new CastOperateNewState(), new CastOperateSetState());
        this.VarOperate = this.AddItem("VarOperate", new VarOperate(), new VarOperateNodeState(), new VarOperateNewState(), new VarOperateSetState());
        this.ValueOperate = this.AddItem("ValueOperate", new ValueOperate(), new ValueOperateNodeState(), new ValueOperateNewState(), new ValueOperateSetState());
        this.BraceOperate = this.AddItem("BraceOperate", new BraceOperate(), new BraceOperateNodeState(), new BraceOperateNewState(), new BraceOperateSetState());
        this.Value = this.AddItem("Value", new Value(), new ValueNodeState(), new ValueNewState(), new ValueSetState());
        this.BoolValue = this.AddItem("BoolValue", new BoolValue(), new BoolValueNodeState(), new BoolValueNewState(), new BoolValueSetState());
        this.IntValue = this.AddItem("IntValue", new IntValue(), new IntValueNodeState(), new IntValueNewState(), new IntValueSetState());
        this.IntSignValue = this.AddItem("IntSignValue", new IntSignValue(), new IntSignValueNodeState(), new IntSignValueNewState(), new IntSignValueSetState());
        this.IntHexValue = this.AddItem("IntHexValue", new IntHexValue(), new IntHexValueNodeState(), new IntHexValueNewState(), new IntHexValueSetState());
        this.IntHexSignValue = this.AddItem("IntHexSignValue", new IntHexSignValue(), new IntHexSignValueNodeState(), new IntHexSignValueNewState(), new IntHexSignValueSetState());
        this.StringValue = this.AddItem("StringValue", new StringValue(), new StringValueNodeState(), new StringValueNewState(), new StringValueSetState());
        this.ClassName = this.AddItem("ClassName", new ClassName(), new ClassNameNodeState(), new ClassNameNewState(), new ClassNameSetState());
        this.FieldName = this.AddItem("FieldName", new FieldName(), new FieldNameNodeState(), new FieldNameNewState(), new FieldNameSetState());
        this.MaideName = this.AddItem("MaideName", new MaideName(), new MaideNameNodeState(), new MaideNameNewState(), new MaideNameSetState());
        this.VarName = this.AddItem("VarName", new VarName(), new VarNameNodeState(), new VarNameNewState(), new VarNameSetState());
        this.SameOperate = this.AddItem("SameOperate", new SameOperate(), new SameOperateNodeState(), new SameOperateNewState(), new SameOperateSetState());
        this.AndOperate = this.AddItem("AndOperate", new AndOperate(), new AndOperateNodeState(), new AndOperateNewState(), new AndOperateSetState());
        this.OrnOperate = this.AddItem("OrnOperate", new OrnOperate(), new OrnOperateNodeState(), new OrnOperateNewState(), new OrnOperateSetState());
        this.NotOperate = this.AddItem("NotOperate", new NotOperate(), new NotOperateNodeState(), new NotOperateNewState(), new NotOperateSetState());
        this.LessOperate = this.AddItem("LessOperate", new LessOperate(), new LessOperateNodeState(), new LessOperateNewState(), new LessOperateSetState());
        this.AddOperate = this.AddItem("AddOperate", new AddOperate(), new AddOperateNodeState(), new AddOperateNewState(), new AddOperateSetState());
        this.SubOperate = this.AddItem("SubOperate", new SubOperate(), new SubOperateNodeState(), new SubOperateNewState(), new SubOperateSetState());
        this.MulOperate = this.AddItem("MulOperate", new MulOperate(), new MulOperateNodeState(), new MulOperateNewState(), new MulOperateSetState());
        this.DivOperate = this.AddItem("DivOperate", new DivOperate(), new DivOperateNodeState(), new DivOperateNewState(), new DivOperateSetState());
        this.SignMulOperate = this.AddItem("SignMulOperate", new SignMulOperate(), new SignMulOperateNodeState(), new SignMulOperateNewState(), new SignMulOperateSetState());
        this.SignDivOperate = this.AddItem("SignDivOperate", new SignDivOperate(), new SignDivOperateNodeState(), new SignDivOperateNewState(), new SignDivOperateSetState());
        this.SignLessOperate = this.AddItem("SignLessOperate", new SignLessOperate(), new SignLessOperateNodeState(), new SignLessOperateNewState(), new SignLessOperateSetState());
        this.BitAndOperate = this.AddItem("BitAndOperate", new BitAndOperate(), new BitAndOperateNodeState(), new BitAndOperateNewState(), new BitAndOperateSetState());
        this.BitOrnOperate = this.AddItem("BitOrnOperate", new BitOrnOperate(), new BitOrnOperateNodeState(), new BitOrnOperateNewState(), new BitOrnOperateSetState());
        this.BitNotOperate = this.AddItem("BitNotOperate", new BitNotOperate(), new BitNotOperateNodeState(), new BitNotOperateNewState(), new BitNotOperateSetState());
        this.BitLiteOperate = this.AddItem("BitLiteOperate", new BitLiteOperate(), new BitLiteOperateNodeState(), new BitLiteOperateNewState(), new BitLiteOperateSetState());
        this.BitRiteOperate = this.AddItem("BitRiteOperate", new BitRiteOperate(), new BitRiteOperateNodeState(), new BitRiteOperateNewState(), new BitRiteOperateSetState());
        this.BitSignRiteOperate = this.AddItem("BitSignRiteOperate", new BitSignRiteOperate(), new BitSignRiteOperateNodeState(), new BitSignRiteOperateNewState(), new BitSignRiteOperateSetState());
        return true;
    }

    public virtual NodeKind Class { get; set; }
    public virtual NodeKind Part { get; set; }
    public virtual NodeKind Comp { get; set; }
    public virtual NodeKind Field { get; set; }
    public virtual NodeKind Maide { get; set; }
    public virtual NodeKind Param { get; set; }
    public virtual NodeKind Var { get; set; }
    public virtual NodeKind ItemCount { get; set; }
    public virtual NodeKind PrusateCount { get; set; }
    public virtual NodeKind PrecateCount { get; set; }
    public virtual NodeKind PronateCount { get; set; }
    public virtual NodeKind PrivateCount { get; set; }
    public virtual NodeKind State { get; set; }
    public virtual NodeKind Execute { get; set; }
    public virtual NodeKind InfExecute { get; set; }
    public virtual NodeKind WhileExecute { get; set; }
    public virtual NodeKind ReturnExecute { get; set; }
    public virtual NodeKind ReferExecute { get; set; }
    public virtual NodeKind AreExecute { get; set; }
    public virtual NodeKind OperateExecute { get; set; }
    public virtual NodeKind Argue { get; set; }
    public virtual NodeKind Mark { get; set; }
    public virtual NodeKind VarMark { get; set; }
    public virtual NodeKind SetMark { get; set; }
    public virtual NodeKind Operate { get; set; }
    public virtual NodeKind GetOperate { get; set; }
    public virtual NodeKind CallOperate { get; set; }
    public virtual NodeKind ThisOperate { get; set; }
    public virtual NodeKind BaseOperate { get; set; }
    public virtual NodeKind NullOperate { get; set; }
    public virtual NodeKind NewOperate { get; set; }
    public virtual NodeKind ShareOperate { get; set; }
    public virtual NodeKind CastOperate { get; set; }
    public virtual NodeKind VarOperate { get; set; }
    public virtual NodeKind ValueOperate { get; set; }
    public virtual NodeKind BraceOperate { get; set; }
    public virtual NodeKind Value { get; set; }
    public virtual NodeKind BoolValue { get; set; }
    public virtual NodeKind IntValue { get; set; }
    public virtual NodeKind IntSignValue { get; set; }
    public virtual NodeKind IntHexValue { get; set; }
    public virtual NodeKind IntHexSignValue { get; set; }
    public virtual NodeKind StringValue { get; set; }
    public virtual NodeKind ClassName { get; set; }
    public virtual NodeKind FieldName { get; set; }
    public virtual NodeKind MaideName { get; set; }
    public virtual NodeKind VarName { get; set; }
    public virtual NodeKind SameOperate { get; set; }
    public virtual NodeKind AndOperate { get; set; }
    public virtual NodeKind OrnOperate { get; set; }
    public virtual NodeKind NotOperate { get; set; }
    public virtual NodeKind LessOperate { get; set; }
    public virtual NodeKind AddOperate { get; set; }
    public virtual NodeKind SubOperate { get; set; }
    public virtual NodeKind MulOperate { get; set; }
    public virtual NodeKind DivOperate { get; set; }
    public virtual NodeKind SignMulOperate { get; set; }
    public virtual NodeKind SignDivOperate { get; set; }
    public virtual NodeKind SignLessOperate { get; set; }
    public virtual NodeKind BitAndOperate { get; set; }
    public virtual NodeKind BitOrnOperate { get; set; }
    public virtual NodeKind BitNotOperate { get; set; }
    public virtual NodeKind BitLiteOperate { get; set; }
    public virtual NodeKind BitRiteOperate { get; set; }
    public virtual NodeKind BitSignRiteOperate { get; set; }

    protected virtual TextStringValue TextStringValue { get; set; }

    protected virtual NodeKind AddItem(string name, Node node, NodeState nodeState, NewState newState, SetState setState)
    {
        node.Init();
        nodeState.Init();
        newState.Init();
        setState.Init();

        String k;
        k = this.TextStringValue.Execute(name);

        NodeKind item;
        item = new NodeKind();
        item.Init();
        item.Index = this.Index;
        item.Name = k;
        item.Node = node;
        item.NodeState = nodeState;
        item.NewState = newState;
        item.SetState = setState;
        this.Array.SetAt(item.Index, item);
        this.Index = this.Index + 1;
        return item;
    }

    protected virtual bool InitArray()
    {
        this.Array = new Array();
        this.Array.Count = this.ArrayCount;
        this.Array.Init();
        return true;
    }

    protected virtual Array Array { get; set; }

    protected virtual long ArrayCount { get { return 65; } set { } }

    public virtual long Count { get; set; }
    
    protected virtual long Index { get; set; }

    public virtual NodeKind Get(long index)
    {
        return this.Array.GetAt(index) as NodeKind;
    }
}