namespace Saber.Class;

public class EndLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateEnd();
        return true;
    }
}

public class RetLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateRet();
        return true;
    }
}

public class ReferLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateRefer();
        return true;
    }
}

public class AreLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateAre();
        return true;
    }
}

public class InfStartLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateInfStart();
        return true;
    }
}

public class InfEndLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateInfEnd();
        return true;
    }
}

public class WhileStartLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateWhileStart();
        return true;
    }
}

public class WhileLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateWhile();
        return true;
    }
}

public class WhileEndLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateWhileEnd();
        return true;
    }
}

public class GetLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateGet();
        return true;
    }
}

public class SetLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateSet();
        return true;
    }
}

public class CallLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateCall();
        return true;
    }
}

public class VarLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateVar();
        return true;
    }
}

public class VarMarkLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateVarMark();
        return true;
    }
}

public class NewLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateNew();
        return true;
    }
}

public class ShareLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateShare();
        return true;
    }
}

public class CastLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateCast();
        return true;
    }
}

public class ThisLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateThis();
        return true;
    }
}

public class BaseLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateBase();
        return true;
    }
}

public class NullLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateNull();
        return true;
    }
}

public class SameLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateSame();
        return true;
    }
}

public class LessLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateLess();
        return true;
    }
}

public class AndLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateAnd();
        return true;
    }
}

public class OrnLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateOrn();
        return true;
    }
}

public class NotLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateNot();
        return true;
    }
}

public class AddLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateAdd();
        return true;
    }
}

public class SubLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateSub();
        return true;
    }
}

public class MulLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateMul();
        return true;
    }
}

public class DivLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateDiv();
        return true;
    }
}

public class SignLessLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateSignLess();
        return true;
    }
}

public class SignMulLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateSignMul();
        return true;
    }
}

public class SignDivLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateSignDiv();
        return true;
    }
}

public class BitAndLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateBitAnd();
        return true;
    }
}

public class BitOrnLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateBitOrn();
        return true;
    }
}

public class BitNotLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateBitNot();
        return true;
    }
}

public class BitLiteLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateBitLite();
        return true;
    }
}

public class BitRiteLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateBitRite();
        return true;
    }
}

public class BitSignRiteLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateBitSignRite();
        return true;
    }
}

public class BoolValueLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateBoolValue();
        return true;
    }
}

public class IntValueLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateIntValue();
        return true;
    }
}

public class StringValueLibraryGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateStringValue();
        return true;
    }
}

