#include "Screen.hpp"

CppClassNew(Screen)

Int Screen_Init(Int o)
{
    Screen* m;
    m = CP(o);

    Int screen;
    screen = Main_ScreenIntern();

    QScreen* k;
    k = (QScreen*)screen;

    QSize ka;
    ka = k->size();

    int widthA;
    int hegthA;
    widthA = ka.width();
    hegthA = ka.height();

    Int width;
    Int hegth;
    width = widthA;
    hegth = hegthA;

    m->Size = Size_New();
    Size_Init(m->Size);
    Size_WidthSet(m->Size, width);
    Size_HegthSet(m->Size, hegth);

    m->Dimend = Size_New();
    Size_Init(m->Dimend);

    Screen_Dimend(o);

    return true;
}

Int Screen_Final(Int o)
{
    Screen* m;
    m = CP(o);

    Size_Final(m->Dimend);
    Size_Delete(m->Dimend);

    Size_Final(m->Size);
    Size_Delete(m->Size);
    return true;
}

CppFieldGet(Screen, Size)

FieldDefaultSet(Screen, Size)

CppFieldGet(Screen, Dimend)

FieldDefaultSet(Screen, Dimend)

CppField(Screen, DimendState)

Int Screen_Dimend(Int o)
{
    Int screen;
    screen = Main_ScreenIntern();

    QScreen* k;
    k = (QScreen*)screen;

    QSizeF ka;
    ka = k->physicalSize();

    qreal width;
    qreal hegth;
    width = ka.width();
    hegth = ka.height();

    ValueFromInternValue(width);
    ValueFromInternValue(hegth);

    Int dimend;
    dimend = Screen_DimendGet(o);

    Size_WidthSet(dimend, widthA);
    Size_HegthSet(dimend, hegthA);
    return true;
}

Int Screen_DimendEvent(Int o)
{
    Screen* m;
    m = CP(o);

    Int state;
    state = m->DimendState;

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

    maide(o, arg);

    return true;
}