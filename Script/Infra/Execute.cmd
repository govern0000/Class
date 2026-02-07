@echo off

set InfraDemoOutFold=.\Out\InfraDemo-Windows-Release
set InfraDeployFold=.\Out\InfraDeploy
set WorkFold=%cd%

setlocal
set "PATH=%WorkFold%\%InfraDeployFold%;%PATH%" && %InfraDemoOutFold%\release\InfraDemo
echo Status: %errorlevel%
endlocal
