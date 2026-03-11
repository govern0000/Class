#pragma once

#include "FrameIntern.hpp"

#include "Pronate.hpp"

struct Frame
{
    Int Title;
    Int Cursor;
    Int DrawState;
    Int TypeState;
    Int PointerState;
    FrameIntern* Intern;
};

#define CP(a) ((Frame*)(a))
