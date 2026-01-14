#pragma once

#include "FrameIntern.hpp"

#include "Pronate.hpp"

struct Frame
{
    Int Title;
    Int TypeState;
    Int DrawState;
    Int DualState;
    Int PointState;
    Int Cursor;
    FrameIntern* Intern;
};

#define CP(a) ((Frame*)(a))
