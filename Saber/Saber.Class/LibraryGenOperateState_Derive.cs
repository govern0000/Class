namespace Saber.Class;

public class EndClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateEnd();
        return true;
    }
}

public class RetClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateRet();
        return true;
    }
}

public class ReferClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateRefer();
        return true;
    }
}

public class AreClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateAre();
        return true;
    }
}

public class InfStartClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateInfStart();
        return true;
    }
}

public class InfEndClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateInfEnd();
        return true;
    }
}

public class WhileStartClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateWhileStart();
        return true;
    }
}

public class WhileClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateWhile();
        return true;
    }
}

public class WhileEndClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateWhileEnd();
        return true;
    }
}

public class GetClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateGet();
        return true;
    }
}

public class SetClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateSet();
        return true;
    }
}

public class CallClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateCall();
        return true;
    }
}

public class VarClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateVar();
        return true;
    }
}

public class VarMarkClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateVarMark();
        return true;
    }
}

public class NewClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateNew();
        return true;
    }
}

public class ShareClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateShare();
        return true;
    }
}

public class CastClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateCast();
        return true;
    }
}

public class ThisClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateThis();
        return true;
    }
}

public class BaseClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateBase();
        return true;
    }
}

public class NullClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateNull();
        return true;
    }
}

public class SameClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateSame();
        return true;
    }
}

public class LessClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateLess();
        return true;
    }
}

public class AndClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateAnd();
        return true;
    }
}

public class OrnClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateOrn();
        return true;
    }
}

public class NotClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateNot();
        return true;
    }
}

public class AddClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateAdd();
        return true;
    }
}

public class SubClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateSub();
        return true;
    }
}

public class MulClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateMul();
        return true;
    }
}

public class DivClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateDiv();
        return true;
    }
}

public class SignLessClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateSignLess();
        return true;
    }
}

public class SignMulClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateSignMul();
        return true;
    }
}

public class SignDivClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateSignDiv();
        return true;
    }
}

public class BitAndClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateBitAnd();
        return true;
    }
}

public class BitOrnClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateBitOrn();
        return true;
    }
}

public class BitNotClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateBitNot();
        return true;
    }
}

public class BitLiteClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateBitLite();
        return true;
    }
}

public class BitRiteClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateBitRite();
        return true;
    }
}

public class BitSignRiteClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateBitSignRite();
        return true;
    }
}

public class BoolValueClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateBoolValue();
        return true;
    }
}

public class IntValueClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateIntValue();
        return true;
    }
}

public class StringValueClassGenOperateState : LibraryGenOperateState
{
    public override bool Execute()
    {
        this.Gen.ExecuteOperateStringValue();
        return true;
    }
}

