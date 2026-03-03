#pragma once

#include <QMediaPlayer>
#include <QAudioOutput>
#include <QIODevice>

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
    QMediaPlayer* Intern;
};

#define CP(a) ((Play*)(a))
