#include "Stat.hpp"

Int Stat_Var_ProgramOutModeSeparateChannels = QProcess::SeparateChannels + 1;
Int Stat_Var_ProgramOutModeMergedChannels = QProcess::MergedChannels + 1;
Int Stat_Var_ProgramOutModeForwardedChannels = QProcess::ForwardedChannels + 1;
Int Stat_Var_ProgramOutModeForwardedOutputChannel = QProcess::ForwardedOutputChannel + 1;
Int Stat_Var_ProgramOutModeForwardedErrorChannel = QProcess::ForwardedErrorChannel + 1;

Int Stat_ProgramOutModeSeparateChannels(Int o)
{
    return Stat_Var_ProgramOutModeSeparateChannels;
}
Int Stat_ProgramOutModeMergedChannels(Int o)
{
    return Stat_Var_ProgramOutModeMergedChannels;
}
Int Stat_ProgramOutModeForwardedChannels(Int o)
{
    return Stat_Var_ProgramOutModeForwardedChannels;
}
Int Stat_ProgramOutModeForwardedOutputChannel(Int o)
{
    return Stat_Var_ProgramOutModeForwardedOutputChannel;
}
Int Stat_ProgramOutModeForwardedErrorChannel(Int o)
{
    return Stat_Var_ProgramOutModeForwardedErrorChannel;
}
