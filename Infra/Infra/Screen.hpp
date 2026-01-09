#pragma once

#include <QScreen>

#include "Pronate.hpp"

struct Screen
{
    Int Size;
    Int Dimend;
    Int DimendState;
    Int OrientState;
};

#define CP(a) ((Screen*)(a))
