#pragma once

#include <QCursor>

#include "Pronate.hpp"

struct Cursor
{
    Int Shape;
    QCursor* Intern;
};

#define CP(a) ((Cursor*)(a))
