#include "PlayIntern.hpp"

Bool PlayIntern::Init()
{
    connect(this, &QMediaPlayer::errorChanged, this, &PlayIntern::StatusEventHandle);
    connect(this, &QMediaPlayer::playbackStateChanged, this, &PlayIntern::CaseEventHandle);
    connect(this, &QMediaPlayer::playbackRateChanged, this, &PlayIntern::RateEventHandle);
    connect(this, &QMediaPlayer::positionChanged, this, &PlayIntern::PosEventHandle);

    return true;
}

void PlayIntern::StatusEventHandle()
{
    Int play;
    play = this->Play;

    Play_StatusEvent(play);
}

void PlayIntern::CaseEventHandle(QMediaPlayer::PlaybackState newState)
{
    Int play;
    play = this->Play;

    Play_CaseEvent(play);
}

void PlayIntern::RateEventHandle(qreal rate)
{
    Int play;
    play = this->Play;

    Play_RateEvent(play);
}

void PlayIntern::PosEventHandle(qint64 position)
{
    Int play;
    play = this->Play;

    Play_PosEvent(play);
}