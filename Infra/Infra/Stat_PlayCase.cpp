#include "Stat.hpp"

Int Stat_Var_PlayCaseStopped = QMediaPlayer::StoppedState + 1;
Int Stat_Var_PlayCasePlaying = QMediaPlayer::PlayingState + 1;
Int Stat_Var_PlayCasePaused = QMediaPlayer::PausedState + 1;

Int Stat_PlayCaseStopped(Int o)
{
    return Stat_Var_PlayCaseStopped;
}
Int Stat_PlayCasePlaying(Int o)
{
    return Stat_Var_PlayCasePlaying;
}
Int Stat_PlayCasePaused(Int o)
{
    return Stat_Var_PlayCasePaused;
}
