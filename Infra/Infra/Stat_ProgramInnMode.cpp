#include "Stat.hpp"

Int Stat_Var_ProgramInnModeManaged = QProcess::ManagedInputChannel + 1;
Int Stat_Var_ProgramInnModeForwarded = QProcess::ForwardedInputChannel + 1;

Int Stat_ProgramInnModeManaged(Int o)
{
    return Stat_Var_ProgramInnModeManaged;
}
Int Stat_ProgramInnModeForwarded(Int o)
{
    return Stat_Var_ProgramInnModeForwarded;
}
