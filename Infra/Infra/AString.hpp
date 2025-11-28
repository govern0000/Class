#pragma once

#include <QString>
#include <QStringList>

#include "Pronate.hpp"

struct String
{
    Int Value;
    Int Count;
};

#define CP(a) ((String*)(a))

Int String_ConstantCount(Int o);