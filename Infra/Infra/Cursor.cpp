#include "Cursor.hpp"

CppClassNew(Cursor)

Int Cursor_Init(Int o)
{
    Cursor* m;
    m = CP(o);

    Qt::CursorShape shape;
    shape = Qt::BlankCursor;

    if (!(m->Shape == null))
    {
        Int k;
        k = m->Shape;
        k = k - 1;

        shape = (Qt::CursorShape)k;
    }

    m->Intern = new QCursor(shape);

    return true;
}

Int Cursor_Final(Int o)
{
    Cursor* m;
    m = CP(o);

    delete m->Intern;
    return true;
}