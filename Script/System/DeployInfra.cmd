@echo off

echo Deploy Infra

set ClassInfraOutFold=.\Out\Class\Infra
set InfraDeployFold=.\Out\InfraDeploy

mkdir %ClassInfraOutFold% 1>NUL 2>NUL

xcopy /S /E /Y "%InfraDeployFold%" "%ClassInfraOutFold%" 1>NUL 2>NUL