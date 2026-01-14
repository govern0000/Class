#pragma once

#include <QScreen>

#include "Pronate.hpp"

struct Screen
{
    Int Size;
    Int Dimend;
    Int DimendState;
    Int OrientState;
    QScreen* Intern;
};

#define CP(a) ((Screen*)(a))
