@echo off

echo Deploy Infra

set ClassOutFold=.\Out\Class
set InfraDeployFold=.\Out\InfraDeploy

mkdir %ClassOutFold%\Infra 1>NUL 2>NUL
mkdir %ClassOutFold%\Module 1>NUL 2>NUL
mkdir %ClassOutFold%\Library 1>NUL 2>NUL

xcopy /S /E /Y "%InfraDeployFold%" "%ClassOutFold%\Infra" 1>NUL 2>NUL