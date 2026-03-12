@echo off

call Script\Infra\Var

set WinDeployQt=windeployqt.exe

call Script\Infra\UpdateDeploy

pushd %InfraDeployFold%
%WinDeployQt% Infra.dll
popd

rem call Script\Infra\DeployClangFile libc++.dll
rem call Script\Infra\DeployClangFile libomp.dll
rem call Script\Infra\DeployClangFile libunwind.dll
rem call Script\Infra\DeployClangFile libwinpthread-1.dll