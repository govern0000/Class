#include "Stat.hpp"

Int Stat_Var_PlayStatusNoError = QMediaPlayer::NoError;
Int Stat_Var_PlayStatusResourceError = QMediaPlayer::ResourceError;
Int Stat_Var_PlayStatusFormatError = QMediaPlayer::FormatError;
Int Stat_Var_PlayStatusNetworkError = QMediaPlayer::NetworkError;
Int Stat_Var_PlayStatusAccessDeniedError = QMediaPlayer::AccessDeniedError;

Int Stat_PlayStatusNoError(Int o)
{
    return Stat_Var_PlayStatusNoError;
}
Int Stat_PlayStatusResourceError(Int o)
{
    return Stat_Var_PlayStatusResourceError;
}
Int Stat_PlayStatusFormatError(Int o)
{
    return Stat_Var_PlayStatusFormatError;
}
Int Stat_PlayStatusNetworkError(Int o)
{
    return Stat_Var_PlayStatusNetworkError;
}
Int Stat_PlayStatusAccessDeniedError(Int o)
{
    return Stat_Var_PlayStatusAccessDeniedError;
}
