#include "Screen.hpp"

CppClassNew(Screen)

Int Screen_Init(Int o)
{
    Screen* m;
    m = CP(o);

    m->Size = Size_New();
    Size_Init(m->Size);

    m->Dimend = Size_New();
    Size_Init(m->Dimend);

    Screen_Size(o);
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
CppField(Screen, OrientState)

Int Screen_Size(Int o)
{
    Screen* m;
    m = CP(o);

    QSize ka;
    ka = m->Intern->size();

    int widthA;
    int hegthA;
    widthA = ka.width();
    hegthA = ka.height();

    Int width;
    Int hegth;
    width = widthA;
    hegth = hegthA;

    Int size;
    size = Screen_SizeGet(o);

    Size_WidthSet(size, width);
    Size_HegthSet(size, hegth);
    return true;
}

Int Screen_Dimend(Int o)
{
    Screen* m;
    m = CP(o);

    QSizeF ka;
    ka = m->Intern->physicalSize();

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

Int Screen_OrientGet(Int o)
{
    Int screen;
    screen = Main_ScreenIntern();

    QScreen* k;
    k = (QScreen*)screen;

    Qt::ScreenOrientation kd;
    kd = k->orientation();

    Int ka;
    ka = kd;
    
    Int a;
    a = ka;
    return a;
}

FieldDefaultSet(Screen, Orient)

Int Screen_OrientEvent(Int o)
{
    Screen* m;
    m = CP(o);

    Int state;
    state = m->OrientState;

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

    Screen_Orient_Maide maide;
    maide = (Screen_Orient_Maide)aa;

    maide(o, arg);

    return true;
}