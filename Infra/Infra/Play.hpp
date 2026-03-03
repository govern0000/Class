#pragma once

#include "PlayIntern.hpp"
#include "VideoOutIntern.hpp"

#include "Pronate.hpp"

struct Play
{
    Int Source;
    Int VideoOut;
    Int AudioOut;
    Int StatusState;
    Int CaseState;
    Int RateState;
    Int PosState;
    PlayIntern* Intern;
};

#define CP(a) ((Play*)(a))
