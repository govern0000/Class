namespace Saber.Class;

partial class LibraryGen
{
    public virtual bool InitOperateKindState()
    {
        this.OperateKindList.End.Any = this.InitOperateState(new EndLibraryGenOperateState());
        this.OperateKindList.Ret.Any = this.InitOperateState(new RetLibraryGenOperateState());
        this.OperateKindList.Refer.Any = this.InitOperateState(new ReferLibraryGenOperateState());
        this.OperateKindList.Are.Any = this.InitOperateState(new AreLibraryGenOperateState());
        this.OperateKindList.InfStart.Any = this.InitOperateState(new InfStartLibraryGenOperateState());
        this.OperateKindList.InfEnd.Any = this.InitOperateState(new InfEndLibraryGenOperateState());
        this.OperateKindList.WhileStart.Any = this.InitOperateState(new WhileStartLibraryGenOperateState());
        this.OperateKindList.While.Any = this.InitOperateState(new WhileLibraryGenOperateState());
        this.OperateKindList.WhileEnd.Any = this.InitOperateState(new WhileEndLibraryGenOperateState());
        this.OperateKindList.ItemGet.Any = this.InitOperateState(new GetLibraryGenOperateState());
        this.OperateKindList.Set.Any = this.InitOperateState(new SetLibraryGenOperateState());
        this.OperateKindList.Call.Any = this.InitOperateState(new CallLibraryGenOperateState());
        this.OperateKindList.Var.Any = this.InitOperateState(new VarLibraryGenOperateState());
        this.OperateKindList.VarMark.Any = this.InitOperateState(new VarMarkLibraryGenOperateState());
        this.OperateKindList.New.Any = this.InitOperateState(new NewLibraryGenOperateState());
        this.OperateKindList.Share.Any = this.InitOperateState(new ShareLibraryGenOperateState());
        this.OperateKindList.Cast.Any = this.InitOperateState(new CastLibraryGenOperateState());
        this.OperateKindList.ItemThis.Any = this.InitOperateState(new ThisLibraryGenOperateState());
        this.OperateKindList.Base.Any = this.InitOperateState(new BaseLibraryGenOperateState());
        this.OperateKindList.Null.Any = this.InitOperateState(new NullLibraryGenOperateState());
        this.OperateKindList.Same.Any = this.InitOperateState(new SameLibraryGenOperateState());
        this.OperateKindList.Less.Any = this.InitOperateState(new LessLibraryGenOperateState());
        this.OperateKindList.And.Any = this.InitOperateState(new AndLibraryGenOperateState());
        this.OperateKindList.Orn.Any = this.InitOperateState(new OrnLibraryGenOperateState());
        this.OperateKindList.Not.Any = this.InitOperateState(new NotLibraryGenOperateState());
        this.OperateKindList.Add.Any = this.InitOperateState(new AddLibraryGenOperateState());
        this.OperateKindList.Sub.Any = this.InitOperateState(new SubLibraryGenOperateState());
        this.OperateKindList.Mul.Any = this.InitOperateState(new MulLibraryGenOperateState());
        this.OperateKindList.Div.Any = this.InitOperateState(new DivLibraryGenOperateState());
        this.OperateKindList.SignLess.Any = this.InitOperateState(new SignLessLibraryGenOperateState());
        this.OperateKindList.SignMul.Any = this.InitOperateState(new SignMulLibraryGenOperateState());
        this.OperateKindList.SignDiv.Any = this.InitOperateState(new SignDivLibraryGenOperateState());
        this.OperateKindList.BitAnd.Any = this.InitOperateState(new BitAndLibraryGenOperateState());
        this.OperateKindList.BitOrn.Any = this.InitOperateState(new BitOrnLibraryGenOperateState());
        this.OperateKindList.BitNot.Any = this.InitOperateState(new BitNotLibraryGenOperateState());
        this.OperateKindList.BitLite.Any = this.InitOperateState(new BitLiteLibraryGenOperateState());
        this.OperateKindList.BitRite.Any = this.InitOperateState(new BitRiteLibraryGenOperateState());
        this.OperateKindList.BitSignRite.Any = this.InitOperateState(new BitSignRiteLibraryGenOperateState());
        this.OperateKindList.BoolValue.Any = this.InitOperateState(new BoolValueLibraryGenOperateState());
        this.OperateKindList.IntValue.Any = this.InitOperateState(new IntValueLibraryGenOperateState());
        this.OperateKindList.StringValue.Any = this.InitOperateState(new StringValueLibraryGenOperateState());

        return true;
    }
}