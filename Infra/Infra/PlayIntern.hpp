#pragma once

#include <QMediaPlayer>

#include "Pronate.hpp"

class PlayIntern : public QMediaPlayer
{
    Q_OBJECT

public:
    Bool Init();

    Int Play;

private slots:

    void StatusEventHandle();
    void CaseEventHandle(QMediaPlayer::PlaybackState newState);
};
