#pragma once

#include <QScreen>

#include "Pronate.hpp"

struct Screen
{
    Int Size;
    Int Dimend;
    Int DimendState;
};

#define CP(a) ((Screen*)(a))
