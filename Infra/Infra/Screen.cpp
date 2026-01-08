#include "Screen.hpp"

Int Screen_Var_DimendState;

CppClassNew(Screen)

Int Screen_Init(Int o)
{
    return true;
}

Int Screen_Final(Int o)
{
    return true;
}

Int Screen_SizeGet(Int o)
{
    Int share;
    share = Infra_Share();
    Int stat;
    stat = Share_Stat(share);

    Int a;
    a = Stat_ScreenSize(stat);
    return a;
}

FieldDefaultSet(Screen, Size)

Int Screen_DimendGet(Int o)
{
    Int share;
    share = Infra_Share();
    Int stat;
    stat = Share_Stat(share);

    Int a;
    a = Stat_ScreenDimend(stat);
    return a;
}

FieldDefaultSet(Screen, Dimend)

Int Screen_DimendStateGet(Int o)
{
    return Screen_Var_DimendState;
}

Int Screen_DimendStateSet(Int o, Int value)
{
    Screen_Var_DimendState = value;
    return true;
}

Int Screen_DimendEvent(Int o, Int oldWidth, Int oldHegth)
{
    Int state;
    state = Screen_Var_DimendState;

    if (state == null)
    {
        return true;
    }

    Int aa;
    aa = State_MaideGet(state);
    Int arg;
    arg = State_ArgGet(state);

    if (aa == null)
    {
        return true;
    }

    Screen_Dimend_Maide maide;
    maide = (Screen_Dimend_Maide)aa;

    maide(o, arg, oldWidth, oldHegth);

    return true;
}