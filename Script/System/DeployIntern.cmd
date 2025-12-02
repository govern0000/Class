@echo off

echo Deploy Intern

set ClassInfraOutFold=.\Out\Class\Infra
set InfraInternOutFold=.\Out\InfraIntern-Windows-Release\release

copy /Y %InfraInternOutFold%\InfraIntern.dll %ClassInfraOutFold% 1>NUL 2>NUL